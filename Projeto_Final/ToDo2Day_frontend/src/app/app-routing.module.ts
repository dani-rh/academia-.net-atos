import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { TagCreateEditComponent } from './components/tag-create-edit/tag-create-edit.component';
import { TagListComponent } from './components/tag-list/tag-list.component';
import { TaskCreateEditComponent } from './components/task-create-edit/task-create-edit.component';
import { TaskListComponent } from './components/task-list/task-list.component';
import { TaskItemComponent } from './components/task-item/task-item.component';

const routes: Routes = [
  { path: '', redirectTo: '/login', pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  {
    path: 'tags',
    children: [
      { path: '', component: TagListComponent },
      { path: 'create', component: TagCreateEditComponent },
      { path: 'edit/:id', component: TagCreateEditComponent },
    ],
  },
  {
    path: 'tasks',
    children: [
      { path: '', component: TaskListComponent },
      { path: 'create', component: TaskCreateEditComponent },
      { path: 'edit/:id', component: TaskCreateEditComponent },
      { path: 'view/:id', component: TaskItemComponent },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
