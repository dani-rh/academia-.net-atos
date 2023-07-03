import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { TaskService } from '../../services/task.service';
import { ActivatedRoute, Router } from '@angular/router';
import { TaskItemResponseDTO } from 'src/app/dtos/task-item-response.dto';
import { Tag } from 'src/app/models/tag.model';
import { AuthService } from 'src/app/services/auth.service';
import { TagService } from 'src/app/services/tag.service';

@Component({
  selector: 'app-task-create-edit',
  templateUrl: './task-create-edit.component.html',
  styleUrls: ['./task-create-edit.component.css'],
})
export class TaskCreateEditComponent implements OnInit {
  private isCompleted: boolean;
  taskForm: FormGroup;
  editMode = false; // Para saber se esta no modo de editar ou criar
  taskId: string;
  tags: Tag[] = []; // Array para armazenar todas as tags
  userId: string;

  constructor(
    private taskService: TaskService,
    private router: Router,
    private route: ActivatedRoute,
    private authService: AuthService,
    private tagService: TagService
  ) {
    // Busca e decodifica o token de autenticacao para obter o ID do usuario
    const token = this.authService.getToken();
    if (token) {
      const decodedToken = this.authService.decodeToken(token);
      this.userId = decodedToken.nameid;
    }
  }

  ngOnInit(): void {
    // Busca os parametros para verificar se o componente esta no modo editar ou criar
    this.route.params.subscribe((params) => {
      this.taskId = params['id'];
      this.editMode = params['id'] != null;
      this.initForm();
      this.getTags();

      // Se no modo de edicao, carrega os dados da tarefa existente
      if (this.editMode) {
        this.loadTask();
      }
    });
  }

  // Busca todas as tags
  getTags(): void {
    this.tagService.getAllTags().subscribe(
      (tags) => {
        this.tags = tags;
        if (this.editMode) {
          this.loadTask();
        }
      },
      (error) => {
        console.log(error);
      }
    );
  }

  // Carrega os dados da tarefa existente
  loadTask(): void {
    this.taskService.getTask(this.taskId).subscribe((taskData) => {
      this.isCompleted = taskData.isCompleted;
      this.taskForm.setValue({
        title: taskData.title,
        description: taskData.description || '',
        tagId: taskData.tagId ?? '',
      });
    });
  }

  // Inicializa o formulario
  initForm() {
    this.taskForm = new FormGroup({
      title: new FormControl('', Validators.required),
      description: new FormControl('', Validators.required),
      tagId: new FormControl(''),
    });
  }

  // Lida com o envio do formulario
  onSubmit() {
    if (!this.taskForm.valid) {
      return;
    }

    const taskData = { ...this.taskForm.value };

    if (taskData.tagId === '') {
      delete taskData.tagId;
    }

    // Se no modo edicao, atualiza a tarefa existente. Se no modo criacao, cria uma nova tarefa
    if (this.editMode) {
      taskData.isCompleted = this.isCompleted;
      this.taskService
        .updateTask(this.taskId, taskData)
        .subscribe((responseData: TaskItemResponseDTO) => {
          this.router.navigate(['/tasks']);
        });
    } else {
      taskData.userId = this.userId;
      this.taskService
        .addTask(taskData)
        .subscribe((responseData: TaskItemResponseDTO) => {
          this.router.navigate(['/tasks']);
        });
    }
  }
}
