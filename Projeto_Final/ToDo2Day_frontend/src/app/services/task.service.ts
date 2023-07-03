import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { TaskItemCreateDTO } from '../dtos/task-item-create.dto';
import { TaskItemUpdateDTO } from '../dtos/task-item-update.dto';
import { TaskItemResponseDTO } from '../dtos/task-item-response.dto';
import { AuthService } from './auth.service';
import { environment } from 'environments/environment.dev';

@Injectable({
  providedIn: 'root'
})
export class TaskService {
  private apiUrl = environment.apiUrl;

  constructor(private httpClient: HttpClient, private authService: AuthService) { }

  getHttpOptions() {
    return {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': `Bearer ${this.authService.getToken()}`
      })
    };
  }

  getTasks(): Observable<TaskItemResponseDTO[]> {
    const url = `${this.apiUrl}/api/TaskItem`;
    return this.httpClient.get<TaskItemResponseDTO[]>(url, this.getHttpOptions());
  }

  getTask(id: string): Observable<TaskItemResponseDTO> {
    const url = `${this.apiUrl}/api/TaskItem/${id}`;
    return this.httpClient.get<TaskItemResponseDTO>(url, this.getHttpOptions());
  }

  addTask(task: TaskItemCreateDTO): Observable<TaskItemResponseDTO> {
    const url = `${this.apiUrl}/api/TaskItem`;
    return this.httpClient.post<TaskItemResponseDTO>(url, task, this.getHttpOptions());
}

  updateTask(id: string, task: TaskItemUpdateDTO): Observable<any> {
    const url = `${this.apiUrl}/api/TaskItem/${id}`;
    return this.httpClient.put(url, task, this.getHttpOptions());
  }

  deleteTask(id: string): Observable<any> {
    const url = `${this.apiUrl}/api/TaskItem/${id}`;
    return this.httpClient.delete(url, this.getHttpOptions());
  }
}
