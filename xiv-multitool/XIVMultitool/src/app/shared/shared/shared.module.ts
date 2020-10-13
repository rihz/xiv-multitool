import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CopyClipboardDirective } from '../clipboard.directive';
import { BrowserModule } from '@angular/platform-browser';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { ConfirmDeleteLogComponent } from '../confirm-delete-log/confirm-delete-log.component';
import { MatCardModule, MatChipsModule, MatSelectModule } from '@angular/material';
import { RetainerSelectorComponent } from '../retainer-selector/retainer-selector.component';



@NgModule({
  declarations: [
    CopyClipboardDirective,
    ConfirmDeleteLogComponent,
    RetainerSelectorComponent
  ],
  imports: [
    CommonModule,
    MatButtonModule,
    MatIconModule,
    MatSelectModule,
    MatCardModule,
    MatChipsModule
  ],
  exports: [
    CopyClipboardDirective
  ]
})
export class SharedModule { }
