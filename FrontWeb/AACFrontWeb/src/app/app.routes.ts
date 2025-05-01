import { Routes } from '@angular/router';
import { LandingComponent } from './pages/Landing/landing.component';
import { EHPCalculatorComponent } from './pages/EHPCalculator/ehpcalculator.component';
import { CraftingComponent } from './pages/Crafting/crafting.component';
import { RegradeSimulatorComponent } from './pages/RegradeSimulator/regradesimulator.component';
import { ErrorComponent } from './pages/Error/error.component';
import { LoginComponent } from './pages/Login/login.component';

export const routes: Routes = [
    { path: '', component: LandingComponent},
    { path: 'login', component: LoginComponent},
    { path: 'crafting', component: CraftingComponent},
    { path: 'regrade', component: RegradeSimulatorComponent},
    { path: 'ehpcalculator', component: EHPCalculatorComponent},
    { path: '**', component: ErrorComponent}
];
