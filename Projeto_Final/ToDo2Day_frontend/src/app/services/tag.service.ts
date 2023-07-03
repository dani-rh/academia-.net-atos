import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Tag } from '../models/tag.model';
import { TagCreateDTO } from '../dtos/tag-create.dto';
import { TagUpdateDTO } from '../dtos/tag-update.dto';
import { environment } from 'environments/environment.dev';
import { AuthService } from './auth.service';

@Injectable({
  providedIn: 'root',
})
export class TagService {
  private readonly baseUrl = environment.apiUrl;

  constructor(private http: HttpClient, private authService: AuthService) {}

  // Obtem o token do AuthService
  getToken() {
    return this.authService.getToken();
  }

  // Busca todas as tags
  getAllTags() {
    const headers = new HttpHeaders().set(
      'Authorization',
      `Bearer ${this.getToken()}`
    );
    return this.http.get<Tag[]>(`${this.baseUrl}/api/Tag`, { headers });
  }

  // Busca uma tag por ID
  getTagById(id: string) {
    const headers = new HttpHeaders().set(
      'Authorization',
      `Bearer ${this.getToken()}`
    );
    return this.http.get<Tag>(`${this.baseUrl}/api/Tag/${id}`, { headers });
  }

  // Adiciona uma nova tag
  addTag(tagCreateDTO: TagCreateDTO) {
    const headers = new HttpHeaders().set(
      'Authorization',
      `Bearer ${this.getToken()}`
    );
    return this.http.post<Tag>(`${this.baseUrl}/api/Tag`, tagCreateDTO, {
      headers,
    });
  }

  // Atualiza uma tag existente
  updateTag(id: string, tagUpdateDTO: TagUpdateDTO) {
    const headers = new HttpHeaders().set(
      'Authorization',
      `Bearer ${this.getToken()}`
    );
    return this.http.put(`${this.baseUrl}/api/Tag/${id}`, tagUpdateDTO, {
      headers,
    });
  }

  // Exclui uma tag por ID
  deleteTag(id: string) {
    const headers = new HttpHeaders().set(
      'Authorization',
      `Bearer ${this.getToken()}`
    );
    return this.http.delete(`${this.baseUrl}/api/Tag/${id}`, { headers });
  }
}
