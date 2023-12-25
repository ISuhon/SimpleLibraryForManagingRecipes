using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipeManagerLogic
{
    public class RecipeManager
    {
        private readonly List<Recipe> _recipes = new List<Recipe>();
        private readonly List<Recipe> _favoriteRecipes = new List<Recipe>(); // New favorites list
        private readonly List<CuisineType> _cuisines = Enum.GetValues(typeof(CuisineType)).Cast<CuisineType>().ToList();

        public List<Recipe> Recipes => _recipes;
        public List<Recipe> FavoriteRecipes => _favoriteRecipes;
        public List<CuisineType> Cuisines => _cuisines;

        public void AddRecipe(Recipe recipe)
        {
            if (_recipes.Any(r => r.Title == recipe.Title && r.Chef == recipe.Chef && r.CuisineType == recipe.CuisineType))
            {
                throw new ArgumentException("Recipe already exists.");
            }

            _recipes.Add(recipe);
        }

        public void RemoveRecipe(Recipe recipe)
        {
            if (!_recipes.Contains(recipe))
            {
                throw new ArgumentException("Recipe not found.");
            }

            _recipes.Remove(recipe);

            // Remove from favorites as well if exists there
            if (_favoriteRecipes.Contains(recipe))
            {
                _favoriteRecipes.Remove(recipe);
            }
        }
        public List<Recipe> GetFavoritesSortedByTitleDescending()
        {
            return _favoriteRecipes
                .OrderByDescending(recipe => recipe.Title)
                .ToList();
        }

        // New method to add a recipe to favorites
        public void AddToFavorites(Recipe recipe)
        {
            if (_favoriteRecipes.Contains(recipe))
            {
                throw new ArgumentException("Recipe is already in favorites.");
            }

            _favoriteRecipes.Add(recipe);
        }

        // New method to remove a recipe from favorites
        public void RemoveFromFavorites(Recipe recipe)
        {
            if (!_favoriteRecipes.Contains(recipe))
            {
                throw new ArgumentException("Recipe is not in favorites.");
            }

            _favoriteRecipes.Remove(recipe);
        }

        // Method to add a new cuisine
        public void AddCuisine(CuisineType newCuisine)
        {
            if (_cuisines.Contains(newCuisine))
            {
                throw new ArgumentException("Cuisine already exists.");
            }

            _cuisines.Add(newCuisine);
        }

        // Method to remove a cuisine
        public void RemoveCuisine(CuisineType cuisineToRemove)
        {
            if (!_cuisines.Contains(cuisineToRemove))
            {
                throw new ArgumentException("Cuisine not found.");
            }

            _cuisines.Remove(cuisineToRemove);
        }


    }
}