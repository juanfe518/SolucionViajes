import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Viaje } from '../modelos/viaje';
import { environment } from 'src/environments/environment';


@Injectable({
  providedIn: 'root'
})
export class NewshoreService {

  private url = "vuelos"
  constructor(private httpClient: HttpClient) { }

  public getViajes(origen: string, destino: string) : Observable<Viaje> {
    return this.httpClient.get<Viaje>(`${environment.apiUrl}/${this.url}/viaje?origen=${origen}&destino=${destino}`);
  }
}
