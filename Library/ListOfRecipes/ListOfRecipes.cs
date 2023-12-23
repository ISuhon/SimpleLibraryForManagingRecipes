using RecipeManagerLogic;

namespace ListOfRecipes
{
    public class ListOfRecipes<T> where T : Recipe
    {
        // Constructor which create list of recipes with sorting by descending order by the title of a recipe (default sorting)
        public ListOfRecipes(List<T> listOfRecipes) 
        {
            if(listOfRecipes == null || listOfRecipes.Count == 0) 
            {
                throw new ArgumentNullException(nameof(listOfRecipes), "List of recipes is empty");
            }

            if(listOfRecipes.Distinct().Count() != listOfRecipes.Count()) 
            {
                throw new ArgumentException(nameof(listOfRecipes), "List of recipes must contain only unique recipes");
            }

            this._recipes = listOfRecipes;
        }

        private List<T> _recipes;

        // Method which return list of descending order by the title of a recipe (default sorting)
        public List<T> GetSortedList()
        {
            return this._recipes.OrderByDescending(f => f.Title).ToList();
        }

        // Method which return list filtered in a certain way
        public List<T> GetSortedList(IFilter<T> filter)
        {
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter), "Filter is empty");
            }

            var sortedList = filter.Filter(this._recipes);

            if(sortedList == null || sortedList.Count == 0)
            {
                throw new ArgumentNullException(nameof(sortedList), "List empty after sorting");
            }

            return sortedList;
        }

        public List<T> GetList()
        {
            return this._recipes;
        }
    }
}
