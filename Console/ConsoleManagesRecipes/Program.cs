using RecipeManagerLogic;
using ListOfRecipes;
using System.Linq;

Console.WriteLine("Knyha: ");
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

Console.WriteLine("----------------------------------------");
Console.WriteLine("Naumenko:");

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
manager.AddRecipe(new Recipe("Huevos rancheros", "Unknown", CuisineType.Mexican));
manager.AddRecipe(new Recipe("Bò Lúc Lắc", "Charles Pham", CuisineType.Asian));
manager.AddRecipe(new Recipe("Spaghetti puttanesca", "Sandro Petti", CuisineType.Italian));



// Printing recipes
Console.WriteLine("List of recipes:");
foreach (var recipe in manager.Recipes)
{
    Console.WriteLine($"Title: {recipe.Title} | Chef: {recipe.Chef} | Cuisine: {recipe.CuisineType}");
}

var listOfRecipes = new ListOfRecipes<Recipe>(manager.Recipes);

Console.WriteLine("Printing recipes sorted in descending order:");
foreach (Recipe recipe in listOfRecipes.GetSortedList())
{
    Console.WriteLine($"Title: {recipe.Title} | Chef: {recipe.Chef} | Cuisine: {recipe.CuisineType}");
}

Console.WriteLine("----------------------------------------");
Console.WriteLine("Berdnychenko:");
// Adding a new cuisine
try
{
    recipeManager.AddCuisine(CuisineType.French);
    Console.WriteLine("French cuisine added.");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error adding cuisine: {ex.Message}");
}

// Displaying cuisines

Console.WriteLine("\nList of Cuisines:");
foreach (var cuisine in recipeManager.Cuisines)
{
    Console.WriteLine(cuisine);
}

// Removing a cuisine
try
{
    recipeManager.RemoveCuisine(CuisineType.American);
    Console.WriteLine("American cuisine removed.");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error removing cuisine: {ex.Message}");
}

// Displaying cuisines

Console.WriteLine("\nList of Cuisines:");
foreach (var cuisine in recipeManager.Cuisines)
{
    Console.WriteLine(cuisine);
}


Console.WriteLine("----------------------------------------");
Console.WriteLine("Honcharuk:");

// Adding new recipes
recipeManager.AddRecipe(new Recipe("Chicken Alfredo", "Emily", CuisineType.Italian));
recipeManager.AddRecipe(new Recipe("Beef Tacos", "Juan", CuisineType.Mexican));
recipeManager.AddRecipe(new Recipe("Sashimi", "Akihiro", CuisineType.Japanese));

// Adding the new recipes to favorites
foreach (var recipe in recipeManager.Recipes)
{
    recipeManager.AddToFavorites(recipe);
}

Console.WriteLine("\nList of Favorite Recipes:");
foreach (var recipe in recipeManager.FavoriteRecipes)
{
    Console.WriteLine($"Title: {recipe.Title} | Chef: {recipe.Chef} | Cuisine: {recipe.CuisineType}");
}


// Displaying favorite recipes sorted by title in descending order
Console.WriteLine("\nList of Favorite Recipes (Sorted by Title in Descending Order):");
foreach (var recipe in recipeManager.GetFavoritesSortedByTitleDescending())
{
    Console.WriteLine($"Title: {recipe.Title} | Chef: {recipe.Chef} | Cuisine: {recipe.CuisineType}");
}