using System;
using Xunit;

namespace RecipeManager.Tests
{
    public class RecipeManagerTests
    {
        [Fact]
        public void GetFavoritesSortedByTitleDescending_ReturnsSortedRecipes()
        {
            // Arrange
            var recipeManager = new RecipeManager();

            var recipe1 = new Recipe("Spaghetti Carbonara", "Chef A", CuisineType.Italian);
            var recipe2 = new Recipe("Tacos", "Chef B", CuisineType.Mexican);
            var recipe3 = new Recipe("Sushi", "Chef C", CuisineType.Asian);

            recipeManager.AddRecipe(recipe1);
            recipeManager.AddRecipe(recipe2);
            recipeManager.AddRecipe(recipe3);

            // Act
            var sortedRecipes = recipeManager.GetFavoritesSortedByTitleDescending();

            // Assert
            Assert.Equal(3, sortedRecipes.Count);
            Assert.Equal("Tacos", sortedRecipes[0].Title);
            Assert.Equal("Spaghetti Carbonara", sortedRecipes[1].Title);
            Assert.Equal("Sushi", sortedRecipes[2].Title);
        }

       
    }
}