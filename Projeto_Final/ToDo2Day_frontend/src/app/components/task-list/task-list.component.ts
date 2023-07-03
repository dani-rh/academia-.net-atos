import { Component, OnInit } from '@angular/core';
import { TaskService } from '../../services/task.service';
import { TaskItemResponseDTO } from '../../dtos/task-item-response.dto';
import { Router } from '@angular/router';
import { TagService } from '../../services/tag.service';
import { Tag } from 'src/app/models/tag.model';
import { TaskItemUpdateDTO } from 'src/app/dtos/task-item-update.dto';

@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html',
  styleUrls: ['./task-list.component.css'],
})
export class TaskListComponent implements OnInit {
  tasks: TaskItemResponseDTO[] = [];
  tagNames: { [id: string]: string } = {};

  constructor(
    private taskService: TaskService,
    private router: Router,
    private tagService: TagService
  ) {}

  ngOnInit(): void {
    // Busca todas as tarefas e suas tags associadas
    this.taskService.getTasks().subscribe((tasks) => {
      this.tasks = tasks;
      tasks.forEach((task) => {
        if (task.tagId) {
          this.tagService.getTagById(task.tagId).subscribe((tag: Tag) => {
            if (tag && task.tagId) {
              this.tagNames[task.tagId] = tag.name;
            }
          });
        }
      });
    });
  }

  onTaskView(taskId: string) {
    this.router.navigate(['/tasks/view', taskId]);
  }

  onTaskDelete(taskId: string) {
    this.taskService.deleteTask(taskId).subscribe(() => {
      this.tasks = this.tasks.filter((task) => task.taskItemId !== taskId);
    });
  }

  onTaskEdit(taskId: string) {
    this.router.navigate(['/tasks/edit', taskId]);
  }

  onTaskCreate(): void {
    this.router.navigate(['/tasks/create']);
  }

  // Lidar com alteracoes de conclusao de tarefas
  onCompletionChange(taskId: string, event: any) {
    const isCompleted = (event.target as HTMLInputElement).checked;
    let task = this.tasks.find((task) => task.taskItemId === taskId);

    if (task) {
      const taskToUpdate: TaskItemUpdateDTO = {
        ...task,
        isCompleted: isCompleted,
      };
      this.taskService.updateTask(taskId, taskToUpdate).subscribe(() => {
        if (task) {
          task.isCompleted = isCompleted;
        }
      });
    }
  }
}
