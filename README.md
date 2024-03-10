# FueliciousFit - A Comprehensive Nutrition and Fitness Management System

FueliciousFit is a robust system designed to enhance training, promote healthy eating habits, and manage diet plans for a nutrition and fitness company. This README provides an overview of the system's features, requirements, and use cases.

## Features:
C# and angularts

1. **Customer Management:**
   - Store customer contact information (unique user ID, name, email, optional phone).
   - Track premium customer attributes with start and end dates.

2. **Training Plans:**
   - Assign up to 5 training plans per customer.
   - Each training plan includes a unique ID, description, exercise set, difficulty level (1-3), duration, repetitions, series, and training days per week.

3. **Exercises:**
   - Categorize exercises as without equipment or with equipment (requiring a unique identifier and name for the equipment).
   - Each exercise has a unique ID, description, images (up to 10), optional demonstration video, and targeted muscle groups.

4. **Dietary Plans:**
   - Create dietary plans with a unique ID, name, description, calorie count, and set of meals.
   - Each meal includes a unique ID, description, and calorie count, along with its nutritional composition.

5. **Nutritional Information:**
   - Define nutritional information with a name and description.

6. **Motivators:**
   - Assign one motivator to each customer.
   - Motivators have a name, pseudonym, and a list of motivating phrases.

7. **Knowledge Base:**
   - Maintain a knowledge base on nutrition and training.

8. **Moderator:**
   - Manage training, dietary plans, and recipes.
   - Create, delete, and edit multiple plans and recipes.

9. **User Tasks:**
   - View all training plans, dietary plans, and recipes.
   - Assign or cancel assigned training or dietary plans.

## Use Cases:

- **Guest (Unregistered User):**
  - Can create an account and log in.

- **Registered User (Client):**
  - View all plans and recipes.
  - Track or cancel assigned plans.

- **Moderator:**
  - Create, edit, or delete plans and recipes.

- **Administrator:**
  - Manage user accounts.
  - Block users.
  - Test site errors.
  - Create, edit, or delete plans and recipes.

- **Knowledge Editor:**
  - Edit the knowledge base.

- **Motivator:**
  - Send motivational messages to clients.

- **Scheduled Tasks:**
  - Perform daily database backups.
  - Generate a monthly report on the number of clients assigned to specific training or dietary plans.

## Getting Started:
