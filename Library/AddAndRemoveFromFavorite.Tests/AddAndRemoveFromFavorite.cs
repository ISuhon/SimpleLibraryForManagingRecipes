using RecipeManagerLogic;

namespace AddAndRemoveFromFavorite.Tests
{
    public class AddAndRemoveFromFavoriteTests
    {
        [Fact]
        public void AddRecipeToFavorite_ShouldAddToFavoriteList()
        {
            // Arrange
            var recipeManager = new RecipeManager();
            var recipe = new Recipe("Spaghetti", "Chef Mario", CuisineType.Italian);

            // Act
            recipeManager.AddRecipe(recipe);
            recipeManager.AddToFavorites(recipe);

            // Assert
            Assert.Contains(recipe, recipeManager.FavoriteRecipes);
        }

        [Fact]
        public void AddExistingRecipeToFavorite_ShouldThrowException()
        {
            // Arrange
            var recipeManager = new RecipeManager();
            var recipe = new Recipe("Spaghetti", "Chef Mario", CuisineType.Italian);

            // Act
            recipeManager.AddRecipe(recipe);
            recipeManager.AddToFavorites(recipe);

            // Assert
            Assert.Throws<ArgumentException>(() => recipeManager.AddToFavorites(recipe));
        }

        [Fact]
        public void RemoveRecipeFromFavorite_ShouldRemoveFromFavoriteList()
        {
            // Arrange
            var recipeManager = new RecipeManager();
            var recipe = new Recipe("Spaghetti", "Chef Mario", CuisineType.Italian);

            // Act
            recipeManager.AddRecipe(recipe);
            recipeManager.AddToFavorites(recipe);
            recipeManager.RemoveFromFavorites(recipe);

            // Assert
            Assert.DoesNotContain(recipe, recipeManager.FavoriteRecipes);
        }

        [Fact]
        public void RemoveNonExistingRecipeFromFavorite_ShouldThrowException()
        {
            // Arrange
            var recipeManager = new RecipeManager();
            var recipe = new Recipe("Spaghetti", "Chef Mario", CuisineType.Italian);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => recipeManager.RemoveFromFavorites(recipe));
        }
    }
}