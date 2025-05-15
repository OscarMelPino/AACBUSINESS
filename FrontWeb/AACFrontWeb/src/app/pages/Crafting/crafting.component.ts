import { Component } from '@angular/core';
import { AddRecipeeComponent } from "./add-recipee/add-recipee.component";
import { MatDialog } from '@angular/material/dialog';
import { MaterialModule } from '../../modules/material/material.module';
import { RecipeListComponent } from "./recipe-list/recipe-list.component";
import { RecipeEditorComponent } from "./recipe-editor/recipe-editor.component";

@Component({
  selector: 'app-crafting',
  standalone: true,
  imports: [MaterialModule, RecipeListComponent, RecipeEditorComponent],
  templateUrl: './crafting.component.html',
  styleUrl: './crafting.component.css'
})
export class CraftingComponent {
  constructor(private dialog: MatDialog) {}

  layout?: Array<Tile>

  ngOnInit(): void {
    this.createLayout()
  }

  private createLayout(): void {
    this.layout = [{cols: 1, rows: 1},{cols: 3, rows: 1},{cols: 6, rows: 1}]
  }

  openFormModal(){
    this.dialog.open(AddRecipeeComponent, {
      disableClose: true,
      autoFocus: true,
    });
  }
}


export interface Tile {
  cols: number;
  rows: number;
}