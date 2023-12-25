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

Console.WriteLine("----------------------------------------"); 
Console.WriteLine("Suhonosenko:");

RecipeManager manager = new RecipeManager();

// Adding recipes
manager.AddRecipe(new Recipe("Spaghetti puttanesca", "Sandro Petti", CuisineType.Italian));
manager.AddRecipe(new Recipe("Huevos rancheros", "Unknown", CuisineType.Mexican));
manager.AddRecipe(new Recipe("Bò Lúc Lắc", "Charles Pham", CuisineType.Asian));

// Printing recipes
Console.WriteLine("List of recipes:");
foreach (var recipe in manager.Recipes)
{
    Console.WriteLine(recipe);
}

// Removing recipe
try
{
    var selectedRecipe = manager.Recipes.Find(r => r.Title == "Huevos rancheros");
    if (selectedRecipe == null)
    {
        Console.WriteLine("There no such recipe");
    }
    else
    {
        recipeManager.RemoveRecipe(selectedRecipe);
        Console.WriteLine("Recipe \"Huevos rancheros\" was removed.");
        
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error while removing recipe: {ex.Message}");
}

// Printing recipes
Console.WriteLine("List after removing one recipe:");
foreach (var recipe in manager.Recipes)
{
    Console.WriteLine(recipe);
}

// Adding recipe to favorites
try
{
#nullable disable
    var selectedRecipes = recipeManager.Recipes.Find(f => f.Chef == "Charles Pham");
    if (selectedRecipes == null)
    {
        Console.WriteLine("Recipe not found.");
    }
    else
    {
        recipeManager.AddToFavorites(selectedRecipes);
        Console.WriteLine("Recipes with chef \"Charles Pham\" added to favorites.");
    }
#nullable enable
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error while adding recipe to favorites: {ex.Message}");
}

// Printing favorites recipes
Console.WriteLine("List of favorite recipes:");
foreach (var recipe in recipeManager.FavoriteRecipes)
{
    Console.WriteLine($"Title: {recipe.Title} | Chef: {recipe.Chef} | Cuisine: {recipe.CuisineType}");
}

// Removing a recipe from favorites
try
{
#nullable disable
    var selectedRecipes = recipeManager.Recipes.Find(f => f.Chef == "Charles Pham");
    if (selectedRecipes == null)
    {
        Console.WriteLine("Recipe not found in favorites.");
    }
    else
    {
        recipeManager.RemoveFromFavorites(selectedRecipes);
        Console.WriteLine("Recipes with chef \"Charles Pham\" removed from favorites.");
    }
#nullable enable
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error removing recipe from favorites: {ex.Message}");
}

Console.WriteLine("\nList of favorite recipes:");
foreach (var recipe in recipeManager.FavoriteRecipes)
{
    Console.WriteLine($"Title: {recipe.Title} | Chef: {recipe.Chef} | Cuisine: {recipe.CuisineType}");
}