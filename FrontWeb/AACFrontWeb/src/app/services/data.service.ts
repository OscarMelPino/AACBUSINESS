import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Users } from '../models/Users';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  private data = new BehaviorSubject<Users | null>(null);
  data$ = this.data.asObservable();

  setData(data: Users) {
    this.data.next(data);
  }
}