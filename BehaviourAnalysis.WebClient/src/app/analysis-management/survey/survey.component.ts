import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Question } from 'src/app/shared/models/question.model';
import { Questionnaire } from 'src/app/shared/models/questionnaire.model';
import { QuestionService } from 'src/app/shared/services/question.service';

@Component({
  selector: 'app-survey',
  templateUrl: './survey.component.html',
  styleUrls: ['./survey.component.scss']
})
export class SurveyComponent implements OnInit {
  surveyForm: FormGroup;
  progressValue = 0;
  questionsList: string[] = [];
  surveyOption: boolean;
  questions: Question[] = [];
  isCompleted = false;
  questionnaire: Questionnaire;

  constructor(
    private formBuilder: FormBuilder,
    private questionService: QuestionService
  ) { }

  ngOnInit(): void {
    this.questionnaire = new Questionnaire();
    this.createForm();
    this.getQuestions();
  }

  createForm(): void {
    this.surveyForm = this.formBuilder.group({
      options: [, [Validators.required]],
    });
  }

  getQuestions(): void {
    this.questionService.getQuestions().then((response) => {
      this.questions = response;
      this.questionsList = response.map(q => q.questionBody);
    }).catch((error) => {
      if (error) {
        console.log('error :', error);
      }
    });
  }

  isLastQuestion(): boolean {
    return this.progressValue >= 23;
  }

  onRadioClick(): void {

  }

  onPrevious(): void {
    if (this.progressValue > 0) {
      this.progressValue--;
    }
  }

  onNext(): void {
    if (this.progressValue < 23) {
      this.progressValue++;
    }
    this.questions[this.progressValue - 1].answer = this.surveyOption;
    this.surveyForm.reset();
  }

  onCompleteSurvey(): void {
    if (this.progressValue === 23) {
      this.progressValue++;
    }
    this.questions[this.progressValue - 1].answer = this.surveyOption;
    this.isCompleted = true;
  }
}
