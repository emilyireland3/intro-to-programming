import { Routes } from '@angular/router';
import { Home } from './components/pages/home';
import { Support } from './components/pages/support';

export const routes: Routes = [
  {
    path: '',
    component: Home,
  },
  {
    path: 'support',
    component: Support,
  },
  {
    path: 'demos',
    loadChildren: () =>
      import('../demos/demos.routes').then((r) => r.DEMOS_ROUTES),
  },
];
