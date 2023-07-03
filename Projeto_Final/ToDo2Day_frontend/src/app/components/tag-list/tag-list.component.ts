import { Component, OnInit } from '@angular/core';
import { TagService } from '../../services/tag.service';
import { Tag } from '../../models/tag.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-tag-list',
  templateUrl: './tag-list.component.html',
  styleUrls: ['./tag-list.component.css'],
})
export class TagListComponent implements OnInit {
  isLoading = false; // Mostrar ou ocultar botao de carregamento
  tags: Tag[] = []; // Array para armazenar todas as tags

  constructor(private tagService: TagService, private router: Router) {}

  ngOnInit(): void {
    this.isLoading = true;
    // Busca todas as tags
    this.tagService.getAllTags().subscribe(
      (tags) => {
        this.tags = tags; // Atribui as tags buscadas na propriedade tags
        this.isLoading = false; // Para o spinner de carregamento
      },
      (error) => {
        console.log(error);
        this.isLoading = false; // Para o spinner de carregamento em caso de erro
      }
    );
  }

  // Funcao para navegar a pagina de criar tags
  onCreate() {
    this.router.navigate(['/tags/create']);
  }

  // Funcao para navegar a pagina de editar tags
  onEdit(id: string) {
    this.router.navigate(['/tags/edit', id]);
  }

  // Funcao para deletar tag
  onDelete(id: string) {
    this.tagService.deleteTag(id).subscribe(
      () => {
        // Se excluido, remove a tag do array
        this.tags = this.tags.filter((tag) => tag.tagId !== id);
      },
      (error) => {
        console.log(error);
      }
    );
  }
}
