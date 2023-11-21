namespace RecipeManager
{
    public class RecipeManager
    {
        private readonly List<Recipe> _recipes = new List<Recipe>();

        public List<Recipe> Recipes
        {
            get { return _recipes; }
        }

        public void AddRecipe(string title, string chef, CuisineType cuisineType)
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

            _recipes.Add(new Recipe(title, chef, cuisineType));
        }

        public void RemoveRecipe(string title, string chef, CuisineType cuisineType)
        {
            var recipe = _recipes.FirstOrDefault(r => r.Title == title && r.Chef == chef && r.CuisineType == cuisineType);

            if (recipe == null)
            {
                throw new ArgumentException("Recipe not found.");
            }

            _recipes.Remove(recipe);
        }
    }

    public enum CuisineType
    {
        Unknown,
        Italian,
        Mexican,
        Asian,
        American
    }

    public class Recipe
    {
        public Recipe(string title, string chef, CuisineType cuisineType)
        {
            Title = title;
            Chef = chef;
            CuisineType = cuisineType;
        }

        public string Title { get; }
        public string Chef { get; }
        public CuisineType CuisineType { get; }
    }
}