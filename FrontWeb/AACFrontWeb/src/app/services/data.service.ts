import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { UserAAC } from '../models/UserAAC';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  private data = new BehaviorSubject<UserAAC | null>(null);
  data$ = this.data.asObservable();

  setData(data: UserAAC) {
    this.data.next(data);
    console.log('set data as ' + JSON.stringify(data))
  }
}