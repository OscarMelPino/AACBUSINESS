import { ChangeDetectionStrategy, Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilder, Validators, FormGroup, ReactiveFormsModule  } from '@angular/forms';
import { MaterialModule } from '../../modules/material/material.module';
import { LoginService } from '../../services/login.service';
import { HttpClientModule } from '@angular/common/http';
import { Users } from '../../models/Users';
import { DataService } from '../../services/data.service';
import * as CryptoJS from 'crypto-js';
import { AuthService } from '../../services/auth.service';


@Component({
  selector: 'app-login',
  standalone: true,
  imports: [MaterialModule, HttpClientModule, CommonModule, ReactiveFormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class LoginComponent {

  constructor(
    private fb: FormBuilder,
    private loginService: LoginService,
    private authService: AuthService,
    private dataService: DataService
  ){}

  loginForm:FormGroup = this.fb.group({
    username: ['', [Validators.required, Validators.minLength(3)]],
    password: ['', [Validators.required, Validators.minLength(4)]],
  });

  sendData(user: Users){
    this.dataService.setData(user)
  }

  onSubmit(): void {
    if (this.loginForm.valid) {
      const { username, password } = this.loginForm.value;
      const hashedPassword = CryptoJS.MD5(password!).toString();
  
      this.loginService.postLogin(username!, hashedPassword).subscribe({
        next: (user) => {
          this.sendData(user);
          this.authService.login(username!);
        },
        error: (err) => {
          console.error('Login error:', err);
          alert('Login failed. Please check your credentials.');
        }
      });
    }
  }
  
}
