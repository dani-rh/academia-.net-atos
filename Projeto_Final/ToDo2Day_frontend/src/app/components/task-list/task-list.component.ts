import { Component, OnInit, OnDestroy, ViewChild } from '@angular/core';
import { TaskService } from '../../services/task.service';
import { TaskItemResponseDTO } from '../../dtos/task-item-response.dto';
import { Router } from '@angular/router';
import { TagService } from '../../services/tag.service';
import { Tag } from 'src/app/models/tag.model';
import { TaskItemUpdateDTO } from 'src/app/dtos/task-item-update.dto';
import { DataTableDirective } from 'angular-datatables';
import { Subject } from 'rxjs';

@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html',
  styleUrls: ['./task-list.component.css'],
})
export class TaskListComponent implements OnInit, OnDestroy {
  @ViewChild(DataTableDirective, { static: false })
  datatableElement: DataTableDirective;

  dtOptions: DataTables.Settings = {};
  dtTrigger: Subject<any> = new Subject();

  tasks: TaskItemResponseDTO[] = [];
  tagNames: { [id: string]: string } = {};

  constructor(
    private taskService: TaskService,
    private router: Router,
    private tagService: TagService
  ) {}

  ngOnInit(): void {
    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 5,
      processing: true
    };

    this.taskService.getTasks().subscribe((tasks) => {
      this.tasks = tasks;
      this.dtTrigger.next(null);

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

  ngOnDestroy(): void {
    this.dtTrigger.unsubscribe();
  }

  rerender(): void {
    this.datatableElement.dtInstance.then((dtInstance: DataTables.Api) => {
      dtInstance.destroy();
      this.dtTrigger.next(null);
    });
  }

  onTaskView(taskId: string) {
    this.router.navigate(['/tasks/view', taskId]);
  }

  onTaskDelete(taskId: string) {
    this.taskService.deleteTask(taskId).subscribe(() => {
      this.tasks = this.tasks.filter((task) => task.taskItemId !== taskId);
      this.rerender();
    });
  }

  onTaskEdit(taskId: string) {
    this.router.navigate(['/tasks/edit', taskId]);
  }

  onTaskCreate(): void {
    this.router.navigate(['/tasks/create']);
  }

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
