import { Component } from '@angular/core';
import { AddRecipeeComponent } from "../../components/add-recipee/add-recipee.component";

@Component({
  selector: 'app-crafting',
  standalone: true,
  imports: [AddRecipeeComponent],
  templateUrl: './crafting.component.html',
  styleUrl: './crafting.component.css'
})
export class CraftingComponent {

}
