import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'banner',
  templateUrl: './banner.component.html',
  styleUrls: ['./banner.component.scss']
})
export class BannerComponent implements OnInit {
  @Input() bannerClass: string;
  @Input() position: number;
  @Output() toggle = new EventEmitter();

  constructor() { }

  get opacity(): number {
    return 1 - (0.15 * (this.position - 1));
  }

  ngOnInit() {
  }

  toggleTracking(e: any) {
    e.stopPropagation();

    this.toggle.emit();
  }

}
