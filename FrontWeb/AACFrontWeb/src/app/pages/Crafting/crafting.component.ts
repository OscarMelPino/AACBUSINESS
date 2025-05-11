import { Component } from '@angular/core';
import { AddRecipeeComponent } from "../../components/add-recipee/add-recipee.component";
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-crafting',
  standalone: true,
  imports: [],
  templateUrl: './crafting.component.html',
  styleUrl: './crafting.component.css'
})
export class CraftingComponent {
  constructor(private dialog: MatDialog) {}

  openFormModal(){
    this.dialog.open(AddRecipeeComponent, {
      autoFocus: true,
    });
  }
}
