import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Cidade } from '../models/cidade';

@Injectable()
export class CidadeService {

  private http: HttpClient;
  private baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
  }

  getCidades(idEstado: number) {
    return this.http.get<Cidade[]>(this.baseUrl + 'api/cidades/' + idEstado).toPromise();
  }

}
