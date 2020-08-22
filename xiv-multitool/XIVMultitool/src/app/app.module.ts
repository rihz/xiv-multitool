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
import { MatButtonModule } from '@angular/material/button';
import { SharedModule } from './shared/shared/shared.module';
import { UserService } from './shared/services/user.service';
import { HeaderComponent } from './shared/header/header.component';
import { MatInputModule } from '@angular/material/input';
import { RetainerService } from './shared/services/retainer.service';
import { MatMenuModule } from '@angular/material/menu';
import { CopyClipboardDirective } from './shared/clipboard.directive';
import { CommonModule } from '@angular/common';
import { LocalStorageService } from './shared/services/local-storage.service';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    AppPanelComponent,
    HeaderComponent,
  ],
  imports: [
    BrowserModule,
    CommonModule,
    AppRoutingModule,
    XIVChecklistModule,
    XIVLedgerModule,
    MatCardModule,
    MatSelectModule,
    MatButtonModule,
    SharedModule,
    MatInputModule,
    MatMenuModule,
    MatIconModule
  ],
  providers: [UserService, RetainerService, LocalStorageService],
  bootstrap: [AppComponent]
})
export class AppModule { }
