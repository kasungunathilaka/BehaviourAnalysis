import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProfileComponent } from './profile/profile.component';
import { SurveyComponent } from './survey/survey.component';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { ClarityModule } from '@clr/angular';
import { SharedModule } from '../shared/shared.module';
import { AnalysisManagementRoutingModule } from './analysis-management-routing.module';

@NgModule({
  declarations: [
    ProfileComponent,
    SurveyComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    FormsModule,
    SharedModule,
    ClarityModule,
    AnalysisManagementRoutingModule
  ]
})
export class AnalysisManagementModule { }
