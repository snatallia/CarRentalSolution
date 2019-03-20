import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Client } from '../models/client';


@Injectable()
export class ClientService {
  clientsUrl = 'api/clients';  // URL to web api 

  constructor(private http: HttpClient) { }

  /** GET car orders from the server */
  getClients(): Observable<Client[]> {
    return this.http.get<Client[]>(this.clientsUrl);
  }
}
