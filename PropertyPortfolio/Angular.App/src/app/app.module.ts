import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'; 

import { AppComponent } from './app.component';

import ApiPropertyPortfolioService from './shared/api.propertyportfolio.service';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [ApiPropertyPortfolioService],
  bootstrap: [AppComponent]
})
export class AppModule { }
