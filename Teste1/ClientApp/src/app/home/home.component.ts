import { Component, OnInit } from '@angular/core';
import { PessoaService } from '../services/pessoa.service';
import { Pessoa } from '../pessoa/pessoa';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {


  pessoas: Pessoa[];

  constructor(private pessoaServive: PessoaService) {}


  ngOnInit(): void {
    this.pessoaServive.getPessoas().then(result => this.pessoas = result);
  }




}
