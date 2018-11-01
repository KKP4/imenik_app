import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { ImenikService } from './services/imenik.service';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { ImenikFormComponent } from './imenik-form/imenik-form.component';
import { ImenikListComponent } from './imenik-list/imenik-list.component';
import { DataTablesModule } from 'angular-datatables';
import * as $ from 'jquery'

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    ImenikFormComponent,
    ImenikListComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    HttpModule,
    FormsModule,
    DataTablesModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'imenik/new', component: ImenikFormComponent },
      { path: 'imenik/:id', component: ImenikFormComponent },
      { path: 'imenik', component: ImenikListComponent },
      { path: 'home', component: HomeComponent },
      { path: '**', redirectTo: 'home' },
    ])
  ],
  providers: [
    ImenikService,
    
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
