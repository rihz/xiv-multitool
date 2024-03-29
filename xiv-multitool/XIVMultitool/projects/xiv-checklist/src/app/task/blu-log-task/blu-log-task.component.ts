import { Component, OnInit, Input } from '@angular/core';
import { trigger, transition, style, animate } from '@angular/animations';
import { BLUCarnivaleTask, BLULogTask } from '../task.models';

@Component({
  selector: 'blu-log-task',
  templateUrl: './blu-log-task.component.html',
  styleUrls: ['./blu-log-task.component.scss'],
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
export class BluLogTaskComponent implements OnInit {
  @Input() isTracked = true;
  @Input() position: number;
  @Input() task: BLULogTask;

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
    return 600 - (25 * (this.position - 1));
  }

  ngOnInit() {
  }

  toggleTracking() {
    this.isTracked = !this.isTracked;
  }

}
