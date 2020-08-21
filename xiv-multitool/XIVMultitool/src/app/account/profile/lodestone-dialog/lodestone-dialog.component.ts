import { Component, OnInit } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';
import { UserService } from 'src/app/shared/services/user.service';

@Component({
  selector: 'xiv-lodestone-dialog',
  templateUrl: './lodestone-dialog.component.html',
  styleUrls: ['./lodestone-dialog.component.scss']
})
export class LodestoneDialogComponent implements OnInit {
  code = '';
  characterId = '';

  constructor(private ref: MatDialogRef<LodestoneDialogComponent>,
    private userService: UserService) { }

  ngOnInit(): void {
    this.code = this.generateCode();
  }

  generateCode(): string {
    let baseCode = 'xivmultitool-';

    for(let i = 0; i < 10; i++) {
      baseCode += Math.floor(Math.random() * 10);
    }

    return baseCode;
  }

  verify() {
    this.userService.verifyLodestone(this.characterId, this.code)
      .subscribe(result => {
        this.ref.close(result);
      });
  }

}
