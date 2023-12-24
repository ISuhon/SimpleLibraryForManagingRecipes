using RecipeManagerLogic;

var recipeManager = new RecipeManager();

recipeManager.AddRecipe(new Recipe("Pasta Carbonara", "Giulia", CuisineType.Italian));
recipeManager.AddRecipe(new Recipe("Tacos", "Maria", CuisineType.Mexican));
recipeManager.AddRecipe(new Recipe("Sushi Rolls", "Kenji", CuisineType.Asian));

// Displaying recipes
Console.WriteLine("\nList of Recipes:");
foreach (var recipe in recipeManager.Recipes)
{
    Console.WriteLine($"Title: {recipe.Title} | Chef: {recipe.Chef} | Cuisine: {recipe.CuisineType}");
}

// Removing a recipe
try
{
    var recipeToRemove = recipeManager.Recipes.Find(r => r.Title == "Tacos");
    if (recipeToRemove != null)
    {
        recipeManager.RemoveRecipe(recipeToRemove);
        Console.WriteLine("Tacos recipe removed.");
    }
    else
    {
        Console.WriteLine("Recipe not found.");
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error removing recipe: {ex.Message}");
}

// Displaying recipes
Console.WriteLine("\nList of Recipes:");
foreach (var recipe in recipeManager.Recipes)
{
    Console.WriteLine($"Title: {recipe.Title} | Chef: {recipe.Chef} | Cuisine: {recipe.CuisineType}");
}

Console.WriteLine("-----------");

// Adding a recipe to favorites
try
{
    var recipeToAddToFavorites = recipeManager.Recipes.Find(r => r.Title == "Pasta Carbonara");
    if (recipeToAddToFavorites != null)
    {
        recipeManager.AddToFavorites(recipeToAddToFavorites);
        Console.WriteLine("Pasta Carbonara added to favorites.");
        Console.WriteLine("\nList of Favorite Recipes:");
        foreach (var recipe in recipeManager.FavoriteRecipes)
        {
            Console.WriteLine($"Title: {recipe.Title} | Chef: {recipe.Chef} | Cuisine: {recipe.CuisineType}");
        }
    }
    else
    {
        Console.WriteLine("Recipe not found.");
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error adding recipe to favorites: {ex.Message}");
}

// Removing a recipe from favorites
try
{
    var recipeToRemoveFromFavorites = recipeManager.FavoriteRecipes.Find(r => r.Title == "Pasta Carbonara");
    if (recipeToRemoveFromFavorites != null)
    {
        recipeManager.RemoveFromFavorites(recipeToRemoveFromFavorites);
        Console.WriteLine("Pasta Carbonara removed from favorites.");
    }
    else
    {
        Console.WriteLine("Recipe not found in favorites.");
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error removing recipe from favorites: {ex.Message}");
}

Console.WriteLine("\nList of Favorite Recipes:");
foreach (var recipe in recipeManager.FavoriteRecipes)
{
    Console.WriteLine($"Title: {recipe.Title} | Chef: {recipe.Chef} | Cuisine: {recipe.CuisineType}");
}