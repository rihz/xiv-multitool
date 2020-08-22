import { Component, OnInit, Input, Optional, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { UserService } from 'src/app/shared/services/user.service';
import { SheetService } from '../../services/sheets.service';
import { SheetModel } from '../ledger-sheet.model';
import { LocalStorageService } from 'src/app/shared/services/local-storage.service';

@Component({
  selector: 'lgr-add-sheet-dialog',
  templateUrl: './add-sheet-dialog.component.html',
  styleUrls: ['./add-sheet-dialog.component.scss']
})
export class AddSheetDialogComponent implements OnInit {
  @Input() sheet: SheetModel;
  name = '';

  constructor(private ref: MatDialogRef<AddSheetDialogComponent>,
    private userService: UserService,
    private sheetService: SheetService,
    private storageService: LocalStorageService,
    @Optional() @Inject(MAT_DIALOG_DATA) public data: any) { }

  ngOnInit(): void {
    this.sheet = this.data ? this.data.sheet : new SheetModel();
    this.name = this.sheet.name;
  }

  add() {
    this.sheet.name = this.name;
    this.sheet.userId = this.storageService.model.userId;

    this.sheetService.addSheet(this.sheet).subscribe(result => {
      this.ref.close(result);
    });
  }

  update() {
    this.sheet.name = this.name;

    this.sheetService.updateSheet(this.sheet).subscribe(result => {
      this.ref.close(result);
    })
  }

}
