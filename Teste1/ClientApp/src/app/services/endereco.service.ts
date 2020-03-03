import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Endereco } from '../models/endereco';

@Injectable()
export class EnderecoService {

  private http: HttpClient;
  private baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
  }

  getEnderecos(idCidade: number) {
    return this.http.get<Endereco[]>(this.baseUrl + 'api/enderecos/' + idCidade).toPromise();
  }

}
