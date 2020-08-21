export class AppPanel {
    path = '';
    logo = '';
}

export class Character {
    id = 0;
    characterId = '';
    userId = '';
    name = '';
    icon = '';
    server = '';
}

export class Retainer {
    id = 0;
    userId = '';
    name = '';
    labels: RetainerLabel[] = [];
}

export class RetainerLabel {
    id = 0;
    retainerId = 0;
    name = '';
    colorHex = '';
}