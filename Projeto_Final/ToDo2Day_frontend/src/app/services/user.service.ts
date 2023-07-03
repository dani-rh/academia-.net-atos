import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../models/user.model';
import { UserUpdateDTO } from '../dtos/user-update.dto';
import { environment } from 'environments/environment.dev';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  constructor(private http: HttpClient) {}

  private apiUrl = environment.apiUrl;

  // Obtem todos os usuarios da API
  getAllUsers(): Observable<User[]> {
    return this.http.get<User[]>(`${this.apiUrl}/api/User`);
  }

  // Ontem um usuario especifico por ID
  getUserById(id: string): Observable<User> {
    return this.http.get<User>(`${this.apiUrl}/api/User/${id}`);
  }

  // Atualiza um usuario especifico por ID
  updateUser(id: string, user: UserUpdateDTO): Observable<void> {
    return this.http.put<void>(`${this.apiUrl}/api/User/${id}`, user);
  }

  // Exclui um usuario especifico por ID
  deleteUser(id: string): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/api/User/${id}`);
  }
}
