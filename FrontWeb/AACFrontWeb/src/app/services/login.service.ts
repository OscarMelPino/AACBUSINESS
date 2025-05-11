import { Injectable } from '@angular/core';
import { config } from '../../environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Users } from '../models/UserModel';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(
    private http: HttpClient
  ) { }

  private readonly apiurl = config.url + config.endpoints.login

  public postLogin(username: string, password: string) : Observable<Users> {
    return this.http.post<Users>(this.apiurl, {username, password})
  }

}
