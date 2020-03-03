import { LocationStrategy } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators  } from '@angular/forms';
import { Estado } from '../../models/estado';
import { CidadeService } from '../../services/cidade.service';
import { EnderecoService } from '../../services/endereco.service';
import { EstadoService } from '../../services/estado.service';
import { Pessoa } from '../pessoa';
import { Cidade } from '../../models/cidade';
import { Endereco } from '../../models/endereco';

@Component({
  selector: 'app-addpessoa',
  templateUrl: './addpessoa.component.html',
  styleUrls: ['./addpessoa.component.css']
})
export class AddpessoaComponent implements OnInit {

  checkoutForm: FormGroup;
  estados: Estado[];
  cidades: Cidade[];
  enderecos: Endereco[];


  constructor(private locationStrategy: LocationStrategy,
    private formBuilder: FormBuilder,
    private estadoService: EstadoService,
    private cidadeService: CidadeService,
    private ederecoService: EnderecoService) {

    this.createForm();
  }

  ngOnInit() {

    this.estadoService.getEstados().then(result => {
      this.estados = result;
    });


  }

  createForm() {
    this.checkoutForm = this.formBuilder.group({
      codPessoa: '',
      codEndereco: ['', Validators.required],
      nome: ['', Validators.required],
      cpf: ['', Validators.required],
      nascimento: ['', Validators.required],
      telefone: ['', Validators.required],
      email: ['', Validators.required]
    });
  }

  selecionarCidades(e) {

    console.log(e);

    this.cidadeService.getCidades(e.target.value).then(result => this.cidades = result);

    this.enderecos = [];

  }

  selecionarEnderecos(idCidade: number) {

    this.ederecoService.getEnderecos(idCidade).then(result => this.enderecos = result);

  }


  onSubmit(customerData: Pessoa) {
    if (this.checkoutForm.valid) {


      //customerData.id = Number(customerData.id);
      //customerData.genre = Number(customerData.genre);
      //customerData.goalInTheGame = Number(customerData.goalInTheGame);
      //customerData.professionalGoal = Number(customerData.professionalGoal);
      //customerData.streamerGoal = Number(customerData.streamerGoal);
      //customerData.streamer = Boolean(customerData.streamer);
      //customerData.proPlayer = Boolean(customerData.proPlayer);

      //this.playerService.addPlayer(customerData).then(() => {
      //  this.checkoutForm.reset();
      //  this.toastService.showSuccess('Jogador adicionado');
      //});

    } else {
      this.validateAllFormFields(this.checkoutForm);
    }
  }

  validateAllFormFields(formGroup: FormGroup) {
    Object.keys(formGroup.controls).forEach(field => {
      console.log(field);
      const control = formGroup.get(field);
      if (control instanceof FormControl) {
        control.markAsTouched({ onlySelf: true });
      } else if (control instanceof FormGroup) {
        this.validateAllFormFields(control);
      }
    });
  }

  back() {
    this.locationStrategy.back();
  }

}
