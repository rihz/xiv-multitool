import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { XIVChecklistModule } from 'projects/xiv-checklist/src/app/app.module';
import { XIVLedgerModule } from 'projects/xiv-ledger/src/app/app.module';


const routes: Routes = [
  {
    path: 'xiv-checklist',
    loadChildren: '../../projects/xiv-checklist/src/app/app.module#XIVChecklistModule'
  },
  {
    path: 'xiv-ledger',
    loadChildren: '../../projects/xiv-ledger/src/app/app.module#XIVLedgerModule'
  }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes),
    XIVChecklistModule.forRoot(),
    XIVLedgerModule.forRoot()
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
