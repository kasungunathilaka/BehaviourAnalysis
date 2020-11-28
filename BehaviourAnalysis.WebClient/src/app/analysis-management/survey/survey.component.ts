import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Question } from 'src/app/shared/models/question.model';
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

  constructor(
    private formBuilder: FormBuilder,
    private questionService: QuestionService
  ) { }

  ngOnInit(): void {
    this.createForm();
    this.getQuestions();
  }

  createForm() {
    this.surveyForm = this.formBuilder.group({
      options: ['', [Validators.required]],
    });
  }

  getQuestions() {
    this.questionService.getQuestions().then((response) => {
      this.questions = response;
      this.questionsList = response.map(q => q.questionBody);
      console.log('this.questionsList :', this.questionsList);
    }).catch((error) => {
      if (error) {
        console.log('error :', error);
      }
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
    this.isCompleted = true;
  }
}
