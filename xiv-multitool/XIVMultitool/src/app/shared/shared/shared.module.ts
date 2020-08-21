import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CopyClipboardDirective } from '../clipboard.directive';
import { BrowserModule } from '@angular/platform-browser';



@NgModule({
  declarations: [
    CopyClipboardDirective
  ],
  imports: [
    CommonModule
  ],
  exports: [
    CopyClipboardDirective
  ]
})
export class SharedModule { }
