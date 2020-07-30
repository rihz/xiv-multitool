import { Component, OnInit, Input } from '@angular/core';
import { AchievementTask } from '../task.models';
import { trigger, transition, animate, style } from '@angular/animations';

@Component({
  selector: 'achievement-task',
  templateUrl: './achievement-task.component.html',
  styleUrls: ['./achievement-task.component.scss'],
  animations: [
    trigger('details', [
      transition(':enter', [
        style({ height: '0px', opacity: 0 }),
        animate('0.25s',
          style({ height: '50px', opacity: 1 }))
      ]),
      transition(':leave', [
        style({ height: '50px', opacity: 1 }),
        animate('0.25s',
          style({
            height: '0px',
            opacity: 0
          }))
      ])
    ])
  ]
})
export class AchievementTaskComponent implements OnInit {
  @Input() isTracked = true;
  @Input() position: number;
  @Input() task: AchievementTask;

  showDetails = false;
  
  constructor() { }

  get bannerClass(): string {
    return this.isTracked ? 'blue' : 'untracked';
  }

  get detailLeft(): number {
    return this.left * 4;
  }

  get detailWidth(): number {
    return this.width - 47;
  }

  get opacity(): number {
    return 1 - (0.15 * (this.position - 1));
  }

  get left(): number {
    return 12 * (this.position - 1);
  }

  get width(): number {
    return 550 - (25 * (this.position - 1));
  }

  get hasReward(): boolean {
      return this.task.rewards &&
          this.task.rewards.findIndex(x => x.rewardTypeId !== 5) > -1;
  }

  get hasTitle(): boolean {
      return this.task.rewards &&
          this.task.rewards.findIndex(x => x.rewardTypeId === 5) > -1;
  }

  ngOnInit() {
  }

  toggleTracking() {
    this.isTracked = !this.isTracked;
  }

}
