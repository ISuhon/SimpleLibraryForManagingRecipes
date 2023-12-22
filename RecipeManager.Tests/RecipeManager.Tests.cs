
namespace RecipeManagerLogic.Tests
{
    public class RecipeTests
    {
        [Fact]
        public void Recipe_WithValidData_IsCreated()
        {
            // Arrange
            string title = "Pasta Carbonara";
            string chef = "Gordon Ramsay";
            CuisineType cuisineType = CuisineType.Italian;

            // Act
            var recipe = new Recipe(title, chef, cuisineType);

            // Assert
            Assert.Equal(title, recipe.Title);
            Assert.Equal(chef, recipe.Chef);
            Assert.Equal(cuisineType, recipe.CuisineType);
        }

        [Theory]
        [InlineData("", "Gordon Ramsay", CuisineType.Italian)]
        [InlineData("Pasta Carbonara", "", CuisineType.Italian)]
        [InlineData("Pasta Carbonara", "Gordon Ramsay", CuisineType.Unknown)]
        public void Recipe_WithInvalidData_ThrowsArgumentException(string title, string chef, CuisineType cuisineType)
        {
            // Assert
            Assert.Throws<ArgumentException>(() => new Recipe(title, chef, cuisineType));
        }


        [Fact]
        public void RecipeManager_AddRecipe_AddsToCollection()
        {
            // Arrange
            var recipeManager = new RecipeManager();
            var recipe = new Recipe("Pasta Carbonara", "Gordon Ramsay", CuisineType.Italian);

            // Act
            recipeManager.AddRecipe(recipe);

            // Assert
            Assert.Contains(recipe, recipeManager.Recipes);
        }

        [Fact]
        public void RecipeManager_AddRecipe_ThrowsArgumentExceptionForDuplicate()
        {
            // Arrange
            var recipeManager = new RecipeManager();
            var recipe1 = new Recipe("Pasta Carbonara", "Gordon Ramsay", CuisineType.Italian);
            var recipe2 = new Recipe("Pasta Carbonara", "Gordon Ramsay", CuisineType.Italian);

            // Act
            recipeManager.AddRecipe(recipe1);

            // Assert
            Assert.Throws<ArgumentException>(() => recipeManager.AddRecipe(recipe2));
        }

        [Fact]
        public void RecipeManager_RemoveRecipe_RemovesFromCollection()
        {
            // Arrange
            var recipeManager = new RecipeManager();
            var recipe = new Recipe("Pasta Carbonara", "Gordon Ramsay", CuisineType.Italian);
            recipeManager.AddRecipe(recipe);

            // Act
            recipeManager.RemoveRecipe(recipe);

            // Assert
            Assert.DoesNotContain(recipe, recipeManager.Recipes);
        }

        [Fact]
        public void RecipeManager_RemoveRecipe_ThrowsArgumentExceptionForNonExistentRecipe()
        {
            // Arrange
            var recipeManager = new RecipeManager();
            var recipe = new Recipe("Pasta Carbonara", "Gordon Ramsay", CuisineType.Italian);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => recipeManager.RemoveRecipe(recipe));
        }
    }
}

