import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { config } from '../../environment';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private readonly STORAGE_KEY = 'loggedInUser';

  constructor(private router: Router) {}

  login(username: string): void {
    localStorage.setItem(this.STORAGE_KEY, JSON.stringify({ username }));
  }

  logout(): void {
    localStorage.removeItem(this.STORAGE_KEY);
    this.router.navigate(['/login']);
  }

  isLoggedIn(): boolean {
    if (config.isDebug)
      return true
    return !!localStorage.getItem(this.STORAGE_KEY);
  }

  getUser(): any {
    const user = localStorage.getItem(this.STORAGE_KEY);
    return user ? JSON.parse(user) : null;
  }
}
