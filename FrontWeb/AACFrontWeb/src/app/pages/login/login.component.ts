import { ChangeDetectionStrategy, Component } from '@angular/core';
import {FormControl, FormGroup, ReactiveFormsModule} from '@angular/forms';
import { MaterialModule } from '../../modules/material/material.module';
import { LoginService } from '../../services/login.service';
import { HttpClientModule } from '@angular/common/http';
import { UserAAC } from '../../models/UserAAC';
import { DataService } from '../../services/data.service';
import { Router } from '@angular/router';
import * as CryptoJS from 'crypto-js';


@Component({
  selector: 'app-login',
  standalone: true,
  imports: [MaterialModule, ReactiveFormsModule, HttpClientModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class LoginComponent {

  constructor(
    private loginService: LoginService,
    private router: Router,
    private dataService: DataService
  ){}

  loginForm = new FormGroup({
    username:  new FormControl(),
    password:  new FormControl()
  })

  sendData(user: UserAAC){
    this.dataService.setData(user)
  }

  onSubmit(){
    if (this.loginForm.valid) {
      try {              
        const hashedPassword = CryptoJS.MD5(this.loginForm.value.password).toString();

        this.loginService.postLogin(this.loginForm.value.username, hashedPassword).subscribe(user => {
          this.sendData(user)
          this.router.navigate([''])
      })
      } catch (error) {
        alert('Login failed')
      }}
  }
}
