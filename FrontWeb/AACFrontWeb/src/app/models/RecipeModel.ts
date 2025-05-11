import { Items } from "./Item";

export class RecipeFormModel {
    name: string = ''
    isItem: boolean = false
    items?: Items[] 
}

export class RecipePostModel {
    recipeId?: number = 0
    name: string = ''
    isItem: boolean = false
    itemsNeeded?: string = ''
}