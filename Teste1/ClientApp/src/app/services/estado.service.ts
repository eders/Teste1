import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Estado } from '../models/estado';

@Injectable()
export class EstadoService {

  private http: HttpClient;
  private baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
  }

  getEstados() {
    return this.http.get<Estado[]>(this.baseUrl + 'api/estados').toPromise();
  }

}
