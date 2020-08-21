import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/shared/services/user.service';
import { MatDialog } from '@angular/material/dialog';
import { RetainerDialogComponent } from './retainer-dialog/retainer-dialog.component';
import { Retainer } from 'src/app/app.models';
import { RetainerService } from 'src/app/shared/services/retainer.service';
import { COMMA, ENTER } from '@angular/cdk/keycodes';
import { MatChipInputEvent } from '@angular/material/chips';
import { LodestoneDialogComponent } from './lodestone-dialog/lodestone-dialog.component';

@Component({
  selector: 'xiv-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})
export class ProfileComponent implements OnInit {
  addOnBlur = true;
  retainers: Retainer[] = [];
  readonly separators: number[] = [ENTER, COMMA];

  constructor(private userService: UserService,
    private retainerService: RetainerService,
    private dialog: MatDialog) { }

  get email(): string {
    return this.userService
      ? this.userService.email
      : '';
  }

  ngOnInit(): void {
    this.getRetainers();
  }

  addLabel(retainer: Retainer, event: MatChipInputEvent): void {
    const input = event.input;
    const value = event.value;

    if((value || '').trim()) {
      const label = { 
        id: 0,
        name: value.trim(),
        colorHex: '#333',
        retainerId: retainer.id
      };

      this.retainerService.addLabel(label).subscribe(result => {
        if(result) {
          retainer.labels.push(result);
        }
      })
    }

    if(input) {
      input.value = '';
    }
  }

  addRetainer() {
    const ref = this.dialog.open(RetainerDialogComponent, {
      width: '400px'
    });

    ref.afterClosed().subscribe(result => {
      if(result) {
        this.retainers.push(result);
      }
    });
  }

  deleteLabel(retainer: Retainer, id: number) {
    this.retainerService.deleteLabel(id).subscribe(x => {
      const index = retainer.labels.findIndex(y => y.id === id);

      retainer.labels.splice(index, 1);
    });
  }

  getRetainers() {
    this.retainerService.getRetainers(this.userService.userId).subscribe(result => {
      this.retainers = result;
    });
  }

  linkLodestone() {
    const ref = this.dialog.open(LodestoneDialogComponent, {
      width: '400px'
    });
  }

}
