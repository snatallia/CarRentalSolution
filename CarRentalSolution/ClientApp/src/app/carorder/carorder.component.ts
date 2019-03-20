import { Component, OnInit } from '@angular/core';
import { CarOrderService } from '../services/carorder.service';
import { CarOrder } from '../models/carorder';
import { NgForm } from '@angular/forms';


@Component({
    selector: 'app-carorder',
    providers: [CarOrderService],
    templateUrl: './carorder.component.html'
})

export class CarOrderComponent implements OnInit{
    public carOrders: CarOrder[];  
    editCarOrder: CarOrder;

  constructor(private carOrderService: CarOrderService) { this.getCarOrders();}

  ngOnInit() {
    this.getCarOrders();
  }

  getCarOrders(): void {
    this.carOrderService.getCarOrders()
      .subscribe(orders => this.carOrders = orders);    
  }



  add(CarID: string, ClientID: string, PickUpDate: string, DropOffDate: string): void {

    const newOrder: CarOrder = { CarID, ClientID, PickUpDate, DropOffDate } as CarOrder;

    this.carOrderService.addCarOrder(newOrder)
      .subscribe(order => 
        this.carOrders.push(order)
      );
    
  }

  edit(carOrder: CarOrder) {}

  delete(id:number): void {
    //this.carOrders = this.carOrders.filter(order => order != carOrder);
    this.carOrderService.deleteCarOrder(id).subscribe();  
  }

  update(editOrder: CarOrder) {    
    this.carOrderService.updateCarOrder(editOrder)
  }

}

