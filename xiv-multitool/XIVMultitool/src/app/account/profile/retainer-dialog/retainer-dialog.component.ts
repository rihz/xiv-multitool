import { Component, OnInit, Optional, Inject, Input } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Retainer } from 'src/app/app.models';
import { UserService } from 'src/app/shared/services/user.service';
import { RetainerService } from 'src/app/shared/services/retainer.service';

@Component({
  selector: 'xiv-retainer-dialog',
  templateUrl: './retainer-dialog.component.html',
  styleUrls: ['./retainer-dialog.component.scss']
})
export class RetainerDialogComponent implements OnInit {
  @Input() retainer: Retainer;
  name = '';

  constructor(private ref: MatDialogRef<RetainerDialogComponent>,
    private userService: UserService,
    private retainerService: RetainerService,
    @Optional() @Inject(MAT_DIALOG_DATA) public data: any) { }

  ngOnInit(): void {
    this.retainer = this.data ? this.data.retainer : new Retainer();
    this.name = this.retainer.name;
  }

  add() {
    this.retainer.name = this.name;
    this.retainer.userId = this.userService.userId;

    this.retainerService.addRetainer(this.retainer).subscribe(result => {
      this.ref.close(result);
    });
  }

  save() {
    if(this.retainer.id > 0) {
      // update
    } else {
      this.add();
    }
  }

}
