import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { XIVChecklistModule } from 'projects/xiv-checklist/src/app/app.module';
import { XIVLedgerModule } from 'projects/xiv-ledger/src/app/app.module';
import { NavComponent } from './nav/nav.component';
import { MatIconModule } from '@angular/material/icon';
import { AppPanelComponent } from './app-panel/app-panel.component';
import { MatCardModule } from '@angular/material/card';
import { MatSelectModule } from '@angular/material/select';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    AppPanelComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    XIVChecklistModule,
    XIVLedgerModule,
    MatCardModule,
    MatSelectModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
