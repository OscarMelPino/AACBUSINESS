import { Component } from '@angular/core';
import { MaterialModule } from '../../modules/material/material.module';
import { NavigationComponent } from "../navigation/navigation.component";
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-banner',
  standalone: true,
  imports: [
    MaterialModule,
    NavigationComponent,
    RouterOutlet
],
  templateUrl: './banner.component.html',
  styleUrl: './banner.component.css'
})
export class BannerComponent {
  
  showFiller: boolean = false;

}
