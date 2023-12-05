namespace RecipeManager
{
    public interface IRecipe
    {
        string Chef { get; }
        CuisineType CuisineType { get; }
        string Title { get; }
    }
}