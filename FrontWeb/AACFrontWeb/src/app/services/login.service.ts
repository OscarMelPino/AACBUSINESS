import { Injectable } from '@angular/core';
import { config } from '../../environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { UserAAC } from '../models/UserAAC';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(
    private http: HttpClient
  ) { }

  private readonly apiurl = config.url + config.endpoints.login

  public postLogin(username: string, password: string) : Observable<UserAAC> {
    return this.http.post<UserAAC>(this.apiurl, {username, password})
  }

}
