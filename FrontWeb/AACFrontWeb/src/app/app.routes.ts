import { Routes } from '@angular/router';
import { LandingComponent } from './pages/Landing/landing.component';
import { EHPCalculatorComponent } from './pages/EHPCalculator/ehpcalculator.component';
import { CraftingComponent } from './pages/Crafting/crafting.component';
import { RegradeSimulatorComponent } from './pages/RegradeSimulator/regradesimulator.component';
import { ErrorComponent } from './pages/Error/error.component';
import { LoginComponent } from './pages/Login/login.component';
import { authGuard } from './services/auth-guard';

export const routes: Routes = [
    { path: 'crafting', component: CraftingComponent, canActivate: [authGuard]},
    { path: 'regrade', component: RegradeSimulatorComponent, canActivate: [authGuard]},
    { path: 'ehpcalculator', component: EHPCalculatorComponent, canActivate: [authGuard]},
    { path: '', redirectTo: 'landing', pathMatch: 'full'},
    { path: '**', redirectTo: 'login'}
];
