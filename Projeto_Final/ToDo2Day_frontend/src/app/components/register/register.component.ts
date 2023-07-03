import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { AuthService } from '../../services/auth.service';
import { Router } from '@angular/router';
import { UserCreateDTO } from '../../dtos/user-create.dto';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent implements OnInit {
  registerForm: FormGroup;

  // Injetando servico de autenticacao e roteador
  constructor(private authService: AuthService, private router: Router) {}

  ngOnInit(): void {
    // Inicializando o grupo de formularios
    this.registerForm = new FormGroup({
      firstName: new FormControl(null, Validators.required),
      lastName: new FormControl(null, Validators.required),
      email: new FormControl(null, [Validators.required, Validators.email]),
      password: new FormControl(null, Validators.required),
    });
  }

  onSubmit() {
    //Se o formulario nao for valido, impede outras execucoes
    if (!this.registerForm.valid) {
      return;
    }

    const user: UserCreateDTO = this.registerForm.value; //Extrai os dados do usuario do form

    // Registra o usuario
    this.authService.register(user).subscribe((responseData) => {
      console.log(responseData);
      this.router.navigate(['/']);
    });

    this.registerForm.reset(); // Redefine o formulario
  }
}
