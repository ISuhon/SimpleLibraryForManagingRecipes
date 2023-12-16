using LabTDD.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace LabTDDTests
{
    [TestClass]
    public class CuisineTests
    {
        [TestMethod]
        public void IsCreated_Cuisine()
        {
            var cuisine = new Cuisine("TestName", "TestCountryName");
            Assert.AreEqual(("TestName", "TestCountryName"), (cuisine.Name, cuisine.CountryName));
        }

        [TestMethod]
        public void IsAdd_Cuisine()
        {
            var cuisine = new Cuisine("TestName", "TestCountryName");
            CuisineManager cuisineManager = new CuisineManager();
            cuisineManager.AddCuisine(cuisine);
            Assert.IsTrue(cuisineManager.GetCuisine(0) == cuisine);
        }

        [TestMethod]
        public void IsCorrectCount_Cuisine()
        {
            var cuisine = new Cuisine("TestName", "TestCountryName");
            CuisineManager cuisineManager = new CuisineManager();
            cuisineManager.AddCuisine(cuisine);
            Assert.IsTrue(cuisineManager.Count == 1);
        }

        [TestMethod]
        public void IsRemove_Cuisine()
        {
            var cuisine = new Cuisine("TestName", "TestCountryName");
            CuisineManager cuisineManager = new CuisineManager();
            cuisineManager.AddCuisine(cuisine);

            cuisineManager.RemoveCuisine(0);
            Assert.IsTrue(cuisineManager.Count == 0);
        }

        [TestMethod]
        public void IsCorrectException_Cuisine()
        {
            var cuisine = new Cuisine("TestName", "TestCountryName");
            CuisineManager cuisineManager = new CuisineManager();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => cuisineManager.RemoveCuisine(0));
        }
    }
}
