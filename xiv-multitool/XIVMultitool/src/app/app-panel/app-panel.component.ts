import { Component, OnInit, Input } from '@angular/core';
import { AppPanel } from '../app.models';

@Component({
  selector: 'xiv-app-panel',
  templateUrl: './app-panel.component.html',
  styleUrls: ['./app-panel.component.scss']
})
export class AppPanelComponent implements OnInit {
  @Input() app: AppPanel;

  constructor() { }

  ngOnInit(): void {
  }

}
