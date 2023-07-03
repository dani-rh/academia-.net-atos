import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../models/user.model';
import { UserCreateDTO } from '../dtos/user-create.dto';
import { UserUpdateDTO } from '../dtos/user-update.dto';
import { UserLoginDTO } from '../dtos/user-login.dto';
import { environment } from 'environments/environment.dev';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  private apiUrl = environment.apiUrl;

  getAllUsers(): Observable<User[]> {
    return this.http.get<User[]>(`${this.apiUrl}/api/User`);
  }

  getUserById(id: string): Observable<User> {
    return this.http.get<User>(`${this.apiUrl}/api/User/${id}`);
  }

  updateUser(id: string, user: UserUpdateDTO): Observable<void> {
    return this.http.put<void>(`${this.apiUrl}/api/User/${id}`, user);
  }

  deleteUser(id: string): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/api/User/${id}`);
  }
}
