import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProfileComponent } from './profile/profile.component';
import { SurveyComponent } from './survey/survey.component';

const routes: Routes = [
  { path: '', component: SurveyComponent },
  { path: 'profile', component: ProfileComponent },
  { path: 'survey', component: SurveyComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AnalysisManagementRoutingModule { }
