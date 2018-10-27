import { Component, OnInit } from '@angular/core';
import { ImenikService } from './../services/imenik.service';
import { ActivatedRoute, Router } from '@angular/router';
@Component({
  selector: 'app-imenik-form',
  templateUrl: './imenik-form.component.html',
  styleUrls: ['./imenik-form.component.css']
})
export class ImenikFormComponent implements OnInit {

  imenik = {
    id: 0,
  };

  id: any;
  ime: any;
  priimek: any;
  naslov: any;
  telStevilka: any;


  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private imenikService: ImenikService) {

    route.params.subscribe(p => {
      if (p['id']) {
        this.imenik.id = p['id'];
      }
    }, err => {
      if (err.status == 404)
        this.router.navigate(['/imenik']);
    });


  }

  ngOnInit() {
    if (this.imenik.id) {
      this.imenikService.getImenik(this.imenik.id)
        .subscribe(b => {
          this.imenik = b;
        });
    }

  }

  submit() {
    if (this.imenik.id != 0) {
      this.imenikService.update(this.imenik)
        .subscribe(x => {
          this.router.navigate(['/imenik'])
        });
    }

    else {

      this.imenikService.create(this.imenik)
        .subscribe(x => {
          this.router.navigate(['/imenik'])
        });

    }
  }

  delete() {
    if (confirm("Ste prepričani?")) {
      this.imenikService.delete(this.imenik.id)
        .subscribe(x => {
          this.router.navigate(['/imenik'])
        });
    }
  }
}
