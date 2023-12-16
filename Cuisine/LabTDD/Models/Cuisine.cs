using LabTDD.Models.Interfaces;

namespace LabTDD.Models
{
    public class Cuisine : ICountry
    {
        public string Name { get; set; }
        public string CountryName { get; set; }

        public Cuisine()
        {
            Name = string.Empty;
            CountryName = string.Empty;
        }

        public Cuisine(string name, string countryName)
        {
            Name = name;
            CountryName = countryName;
        }

        public override string ToString()
        {
            return $"Cuisine: {Name}. Country: {CountryName}.";
        }
    }
}
