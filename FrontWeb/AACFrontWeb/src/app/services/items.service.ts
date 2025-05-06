import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { config } from '../../environment';
import { Items } from '../models/Item';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ItemsService {

  constructor(
    private http: HttpClient
  ) { }

  private readonly apiurl = config.url + config.endpoints.items

  public getItems() : Observable<Items[]> {
    return this.http.get<Items[]>(this.apiurl)
  }
}
