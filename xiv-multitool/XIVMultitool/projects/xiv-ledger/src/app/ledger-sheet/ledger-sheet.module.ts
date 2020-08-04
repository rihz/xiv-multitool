import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LedgerSheetComponent } from './ledger-sheet.component';
import { MatCardModule } from '@angular/material/card';
import { MatInputModule } from '@angular/material/input';
import { SheetService } from '../services/sheets.service';



@NgModule({
  declarations: [LedgerSheetComponent],
  imports: [
    CommonModule,
    MatCardModule,
    MatInputModule
  ],
  exports: [
    LedgerSheetComponent
  ],
  providers: [
    SheetService
  ]
})
export class LedgerSheetModule { }
