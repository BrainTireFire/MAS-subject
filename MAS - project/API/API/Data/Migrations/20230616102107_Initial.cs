using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dish",
                columns: table => new
                {
                    IdDish = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdCompositionOfNutritionalValue = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    AmountOfCaloriesInTheDish = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dish", x => x.IdDish);
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    IdExercise = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    Photo = table.Column<string>(type: "TEXT", nullable: false),
                    Video = table.Column<string>(type: "TEXT", nullable: false),
                    MuscleGroups = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.IdExercise);
                });

            migrationBuilder.CreateTable(
                name: "Instrument",
                columns: table => new
                {
                    IdInstrument = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instrument", x => x.IdInstrument);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DietPlan",
                columns: table => new
                {
                    IdDietPlan = table.Column<int>(type: "INTEGER", nullable: false),
                    IdUser = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    PlanCalories = table.Column<int>(type: "INTEGER", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietPlan", x => x.IdDietPlan);
                    table.ForeignKey(
                        name: "FK_DietPlan_AspNetUsers_IdDietPlan",
                        column: x => x.IdDietPlan,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DietPlan_AspNetUsers_IdUser",
                        column: x => x.IdUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    IdRecipe = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IngredientsNeeded = table.Column<string>(type: "TEXT", nullable: false),
                    StepsToCreate = table.Column<string>(type: "TEXT", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.IdRecipe);
                    table.ForeignKey(
                        name: "FK_Recipe_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingPlan",
                columns: table => new
                {
                    IdTrainingPlan = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdUser = table.Column<int>(type: "INTEGER", nullable: false),
                    IdAdminAndModerator = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DegreeOfDifficulty = table.Column<int>(type: "INTEGER", nullable: false),
                    TrainingLength = table.Column<int>(type: "INTEGER", nullable: false),
                    NumberOfRepetitions = table.Column<int>(type: "INTEGER", nullable: false),
                    NumberOfSeries = table.Column<int>(type: "INTEGER", nullable: false),
                    NumberOfTrainingDaysPerWeek = table.Column<int>(type: "INTEGER", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPlan", x => x.IdTrainingPlan);
                    table.ForeignKey(
                        name: "FK_TrainingPlan_AspNetUsers_IdAdminAndModerator",
                        column: x => x.IdAdminAndModerator,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingPlan_AspNetUsers_IdUser",
                        column: x => x.IdUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompositionOfNutritionalValue",
                columns: table => new
                {
                    IdCompositionOfNutritionalValue = table.Column<int>(type: "INTEGER", nullable: false),
                    IdDish = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompositionOfNutritionalValue", x => x.IdCompositionOfNutritionalValue);
                    table.ForeignKey(
                        name: "FK_CompositionOfNutritionalValue_Dish_IdCompositionOfNutritionalValue",
                        column: x => x.IdCompositionOfNutritionalValue,
                        principalTable: "Dish",
                        principalColumn: "IdDish",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseWithoutTheDevice",
                columns: table => new
                {
                    IdExercise = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseWithoutTheDevice", x => x.IdExercise);
                    table.ForeignKey(
                        name: "FK_ExerciseWithoutTheDevice_Exercise_IdExercise",
                        column: x => x.IdExercise,
                        principalTable: "Exercise",
                        principalColumn: "IdExercise",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseWithTheDevice",
                columns: table => new
                {
                    IdExercise = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdInstrument = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseWithTheDevice", x => x.IdExercise);
                    table.ForeignKey(
                        name: "FK_ExerciseWithTheDevice_Exercise_IdExercise",
                        column: x => x.IdExercise,
                        principalTable: "Exercise",
                        principalColumn: "IdExercise",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseWithTheDevice_Instrument_IdInstrument",
                        column: x => x.IdInstrument,
                        principalTable: "Instrument",
                        principalColumn: "IdInstrument",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DishDietPlan",
                columns: table => new
                {
                    IdDishDietPlan = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdDietPlan = table.Column<int>(type: "INTEGER", nullable: false),
                    IdDish = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishDietPlan", x => x.IdDishDietPlan);
                    table.ForeignKey(
                        name: "FK_DishDietPlan_DietPlan_IdDietPlan",
                        column: x => x.IdDietPlan,
                        principalTable: "DietPlan",
                        principalColumn: "IdDietPlan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DishDietPlan_Dish_IdDish",
                        column: x => x.IdDish,
                        principalTable: "Dish",
                        principalColumn: "IdDish",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseTraningPlan",
                columns: table => new
                {
                    IdExerciseTraningPlan = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdExercise = table.Column<int>(type: "INTEGER", nullable: false),
                    IdTraningPlan = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseTraningPlan", x => x.IdExerciseTraningPlan);
                    table.ForeignKey(
                        name: "FK_ExerciseTraningPlan_TrainingPlan_IdTraningPlan",
                        column: x => x.IdTraningPlan,
                        principalTable: "TrainingPlan",
                        principalColumn: "IdTrainingPlan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseExerciseTraningPlan",
                columns: table => new
                {
                    ExerciseTraningPlansIdExerciseTraningPlan = table.Column<int>(type: "INTEGER", nullable: false),
                    ExercisesIdExercise = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseExerciseTraningPlan", x => new { x.ExerciseTraningPlansIdExerciseTraningPlan, x.ExercisesIdExercise });
                    table.ForeignKey(
                        name: "FK_ExerciseExerciseTraningPlan_ExerciseTraningPlan_ExerciseTraningPlansIdExerciseTraningPlan",
                        column: x => x.ExerciseTraningPlansIdExerciseTraningPlan,
                        principalTable: "ExerciseTraningPlan",
                        principalColumn: "IdExerciseTraningPlan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseExerciseTraningPlan_Exercise_ExercisesIdExercise",
                        column: x => x.ExercisesIdExercise,
                        principalTable: "Exercise",
                        principalColumn: "IdExercise",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Dish",
                columns: new[] { "IdDish", "AmountOfCaloriesInTheDish", "Description", "IdCompositionOfNutritionalValue", "Name" },
                values: new object[,]
                {
                    { 1, 350, "A healthy salad with grilled chicken breast.", 1, "Grilled Chicken Salad" },
                    { 2, 250, "A stir-fried medley of fresh vegetables.", 2, "Vegetable Stir-Fry" },
                    { 3, 400, "Oven-roasted salmon served with a side of roasted vegetables.", 3, "Salmon with Roasted Vegetables" },
                    { 4, 300, "A nutritious salad with quinoa, vegetables, and vinaigrette dressing.", 4, "Quinoa Salad" },
                    { 5, 450, "Pasta dish with tomatoes, olives, feta cheese, and herbs.", 5, "Mediterranean Pasta" }
                });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "IdExercise", "Description", "MuscleGroups", "Name", "Photo", "Video" },
                values: new object[,]
                {
                    { 1, "A classic bodyweight exercise targeting the chest, shoulders, and triceps.", "Chest, Shoulders, Triceps", "Push-ups", "pushups.jpg", "pushups.mp4" },
                    { 2, "A compound lower body exercise targeting the quadriceps, hamstrings, and glutes.", "Quadriceps, Hamstrings, Glutes", "Squats", "squats.jpg", "squats.mp4" },
                    { 3, "An isometric core exercise that strengthens the abs, back, and shoulders.", "Abs, Back, Shoulders", "Plank", "plank.jpg", "plank.mp4" },
                    { 4, "A compound lower body exercise targeting the quadriceps, hamstrings, and glutes.", "Quadriceps, Hamstrings, Glutes", "Lunges", "lunges.jpg", "lunges.mp4" },
                    { 5, "A full-body exercise that combines squats, push-ups, and jumps.", "Chest, Shoulders, Legs, Abs", "Burpees", "burpees.jpg", "burpees.mp4" },
                    { 6, "A compound exercise for the upper body that primarily targets the chest, shoulders, and triceps.", "Chest, Shoulders, Triceps", "Bench Press", "benchpress.jpg", "benchpress.mp4" },
                    { 7, "An isolation exercise targeting the biceps using dumbbells.", "Biceps", "Dumbbell Bicep Curls", "bicepcurls.jpg", "bicepcurls.mp4" },
                    { 8, "A dynamic full-body exercise targeting the hips, glutes, and hamstrings.", "Glutes, Hamstrings", "Kettlebell Swings", "kettlebellswings.jpg", "kettlebellswings.mp4" },
                    { 9, "An upper body exercise targeting the back and biceps using a lat pulldown machine.", "Back, Biceps", "Lat Pulldown", "latpulldown.jpg", "latpulldown.mp4" },
                    { 10, "A compound exercise for the upper body that targets the upper chest, shoulders, and triceps.", "Upper Chest, Shoulders, Triceps", "Incline Bench Press", "inclinebenchpress.jpg", "inclinebenchpress.mp4" }
                });

            migrationBuilder.InsertData(
                table: "Instrument",
                columns: new[] { "IdInstrument", "Name" },
                values: new object[,]
                {
                    { 1, "Dumbbells" },
                    { 2, "Barbell" },
                    { 3, "Kettlebell" },
                    { 4, "Resistance Bands" },
                    { 5, "Medicine Ball" }
                });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "IdRecipe", "Active", "IngredientsNeeded", "Name", "StepsToCreate", "UserId" },
                values: new object[,]
                {
                    { 1, true, "Spaghetti, Bacon, Eggs, Parmesan Cheese, Black Pepper", "Pasta Carbonara", "1. Cook spaghetti according to package instructions. 2. Cook bacon in a pan until crispy. 3. In a bowl, whisk eggs and grated Parmesan cheese. 4. Drain cooked pasta and immediately toss with the egg mixture. 5. Add cooked bacon and black pepper. Mix well. 6. Serve hot.", null },
                    { 2, true, "Chicken Breast, Mixed Vegetables, Soy Sauce, Garlic, Ginger", "Chicken Stir-Fry", "1. Cut chicken breast into small pieces. 2. Heat oil in a pan and add minced garlic and ginger. 3. Add chicken and stir-fry until cooked through. 4. Add mixed vegetables and cook until tender. 5. Season with soy sauce and stir well. 6. Serve hot with rice or noodles.", null },
                    { 3, true, "Tomatoes, Fresh Mozzarella Cheese, Basil Leaves, Olive Oil, Balsamic Vinegar", "Caprese Salad", "1. Slice tomatoes and fresh mozzarella cheese. 2. Arrange tomato and mozzarella slices on a plate. 3. Tuck basil leaves between the slices. 4. Drizzle with olive oil and balsamic vinegar. 5. Season with salt and pepper, if desired. 6. Serve as a refreshing salad.", null },
                    { 4, true, "All-Purpose Flour, Butter, Brown Sugar, Granulated Sugar, Eggs, Vanilla Extract, Baking Soda, Salt, Chocolate Chips", "Chocolate Chip Cookies", "1. Preheat the oven to 375°F (190°C). 2. In a mixing bowl, cream together butter, brown sugar, and granulated sugar. 3. Beat in eggs and vanilla extract. 4. In a separate bowl, whisk together flour, baking soda, and salt. 5. Gradually add the dry ingredients to the wet ingredients and mix well. 6. Stir in chocolate chips. 7. Drop rounded tablespoons of dough onto a baking sheet. 8. Bake for 8-10 minutes until lightly golden. 9. Allow the cookies to cool on a wire rack. 10. Enjoy delicious homemade cookies!", null },
                    { 5, true, "Assorted Vegetables (e.g., potatoes, carrots, peas, bell peppers), Onion, Garlic, Ginger, Curry Powder, Coconut Milk", "Vegetable Curry", "1. Chop the vegetables into bite-sized pieces. 2. Heat oil in a pan and sauté chopped onion, garlic, and ginger. 3. Add the vegetables and stir-fry for a few minutes. 4. Sprinkle curry powder over the vegetables and mix well. 5. Pour in coconut milk and simmer until the vegetables are cooked. 6. Season with salt and additional spices, if desired. 7. Serve hot with rice or naan bread.", null }
                });

            migrationBuilder.InsertData(
                table: "CompositionOfNutritionalValue",
                columns: new[] { "IdCompositionOfNutritionalValue", "Description", "IdDish", "Name" },
                values: new object[,]
                {
                    { 1, "High protein content in grilled chicken salad.", 1, "Protein" },
                    { 2, "Rich in dietary fiber due to various vegetables in stir-fry.", 2, "Fiber" },
                    { 3, "Salmon provides a good source of omega-3 fatty acids.", 3, "Omega-3" },
                    { 4, "Quinoa salad is packed with essential vitamins and minerals.", 4, "Vitamins" },
                    { 5, "Mediterranean pasta offers a delightful blend of flavors and textures.", 5, "Mediterranean Flavors" }
                });

            migrationBuilder.InsertData(
                table: "ExerciseWithTheDevice",
                columns: new[] { "IdExercise", "IdInstrument" },
                values: new object[,]
                {
                    { 6, 1 },
                    { 7, 2 },
                    { 8, 3 },
                    { 9, 4 },
                    { 10, 4 }
                });

            migrationBuilder.InsertData(
                table: "ExerciseWithoutTheDevice",
                column: "IdExercise",
                values: new object[]
                {
                    1,
                    2,
                    3,
                    4,
                    5
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DietPlan_IdUser",
                table: "DietPlan",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_DishDietPlan_IdDietPlan",
                table: "DishDietPlan",
                column: "IdDietPlan");

            migrationBuilder.CreateIndex(
                name: "IX_DishDietPlan_IdDish",
                table: "DishDietPlan",
                column: "IdDish");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseExerciseTraningPlan_ExercisesIdExercise",
                table: "ExerciseExerciseTraningPlan",
                column: "ExercisesIdExercise");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseTraningPlan_IdTraningPlan",
                table: "ExerciseTraningPlan",
                column: "IdTraningPlan");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseWithTheDevice_IdInstrument",
                table: "ExerciseWithTheDevice",
                column: "IdInstrument");

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_UserId",
                table: "Recipe",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlan_IdAdminAndModerator",
                table: "TrainingPlan",
                column: "IdAdminAndModerator");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlan_IdUser",
                table: "TrainingPlan",
                column: "IdUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CompositionOfNutritionalValue");

            migrationBuilder.DropTable(
                name: "DishDietPlan");

            migrationBuilder.DropTable(
                name: "ExerciseExerciseTraningPlan");

            migrationBuilder.DropTable(
                name: "ExerciseWithoutTheDevice");

            migrationBuilder.DropTable(
                name: "ExerciseWithTheDevice");

            migrationBuilder.DropTable(
                name: "Recipe");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "DietPlan");

            migrationBuilder.DropTable(
                name: "Dish");

            migrationBuilder.DropTable(
                name: "ExerciseTraningPlan");

            migrationBuilder.DropTable(
                name: "Exercise");

            migrationBuilder.DropTable(
                name: "Instrument");

            migrationBuilder.DropTable(
                name: "TrainingPlan");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
