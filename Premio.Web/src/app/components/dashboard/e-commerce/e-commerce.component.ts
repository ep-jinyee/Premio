import { CommonModule } from '@angular/common';
import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { NgApexchartsModule } from 'ng-apexcharts';
import { BaseChartDirective } from 'ng2-charts';
import { CarouselModule } from 'ngx-owl-carousel-o';
import { FeatherIconsComponent } from '../../../shared/components/feather-icons/feather-icons.component';
import * as data from './../../../shared/data/dashboard/e-commerce';

@Component({
  selector: 'app-e-commerce',
  standalone: true,
  imports: [CommonModule, FeatherIconsComponent, NgbModule, BaseChartDirective,CarouselModule,NgApexchartsModule],
  templateUrl: './e-commerce.component.html',
  styleUrls: ['./e-commerce.component.scss'],
  encapsulation: ViewEncapsulation.None
})

export class ECommerceComponent implements OnInit {

  ngOnInit() {

  }

  public slidesStore = [{
    id: 1,
    icon: 'dollar-sign',
    title: 'Total Earning',
    number: 72
  },
  {
    id: 2,
    icon: 'map-pin',
    title: 'Total Web Visitor',
    number: 65
  },
  {
    id: 3,
    icon: 'shopping-cart',
    title: 'Total Sale Product',
    number: 96
  },
  {
    id: 4,
    icon: 'trending-down',
    title: 'Company Loss',
    number: 89
  },
  {
    id: 5,
    icon: 'dollar-sign',
    title: 'Total Earning',
    number: 72
  }]

  public customOptions: any = {
    margin: 10,
    autoplay: true,
    autoplayTimeout: 3000,
    autoplayHoverPause: true,
    loop: true,
    dots: false,
    nav: false,
    responsiveClass: true,
    responsive: {
      0: {
        items: 1,
        nav: false
      },
      420: {
        items: 2,
        nav: false
      },
      600: {
        items: 3,
        nav: false
      },
      932: {
        items: 4,
        nav: false
      }
    }
  }

  // Charts1
  public saleChartType = data.saleChartType;
  public saleChartLable = data.saleChartLabels;
  public saleChartData = data.saleChartData;
  public saleChartOption = data.saleChartOptions;
  public saleChartLegend = data.saleChartLegend;

  // Charts1
  public chartType1 = data.lineChartType1;
  public chartLable1 = data.lineChartLabels1;
  public chartData1: any = data.lineChartData1;
  public chartOption1: any = data.lineChartOptions1;
  // public chartColor1 = data.lineChartColors1;
  public chartLegend1 = data.lineChartLegend1;

  // Chart2
  public chartType2: any = data.lineChartType2;
  public chartLable2 = data.lineChartLabels2;
  public chartData2 = data.lineChartData2;
  public chartOption2 = data.lineChartOptions2;
  public chartColor2 = data.lineChartColors2;
  public chartLegend2 = data.lineChartLegend2;

  //Static chart
  public staticChartType = data.staticChartType;
  public staticChartLable = data.staticChartLabels;
  public staticChartData = data.staticChartData;
  public staticChartOption = data.staticChartOptions;
  public staticChartColor = data.staticChartColors;
  public staticChartLegend = data.staticChartLegend;

  public chartClicked({ event: any, active }: { event: MouseEvent, active: {}[] }): void {
  }

  public chartHovered({ event, active }: { event: MouseEvent, active: {}[] }): void {
  }

  public TotalReview: any = {
    series: [35],
    chart: {
      height: 320,
      type: "radialBar",
    },
    plotOptions: {
      radialBar: {
        hollow: {
          size: "80%",
        },
      },
    },
    colors: ['#4466F2'],
    labels: ["REVIEW"],
  };

  Totalreview: any = {
    series: [85],
    chart: {
      height: 300,
      type: "radialBar",
    },
    plotOptions: {
      radialBar: {
        hollow: {
          size: "80%",
        },
        track: {
          background: "#4466F2",
        },
      },
    },
    stroke: {
      lineCap: "round",
    },
    fill: {
      colors: ["#fff"],
    },
    dataLabels: {
      name: {
        show: true,
        color: "#fff",
        offsetY: -10,
      },
    },

    labels: ["REVIEW"],
  };

}
