import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { retry } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { DietPlan } from '../_models/dietPlan';
import { Dish } from '../_models/dish';
import { User } from '../_models/user';

@Injectable({
  providedIn: 'root'
})
export class AdminService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getUsersWithRoles() {
    return this.http.get<Partial<User[]>>(this.baseUrl + 'Admin/admin_moderator_role');
  }

  updateUserRoles(username: string, roles: string[]) {
    return this.http.put(this.baseUrl + 'Admin/edit_roles/' + username + '?roles=' + roles, {});
  }

  getDietPlans() {
    return this.http.get<Partial<DietPlan[]>>(this.baseUrl + 'PlansManagment');
  }

  getDishes() {
    return this.http.get<Partial<Dish[]>>(this.baseUrl + 'Dishes');
  }

  createDietPlan(model: any): Observable<DietPlan> {
    return this.http.post<DietPlan>(this.baseUrl + 'PlansManagment', model);
  }
  
  createDish(model: any): Observable<Dish> {
    return this.http.post<Dish>(this.baseUrl + 'Dishes', model);
  }

}
