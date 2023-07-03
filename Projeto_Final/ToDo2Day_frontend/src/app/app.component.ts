import { Component } from '@angular/core';
import { AuthService } from './services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'TaskManagerFront';
  constructor(public authService: AuthService, private router: Router){}

  onLogout() {
    this.authService.logout();
    this.router.navigate(['/login']);
  }
}
