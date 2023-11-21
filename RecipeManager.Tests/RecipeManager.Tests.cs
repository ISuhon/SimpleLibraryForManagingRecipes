namespace RecipeManager.Tests
{
    public class RecipeManagerTests
    {
        [Fact]
        public void AddingRecipeWithValidDataSucceeds()
        {
            var recipeManager = new RecipeManager();

            recipeManager.AddRecipe("Title", "Chef", CuisineType.Italian);

            Assert.Single(recipeManager.Recipes);
        }

        [Fact]
        public void AddingRecipeWithInvalidTitleFails()
        {
            var recipeManager = new RecipeManager();

            try
            {
                recipeManager.AddRecipe("", "Chef", CuisineType.Italian);
            }
            catch (ArgumentException ex)
            {
                Assert.Equal("Title cannot be null or whitespace.", ex.Message);
            }
        }

        [Fact]
        public void RemovingExistingRecipeSucceeds()
        {
            var recipeManager = new RecipeManager();

            recipeManager.AddRecipe("Title", "Chef", CuisineType.Italian);

            recipeManager.RemoveRecipe("Title", "Chef", CuisineType.Italian);

            Assert.Empty(recipeManager.Recipes);
        }

        [Fact]
        public void RemovingNonExistingRecipeFails()
        {
            var recipeManager = new RecipeManager();

            try
            {
                recipeManager.RemoveRecipe("Title", "Chef", CuisineType.Italian);
            }
            catch (ArgumentException ex)
            {
                Assert.Equal("Recipe not found.", ex.Message);
            }
        }


    }

}