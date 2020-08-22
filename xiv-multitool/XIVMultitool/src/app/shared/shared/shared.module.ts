import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CopyClipboardDirective } from '../clipboard.directive';
import { BrowserModule } from '@angular/platform-browser';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';



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
