import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'xiv-app-panel',
  templateUrl: './app-panel.component.html',
  styleUrls: ['./app-panel.component.scss']
})
export class AppPanelComponent implements OnInit {
  @Input() appName = '';
  
  constructor() { }

  ngOnInit(): void {
  }

}
