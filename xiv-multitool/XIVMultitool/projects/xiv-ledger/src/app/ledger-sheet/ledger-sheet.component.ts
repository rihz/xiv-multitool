import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/shared/services/user.service';
import { SheetService } from '../services/sheets.service';
import { SheetModel } from './ledger-sheet.model';

@Component({
  selector: 'lgr-ledger-sheet',
  templateUrl: './ledger-sheet.component.html',
  styleUrls: ['./ledger-sheet.component.scss']
})
export class LedgerSheetComponent implements OnInit {
  sheets: SheetModel[] = [];

  constructor(private userService: UserService,
    private sheetService: SheetService) { }

  ngOnInit(): void {
    if(this.userService.loggedIn) {
      this.sheetService.getSheets(this.userService.userId).subscribe(s => {
        this.sheets = s;
      });
    }
  }

}
