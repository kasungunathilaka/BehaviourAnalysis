import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-survey-complete',
  templateUrl: './survey-complete.component.html',
  styleUrls: ['./survey-complete.component.scss']
})
export class SurveyCompleteComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit(): void {

  }

  navigateToSurvey(): void {
    this.router.navigate(['']);
  }
}
