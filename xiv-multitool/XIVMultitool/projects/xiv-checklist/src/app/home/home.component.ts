import { Component, OnInit, ViewChild, OnDestroy, AfterViewInit } from '@angular/core';
import { Category } from '../category/category.models';
import { ITask, AchievementTask } from '../task/task.models';
import { ApiService } from '../shared/services/api.service';
import { CdkVirtualScrollViewport } from '@angular/cdk/scrolling';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit, AfterViewInit {
  @ViewChild(CdkVirtualScrollViewport) virtualScroll: CdkVirtualScrollViewport;
  categories: Category[] = [];
  isLoading = false;
  selectedCategories: Category[] = [];

  get optionCategories(): Category[] {
    return this.selectedCategories.length > 0
      ? this.selectedCategories[this.selectedCategories.length - 1].categories
      : this.categories;
  }

  get optionTasks(): ITask[] {
    const recent = this.selectedCategories.length > 0
      ? this.selectedCategories[this.selectedCategories.length - 1]
      : null;

    return recent && recent.tasks && recent.tasks.length > 0
      ? recent.tasks
      : [];
  }

  constructor(private api: ApiService) { }

  ngAfterViewInit() {    
    if(this.virtualScroll) {
      this.virtualScroll.renderedRangeStream.subscribe(range => {
        console.log('range', range);
      });
    }
  }

  ngOnInit() {
    this.isLoading = true;
    this.api.get('/categories')
      .subscribe(results => {
        this.categories = results;
        this.isLoading = false;
      }, error => {
        alert(error);
        this.isLoading = false;
      });
  }

  backtrack(id: number) {
    const index = this.selectedCategories.findIndex(x => x.id === id);

    if (index > -1) {
      this.selectedCategories.splice(index);
    }
  }

  handleSelect(category: Category) {
    this.selectedCategories.push(category);
  }

}
