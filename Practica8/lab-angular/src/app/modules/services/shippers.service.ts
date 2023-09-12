import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ShipperDTO } from '../models/shippers'
import { environment } from '../../../environments/environment'

@Injectable({
  providedIn: 'root'
})
export class ShippersService {

  constructor(private http: HttpClient) { }

  postShippers(request: ShipperDTO) {
    return this.http.post(environment.shippers + 'Shippers/', request);
  }
  readShippers(id: number): Observable<ShipperDTO> {
    return this.http.get<any>(environment.shippers + 'Shippers/' + id);
  }
  getShippers(): Observable<ShipperDTO[]> {
    return this.http.get<any>(environment.shippers + 'Shippers/');
  }
  deleteShippers(id: number): Observable<ShipperDTO> {
    return this.http.delete<any>(environment.shippers + 'Shippers/' + id);
  }
  updateShippers(request: ShipperDTO) {
    const url = `${environment.shippers}Shippers/${request.Id}`;
    return this.http.put<any>(url, request);
  }
}
