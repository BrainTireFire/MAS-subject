import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { DietPlan } from 'src/app/_models/dietPlan';
import { Dish } from 'src/app/_models/dish';
import { Router } from '@angular/router';
import { AdminService } from 'src/app/_services/admin.service';

@Component({
  selector: 'app-dietplans-management',
  templateUrl: './dietplans-management.component.html',
  styleUrls: ['./dietplans-management.component.css']
})
export class DietPlansManagementComponent implements OnInit {
  dietPlans: Partial<DietPlan[]>;
  dishes: Partial<Dish[]>;
  bsModalRef: BsModalRef;
  newDietPlan: DietPlan = {} as DietPlan;
  newDishes: Dish[] = {} as Dish[];
  newDish: Dish = {} as Dish;
  selectedDishIds: number[] = [];

  constructor(private adminService: AdminService, private router: Router, private modalService: BsModalService) { }

  ngOnInit(): void {
    this.getDietPlans();
    this.getDishes();
  }

  getDietPlans() {
    this.adminService.getDietPlans().subscribe(dietPlans => {
      this.dietPlans = dietPlans;
    })
  }

  getDishes() {
    this.adminService.getDishes().subscribe(dishes => {
      this.dishes = dishes;
    })
  }

  openAddDietPlanModal(template: TemplateRef<any>) {
    this.newDietPlan = {} as DietPlan;
    this.bsModalRef = this.modalService.show(template);
  }

  openAddDishesModal(template: TemplateRef<any>) {
    this.newDishes = {} as Dish[];
    this.bsModalRef = this.modalService.show(template);
  }

  openAddNewDish(template: TemplateRef<any>) {
    this.bsModalRef.hide();
    this.newDish = {} as Dish;
    this.bsModalRef = this.modalService.show(template);
  }

  addDietPlan(addDishesModal) {
    this.bsModalRef.hide();
    this.openAddDishesModal(addDishesModal);
  }

  addNewDishes(addDishesModal) {
    this.bsModalRef.hide();
    this.createDish();
    this.openAddDishesModal(addDishesModal);
  }

  addDishesToPlan() {
    const selectedDishes = this.dishes.filter(dish => this.selectedDishIds.includes(dish.idDish));
    this.newDishes = selectedDishes;
    this.bsModalRef.hide();
    this.createPlan();
  }

  refreshDietPlansAndDishes() {
    this.getDietPlans();
    this.getDishes();
  }

  cancelDishAdd(addDietPlanModal) {
    this.bsModalRef.hide();
    this.openAddDietPlanModal(addDietPlanModal);
  }
  
  createDish() {
    this.adminService.createDish(this.newDish).subscribe(
      (dish: Dish) => {
        this.refreshDietPlansAndDishes();
        this.router.navigateByUrl('/admin');
      },
      (error) => {
        console.log(error);
      }
    );
  }

  createPlan() {
    const dishDietPlans = this.selectedDishIds.map(id => ({ IdDish: id }));

    const mergedData = {
      Name: this.newDietPlan.name,
      Description: this.newDietPlan.description,
      PlanCalories: this.newDietPlan.planCalories,
      Active: this.newDietPlan.active,
      DishDietPlans: dishDietPlans
    };

    console.log(mergedData);
    
    this.adminService.createDietPlan(mergedData).subscribe(
      (dietPlan: DietPlan) => {
        this.refreshDietPlansAndDishes();
        this.router.navigateByUrl('/admin');
      },
      (error) => {
        console.log(error);
      }
    );
  }

  editPlan(idDietPlan) {

  }

  removePlan(idDietPlan) {

  }
}
