import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class ImenikService {

  constructor(private http: Http) { }

  create(imenik: any) {
    return this.http.post('/api/imenik', imenik)
      .map(res => res.json());
  }

  getKontakt(id: any) {
    return this.http.get('/api/imenik/' + id)
    .map(res => res.json())
  }

  update(imenik: any) {
    return this.http.put('/api/imenik/' + imenik.id, imenik)
    .map(res => res.json())
  }

  delete(id: any) {
    return this.http.delete('/api/imenik/' + id)
      .map(res => res.json())

  }

  getKontakti() {
    return this.http.get('/api/imenik')
     .map(res => res.json());
    
    
  }
}
