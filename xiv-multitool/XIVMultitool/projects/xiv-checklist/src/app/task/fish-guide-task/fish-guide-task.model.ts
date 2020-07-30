import { ITask } from '../task.models';

export class FishGuideTaskModel implements ITask {
    id = 0;
    name = '';
    categoryId = 0;
    taskTypeId = 0;
    ilevel = 0;
    zoneId = 0;
    zoneName = '';
    bait = '';
}