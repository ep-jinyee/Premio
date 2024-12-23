import { Component, AfterViewChecked, ViewChildren, QueryList } from '@angular/core';
import * as chartData from './../../../shared/data/dashboard/server';
import { SERVERDB, serverDB } from '../../../shared/data/tables/server';

import { Observable } from 'rxjs';
import { FeatherIconsComponent } from '../../../shared/components/feather-icons/feather-icons.component';
import { CommonModule, DecimalPipe } from '@angular/common';
import { NgbdSortableHeader, SortEvent } from '../../../shared/directives/NgbdSortableHeader';
import { TableService } from '../../../shared/services/table.service';
import { BaseChartDirective } from 'ng2-charts';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-server',
  standalone: true,
  imports: [CommonModule,FeatherIconsComponent,BaseChartDirective,NgbModule ,NgbdSortableHeader],
  providers:[TableService,DecimalPipe],
  templateUrl: './server.component.html',
  styleUrls: ['./server.component.scss']
})
export class ServerComponent implements AfterViewChecked {
  public explorer = [];
  public selected = [];

  public tableItem$: Observable<serverDB[]>;
  public searchText:string;
  total$: Observable<number>;

  constructor(public service: TableService) {
    this.tableItem$ = service.tableItem$;
    this.total$ = service.total$;
    this.service.setUserData(SERVERDB)
  }

  
  @ViewChildren(NgbdSortableHeader) headers: QueryList<NgbdSortableHeader>;

  onSort({ column, direction }: SortEvent) {
    // resetting other headers
    this.headers.forEach((header) => {
      if (header.sortable !== column) {
        header.direction = '';
      }
    });

    this.service.sortColumn = column;
    this.service.sortDirection = direction;

  }

  public onSelect(selected:any) {
    this.service.deleteSingleData(selected);
  }


  ngOnInit() {
  }

  

  fetch(cb:any) {
    const req = new XMLHttpRequest();
    req.open('GET', 'assets/data/tables/explorer.json');
    req.onload = () => {
      cb(JSON.parse(req.response));
    };
    req.send();
  }

  public settings = {
    columns: {
      name: {
        title: 'Name'
      },
      user: {
        title: 'User Name',
        type: 'html',
      },
      IO: {
        title: 'IO'
      },
      cpu: {
        title: 'CPU'
      },
      mem: {
        title: 'MEM'
      }
    }
  }; 

  ngAfterViewChecked() {}

  public memoryChartType = chartData.memoryChartType;
  public memoryChartLabels = chartData.memoryChartLabels;
  public memoryChartData = chartData.memoryChartData;
  public memoryChartOptions = chartData.memoryChartOptions;
  public memoryChartColors = chartData.memoryChartColors;
  public memoryChartLegend = chartData.memoryChartLegend;

  public cpuChartType = chartData.cpuChartType;
  public cpuChartLabels = chartData.cpuChartLabels;
  public cpuChartData = chartData.cpuChartData;
  public cpuChartOptions = chartData.cpuChartOptions;
  public cpuChartColors = chartData.cpuChartColors;
  public cpuChartLegend = chartData.cpuChartLegend;
}
