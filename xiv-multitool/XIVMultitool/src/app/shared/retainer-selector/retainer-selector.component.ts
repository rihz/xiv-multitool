import { Component, OnInit } from '@angular/core';
import { MatDialogRef } from '@angular/material';
import { Retainer } from 'src/app/app.models';
import { RetainerService } from '../services/retainer.service';
import { UserService } from '../services/user.service';

@Component({
  selector: 'xiv-retainer-selector',
  templateUrl: './retainer-selector.component.html',
  styleUrls: ['./retainer-selector.component.scss']
})
export class RetainerSelectorComponent implements OnInit {
  retainers: Retainer[] = [];

  constructor(private ref: MatDialogRef<RetainerSelectorComponent>,
    private retainerService: RetainerService,
    private userService: UserService) { }

  ngOnInit(): void {
    this.retainerService.getRetainers(this.userService.userId).subscribe(result => {
      this.retainers = result;
    });
  }

}
