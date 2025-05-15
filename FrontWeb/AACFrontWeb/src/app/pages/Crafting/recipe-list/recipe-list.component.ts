import { Component } from '@angular/core';
import { RecipeService } from '../../../services/recipe.service';
import { RecipePostModel } from '../../../models/RecipeModel';
import { MaterialModule } from '../../../modules/material/material.module';
import { FormControl, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { ToastService } from '../../../services/toast.service';

@Component({
  selector: 'app-recipe-list',
  standalone: true,
  imports: [MaterialModule, ReactiveFormsModule, CommonModule],
  templateUrl: './recipe-list.component.html',
  styleUrl: './recipe-list.component.css'
})

export class RecipeListComponent {

  constructor(
    private recipeService: RecipeService,
    private toast: ToastService
  ){}
  
  recipeList?: Array<RecipePostModel>
  selectedRecipe? : RecipePostModel
  filterControl = new FormControl('');

  ngOnInit(): void {
    this.recipeService.getRecipes().subscribe(recipes => {
      this.recipeList = recipes
      console.log(this.recipeList)
    })
  }  

  selectRecipe(recipe: any) {
    this.selectedRecipe = recipe
    this.toast.info('You have selected ' + this.selectedRecipe!.name)
  }
}
