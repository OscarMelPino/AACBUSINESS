import { Component } from '@angular/core';
import { BannerComponent } from "../../components/banner/banner.component";
import { DataService } from '../../services/data.service';
import { Subscription } from 'rxjs';
import { Users } from '../../models/Users';
import { Router } from '@angular/router';

@Component({
  selector: 'app-landing',
  standalone: true,
  imports: [BannerComponent],
  templateUrl: './landing.component.html',
  styleUrl: './landing.component.css'
})
export class LandingComponent {
  subscription: Subscription;
  user?: Users;
  
  constructor(
    private dataService: DataService,
    private router: Router
    ) {
    this.subscription = this.dataService.data$.subscribe(data => {
      this.user = data as Users;
    });
  }

  ngOnDestroy() {
    this.subscription.unsubscribe();
  }
}
