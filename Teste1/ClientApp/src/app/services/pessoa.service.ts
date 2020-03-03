import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Pessoa } from '../pessoa/pessoa';

@Injectable()
export class PessoaService {

  private http: HttpClient;
  private baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
  }

  getPessoas() {
    return this.http.get<Pessoa[]>(this.baseUrl + 'api/pessoas').toPromise();
  }

}
