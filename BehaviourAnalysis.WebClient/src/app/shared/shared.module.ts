import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ClarityModule } from '@clr/angular';
import { SideNavigationComponent } from './components/side-navigation/side-navigation.component';
import { LoaderComponent } from './components/loader/loader.component';

@NgModule({
  declarations: [
    SideNavigationComponent,
    LoaderComponent
  ],
  imports: [
    CommonModule,
    ClarityModule,
    RouterModule
  ],
  exports: [
    SideNavigationComponent,
    LoaderComponent
  ]
})
export class SharedModule { }
