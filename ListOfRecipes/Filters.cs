using RecipeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfRecipes
{
    public class SortByCuisineTypeInAscendingOrder : IFilter<Recipe>
    {
        public List<Recipe> Filter(List<Recipe> Recipes)
        {
            return Recipes.OrderBy(f => f.CuisineType).ToList();
        }
    }

    public class SortByCuisineTypeInDescendingOrder : IFilter<Recipe>
    {
        public List<Recipe> Filter(List<Recipe> Recipes)
        {
            return Recipes.OrderByDescending(f => f.CuisineType).ToList();
        }
    }
}
