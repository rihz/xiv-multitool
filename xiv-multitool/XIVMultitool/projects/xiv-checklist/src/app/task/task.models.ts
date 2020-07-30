export interface ITask {
    id: number;
    name: string;
    categoryId: number;
    taskTypeId: number;
}

export class AchievementReward {
    id = 0;
    achievementId = 0;
    rewardTypeId = 0;
    rewardName = '';
}

export class AchievementTask implements ITask {
    id = 0;
    name = '';
    description = '';
    categoryId = 0;
    taskTypeId = 0;
    points = 0;
    rewards: AchievementReward[] = [];
    achievementTypeId = 0;
    achievementTypeName = '';
}

export class BLUCarnivaleTask implements ITask {
    id = 0;
    name = '';
    categoryId = 0;
    taskTypeId = 0;
    stage = 0;
    standardTime = '';
    idealTime = '';
}

export class BLULogTask implements ITask {
    id = 0;
    name = '';
    categoryId = 0;
    taskTypeId = 0;
    contentId = 0;
    contentName = '';
}

export class BLUSpellLocation {
    id = 0;
    mob = '';
    location = '';
}

export class BLUSpellTask implements ITask {
    id = 0;
    name = '';
    categoryId = 0;
    taskTypeId = 0;
    number = 0;
    locations: BLUSpellLocation[] = [];
}