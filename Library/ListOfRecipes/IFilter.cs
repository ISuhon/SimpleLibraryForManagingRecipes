﻿using RecipeManagerLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfRecipes
{
    public interface IFilter<T> where T : Recipe
    {
        public List<T> Filter(List<T> Recipes);
    }
}
