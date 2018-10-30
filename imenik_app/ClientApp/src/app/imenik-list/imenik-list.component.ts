import { Component, OnInit } from '@angular/core';
import { ImenikService } from './../services/imenik.service';
import { Http } from '@angular/http';
import { Subject } from 'rxjs/Subject';
import 'rxjs/add/operator/map';

@Component({
  selector: 'app-imenik-list',
  templateUrl: './imenik-list.component.html',
  styleUrls: ['./imenik-list.component.css']
})
export class ImenikListComponent implements OnInit {

  kontakti: any[] = [];
  dtTrigger: Subject<any> = new Subject();
  dtOptions: DataTables.Settings = {};
  
 

  constructor(
    private http: Http,
    private imenikService: ImenikService
  ) { }

  ngOnInit() {

    this.dtOptions = {
      pagingType: "full_numbers",
      pageLength: 2
    };

    this.imenikService.getKontakti()
      .subscribe(kontakti => {
        this.kontakti = kontakti;
        this.dtTrigger.next();
        
      });
  }

}
