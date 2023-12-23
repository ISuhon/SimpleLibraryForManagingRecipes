using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipeManagerLogic
{
    public class RecipeManager
    {
        private readonly List<Recipe> _recipes = new List<Recipe>();

        public List<Recipe> Recipes => _recipes;

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
        }
        public List<Recipe> GetFavoritesSortedByTitleDescending()
        {
            return _recipes
                .OrderByDescending(recipe => recipe.Title)
                .ToList();
        }
        
    }
}
    

