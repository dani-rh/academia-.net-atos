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

// Fornece todos os metodos necessarios para autenticacao
@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private apiUrl = environment.apiUrl;
  private currentUser: string | null = null;  // Armazena o usuario conectado

  // O HttpClient e injetado no construtor
  constructor(private http: HttpClient) {
    // Verifica se ja existe um token, decodifica-o e define a propriedade currentUser
    const savedToken = localStorage.getItem('token');
    if (savedToken) {
      const decodedToken = this.decodeToken(savedToken);
      if (decodedToken && decodedToken.email) {
        this.currentUser = decodedToken.email;
      }
    }
  }

  // Cadastrar novo usuario
  register(user: UserCreateDTO): Observable<RegisterResponse> {
    return this.http.post<RegisterResponse>(
      `${this.apiUrl}/api/Auth/Register`,
      user
    );
  }

  // Logar um usuario existente
  login(email: string, password: string): Observable<LoginResponse> {
    return this.http
      .post<LoginResponse>(`${this.apiUrl}/api/Auth/Login`, { email, password })
      .pipe(
        tap((response) => {
          // Se o login for bem sucedido, salva o token no armazenamento local e define o currentUser
          if (response.token) {
            localStorage.setItem('token', response.token);
            this.currentUser = email;
          }
        })
      );
  }

  // Verifica se o usuario esta logado
  isLoggedIn(): boolean {
    const savedToken = localStorage.getItem('token');
    return this.currentUser !== null || savedToken !== null;
  }

  // Retorna o usuario atual
  getCurrentUser(): string | null {
    return this.currentUser;
  }

  // Faz logout do usuario removendo token e redefinindo o currentUser
  logout(): void {
    localStorage.removeItem('token');
    this.currentUser = null;
  }

  // Recupera o token
  getToken(): string | null {
    return localStorage.getItem('token');
  }

  // Decodifica o token JWT
  public decodeToken(token: string): any {
    const base64Url = token.split('.')[1];
    const base64 = base64Url.replace('-', '+').replace('_', '/');
    return JSON.parse(window.atob(base64));
  }
}
