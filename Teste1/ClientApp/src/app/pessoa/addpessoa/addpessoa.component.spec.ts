import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddpessoaComponent } from './addpessoa.component';

describe('AddpessoaComponent', () => {
  let component: AddpessoaComponent;
  let fixture: ComponentFixture<AddpessoaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddpessoaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddpessoaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
