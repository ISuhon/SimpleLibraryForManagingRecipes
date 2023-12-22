namespace RecipeManagerLogic
{
    public class Recipe
    {
        public Recipe(string title, string chef, CuisineType cuisineType)
        {
            ValidateAndInitialize(title, chef, cuisineType);
        }

        public string Title { get; private set; }
        public string Chef { get; private set; }
        public CuisineType CuisineType { get; private set; }

        private void ValidateAndInitialize(string title, string chef, CuisineType cuisineType)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title cannot be null or whitespace.");
            }

            if (string.IsNullOrWhiteSpace(chef))
            {
                throw new ArgumentException("Chef cannot be null or whitespace.");
            }

            if (cuisineType == CuisineType.Unknown)
            {
                throw new ArgumentException("Cuisine type cannot be unknown.");
            }

            Title = title;
            Chef = chef;
            CuisineType = cuisineType;
        }

        // Додаткові методи для роботи з рецептом можна додавати тут
    }
}
