import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { AuthService } from '../../services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup;

  // Serviço de autenticacao e roteador
  constructor(private authService: AuthService, private router: Router) {}

  ngOnInit(): void {
    // Inicializando o grupo de formularios
    this.loginForm = new FormGroup({
      email: new FormControl(null, [Validators.required, Validators.email]), // validar email
      password: new FormControl(null, Validators.required), // validar senha
    });
  }

  onSubmit() {
    // Se o formulario nao for valido, não permite seguir
    if (!this.loginForm.valid) {
      return;
    }

    // extrai o email e a senha do formulario
    const email = this.loginForm.value.email;
    const password = this.loginForm.value.password;

    // Logar o usuario
    this.authService.login(email, password).subscribe((responseData) => {
      console.log(responseData);
      this.router.navigate(['/tasks']); // Navegar ate a rota de tarefas
    });

    this.loginForm.reset(); // Redefinir o formulario
  }
}
