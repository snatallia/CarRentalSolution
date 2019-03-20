import { Component, OnInit } from '@angular/core';
import { CarOrderService } from '../services/carorder.service';
import { CarOrder } from '../models/carorder';
import { NgForm } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';


@Component({
  selector: 'app-addcarorder',
  providers: [CarOrderService],
  templateUrl: './addcarorder.component.html'
})

export class AddCarOrderComponent {    
  carOrderId: number;
  order: Observable<CarOrder>;

  constructor(private carOrderService: CarOrderService, private avRoute: ActivatedRoute) {
    this.carOrderId = 0;
    this.getCarOrder();    
  }

  getCarOrder() {
    if (this.avRoute.snapshot.params["id"]) {
      this.carOrderId = this.avRoute.snapshot.params["id"];
    }

    if (this.carOrderId > 0) {
      this.order = this.carOrderService.getCarOrderById(this.carOrderId);
    }
  }




  add(CarID: string, ClientID: string, PickUpDate: string, DropOffDate: string): void {
    
    if (this.carOrderId > 0) {
      //  let id = this.carOrderId;
      //  const editOrder: CarOrder = {id, CarID, ClientID, PickUpDate, DropOffDate } as CarOrder;        
      //this.carOrderService.updateCarOrder(editOrder);
    }
    else if (this.carOrderId == 0) {
      
      const newOrder: CarOrder = { CarID, ClientID, PickUpDate, DropOffDate } as CarOrder;

      this.carOrderService.addCarOrder(newOrder).subscribe();
        
    }
  }

}
