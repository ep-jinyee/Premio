import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router, RouterModule } from "@angular/router";
import { NgbModule, NgbRatingConfig } from '@ng-bootstrap/ng-bootstrap';
import { Products } from "../../../shared/model/e-commerce/product.model";
import { ProductsService } from "../../../shared/services/e-commerce/products.service";
import { CartService } from '../../../shared/services/e-commerce/cart.service';
import { ContentDetail } from '../../../shared/model/e-commerce/content';
import { Image } from '@ks89/angular-modal-gallery';
import { GalleryModule } from '@ks89/angular-modal-gallery';
import { CommonModule } from '@angular/common';


export interface Contents {
  type: any;
  content_1: any;
  content_2: any;
}
@Component({
  selector: 'app-product-detail',
  standalone: true,
  imports: [CommonModule,NgbModule,GalleryModule,RouterModule],
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.scss'],
  providers: [NgbRatingConfig]
})


export class ProductDetailComponent implements OnInit {
  public product: Products = {};
  public products: Products[] = [];
  public detailCnt = [];
  public slidesPerPage = 4;
  public syncedSecondary = true;
  public allContent :any = [];
  public contents:any = [];
  public active: boolean = false;
  public type: string = "Febric"
  public nav: any;
  imagesRect: Image[] = [
    new Image(0, { img: 'assets/images/ecommerce/01.jpg' }, { img: 'assets/images/ecommerce/01.jpg' }),
    new Image(1, { img: 'assets/images/ecommerce/04.jpg' }, { img: 'assets/images/ecommerce/04.jpg' }),
    new Image(2, { img: 'assets/images/ecommerce/03.jpg' }, { img: 'assets/images/ecommerce/03.jpg' }),
    new Image(3, { img: 'assets/images/ecommerce/02.jpg' }, { img: 'assets/images/ecommerce/02.jpg' })]

  constructor(private router: Router, private route: ActivatedRoute, config: NgbRatingConfig, public productService: ProductsService, private cartService: CartService) {
    this.allContent = ContentDetail.ContentDetails;
    //for rating 
    this.allContent.filter((opt:any) => {
      if (this.type == opt.type) {
        this.contents.push(opt);
      }
    });

    config.max = 5;
    config.readonly = false;

    this.route.params.subscribe(params => {
      const id = +params['id'];
      this.productService.getProduct(id).subscribe((product) => {
        this.product = product;
      });
    });

  }
  getOption(type:any) {
    this.contents = [];
    return this.allContent.filter((data:any) => {
      if (type == data.type) {
        this.active = true;
        return this.contents.push(data)
      } else {
        return false
      }
    })
  }

  public buyNow(product: Products, quantity: number = 1) {
    if (quantity > 0)
      this.cartService.addToCart(product, quantity);
    this.router.navigate(['/ecommerce/check-out']);
  }

  public addToCart(product: Products, quantity: number = 1) {
    if (quantity == 0){
      return false;
    } 
    return  this.cartService.addToCart(product, quantity);
  }

  ngOnInit() {
    this.productService.getProducts().subscribe((product) => {
      this.products = product;
      product.filter(ele => {
        this.nav = ele.img
      })
    });
  }

}
