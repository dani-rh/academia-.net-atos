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
  tagForm: FormGroup; // Form group instance to handle form operations
  editMode = false; // To keep track of whether we are in edit mode or create mode
  tag: Tag; // To hold the data of the tag to be edited
  tagId: string; // To hold the ID of the tag to be edited

  constructor(
    private tagService: TagService, // Injecting the tag service
    private route: ActivatedRoute, // Injecting the activated route service
    private router: Router // Injecting the router service
  ) {}

  ngOnInit(): void {
    // Initializing the form group
    this.tagForm = new FormGroup({
      tagName: new FormControl(null, Validators.required), // tagName field with required validator
    });

    // Subscribing to route parameters
    this.route.params.subscribe((params) => {
      if (params['id']) {
        // If ID is present in the route, we are in edit mode
        this.editMode = true;
        this.tagId = params['id']; // Storing the ID from the route parameters
        // Fetching the tag data
        this.tagService.getTagById(this.tagId).subscribe((tag: Tag) => {
          this.tag = tag; // Storing the fetched tag data
          // Setting the fetched tag's name to the form
          this.tagForm.setValue({
            tagName: this.tag.name,
          });
        });
      }
    });
  }

  onSubmit() {
    if (this.editMode) {
      // If in edit mode
      const { tagName: newTagName } = this.tagForm.value; // Extract the updated tag name
      // Update the tag
      this.tagService.updateTag(this.tagId, { newTagName }).subscribe(() => {
        this.router.navigate(['/tags']); // Navigate to the tags list
      });
    } else {
      // If in create mode
      const { tagName } = this.tagForm.value; // Extract the tag name
      // Add the new tag
      this.tagService.addTag({ tagName }).subscribe(() => {
        this.router.navigate(['/tags']); // Navigate to the tags list
      });
    }
  }
}
