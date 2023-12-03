using ListOfRecipes;
using RecipeManager;

namespace ListOfRecipes.Tests
{
    public class Test
    {
        [Fact]
        public void ConstructorListOfRecipes_UsingCorrectValues_ListOfRecipesCreated()
        {
            // Arrange
            List<Recipe> listOfRecipes = new List<Recipe>();

            var firstRecipe = new Recipe("Risotto", "Gordon Ramsay", CuisineType.Italian);
            var secondRecipe = new Recipe("Pizza", "Matty Matheson", CuisineType.Italian);
            var thirdRecipe = new Recipe("Pasta", "Giada De Laurentiis", CuisineType.Italian);
            var fourthRecipe = new Recipe("Chilaquiles", "Vikas Khanna", CuisineType.Mexican);

            listOfRecipes.Add(firstRecipe);
            listOfRecipes.Add(secondRecipe);
            listOfRecipes.Add(thirdRecipe);
            listOfRecipes.Add(fourthRecipe);

            // Act
            var sut = new ListOfRecipes.ListOfRecipes<Recipe>(listOfRecipes);

            // Assert
            Assert.Equal(firstRecipe, sut.GetList()[0]);
            Assert.Equal(secondRecipe, sut.GetList()[1]);
            Assert.Equal(thirdRecipe, sut.GetList()[2]);
            Assert.Equal(fourthRecipe, sut.GetList()[3]);
        }
    }
}