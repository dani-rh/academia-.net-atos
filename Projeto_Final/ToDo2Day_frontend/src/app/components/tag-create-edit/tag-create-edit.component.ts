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
  editMode = false;
  tag: Tag;
  tagId: string;

  constructor(
    private tagService: TagService,
    private route: ActivatedRoute,
    private router: Router
  ) {}

  ngOnInit(): void {
    // Inicializando o form
    this.tagForm = new FormGroup({
      tagName: new FormControl(null, Validators.required),
    });

    this.route.params.subscribe((params) => {
      if (params['id']) {
        //Se o ID estiver presente na rota, estamos no modo de edicao
        this.editMode = true;
        this.tagId = params['id']; // Armazenando o ID
        // Buscando os dados da tag
        this.tagService.getTagById(this.tagId).subscribe((tag: Tag) => {
          this.tag = tag; // Armazenando os dados da tag
          // Configurando o nome da tag para o form
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
      const { tagName: newTagName } = this.tagForm.value; // Extrai o nome da tag atualizado
      // Atualiza a  tag
      this.tagService.updateTag(this.tagId, { newTagName }).subscribe(() => {
        this.router.navigate(['/tags']); // Navega até a lista de tags
      });
    } else {
      // Se no modo de criacao
      const { tagName } = this.tagForm.value; // Extrai o nome da tag
      // Adiciona uma nova tag
      this.tagService.addTag({ tagName }).subscribe(() => {
        this.router.navigate(['/tags']); //  Navega até a lista de tags
      });
    }
  }
}
