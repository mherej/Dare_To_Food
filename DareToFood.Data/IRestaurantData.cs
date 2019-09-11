using DareToFood.Core;
using System.Collections.Generic;
using System.Linq;

namespace DareToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
    }
    public class InMemeoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;

        public InMemeoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name="Jonny's Pizza", Location="Galway", Cuisne = CuisneType.Italian},
                new Restaurant { Id = 2, Name="Mr.Wong", Location="Galway", Cuisne = CuisneType.Chaineese},
                new Restaurant { Id = 3, Name="Taco Locos", Location="Galway", Cuisne = CuisneType.Mexican},
                new Restaurant { Id = 4, Name="Taj Mahal", Location="Galway", Cuisne = CuisneType.Indian},
            };
        }
        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
    }

}
