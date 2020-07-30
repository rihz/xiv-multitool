import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BannerComponent } from './banner/banner.component';
import { HeaderComponent } from './header/header.component';



@NgModule({
  declarations: [BannerComponent, HeaderComponent],
  imports: [
    CommonModule
  ],
  exports: [
    BannerComponent,
    HeaderComponent
  ]
})
export class SharedModule { }
