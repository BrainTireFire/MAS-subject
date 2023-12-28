using API.Entities.Plans.Diet;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configurations.Diet
{
    public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.ToTable("Recipe");
            builder.HasKey(e => e.IdRecipe);

            builder.HasOne(e => e.User)
                .WithMany(e => e.Recipes)
                .OnDelete(DeleteBehavior.Cascade);


            builder.HasData(new List<Recipe>
            {
                new Recipe
                {
                    IdRecipe = 1,
                    Name = "Pasta Carbonara",
                    IngredientsNeeded = "Spaghetti, Bacon, Eggs, Parmesan Cheese, Black Pepper",
                    StepsToCreate = "1. Cook spaghetti according to package instructions. " +
                                    "2. Cook bacon in a pan until crispy. " +
                                    "3. In a bowl, whisk eggs and grated Parmesan cheese. " +
                                    "4. Drain cooked pasta and immediately toss with the egg mixture. " +
                                    "5. Add cooked bacon and black pepper. Mix well. " +
                                    "6. Serve hot.",
                    Active = true
                },
                new Recipe
                {
                    IdRecipe = 2,
                    Name = "Chicken Stir-Fry",
                    IngredientsNeeded = "Chicken Breast, Mixed Vegetables, Soy Sauce, Garlic, Ginger",
                    StepsToCreate = "1. Cut chicken breast into small pieces. " +
                                    "2. Heat oil in a pan and add minced garlic and ginger. " +
                                    "3. Add chicken and stir-fry until cooked through. " +
                                    "4. Add mixed vegetables and cook until tender. " +
                                    "5. Season with soy sauce and stir well. " +
                                    "6. Serve hot with rice or noodles.",
                    Active = true
                },
                new Recipe
                {
                    IdRecipe = 3,
                    Name = "Caprese Salad",
                    IngredientsNeeded = "Tomatoes, Fresh Mozzarella Cheese, Basil Leaves, Olive Oil, Balsamic Vinegar",
                    StepsToCreate = "1. Slice tomatoes and fresh mozzarella cheese. " +
                                    "2. Arrange tomato and mozzarella slices on a plate. " +
                                    "3. Tuck basil leaves between the slices. " +
                                    "4. Drizzle with olive oil and balsamic vinegar. " +
                                    "5. Season with salt and pepper, if desired. " +
                                    "6. Serve as a refreshing salad.",
                    Active = true
                },
                new Recipe
                {
                    IdRecipe = 4,
                    Name = "Chocolate Chip Cookies",
                    IngredientsNeeded = "All-Purpose Flour, Butter, Brown Sugar, Granulated Sugar, Eggs, " +
                                        "Vanilla Extract, Baking Soda, Salt, Chocolate Chips",
                    StepsToCreate = "1. Preheat the oven to 375°F (190°C). " +
                                    "2. In a mixing bowl, cream together butter, brown sugar, and granulated sugar. " +
                                    "3. Beat in eggs and vanilla extract. " +
                                    "4. In a separate bowl, whisk together flour, baking soda, and salt. " +
                                    "5. Gradually add the dry ingredients to the wet ingredients and mix well. " +
                                    "6. Stir in chocolate chips. " +
                                    "7. Drop rounded tablespoons of dough onto a baking sheet. " +
                                    "8. Bake for 8-10 minutes until lightly golden. " +
                                    "9. Allow the cookies to cool on a wire rack. " +
                                    "10. Enjoy delicious homemade cookies!",
                    Active = true
                },
                new Recipe
                {
                    IdRecipe = 5,
                    Name = "Vegetable Curry",
                    IngredientsNeeded = "Assorted Vegetables (e.g., potatoes, carrots, peas, bell peppers), " +
                                        "Onion, Garlic, Ginger, Curry Powder, Coconut Milk",
                    StepsToCreate = "1. Chop the vegetables into bite-sized pieces. " +
                                    "2. Heat oil in a pan and sauté chopped onion, garlic, and ginger. " +
                                    "3. Add the vegetables and stir-fry for a few minutes. " +
                                    "4. Sprinkle curry powder over the vegetables and mix well. " +
                                    "5. Pour in coconut milk and simmer until the vegetables are cooked. " +
                                    "6. Season with salt and additional spices, if desired. " +
                                    "7. Serve hot with rice or naan bread.",
                    Active = true
                }
            });
        }
    }
}
