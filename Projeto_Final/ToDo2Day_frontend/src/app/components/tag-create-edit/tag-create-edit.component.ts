import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { TagService } from '../../services/tag.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Tag } from '../../models/tag.model';

@Component({
  selector: 'app-tag-create-edit',
  templateUrl: './tag-create-edit.component.html',
  styleUrls: ['./tag-create-edit.component.css'],
})
export class TagCreateEditComponent implements OnInit {
  tagForm: FormGroup;
  editMode = false; // Para saber se esta no modo de editar ou criar
  tag: Tag; // Armazenar os dados da tag a ser editado
  tagId: string; // Manter o ID da tag a ser editada

  constructor(
    private tagService: TagService,
    private route: ActivatedRoute,
    private router: Router
  ) {}

  ngOnInit(): void {
    // Inicilizar o formulario
    this.tagForm = new FormGroup({
      tagName: new FormControl(null, Validators.required), // validador obrigatorio
    });

    //Inscrevendo-se em parametros de rota
    this.route.params.subscribe((params) => {
      if (params['id']) {
        // Se o Id estiver presente na rota -> modo edicao
        this.editMode = true;
        this.tagId = params['id']; // Armazena o ID dos parametros da rota
        // Buscando os dados da tag
        this.tagService.getTagById(this.tagId).subscribe((tag: Tag) => {
          this.tag = tag; // Armazena os dados da tag
          // Configura o nome da tag para o formulario
          this.tagForm.setValue({
            tagName: this.tag.name,
          });
        });
      }
    });
  }

  onSubmit() {
    if (this.editMode) {
      // Se no modo de edicao
      const { tagName: newTagName } = this.tagForm.value; //Extrai o nome da tag atualizado
      // Atualiza a tag
      this.tagService.updateTag(this.tagId, { newTagName }).subscribe(() => {
        this.router.navigate(['/tags']); // Navega ate a lista de tags
      });
    } else {
      // Se no modo de criacao
      const { tagName } = this.tagForm.value; // Extrai o nome da tag do form
      // Adiciona a nova tag
      this.tagService.addTag({ tagName }).subscribe(() => {
        this.router.navigate(['/tags']); // Navega ate a lista de tags
      });
    }
  }
}
