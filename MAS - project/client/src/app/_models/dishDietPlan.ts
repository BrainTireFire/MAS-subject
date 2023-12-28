import { DietPlan } from "./dietPlan";
import { Dish } from "./dish";

export interface DishDietPlan {
  idDishDietPlan: number;
  idDietPlan: number;
  idDish: number;
  dish: Dish;
  dietPlan: DietPlan;
}