import { Component, OnInit } from '@angular/core';
import { ImenikService } from './../services/imenik.service';

@Component({
  selector: 'app-imenik-list',
  templateUrl: './imenik-list.component.html',
  styleUrls: ['./imenik-list.component.css']
})
export class ImenikListComponent implements OnInit {

  imeniki: any[];
  
 

  constructor(
    
    private imenikService: ImenikService) { }

  ngOnInit() {

    this.imenikService.getImeniki()
      .subscribe(imeniki => {
        this.imeniki = imeniki;
        
      });
  }

}
