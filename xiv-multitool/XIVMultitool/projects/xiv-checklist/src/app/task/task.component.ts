import { Component, OnInit, Input } from '@angular/core';
import { ITask } from './task.models';
import { TaskTypes } from '../shared/shared.models';

@Component({
  selector: 'app-task',
  templateUrl: './task.component.html',
  styleUrls: ['./task.component.scss']
})
export class TaskComponent implements OnInit {
  @Input() position: number = 1;
  @Input() task: ITask;
  taskTypes: TaskTypes = new TaskTypes();
  
  constructor() { }

  ngOnInit() {
    console.log(this.task.taskTypeId);
  }  

  isCollectionTask(): boolean {
    return this.task.taskTypeId === this.taskTypes.collection;
  }

}
