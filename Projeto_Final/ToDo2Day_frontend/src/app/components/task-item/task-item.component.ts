import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { TaskItemResponseDTO } from '../../dtos/task-item-response.dto';
import { ActivatedRoute, Router } from '@angular/router';
import { TaskService } from 'src/app/services/task.service';
import { TagService } from 'src/app/services/tag.service';
import { Tag } from '../../models/tag.model';


@Component({
  selector: 'app-task-item', // nome da tag HTML personalizada que sera substituida pelo modelo deste componente
  templateUrl: './task-item.component.html',
  styleUrls: ['./task-item.component.css'],
})
export class TaskItemComponent implements OnInit {
  // Define inputs e outputs para o componente
  @Input() task: TaskItemResponseDTO;
  @Output() deleteTask = new EventEmitter<string>();
  @Output() editTask = new EventEmitter<string>();
  @Output() viewTask = new EventEmitter<string>();

  // Servicos necessarios para o construtor do componente
  constructor(
    private taskService: TaskService,
    private tagService: TagService,
    private route: ActivatedRoute,
    private router: Router
  ) {}
  public tag: Tag;

  ngOnInit(): void {
    this.route.params.subscribe((params) => {
      const taskId = params['id'];
      this.taskService.getTask(taskId).subscribe((taskData) => {
        this.task = taskData;

        if (this.task.tagId) {
          this.tagService.getTagById(this.task.tagId).subscribe(tagData => {
            this.tag = tagData;
          });
        }
      });
    });
  }

  // Emitir um evento para visualizar tarefa
  onViewTask() {
    this.viewTask.emit(this.task.taskItemId);
  }

  //Navegar para a pagina de edicao de tarefa
  onEditTask() {
    this.router.navigate(['/tasks/edit', this.task.taskItemId]);
  }

  // Excluir uma tarefa e navegar para a lista de tarefas
  onDeleteTask() {
    this.taskService.deleteTask(this.task.taskItemId).subscribe(() => {
      this.router.navigate(['/tasks']);
    });
  }
}
