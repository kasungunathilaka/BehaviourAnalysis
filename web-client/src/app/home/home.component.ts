import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  title: string;

  constructor(private router: Router) { }

  ngOnInit(): void {
    this.title = 'Behavior Analysis';
  }

  navigateToWelcome(): void {
    this.router.navigate(['']);
  }
}
