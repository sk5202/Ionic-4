import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AuthordetailPage } from './authordetail.page';

describe('AuthordetailPage', () => {
  let component: AuthordetailPage;
  let fixture: ComponentFixture<AuthordetailPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AuthordetailPage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AuthordetailPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
