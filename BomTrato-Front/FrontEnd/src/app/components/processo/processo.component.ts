import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-processo',
  templateUrl: './processo.component.html',
  styleUrls: ['./processo.component.css']
})
export class ProcessoComponent implements OnInit {

  list: any = [];

  constructor() { }

  ngOnInit() {
    this.list = [
        {
          id: 1,
          numeroProcesso: 15,
          valorCausa: "20.000,00",
          escritorio: "Guttenber",
          nomeReclamante: "Kevin",
          ativo: false
        },
        {
          id: 2,
          numeroProcesso: 501,
          valorCausa: "14.000.000,00",
          escritorio: "Hakuna Matata",
          nomeReclamante: "Kevão",
          "ativo": true
        },
        {
          id: 3,
          numeroProcesso: 205,
          valorCausa: "10.000,00",
          escritorio: "Batman",
          nomeReclamante: "Lucas",
          ativo: true
        }
      ]
  }

}
