import { Routes } from "@angular/router";
import { GoogleComponent } from './google/google.component';
import { ChartjsComponent } from './chartjs/chartjs.component';
import { ChartistComponent } from './chartist/chartist.component';
import { NgxChartComponent } from './ngx-chart/ngx-chart.component';

export const charts: Routes = [
    {
        path: '',
        children: [
          {
            path: 'google',
            component: GoogleComponent,
            data: {
              title: "Google",
              breadcrumb: "Google"
            }
          },
          {
            path: 'chartjs',
            component: ChartjsComponent,
            data: {
              title: "ChartJS",
              breadcrumb: "ChartJS"
            }
          },
          {
            path: 'chartist',
            component: ChartistComponent,
            data: {
              title: "Chartist",
              breadcrumb: "Chartist"
            }
          },
          {
            path: 'ngx-chart',
            component: NgxChartComponent,
            data: {
              title: "Ngx-Chart",
              breadcrumb: "Ngx-Chart"
            }
          }
        ]
      }
]