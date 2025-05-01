import { Component } from '@angular/core';
import { MaterialModule } from '../../modules/material/material.module';
import { Router } from '@angular/router';
import { NavigationModel } from '../../models/NavigationModel';

@Component({
  selector: 'app-navigation',
  standalone: true,
  imports: [MaterialModule],
  templateUrl: './navigation.component.html',
  styleUrl: './navigation.component.css'
})
export class NavigationComponent {

  constructor(private readonly router: Router){}

  readonly areas: NavigationModel[] = [
    {route: 'crafting', textTemplate: 'Crafting'}, 
    {route: 'ehpcalculator', textTemplate: 'EHP Calculator'}, 
    {route: 'regrade', textTemplate: 'Regrade Simulator'}   
  ]


  redirectTo(route: string){
    this.router.navigate([route])
  }

}
