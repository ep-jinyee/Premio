import { Routes } from '@angular/router';
import { ContentLayoutComponent } from './shared/components/layout/content-layout/content-layout.component';
import { content } from './shared/routes/content-routes';
import { FullLayoutComponent } from './shared/components/layout/full-layout/full-layout.component';
import { fullRoutes } from './shared/routes/full.routes';
import { AdminGuard } from './shared/guard/admin.guard';
import { LoginComponent } from './auth/login/login.component';
import { RegisterComponent } from './pages/authentication/register/register.component';
import { authGuard } from './auth/auth.guard';

export const routes: Routes = [
    {
        path: "",
        redirectTo: "/auth",
        pathMatch: "full",
    },
    {
        path: "auth",
        loadChildren: () => import('./auth/auth.module').then(m => m.AuthModule)
    },
    {
        path: "admin",
        canActivate: [authGuard],
        loadChildren: () => import('./admin/admin-routing.module').then(m => m.AdminRoutingModule)
    },
    {
        path: "mng",
        loadChildren: () => import('./mng/mng-routing.module').then(m => m.MngRoutingModule)
    },
    {
        path: "user",
        loadChildren: () => import('./user/user-routing.module').then(m => m.UserRoutingModule)
    }
    // {
    //     path: '',
    //     component: ContentLayoutComponent,
    //     canActivate: [AdminGuard],
    //     children: content,
    // },
    // {
    //     path: '',
    //     component: FullLayoutComponent,
    //     canActivate: [AdminGuard],
    //     children: fullRoutes,
    // },
];
