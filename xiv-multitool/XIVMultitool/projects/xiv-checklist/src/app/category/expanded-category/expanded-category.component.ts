import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Category } from '../category.models';

@Component({
  selector: 'expanded-category',
  templateUrl: './expanded-category.component.html',
  styleUrls: ['./expanded-category.component.scss']
})
export class ExpandedCategoryComponent implements OnInit {
  @Input() category: Category;
  @Input() default = false;
  @Output() goBack = new EventEmitter<number>();

  constructor() { }

  ngOnInit(): void {
  }

  backtrack(id: number) {
    this.goBack.emit(id);
  }

  getWidth(position: number): number {
    return position * 50;
  }

}
