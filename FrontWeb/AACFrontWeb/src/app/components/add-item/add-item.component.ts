import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { Items } from '../../models/Item';
import { Recipee } from '../../models/Recipee';
import { MaterialModule } from '../../modules/material/material.module';

@Component({
  selector: 'app-add-item',
  standalone: true,
  imports: [MaterialModule, ReactiveFormsModule, CommonModule],
  templateUrl: './add-item.component.html',
  styleUrl: './add-item.component.css'
})
export class AddItemComponent {
  constructor(private fb: FormBuilder) {
    this.form = this.fb.group({
      name: ['', Validators.required],
      amount: [1, [Validators.required, Validators.min(1)]],
    });
    this.recipee = new Recipee()
    this.recipee.items = []
  }

  form: FormGroup

  recipee: Recipee

  items: Items[] =[ 
    {name: 'charcoal', amount: 0}, 
    {name: 'fabric', amount: 0 }
    // this would be loaded from the back end, those 2 are just a sample
  ]

  addItem(): void {
    if (this.form.valid) {
      this.recipee.items?.push({...this.form.value});
      console.log(this.recipee.items)
      this.form.reset({ quantity: 1 });
    }
  }
}
