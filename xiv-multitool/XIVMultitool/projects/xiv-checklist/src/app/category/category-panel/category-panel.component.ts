import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Category } from '../category.models';

@Component({
  selector: 'category-panel',
  templateUrl: './category-panel.component.html',
  styleUrls: ['./category-panel.component.scss']
})
export class CategoryPanelComponent implements OnInit {
  @Input() category: Category;
  @Input() completed: number;
  @Input() total: number;
  @Output() onSelect = new EventEmitter<Category>();

  constructor() { }

  ngOnInit(): void {
  }

  selectCategory(category: Category) {
    console.log('select', category);
    this.onSelect.emit(this.category);
  }

}
