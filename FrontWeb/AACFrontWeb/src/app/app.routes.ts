import { Routes } from '@angular/router';
import { LoginComponent } from './pages/login/login.component';
import { LandingComponent } from './pages/landing/landing/landing.component';
import { EHPCalculatorComponent } from './pages/EHPCalculator/ehpcalculator/ehpcalculator.component';
import { CraftingComponent } from './pages/Crafting/crafting/crafting.component';
import { RegradeSimulatorComponent } from './pages/RegradeSimulator/regradesimulator/regradesimulator.component';

export const routes: Routes = [
    { path: '', component: LandingComponent},
    { path: 'ehpcalculator', component: EHPCalculatorComponent},
    { path: 'crafting', component: CraftingComponent},
    { path: 'regrade', component: RegradeSimulatorComponent},
    { path: 'login', component: LoginComponent},
    { path: '**', component: LoginComponent},
];
