import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { HomeComponent } from './home.component';
import { CategoryModule } from '../category/category.module';
import { ApiService } from '../shared/services/api.service';
import { SharedModule } from '../shared/shared.module';
import { TaskModule } from '../task/task.module';
import { ScrollingModule } from '@angular/cdk/scrolling';

@NgModule({
  declarations: [HomeComponent],
  imports: [
    CommonModule,
    CategoryModule,
    MatIconModule,
    MatButtonModule,
    SharedModule,
    TaskModule,
    ScrollingModule
  ],
  providers: [ApiService]
})
export class HomeModule { }
