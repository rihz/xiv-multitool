import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'category-banner',
  templateUrl: './category-banner.component.html',
  styleUrls: ['./category-banner.component.scss']
})
export class CategoryBannerComponent implements OnInit {
  @Input() bannerClass: string;
  @Output() toggle = new EventEmitter();

  constructor() { }

  ngOnInit() {
  }

  toggleTracking(e: any) {
    e.stopPropagation();

    this.toggle.emit();
  }

}
