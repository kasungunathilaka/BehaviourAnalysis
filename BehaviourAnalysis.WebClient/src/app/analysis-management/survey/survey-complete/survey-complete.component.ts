import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { DisorderMessages, DisorderTypes } from 'src/app/shared/constants/disorder-types';
import { SurveySharedService } from '../survey.shared.service';

@Component({
  selector: 'app-survey-complete',
  templateUrl: './survey-complete.component.html',
  styleUrls: ['./survey-complete.component.scss']
})
export class SurveyCompleteComponent implements OnInit, OnDestroy {
  disorder: string = null;
  disorderMessages: string = null;

  constructor(
    private router: Router,
    private surveySharedService: SurveySharedService
  ) { }

  ngOnInit(): void {
    this.surveySharedService.disorder.subscribe(disorder => {
      setTimeout(() => {
        this.disorder = disorder;
        this.setDisorderMessage();
      }, 0);
    });
  }

  setDisorderMessage(): void {
    switch (this.disorder) {
      case DisorderTypes.ANXIETY:
        this.disorderMessages = DisorderMessages.ANXIETY_MESSAGE;
        break;
      case DisorderTypes.DEPRESSION:
        this.disorderMessages = DisorderMessages.DEPRESSION_MESSAGE;
        break;
      case DisorderTypes.LONELINESS:
        this.disorderMessages = DisorderMessages.LONELINESS_MESSAGE;
        break;
      case DisorderTypes.NORMAL:
        this.disorderMessages = DisorderMessages.NORMAL_MESSAGE;
        break;
      case DisorderTypes.STRESS:
        this.disorderMessages = DisorderMessages.STRESS_MESSAGE;
        break;
      default:
        this.disorderMessages = null;
        break;
    }
  }

  ngOnDestroy(): void {
    this.surveySharedService.setDisorder(null);
    this.disorderMessages = null;
  }

  navigateToSurvey(): void {
    this.router.navigate(['']);
  }
}
