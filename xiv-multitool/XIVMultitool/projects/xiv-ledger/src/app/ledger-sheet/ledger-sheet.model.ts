export class SheetModel {
    id = 0;
    name = '';
    userId = '';
    startingFunds = 0;
    marketTransactions: MarketTransaction[] = [];
}

export class MarketTransaction {
    id = 0;
    sheetId = 0;
    name = '';
    cost = 0;
    soldFor = 0;
    dateListed: Date = null;
    dateSold: Date = null;
}