import { Component, OnInit, Optional, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { SheetService } from '../../services/sheets.service';
import { MarketTransaction } from '../ledger-sheet.model';

@Component({
  selector: 'lgr-add-transaction-dialog',
  templateUrl: './add-transaction-dialog.component.html',
  styleUrls: ['./add-transaction-dialog.component.scss']
})
export class AddTransactionDialogComponent implements OnInit {
  name = '';
  cost: number;
  sold: number;
  sheetId = 0;
  transactionType = 0;
  
  constructor(private ref: MatDialogRef<AddTransactionDialogComponent>,
    private sheetService: SheetService,
    @Optional() @Inject(MAT_DIALOG_DATA) public data: any) { }

  ngOnInit(): void {
    if(this.data && this.data.sheetId) {
      this.sheetId = this.data.sheetId;
    }
  }

  addTransaction() {
    let transaction = null;

    if(this.transactionType == 1) {
      transaction = <MarketTransaction>{
        name: this.name,
        cost: this.cost,
        soldFor: this.sold,
        dateListed: new Date(),
        dateSold: new Date(),
        sheetId: this.sheetId
      };

      this.sheetService.addMarketTransaction(transaction).subscribe(result => {
        this.ref.close(result);
      });
    }
  }

}
