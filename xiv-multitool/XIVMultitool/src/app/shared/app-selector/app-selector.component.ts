import { Location } from '@angular/common';
import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AppPanel } from 'src/app/app.models';

@Component({
  selector: 'xiv-app-selector',
  templateUrl: './app-selector.component.html',
  styleUrls: ['./app-selector.component.scss']
})
export class AppSelectorComponent implements OnInit {
  @Input() apps: AppPanel[];
  selectedApp: AppPanel = null;
  
  constructor(public router: Router, public location: Location) { }

  get availableApps(): AppPanel[] {
    return this.apps.filter(x => x.name !== this.selectedApp.name);
  }

  ngOnInit(): void {
    if(this.apps && this.apps.length > 0) {
      this.selectedApp = this.apps[0];
      
      this.apps.filter(x => x.path !== '/').forEach(value => {
        if(this.location.path().includes(value.path)) {
          this.selectedApp = value;
        }
      });
    }
  }

  chooseApp(app: AppPanel) {
    this.selectedApp = app;

    this.router.navigate([this.selectedApp.path]);
  }

}
