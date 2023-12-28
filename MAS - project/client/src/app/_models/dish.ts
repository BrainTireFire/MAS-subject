import { DishDietPlan } from "./dishDietPlan";

export interface Dish {
    idDish: number;
    name: string;
    description: string;
    amountOfCaloriesInTheDish: number;
    dishDietPlans: DishDietPlan[];
    //compositionOfNutritionalValue: CompositionOfNutritionalValue;
}