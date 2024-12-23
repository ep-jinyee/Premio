import { Routes } from '@angular/router';
import { JobListComponent } from './job-list/job-list.component';
import { JobApplyComponent } from './job-apply/job-apply.component';
import { JobDescComponent } from './job-desc/job-desc.component';
import { JobCardComponent } from './job-card/job-card.component';

export const jobsearch: Routes = [
    {
        path: '',
        children: [
            {
                path: 'cardview',
                component: JobCardComponent,
                data: {
                    title: "Card View",
                    breadcrumb: "Card View"
                }
            },
            {
                path: 'listview',
                component: JobListComponent,
                data: {
                    title: "List View",
                    breadcrumb: "List View"
                }
            },
            {
                path: 'job-desc/:id',
                component: JobDescComponent,
                data: {
                    title: "Job Details",
                    breadcrumb: "Job Details"
                }
            },
            {
                path: 'job-apply/:id',
                component: JobApplyComponent,
                data: {
                    title: "Apply",
                    breadcrumb: "Apply"
                }
            },
        ]
    }
]