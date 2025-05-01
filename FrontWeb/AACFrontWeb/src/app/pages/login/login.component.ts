import { Component } from '@angular/core';
import { LoginService } from '../../services/login.service';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {

  constructor(
    private readonly loginService: LoginService)
    {}

    username: string = ''

    ngOnInit(){
      this.loginService.postLogin().subscribe(name => this.username = name)

      if (!this.username)
        this.username = 'Zzeddy'
    }

}
