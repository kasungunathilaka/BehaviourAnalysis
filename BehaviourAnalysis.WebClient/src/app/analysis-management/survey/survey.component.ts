import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-survey',
  templateUrl: './survey.component.html',
  styleUrls: ['./survey.component.scss']
})
export class SurveyComponent implements OnInit {
  surveyForm: FormGroup;
  progressValue = 0;
  questionsList = [
    'Are you feeling nervous all the time',
    'Are you having sudden panic attacks',
    'Are you breathing rapidly',
    'Are you sweating excessively',
    'Are you having troubles in concentration',
    'Are you having troubles in sleeping',
    'Are you having troubles with work',
    'Are you feeling hopeless',
    'Are you feeling angry',
    'Do you feel like over reacting',
    'Are you feeling any changes in eating habits',
    'Are you having any suicidal thoughts',
    'Are you feeling tired all the time',
    'Do you have a close friend that you can share your feelings',
    'Are you addicted to the social media platforms (Facebook, Instagram, Twitter etc.)',
    'Do you feel like rapid weight gain',
    'Do you feel like wanting material possession',
    'Are you feeling shy',
    'Are you experiencing any emotional flashbacks of stressful memories',
    'Are you having nightmares',
    'Do you feel like avoiding people or activities',
    'Are you feeling negative',
    'Are you having troubles in focusing',
    'Are you blaming yourself'
  ];
  surveyOption: boolean;

  constructor(
    private formBuilder: FormBuilder
  ) { }

  ngOnInit(): void {
    this.createForm();
  }

  createForm() {
    this.surveyForm = this.formBuilder.group({
      options: ['', [Validators.required]],
    });
  }

  isLastQuestion() {
    return this.progressValue >= 23;
  }

  onRadioClick() {

  }

  onPrevious() {
    if (this.progressValue > 0) {
      this.progressValue--;
    }
  }

  onNext() {
    if (this.progressValue < 23) {
      this.progressValue++;
    }
    this.surveyForm.reset();
  }

  onCompleteSurvey() {
    if (this.progressValue === 23) {
      this.progressValue++;
    }
  }
}
