import { Injectable } from '@angular/core';
import { config } from '../../environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { RecipePostModel, RecipeFormModel } from '../models/RecipeModel';

@Injectable({
  providedIn: 'root'
})
export class RecipeService {

  constructor(
    private http: HttpClient
  ) { }

  private readonly apiurl = config.url + config.endpoints.recipe

  public postNewRecipe(recipe: RecipeFormModel) : Observable<RecipeFormModel> {
    const recipePost: RecipePostModel = new RecipePostModel()
    recipePost.isItem = recipe.isItem
    recipePost.name = recipe.name
    recipePost.itemsNeeded = JSON.stringify(recipe.items)
    return this.http.post<RecipeFormModel>(this.apiurl, recipePost)
  }
}
