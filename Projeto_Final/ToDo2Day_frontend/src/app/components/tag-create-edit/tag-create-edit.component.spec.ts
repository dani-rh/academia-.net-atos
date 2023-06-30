import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TagCreateEditComponent } from './tag-create-edit.component';

describe('TagCreateEditComponent', () => {
  let component: TagCreateEditComponent;
  let fixture: ComponentFixture<TagCreateEditComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TagCreateEditComponent]
    });
    fixture = TestBed.createComponent(TagCreateEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
