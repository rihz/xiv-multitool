import { Component, OnInit, Input } from '@angular/core';
import { GatheringLogTaskModel } from './gathering-log-task.model';

@Component({
  selector: 'gathering-log-task',
  templateUrl: './gathering-log-task.component.html',
  styleUrls: ['./gathering-log-task.component.scss']
})
export class GatheringLogTaskComponent implements OnInit {
  @Input() task: GatheringLogTaskModel;
  
  constructor() { }

  ngOnInit(): void {
  }

}
