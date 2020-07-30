import { Component, OnInit, Input } from '@angular/core';
import { CollectionTaskModel } from './collection-task.model';

@Component({
  selector: 'collection-task',
  templateUrl: './collection-task.component.html',
  styleUrls: ['./collection-task.component.scss']
})
export class CollectionTaskComponent implements OnInit {
  @Input() task: CollectionTaskModel;

  constructor() { }

  ngOnInit(): void {
    console.log(this.task);
  }

}
