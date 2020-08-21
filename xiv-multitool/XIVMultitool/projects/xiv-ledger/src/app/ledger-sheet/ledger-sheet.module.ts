import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LedgerSheetComponent } from './ledger-sheet.component';
import { MatCardModule } from '@angular/material/card';
import { MatInputModule } from '@angular/material/input';
import { SheetService } from '../services/sheets.service';
import { AddSheetDialogComponent } from './add-sheet-dialog/add-sheet-dialog.component';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { AddTransactionDialogComponent } from './add-transaction-dialog/add-transaction-dialog.component';
import { MatSelectModule } from '@angular/material/select';



@NgModule({
  declarations: [LedgerSheetComponent, AddSheetDialogComponent, AddTransactionDialogComponent],
  imports: [
    CommonModule,
    MatCardModule,
    MatInputModule,
    MatButtonModule,
    MatIconModule,
    MatSelectModule
  ],
  exports: [
    LedgerSheetComponent
  ],
  providers: [
    SheetService
  ],
  entryComponents: [
    AddSheetDialogComponent
  ]
})
export class LedgerSheetModule { }
