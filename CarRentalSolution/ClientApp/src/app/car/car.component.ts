import { Component, OnInit } from '@angular/core';
import { CarService } from '../services/car.service';
import { Car } from '../models/car';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-car',
  templateUrl: './car.component.html'
})
export class CarComponent implements OnInit {
  public cars: Car[];

  constructor(private carSevice: CarService) { }

  ngOnInit() {
    this.getCars();
  }

  getCars(): void {
    this.carSevice.getCars().
      subscribe(cars => this.cars = cars);
  }

}
