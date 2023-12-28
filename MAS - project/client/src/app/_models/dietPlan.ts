import { Dish } from "./dish";
import { DishDietPlan } from "./dishDietPlan";
import { User } from "./user";

export interface DietPlan {
    idDietPlan: number;
    idUser?: number;
    name: string;
    description: string;
    planCalories: number;
    active: boolean;
    dishes: Dish[];
    adminsAndModerator: User;
    user?: User;
  }

