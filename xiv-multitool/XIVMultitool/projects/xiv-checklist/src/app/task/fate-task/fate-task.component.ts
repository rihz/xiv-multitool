import { Component, OnInit, Input } from '@angular/core';
import { FATETaskModel } from './fate-task.model';

@Component({
  selector: 'fate-task',
  templateUrl: './fate-task.component.html',
  styleUrls: ['./fate-task.component.scss']
})
export class FateTaskComponent implements OnInit {
  @Input() task: FATETaskModel;

  constructor() { }

  ngOnInit(): void {
  }

}
