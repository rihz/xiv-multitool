import { ITask } from '../task.models';

export class CollectionTaskModel implements ITask {
    id = 0;
    name = '';
    categoryId = 0;
    taskTypeId = 0;
    method = '';
    collectionTypeId = 0;
    collectionTypeName = '';
}