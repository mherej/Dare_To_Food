using DareToFood.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DareToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurants> GetAll();
    }
    public class InMemeoryRestauranData : IRestaurantData
    {
        readonly List<Restaurants> restaurants;

        public InMemeoryRestauranData()
        {
            restaurants = new List<Restaurants>()
            {
                new Restaurants { Id = 1, Name="Jonny's Pizza", Location="Galway", Cuisne = CuisneType.Italian},
                new Restaurants { Id = 2, Name="Mr.Wong", Location="Galway", Cuisne = CuisneType.Chaineese},
                new Restaurants { Id = 3, Name="Taco Locos", Location="Galway", Cuisne = CuisneType.Mexican},
                new Restaurants { Id = 4, Name="Taj Mahal", Location="Galway", Cuisne = CuisneType.Indian},
            };
        }
        public IEnumerable<Restaurants> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }

}
