import { ITask } from '../task.models';

export class CraftingLogTaskModel implements ITask {
    id = 0;
    name = '';
    categoryId = 0;
    taskTypeId = 0;
    level = '';
    craftingLogTypeId = 0;
    craftingLogTypeName = '';
}