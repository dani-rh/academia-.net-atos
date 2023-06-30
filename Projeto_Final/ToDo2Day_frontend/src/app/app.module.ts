import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ComponentNameComponent } from './component-name/component-name.component';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { TagCreateEditComponent } from './components/tag-create-edit/tag-create-edit.component';
import { TagListComponent } from './components/tag-list/tag-list.component';
import { TaskCreateEditComponent } from './components/task-create-edit/task-create-edit.component';
import { TaskItemComponent } from './components/task-item/task-item.component';
import { TaskListComponent } from './components/task-list/task-list.component';
import { UserAuthComponent } from './components/user-auth/user-auth.component';

@NgModule({
  declarations: [
    AppComponent,
    ComponentNameComponent,
    LoginComponent,
    RegisterComponent,
    TagCreateEditComponent,
    TagListComponent,
    TaskCreateEditComponent,
    TaskItemComponent,
    TaskListComponent,
    UserAuthComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
