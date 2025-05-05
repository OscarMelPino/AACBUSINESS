import { Component } from '@angular/core';
import { AddItemComponent } from "../../components/add-item/add-item.component";

@Component({
  selector: 'app-crafting',
  standalone: true,
  imports: [AddItemComponent],
  templateUrl: './crafting.component.html',
  styleUrl: './crafting.component.css'
})
export class CraftingComponent {

}
