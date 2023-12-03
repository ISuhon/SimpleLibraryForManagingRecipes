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

        [Fact]
        public void ConstructorListOfRecipes_UsingNullValue_ThrowingException()
        {
            // Arrange
            List<Recipe>? listOfRecipes = null;

            // Act and assert
            Assert.Throws<ArgumentNullException>(() => new ListOfRecipes<Recipe>(listOfRecipes));
        }

        [Fact]
        public void ConstructorListOfRecipes_UsingNotUniqueCorrectValues_ListOfRecipesCreated()
        {
            // Arrange
            List<Recipe> listOfRecipes = new List<Recipe>();

            var firstRecipe = new Recipe("Risotto", "Gordon Ramsay", CuisineType.Italian);
            var secondRecipe = new Recipe("Pizza", "Matty Matheson", CuisineType.Italian);
            var fourthRecipe = new Recipe("Chilaquiles", "Vikas Khanna", CuisineType.Mexican);

            listOfRecipes.Add(firstRecipe);
            listOfRecipes.Add(secondRecipe);
            listOfRecipes.Add(secondRecipe);
            listOfRecipes.Add(fourthRecipe);

            // Act and assert
            Assert.Throws<ArgumentException>(() => new ListOfRecipes<Recipe>(listOfRecipes));
        }

        [Fact]
        public void DefaultSorting_UsingCorrectValues_SortedListOfRecipesReturned()
        {
            // Arrange
            List<Recipe> listOfRecipes = new List<Recipe>();
            List<Recipe> sortedListOfRecipes = new List<Recipe>();

            var firstRecipe = new Recipe("Risotto", "Gordon Ramsay", CuisineType.Italian);
            var secondRecipe = new Recipe("Gnocchi", "Matty Matheson", CuisineType.Italian);
            var thirdRecipe = new Recipe("Pasta", "Giada De Laurentiis", CuisineType.Italian);
            var fourthRecipe = new Recipe("Chilaquiles", "Vikas Khanna", CuisineType.Mexican);

            listOfRecipes.Add(firstRecipe);
            listOfRecipes.Add(secondRecipe);
            listOfRecipes.Add(thirdRecipe);
            listOfRecipes.Add(fourthRecipe);

            sortedListOfRecipes.Add(firstRecipe);
            sortedListOfRecipes.Add(thirdRecipe);
            sortedListOfRecipes.Add(secondRecipe);
            sortedListOfRecipes.Add(fourthRecipe);

            // Act
            var sut = new ListOfRecipes.ListOfRecipes<Recipe>(listOfRecipes);
            

            // Assert
            Assert.Equal(sortedListOfRecipes[0], sut.GetSortedList()[0]);
            Assert.Equal(sortedListOfRecipes[1], sut.GetSortedList()[1]);
            Assert.Equal(sortedListOfRecipes[2], sut.GetSortedList()[2]);
            Assert.Equal(sortedListOfRecipes[3], sut.GetSortedList()[3]);
        }

        [Fact]
        public void SortingWthFilters_UsingNullValues_ThrowsException()
        {
            // Arrange
            // Arrange
            List<Recipe> listOfRecipes = new List<Recipe>();

            var firstRecipe = new Recipe("Risotto", "Gordon Ramsay", CuisineType.Italian);
            var secondRecipe = new Recipe("Gnocchi", "Matty Matheson", CuisineType.Italian);
            var thirdRecipe = new Recipe("Pasta", "Giada De Laurentiis", CuisineType.Italian);
            var fourthRecipe = new Recipe("Chilaquiles", "Vikas Khanna", CuisineType.Mexican);

            listOfRecipes.Add(firstRecipe);
            listOfRecipes.Add(secondRecipe);
            listOfRecipes.Add(thirdRecipe);
            listOfRecipes.Add(fourthRecipe);

            // Act
            var sut = new ListOfRecipes.ListOfRecipes<Recipe>(listOfRecipes);

            // Act and assert
            Assert.Throws<ArgumentNullException>(() => sut.GetSortedList(null));
        }

        [Fact]
        public void SortingWthFilters_UsingCorrectValues_SortedListOfRecipesCreated()
        {
            // Arrange
            List<Recipe>? listOfRecipes = null;

            // Act and assert
            Assert.Throws<ArgumentNullException>(() => new ListOfRecipes<Recipe>(listOfRecipes));
        }
    }
}