import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AuthorPage } from './author.page';

describe('AuthorPage', () => {
  let component: AuthorPage;
  let fixture: ComponentFixture<AuthorPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AuthorPage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AuthorPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
