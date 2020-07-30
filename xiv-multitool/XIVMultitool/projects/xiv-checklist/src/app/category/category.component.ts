import { Component, OnInit, Input } from '@angular/core';
import { Category } from './category.models';
import { trigger, transition, style, animate, query, stagger, animateChild } from '@angular/animations';
import { ITask } from '../task/task.models';

@Component({
  selector: 'category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.scss'],
  animations: [
    trigger('list', [
      transition('* => *', [
        query(':leave', [
          stagger(0, [
            animate('250ms', style({ opacity: 0 }))
          ])
        ], { optional: true }),
        query(':enter', [
          style({ opacity: 0 }),
          stagger(100, [
            animate('250ms', style({ opacity: 1 }))
          ])
        ], { optional: true })
      ])
    ]),
    trigger('fadeIn', [
      transition(':enter', [
        style({ transform: 'scale(0.5)', opacity: 0 }),  // initial
        animate('250ms ease-in', 
          style({ transform: 'scale(1)', opacity: 1 }))  // final
      ]),
      transition(':leave', [
        style({ transform: 'scale(1)', opacity: 1, height: '*' }),
        animate('250ms ease-out', 
         style({ 
           transform: 'scale(0.5)', opacity: 0, 
           height: '0px', margin: '0px' 
         })) 
      ])
    ]),
  ],
})
export class CategoryComponent implements OnInit {
  @Input() category: Category;
  @Input() isTracked = true;
  
  showChildren: boolean = false;

  constructor() { }

  get bannerClass(): string {
    return this.isTracked ? 'blue' : `untracked`;
  }

  get categories(): Category[] {
    return this.showChildren && this.category.categories
      ? this.category.categories
      : [];
  }

  get categoryClass(): string {
    return this.isTracked ? 'blue' : `untracked`;
  }

  get childPosition(): number {
    return this.category.position + 1;
  }

  get left(): number {
    return 12 * (this.category.position - 1);
  }

  get tasks(): ITask[] {
    return this.showChildren && this.category.tasks
      ? this.category.tasks
      : [];
  }

  get width(): number {
    return 600 - (25 * (this.category.position - 1));
  }

  ngOnInit() {
  }
  
  toggleTracking() {
    this.isTracked = !this.isTracked;
  }
}
