import { Component, OnInit, Input } from '@angular/core';
import { UserService } from 'src/app/shared/services/user.service';
import { SheetService } from '../services/sheets.service';
import { MarketTransaction, SheetModel } from './ledger-sheet.model';
import { MatDialog } from '@angular/material/dialog';
import { AddTransactionDialogComponent } from './add-transaction-dialog/add-transaction-dialog.component';
import { ConfirmDeleteLogComponent } from 'src/app/shared/confirm-delete-log/confirm-delete-log.component';
import { P } from '@angular/cdk/keycodes';
import { RetainerSelectorComponent } from 'src/app/shared/retainer-selector/retainer-selector.component';

@Component({
  selector: 'lgr-ledger-sheet',
  templateUrl: './ledger-sheet.component.html',
  styleUrls: ['./ledger-sheet.component.scss']
})
export class LedgerSheetComponent implements OnInit {
  @Input() sheet: SheetModel;
  headers: string[] = [
    'Name',
    'Cost',
    'Sold For',
    'Profit',
    'Date Listed',
    'Date Sold',
    'Controls'
  ]

  constructor(private userService: UserService,
    private sheetService: SheetService,
    private dialog: MatDialog) { }

  get projectedFunds(): number {
    return this.totalProfits && this.sheet.startingFunds
      ? this.sheet.startingFunds + this.totalProfits
      : null;
  }

  get totalCosts(): number {
    return this.sheet.marketTransactions
      ? this.sheet.marketTransactions.reduce((last, current) => last + current.cost, 0)
      : null;
  }

  get totalProfits(): number {
    return this.sheet.marketTransactions
      ? this.totalSales - this.totalCosts
      : null;
  }

  get totalSales(): number {
    return this.sheet.marketTransactions
      ? this.sheet.marketTransactions.reduce((last, current) => last + current.soldFor, 0)
      : null;
  }

  ngOnInit(): void {
    
  }

  assignRetainer(transaction: MarketTransaction) {
    const ref = this.dialog.open(RetainerSelectorComponent, {
      width: '600px'
    });
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

  deleteTransaction(transaction: MarketTransaction) {
    const ref = this.dialog.open(ConfirmDeleteLogComponent, {
      width: '500px',
      data: {
        confirm: 'Yes',
        cancel: 'No',
        heading: 'Confirm Delete',
        message: 'Are you sure you want to delete this transaction?'
      }
    });

    ref.afterClosed().subscribe(result => {
      if(result) {
        this.sheetService.deleteMarketTransaction(transaction.sheetId, transaction.id)
          .subscribe(x => {
            const index = this.sheet.marketTransactions.findIndex(x => x.id === transaction.id);

            this.sheet.marketTransactions.splice(index, 1);
          });
      }
    })
  }

  editTransaction(transaction: MarketTransaction) {
    const ref = this.dialog.open(AddTransactionDialogComponent, {
      width: '500px',
      data: {
        transaction: transaction,
        transactionType: '1'
      }
    });

    ref.afterClosed().subscribe(result => {
      if(result) {
        const index = this.sheet.marketTransactions.findIndex(x => x.id === result.id);

        this.sheet.marketTransactions[index] = result;
      }
    });
  }

  setStartingFunds(funds: any) {
    this.sheet.startingFunds = funds.target.valueAsNumber;

    this.sheetService.updateSheet(this.sheet).subscribe(x => {
      console.log('Update complete');
    });
  }

}
