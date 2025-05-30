import { Component, OnInit } from '@angular/core';
import { HotelService } from '../hotel.service';
import { Hotel } from '../hotel.model';
import { CommonModule } from '@angular/common';
import { MatTableModule } from '@angular/material/table';
import { MatButtonModule } from '@angular/material/button';
import { RouterModule, Router } from '@angular/router';

@Component({
  selector: 'app-hotel-list',
  standalone: true,
  imports: [CommonModule, MatTableModule, MatButtonModule, RouterModule],
  templateUrl: './hotel-list.component.html',
})
export class HotelListComponent implements OnInit {
  hoteis: Hotel[] = [];
  displayedColumns = ['nome', 'descricao', 'localizacao', 'quarto', 'acoes'];

  constructor(private service: HotelService, private router: Router) {}

  ngOnInit(): void {
    this.service.listar().subscribe({
      next: (dados: Hotel[]) => {
        console.log('Resposta da API:', dados);
        this.hoteis = dados;
      },
      error: () => {
        if (typeof window !== 'undefined') {
          alert('Erro ao carregar hotéis.');
        }
      },
    });
  }

  editar(hotel: Hotel) {
    if (typeof window !== 'undefined') {
      alert(`Editar hotel ${hotel.nome} (simulação)`);
    }
  }

  remover(hotel: Hotel) {
    if (typeof window !== 'undefined') {
      alert(`Remover hotel ${hotel.nome} (simulação)`);
    }
  }
}
