import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdatepessoaComponent } from './updatepessoa.component';

describe('UpdatepessoaComponent', () => {
  let component: UpdatepessoaComponent;
  let fixture: ComponentFixture<UpdatepessoaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UpdatepessoaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UpdatepessoaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
