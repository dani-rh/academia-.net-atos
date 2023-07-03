import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { environment } from 'environments/environment.dev';
import { UserCreateDTO } from '../dtos/user-create.dto';
import { tap } from 'rxjs/operators';

interface RegisterResponse {
  userId: string;
  firstName: string;
  lastName: string;
  email: string;
  password: string;
  refreshToken: string;
  refreshTokenExpiryTime: string;
  createdAt: string;
  updatedAt: string;
}


interface LoginResponse {
  token: string;
}

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private apiUrl = environment.apiUrl;
  private currentUser: string | null = null;

  constructor(private http: HttpClient) {
    const savedToken = localStorage.getItem('token');
    if (savedToken) {
      const decodedToken = this.decodeToken(savedToken);
      if (decodedToken && decodedToken.email) {
        this.currentUser = decodedToken.email;
      }
    }
  }

  register(user: UserCreateDTO): Observable<RegisterResponse> {
    return this.http.post<RegisterResponse>(`${this.apiUrl}/api/Auth/Register`, user);
  }

  login(email: string, password: string): Observable<LoginResponse> {
    return this.http.post<LoginResponse>(`${this.apiUrl}/api/Auth/Login`, { email, password }).pipe(
      tap(response => {
        if (response.token) {
          localStorage.setItem('token', response.token);
          this.currentUser = email;
        }
      })
    );
  }

  isLoggedIn(): boolean {
    const savedToken = localStorage.getItem('token');
    return this.currentUser !== null || savedToken !== null;
  }

  getCurrentUser(): string | null {
    return this.currentUser;
  }

  logout(): void {
    localStorage.removeItem('token');
    this.currentUser = null;
  }

  getToken(): string | null {
    return localStorage.getItem('token');
  }

  public decodeToken(token: string): any {
    const base64Url = token.split('.')[1];
    const base64 = base64Url.replace('-', '+').replace('_', '/');
    return JSON.parse(window.atob(base64));
  }
}
