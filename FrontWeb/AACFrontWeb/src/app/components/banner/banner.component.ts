import { Component, Input } from '@angular/core';
import { MaterialModule } from '../../modules/material/material.module';
import { NavigationComponent } from "../navigation/navigation.component";
import { RouterLink, RouterOutlet } from '@angular/router';
import { UserAAC } from '../../models/UserAAC';
import { LoginComponent } from '../../pages/Login/login.component';
import { config } from '../../../environment';


@Component({
  selector: 'app-banner',
  standalone: true,
  imports: [
    MaterialModule,
    NavigationComponent,
    RouterOutlet,
    RouterLink,
    LoginComponent
],
  templateUrl: './banner.component.html',
  styleUrl: './banner.component.css'
})
export class BannerComponent {
  
  showFiller: boolean = false;

  @Input()
  user?:UserAAC

  isDebug = config.isDebug

}
