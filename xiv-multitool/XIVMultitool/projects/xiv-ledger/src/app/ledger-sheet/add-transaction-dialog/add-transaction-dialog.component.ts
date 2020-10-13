import { DatePipe } from '@angular/common';
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
  dateListed = '';
  dateSold = '';
  id: number = 0;
  
  constructor(private ref: MatDialogRef<AddTransactionDialogComponent>,
    private sheetService: SheetService,
    private datePipe: DatePipe,
    @Optional() @Inject(MAT_DIALOG_DATA) public data: any) { }

  ngOnInit(): void {
    if(this.data && this.data.sheetId) {
      this.sheetId = this.data.sheetId;
    }

    if(this.data && this.data.transaction) {
      this.transactionType = this.data.transactionType;
      this.name = this.data.transaction.name;
      this.cost = this.data.transaction.cost;
      this.sold = this.data.transaction.soldFor;
      this.sheetId = this.data.transaction.sheetId;
      this.dateListed = this.datePipe.transform(new Date(this.data.transaction.dateListed), 'yyyy-MM-dd');
      this.dateSold = this.datePipe.transform(new Date(this.data.transaction.dateSold), 'yyyy-MM-dd');
      this.id = this.data.transaction.id;
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
        sheetId: this.sheetId,
        id: this.id
      };

      this.sheetService.addMarketTransaction(transaction).subscribe(result => {
        this.ref.close(result);
      });
    }
  }

  editTransaction() {
    let transaction = null;

    if(this.transactionType == 1) {
      transaction = <MarketTransaction>{
        name: this.name,
        cost: this.cost,
        soldFor: this.sold,
        dateListed: new Date(),
        dateSold: new Date(),
        sheetId: this.sheetId,
        id: this.id
      };

      this.sheetService.updateMarketTransaction(transaction).subscribe(result => {
        this.ref.close(result);
      });
    }
  }

  submit() {
    if(this.id > 0) {
      this.editTransaction();
    } else {
      this.addTransaction();
    }
  }

}
