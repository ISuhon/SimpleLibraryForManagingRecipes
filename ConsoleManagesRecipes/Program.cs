using RecipeManagerLogic;

var recipeManager = new RecipeManager();

// Adding recipes
try
{
    recipeManager.AddRecipe(new Recipe("Pasta Carbonara", "Giulia", CuisineType.Italian));
    recipeManager.AddRecipe(new Recipe("Tacos", "Maria", CuisineType.Mexican));
    recipeManager.AddRecipe(new Recipe("Sushi Rolls", "Kenji", CuisineType.Asian));
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error adding recipe: {ex.Message}");
}

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


Console.ReadKey();