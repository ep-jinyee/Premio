import { Component, OnInit } from '@angular/core';
import { FeatherIconsComponent } from '../../shared/components/feather-icons/feather-icons.component';
import { CommonModule } from '@angular/common';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-faq',
  standalone: true,
  imports: [CommonModule, FeatherIconsComponent, NgbModule],
  templateUrl: './faq.component.html',
  styleUrls: ['./faq.component.scss']
})
export class FaqComponent implements OnInit {
  public isCollapsed1 = true;
  public isCollapsed2 = true;
  public isCollapsed3 = true;
  public isCollapsed4 = true;
  public isCollapsed5 = true;
  public isCollapsed6 = true;
  public isCollapsed7 = true;
  public isCollapsed8 = true;
  public isCollapsed9 = true;
  public isCollapsed10 = true;
  public isCollapsed11 = true;
  public isCollapsed12 = true;
  public isCollapsed13 = true;
  public isCollapsed14 = true;
  public isCollapsed15 = true;
  public isCollapsed16 = true;

  constructor() { }

  ngOnInit() { }

}
