import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Practica 8 Angular';
  currentYear: number = new Date().getFullYear();
  constructor(private router: Router) { }

  goToShippers() {
    this.router.navigateByUrl('shippers');
  }
  goToHome() {

    this.router.navigateByUrl('');
  }
}
