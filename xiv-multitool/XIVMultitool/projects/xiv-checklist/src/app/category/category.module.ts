import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CategoryComponent } from './category.component';
import { CategoryBannerComponent } from './category-banner/category-banner.component';
import { MatExpansionModule } from '@angular/material/expansion';
import { MatRippleModule } from '@angular/material/core';
import { MatCardModule } from '@angular/material/card';
import {MatCheckboxModule} from '@angular/material/checkbox';
import { TaskModule } from '../task/task.module';
import { SharedModule } from '../shared/shared.module';
import { ExpandedCategoryComponent } from './expanded-category/expanded-category.component';
import { CategoryPanelComponent } from './category-panel/category-panel.component';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatButtonToggleModule } from '@angular/material/button-toggle';

@NgModule({
  declarations: [CategoryComponent, CategoryBannerComponent, ExpandedCategoryComponent, CategoryPanelComponent],
  imports: [
    CommonModule,
    TaskModule,
    MatButtonModule,
    MatButtonToggleModule,
    MatExpansionModule,
    MatRippleModule,
    MatCardModule,
    MatCheckboxModule,
    MatIconModule,
    SharedModule
  ],
  exports: [
    CategoryComponent, 
    CategoryPanelComponent, 
    ExpandedCategoryComponent
  ]
})
export class CategoryModule { }
