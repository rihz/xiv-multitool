import { ITask } from '../task.models';

export class GatheringLogTaskModel implements ITask {
    id = 0;
    name = '';
    categoryId = 0;
    taskTypeId = 0;
    gatherTypeId = 0;
    gatherTypeName = '';
    level = '';
    location = '';
}