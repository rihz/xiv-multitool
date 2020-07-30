import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { XIVChecklistModule } from 'projects/xiv-checklist/src/app/app.module';
import { XIVLedgerModule } from 'projects/xiv-ledger/src/app/app.module';
import { NavComponent } from './nav/nav.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    XIVChecklistModule,
    XIVLedgerModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
