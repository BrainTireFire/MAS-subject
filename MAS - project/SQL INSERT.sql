
INSERT INTO DietPlan (IdDietPlan, IdUser, Name, Description, PlanCalories, Active)
VALUES (1, 1, 'Low Carb Diet', 'A diet plan that restricts carbohydrates intake.', 1500, 1);

INSERT INTO DietPlan (IdDietPlan, IdUser, Name, Description, PlanCalories, Active)
VALUES (2, 2, 'Mediterranean Diet', 'A diet plan inspired by the Mediterranean region.', 1800, 1);

INSERT INTO DietPlan (IdDietPlan, IdUser, Name, Description, PlanCalories, Active)
VALUES (3, 3, 'Vegetarian Diet', 'A diet plan that focuses on plant-based foods.', 1600, 1);

INSERT INTO DietPlan (IdDietPlan, IdUser, Name, Description, PlanCalories, Active)
VALUES (4, 4, 'Keto Diet', 'A diet plan that emphasizes high-fat, low-carb foods.', 2000, 1);

INSERT INTO DietPlan (IdDietPlan, IdUser, Name, Description, PlanCalories, Active)
VALUES (5, 5, 'Paleo Diet', 'A diet plan based on the types of foods presumed to have been eaten by early humans.', 1700, 1);

INSERT INTO DishDietPlan (IdDishDietPlan, IdDietPlan, IdDish)
VALUES (1, 1, 1);

INSERT INTO DishDietPlan (IdDishDietPlan, IdDietPlan, IdDish)
VALUES (2, 1, 2);

INSERT INTO DishDietPlan (IdDishDietPlan, IdDietPlan, IdDish)
VALUES (3, 2, 3);

INSERT INTO DishDietPlan (IdDishDietPlan, IdDietPlan, IdDish)
VALUES (4, 3, 4);

INSERT INTO DishDietPlan (IdDishDietPlan, IdDietPlan, IdDish)
VALUES (5, 4, 5);

INSERT INTO DishDietPlan (IdDishDietPlan, IdDietPlan, IdDish)
VALUES (6, 4, 1);

INSERT INTO DishDietPlan (IdDishDietPlan, IdDietPlan, IdDish)
VALUES (7, 5, 3);

INSERT INTO DishDietPlan (IdDishDietPlan, IdDietPlan, IdDish)
VALUES (8, 5, 4);

INSERT INTO DishDietPlan (IdDishDietPlan, IdDietPlan, IdDish)
VALUES (9, 5, 5);

-- Training Plan 1
INSERT INTO TrainingPlan (IdTrainingPlan, Name, Description, DegreeOfDifficulty, TrainingLength, NumberOfRepetitions, NumberOfSeries, NumberOfTrainingDaysPerWeek, Active, IdUser, IdAdminAndModerator)
VALUES (1, 'Beginner Full-Body Workout', 'A beginner-level full-body workout routine', 1, 45, 10, 3, 3, true, 1, 1);

-- Training Plan 2
INSERT INTO TrainingPlan (IdTrainingPlan, Name, Description, DegreeOfDifficulty, TrainingLength, NumberOfRepetitions, NumberOfSeries, NumberOfTrainingDaysPerWeek, Active, IdUser, IdAdminAndModerator)
VALUES (2, 'Advanced Push-Pull Split', 'An advanced push-pull split workout routine', 3, 60, 8, 4, 4, true, 1, 1);

-- Training Plan 3
INSERT INTO TrainingPlan (IdTrainingPlan, Name, Description, DegreeOfDifficulty, TrainingLength, NumberOfRepetitions, NumberOfSeries, NumberOfTrainingDaysPerWeek, Active, IdUser, IdAdminAndModerator)
VALUES (3, 'Intermediate Cardio Circuit', 'An intermediate-level cardio circuit training routine', 2, 30, 15, 5, 5, true, 2, 1);

-- Training Plan 4
INSERT INTO TrainingPlan (IdTrainingPlan, Name, Description, DegreeOfDifficulty, TrainingLength, NumberOfRepetitions, NumberOfSeries, NumberOfTrainingDaysPerWeek, Active, IdUser, IdAdminAndModerator)
VALUES (4, 'Strength and Conditioning Program', 'A comprehensive strength and conditioning program', 3, 75, 6, 5, 4, true, 2, 1);

-- Training Plan 5
INSERT INTO TrainingPlan (IdTrainingPlan, Name, Description, DegreeOfDifficulty, TrainingLength, NumberOfRepetitions, NumberOfSeries, NumberOfTrainingDaysPerWeek, Active, IdUser, IdAdminAndModerator)
VALUES (5, 'Bodyweight HIIT Workout', 'A high-intensity bodyweight workout routine', 2, 40, 12, 4, 3, true, 3, 1);


INSERT INTO ExerciseTraningPlan (IdExerciseTraningPlan, IdExercise, IdTraningPlan)
VALUES (1, 1, 1);

INSERT INTO ExerciseTraningPlan (IdExerciseTraningPlan, IdExercise, IdTraningPlan)
VALUES (2, 2, 2);

INSERT INTO ExerciseTraningPlan (IdExerciseTraningPlan, IdExercise, IdTraningPlan)
VALUES (3, 3, 3);

INSERT INTO ExerciseTraningPlan (IdExerciseTraningPlan, IdExercise, IdTraningPlan)
VALUES (4, 4, 4);

INSERT INTO ExerciseTraningPlan (IdExerciseTraningPlan, IdExercise, IdTraningPlan)
VALUES (5, 5, 5);

INSERT INTO ExerciseTraningPlan (IdExerciseTraningPlan, IdExercise, IdTraningPlan)
VALUES (6, 1, 2);

INSERT INTO ExerciseTraningPlan (IdExerciseTraningPlan, IdExercise, IdTraningPlan)
VALUES (7, 2, 3);

INSERT INTO ExerciseTraningPlan (IdExerciseTraningPlan, IdExercise, IdTraningPlan)
VALUES (8, 3, 4);

INSERT INTO ExerciseTraningPlan (IdExerciseTraningPlan, IdExercise, IdTraningPlan)
VALUES (9, 4, 5);

INSERT INTO ExerciseTraningPlan (IdExerciseTraningPlan, IdExercise, IdTraningPlan)
VALUES (10, 5, 1);

