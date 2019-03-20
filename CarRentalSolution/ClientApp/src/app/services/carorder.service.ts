import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';
import { CarOrder } from '../models/carorder';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
    //'Authorization': 'my-auth-token'
  })
};

@Injectable()
export class CarOrderService {
  //readonly rootURL = "https://localhost:44338/api/";
  ordersUrl = 'api/order';  // URL to web api
  ordersAddUrl = 'api/order/add';
  ordersDeleteUrl = 'api/order/delete';
  ordersEditUrl = 'api/order/edit';



  constructor(private http: HttpClient) { }

  /** GET car orders from the server */
  getCarOrders(): Observable<CarOrder[]> {
    return this.http.get<CarOrder[]>(this.ordersUrl);
      //.pipe(
      //  catchError(this.handleError('getHeroes', []))
      //);
  }

  /** POST: add a new car order to the database */
  addCarOrder(carorder: CarOrder): Observable<CarOrder> {    
    return this.http.post<CarOrder>(this.ordersAddUrl, carorder, httpOptions);      
  }
  
  deleteCarOrder(id) {    
    const url = `${this.ordersDeleteUrl}/${id}`;
    return this.http.delete(url, httpOptions);
  }
  


  getCarOrderById(id) {  
    const url = `${this.ordersUrl}/${id}`;    
    return this.http.get<CarOrder>(url);    
  }

  updateCarOrder(carOrder: CarOrder) {
    
    return this.http.put<CarOrder>(this.ordersEditUrl, carOrder).subscribe();
  }
}
