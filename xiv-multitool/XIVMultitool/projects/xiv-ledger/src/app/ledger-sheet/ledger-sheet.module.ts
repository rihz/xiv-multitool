import { NgModule } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { LedgerSheetComponent } from './ledger-sheet.component';
import { MatCardModule } from '@angular/material/card';
import { MatInputModule } from '@angular/material/input';
import { SheetService } from '../services/sheets.service';
import { AddSheetDialogComponent } from './add-sheet-dialog/add-sheet-dialog.component';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { AddTransactionDialogComponent } from './add-transaction-dialog/add-transaction-dialog.component';
import { MatSelectModule } from '@angular/material/select';
import { SharedModule } from 'src/app/shared/shared/shared.module';
import { MatMenuModule } from '@angular/material';



@NgModule({
  declarations: [LedgerSheetComponent, AddSheetDialogComponent, AddTransactionDialogComponent],
  imports: [
    CommonModule,
    MatCardModule,
    MatInputModule,
    MatButtonModule,
    MatIconModule,
    MatSelectModule,
    SharedModule,
    MatMenuModule
  ],
  exports: [
    LedgerSheetComponent
  ],
  providers: [
    SheetService,
    DatePipe
  ],
  entryComponents: [
    AddSheetDialogComponent
  ]
})
export class LedgerSheetModule { }
