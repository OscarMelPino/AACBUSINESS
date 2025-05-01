import { ChangeDetectionStrategy, Component, signal } from '@angular/core';
import {FormControl, FormGroup, ReactiveFormsModule} from '@angular/forms';
import { MaterialModule } from '../../modules/material/material.module';
import { LoginService } from '../../services/login.service';
import { HttpClientModule } from '@angular/common/http';
import { UserAAC } from '../../models/UserAAC';
import { Subject } from 'rxjs';
import { DataService } from '../../services/data.service';
import { Router } from '@angular/router';
import { config } from '../../../environment';

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

  hide = signal(true);

  clickEvent(event: MouseEvent) {
    this.hide.set(!this.hide());
    event.stopPropagation();
  }

  sendData(user: UserAAC){
    this.dataService.setData(user)
  }

  onSubmit(){
    if (this.loginForm.valid) {
      try {      
        this.loginService.postLogin(this.loginForm.value.username, this.loginForm.value.password).subscribe(user => {
          this.sendData(user)
          this.router.navigate([''])
      })
      } catch (error) {
        alert('Login failed')
      }}
  }
}
