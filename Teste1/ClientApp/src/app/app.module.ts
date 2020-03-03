import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { PessoaService } from './services/pessoa.service';
import { AddpessoaComponent } from './pessoa/addpessoa/addpessoa.component';
import { UpdatepessoaComponent } from './pessoa/updatepessoa/updatepessoa.component';
import { EstadoService } from './services/estado.service';
import { CidadeService } from './services/cidade.service';
import { EnderecoService } from './services/endereco.service';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AddpessoaComponent,
    UpdatepessoaComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule ,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'adicionar/pessoa', component: AddpessoaComponent}
    ])
  ],
  providers: [PessoaService, EstadoService, CidadeService, EnderecoService],
  bootstrap: [AppComponent]
})
export class AppModule { }
