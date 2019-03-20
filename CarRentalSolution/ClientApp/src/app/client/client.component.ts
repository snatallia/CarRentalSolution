import { Component, OnInit } from '@angular/core';
import { ClientService } from '../services/client.service';
import { Client } from '../models/client';
import { NgForm } from '@angular/forms';


@Component({
  selector: 'app-client',
  templateUrl: './client.component.html'
})
export class ClientComponent implements OnInit {
  public clients: Client[];

  constructor(private clientSevice: ClientService) { }

  ngOnInit() {
    this.getClients();
  }

  getClients(): void {
    this.clientSevice.getClients()
      .subscribe(clients => this.clients = clients);
  }

}
