import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/shared/services/user.service';
import { SheetService } from './services/sheets.service';
import { MatDialog } from '@angular/material/dialog';
import { SheetModel } from './ledger-sheet/ledger-sheet.model';
import { AddSheetDialogComponent } from './ledger-sheet/add-sheet-dialog/add-sheet-dialog.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  isLoading = false;
  sheets: SheetModel[] = [];
  title = 'XIV Ledger';

  constructor(private userService: UserService,
    private sheetService: SheetService,
    private dialog: MatDialog) {

  }

  ngOnInit() {
    if (this.userService.loggedIn) {
      this.getSheets();
    }
  }

  addSheet() {
    const ref = this.dialog.open(AddSheetDialogComponent, {
      width: '300px'
    });

    ref.afterClosed().subscribe(result => {
      if (result) {
        this.getSheets();
      }
    });
  }

  renameSheet(sheet: SheetModel) {
    const ref = this.dialog.open(AddSheetDialogComponent, {
      width: '300px',
      data: {
        sheet: sheet
      }
    });

    ref.afterClosed().subscribe(result => {
      if (result) {
        const index = this.sheets.findIndex(x => x.id === result.id);

        this.sheets[index] = result;
      }
    })
  }

  deleteSheet(id: number) {
    this.sheetService.deleteSheet(id).subscribe(d => {
      const index = this.sheets.findIndex(x => x.id === id);

      this.sheets.splice(index, 1);
    })
  }

  getSheets() {
    this.isLoading = true;
    this.sheetService.getSheets(this.userService.userId).subscribe(s => {
      this.sheets = s;
      this.isLoading = false;
    });
  }
}
