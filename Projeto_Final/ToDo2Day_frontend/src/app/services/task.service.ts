import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { TaskItemCreateDTO } from '../dtos/task-item-create.dto';
import { TaskItemUpdateDTO } from '../dtos/task-item-update.dto';
import { TaskItemResponseDTO } from '../dtos/task-item-response.dto';
import { AuthService } from './auth.service';
import { environment } from 'environments/environment.dev';

@Injectable({
  providedIn: 'root',
})
export class TaskService {
  private apiUrl = environment.apiUrl;

  constructor(
    private httpClient: HttpClient,
    private authService: AuthService
  ) {}

  // Obtem opcoes HTTP incluindo cabecalhos. Inclui o token no cabecalho de autorizacao
  getHttpOptions() {
    return {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: `Bearer ${this.authService.getToken()}`,
      }),
    };
  }

  // Busca todas as tasks
  getTasks(): Observable<TaskItemResponseDTO[]> {
    const url = `${this.apiUrl}/api/TaskItem`;
    // Envia requisicao GET para buscar tarefas
    return this.httpClient.get<TaskItemResponseDTO[]>(
      url,
      this.getHttpOptions()
    );
  }

  // Busca uma task por ID
  getTask(id: string): Observable<TaskItemResponseDTO> {
    const url = `${this.apiUrl}/api/TaskItem/${id}`;
    // Envia requisicao GET para buscar a tarefa
    return this.httpClient.get<TaskItemResponseDTO>(url, this.getHttpOptions());
  }

  // Cria uma nova task
  addTask(task: TaskItemCreateDTO): Observable<TaskItemResponseDTO> {
    const url = `${this.apiUrl}/api/TaskItem`;
    // Envia requisicao POST para criar tarefa
    return this.httpClient.post<TaskItemResponseDTO>(
      url,
      task,
      this.getHttpOptions()
    );
  }

  // Atualiza uma task existente
  updateTask(id: string, task: TaskItemUpdateDTO): Observable<any> {
    const url = `${this.apiUrl}/api/TaskItem/${id}`;
    // Envia requisicao PUT para atualizar a tarefa
    return this.httpClient.put(url, task, this.getHttpOptions());
  }

  // Exclui uma task
  deleteTask(id: string): Observable<any> {
    const url = `${this.apiUrl}/api/TaskItem/${id}`;
    // Envia requisicao DELETE para excluir uma task
    return this.httpClient.delete(url, this.getHttpOptions());
  }
}
