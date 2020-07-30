import { Component, OnInit, Input, ChangeDetectionStrategy } from '@angular/core';
import { FishGuideTaskModel } from './fish-guide-task.model';

@Component({
  selector: 'fish-guide-task',
  templateUrl: './fish-guide-task.component.html',
  styleUrls: ['./fish-guide-task.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class FishGuideTaskComponent implements OnInit {
  @Input() task: FishGuideTaskModel;

  constructor() { }

  ngOnInit(): void {
  }

}
