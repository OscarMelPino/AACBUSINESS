import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { Items } from '../../models/Item';
import { Recipee } from '../../models/Recipee';
import { MaterialModule } from '../../modules/material/material.module';
import { ItemsService } from '../../services/items.service';
import { RecipeeService } from '../../services/recipee.service';
import { ToastService } from '../../services/toast.service';
import { catchError, of } from 'rxjs';

@Component({
  selector: 'app-add-recipee',
  standalone: true,
  imports: [MaterialModule, ReactiveFormsModule, CommonModule],
  templateUrl: './add-recipee.component.html',
  styleUrl: './add-recipee.component.css'
})
export class AddRecipeeComponent {
  constructor(
    private fb: FormBuilder,
    private itemService: ItemsService,
    private recipeeService: RecipeeService,
    private toastService: ToastService
    ) {
    this.form = this.fb.group({
      recipeeName: ['', Validators.required],
      itemName: ['', Validators.required],
      itemAmount: [0, [Validators.required, Validators.min(1)]],
    });
    this.recipee = new Recipee()
    this.recipee.items = []
  }

  recipee?: Recipee
  form: FormGroup

  items: Items[] = []

  ngOnInit() {
    this.loadItems()
  }

  private loadItems(): void {
    this.itemService.getItems().pipe(
      catchError(error => {
        this.toastService.error('There was an error trying to retrieve the item list.');
    
        return of([]); 
      })
    ).subscribe(items => {
      this.items = items
    });
  }

  addItem(): void {
    if (this.form.valid) {
      const { itemId, itemName, itemAmount } = this.form.value
      this.recipee!.name = this.form.value.recipeeName
      this.recipee!.items?.push({itemId, itemName, itemAmount});
    }
  }
}
