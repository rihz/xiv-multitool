import { ITask } from '../task/task.models';

export class Category {
    id = 0;
    name = '';
    parentCategoryId = 0;
    categories: Category[] = [];
    tasks: ITask[] = [];
    position = 0;
}