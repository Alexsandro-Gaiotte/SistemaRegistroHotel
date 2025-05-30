import { Component } from '@angular/core';
import {
  FormBuilder,
  FormGroup,
  Validators,
  ReactiveFormsModule,
} from '@angular/forms';
import { Router } from '@angular/router';
import { HotelService } from '../hotel.service';
import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-hotel-form',
  standalone: true,
  imports: [
    ReactiveFormsModule,
    MatCardModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    CommonModule,
  ],
  templateUrl: './hotel-form.component.html',
  styleUrls: ['./hotel-form.component.css'],
})
export class HotelFormComponent {
  form: FormGroup;

  constructor(
    private fb: FormBuilder,
    private service: HotelService,
    private router: Router
  ) {
    this.form = this.fb.group({
      nome: ['', Validators.required],
      descricao: ['', Validators.required],
      localizacao: ['', Validators.required],
      quarto: [null, [Validators.required, Validators.min(0)]],
    });
  }

  salvar() {
    if (this.form.valid) {
      this.service.adicionar(this.form.value).subscribe({
        next: () => this.router.navigate(['/']),
        error: () => alert('Erro ao salvar hotel.'),
      });
    }
  }
}
