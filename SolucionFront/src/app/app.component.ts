import { Component, OnInit } from '@angular/core';
import { Transporte } from './modelos/transporte';
import { Viaje } from './modelos/viaje';
import { Vuelo } from './modelos/vuelo';
import { NewshoreService } from './servicios/newshore.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Consultar Viajes';

  viajes: Viaje;
  
  constructor(private newSshoreService: NewshoreService) {}
  
  obtenerRuta(origen: string, destino: string): void{
    this.newSshoreService.getViajes(origen, destino)
      .subscribe((viaje: any) => {
        this.viajes = viaje
      });
  }
}
