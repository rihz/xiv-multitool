import { Component, OnInit, Input } from '@angular/core';
import { CraftingLogTaskModel } from './crafting-log-task.model';

@Component({
  selector: 'crafting-log-task',
  templateUrl: './crafting-log-task.component.html',
  styleUrls: ['./crafting-log-task.component.scss']
})
export class CraftingLogTaskComponent implements OnInit {
  @Input() task: CraftingLogTaskModel;

  constructor() { }

  ngOnInit(): void {
  }

}
