import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TaskComponent } from './task.component';
import { AchievementTaskComponent } from './achievement-task/achievement-task.component';
import { MatExpansionModule } from '@angular/material/expansion';
import { MatRippleModule } from '@angular/material/core';
import { MatCardModule } from '@angular/material/card';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { SharedModule } from '../shared/shared.module';
import { MatBadgeModule } from '@angular/material/badge';
import { MatChipsModule } from '@angular/material/chips';
import { BluCarnivaleTaskComponent } from './blu-carnivale-task/blu-carnivale-task.component';
import { BluLogTaskComponent } from './blu-log-task/blu-log-task.component';
import { BluSpellTaskComponent } from './blu-spell-task/blu-spell-task.component';
import { MatButtonModule } from '@angular/material/button';
import { MatButtonToggleModule } from '@angular/material/button-toggle';
import { MatIconModule } from '@angular/material/icon';
import { CollectionTaskComponent } from './collection-task/collection-task.component';
import { CraftingLogTaskComponent } from './crafting-log-task/crafting-log-task.component';
import { FateTaskComponent } from './fate-task/fate-task.component';
import { FishGuideTaskComponent } from './fish-guide-task/fish-guide-task.component';
import { GatheringLogTaskComponent } from './gathering-log-task/gathering-log-task.component';

@NgModule({
  declarations: [TaskComponent, AchievementTaskComponent, BluCarnivaleTaskComponent, BluLogTaskComponent, BluSpellTaskComponent, CollectionTaskComponent, CraftingLogTaskComponent, FateTaskComponent, FishGuideTaskComponent, GatheringLogTaskComponent],
  imports: [
    CommonModule,
    MatButtonModule,
    MatButtonToggleModule,
    MatExpansionModule,
    MatRippleModule,
    MatCardModule,
    MatCheckboxModule,
    MatBadgeModule,
    MatChipsModule,
    MatIconModule,
    SharedModule
  ],
  exports: [
    TaskComponent
  ]
})
export class TaskModule { }
