import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule, FormsModule, FormControl } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { Items } from '../../models/Item';
import { RecipeFormModel } from '../../models/RecipeModel';
import { MaterialModule } from '../../modules/material/material.module';
import { ItemsService } from '../../services/items.service';
import { RecipeService } from '../../services/recipe.service';
import { ToastService } from '../../services/toast.service';
import { catchError, of } from 'rxjs';

@Component({
  selector: 'app-add-recipee',
  standalone: true,
  imports: [MaterialModule, ReactiveFormsModule, CommonModule, FormsModule, ReactiveFormsModule],
  templateUrl: './add-recipee.component.html',
  styleUrl: './add-recipee.component.css'
})
export class AddRecipeeComponent {
  constructor(
    private fb: FormBuilder,
    private itemService: ItemsService,
    private recipeService: RecipeService,
    private toastService: ToastService
    ) {


    this.itemForm  = this.fb.group({
      itemId: ['', Validators.required],
      itemAmount: [0, [Validators.required, Validators.min(1)]],
    });
    this.recipeForm = this.fb.group({
      recipeeName: ['', Validators.required],
      isItem: [false] 
    });

    this.recipe = new RecipeFormModel()
    this.recipe.items = []
  }
  filterControl = new FormControl('');
  recipe?: RecipeFormModel
  itemForm : FormGroup
  recipeForm  : FormGroup

  items: Items[] = []
  filteredItems = [...this.items];
  filterValue = '';

  ngOnInit() {
    this.loadItems()

    this.filterControl.valueChanges.subscribe(value => {
      const filter = value?.toLowerCase() ?? '';
      this.filteredItems = this.items.filter(item =>
        item.name.toLowerCase().includes(filter)
      );
    });
  }

  private loadItems(): void {
    this.itemService.getItems().pipe(
      catchError(error => {
        // this.toastService.error('There was an error trying to retrieve the item list.');
    
        return of([]); 
      })
    ).subscribe(items => {
      this.items = items
      this.filteredItems = items;
    });

  }

  addItem(): void {
    if (this.itemForm.valid) {
      const { itemId, itemAmount } = this.itemForm.value
      this.recipe!.name = this.itemForm.value.recipeeName
      const item = this.items.find(item => item.itemId === itemId)
      item!.itemAmount = itemAmount
      this.recipe!.items?.push(item!);
      this.filteredItems = this.filteredItems.filter(x => x.name != item!.name)
      this.items = this.items.filter(x => x.name != item!.name)
      this.itemForm.reset()
    }
  }
  addRecipe() : void {
    const { isItem, recipeeName } = this.recipeForm.value
    this.recipe!.isItem = isItem ?? false
    this.recipe!.name = recipeeName
    this.recipeService.postNewRecipe(this.recipe!).subscribe(response => {
      if (response){
        this.toastService.success('Recipe addded successfully')
        this.itemForm.reset()
        this.recipeForm.reset()
      }
    })
  }
}
