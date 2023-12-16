using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTDD.Models
{
    public class CuisineManager
    {
        private List<Cuisine> cuisines;
        public int Count
        {
            get
            {
                return cuisines.Count;
            }
        }

        public CuisineManager()
        {
            cuisines = new List<Cuisine>();
        }

        public void AddCuisine(Cuisine cuisine)
        {
            cuisines.Add(cuisine);
        }

        public void RemoveCuisine(int index)
        {
            cuisines.RemoveAt(index);
        }

        public Cuisine GetCuisine(int index)
        {
            return cuisines[index];
        }
    }
}
