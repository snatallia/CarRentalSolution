import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Car } from '../models/car';


@Injectable()
export class CarService {
  carsUrl = 'api/cars';  // URL to web api 

  constructor(private http: HttpClient) { }

  /** GET car orders from the server */
  getCars(): Observable<Car[]> {
    return this.http.get<Car[]>(this.carsUrl);
  }
}
