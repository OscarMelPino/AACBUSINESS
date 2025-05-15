import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { LandingComponent } from "./pages/Landing/landing.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [HttpClientModule, LandingComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'AAC Tools';
}
