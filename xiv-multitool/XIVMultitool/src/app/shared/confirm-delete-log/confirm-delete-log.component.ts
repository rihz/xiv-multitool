import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';

@Component({
  selector: 'xiv-confirm-delete-log',
  templateUrl: './confirm-delete-log.component.html',
  styleUrls: ['./confirm-delete-log.component.scss']
})
export class ConfirmDeleteLogComponent implements OnInit {

  constructor(private ref: MatDialogRef<ConfirmDeleteLogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any) { }

  ngOnInit(): void {
  }

  close(value: boolean) {
    this.ref.close(value);
  }

}
