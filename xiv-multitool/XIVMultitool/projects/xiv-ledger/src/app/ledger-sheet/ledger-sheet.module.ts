import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LedgerSheetComponent } from './ledger-sheet.component';
import { MatCardModule } from '@angular/material/card';
import { MatInputModule } from '@angular/material/input';



@NgModule({
  declarations: [LedgerSheetComponent],
  imports: [
    CommonModule,
    MatCardModule,
    MatInputModule
  ],
  exports: [
    LedgerSheetComponent
  ]
})
export class LedgerSheetModule { }
