import { Component, OnInit, Input } from '@angular/core';
import { UserService } from 'src/app/shared/services/user.service';
import { SheetService } from '../services/sheets.service';
import { SheetModel } from './ledger-sheet.model';
import { MatDialog } from '@angular/material/dialog';
import { AddTransactionDialogComponent } from './add-transaction-dialog/add-transaction-dialog.component';

@Component({
  selector: 'lgr-ledger-sheet',
  templateUrl: './ledger-sheet.component.html',
  styleUrls: ['./ledger-sheet.component.scss']
})
export class LedgerSheetComponent implements OnInit {
  @Input() sheet: SheetModel;

  constructor(private userService: UserService,
    private sheetService: SheetService,
    private dialog: MatDialog) { }

  ngOnInit(): void {
    
  }

  addTransaction() {
    const ref = this.dialog.open(AddTransactionDialogComponent, {
      width: '500px',
      data: {
        sheetId: this.sheet.id
      }
    });

    ref.afterClosed().subscribe(result => {
      if(result) {
        this.sheet.marketTransactions.push(result);
      }
    });
  }

}
