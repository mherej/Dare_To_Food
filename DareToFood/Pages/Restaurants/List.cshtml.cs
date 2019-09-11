using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DareToFood.Data;
using DareToFood.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace DareToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;
        [BindProperty(SupportsGet =true)]
        public string SearchTerm { get; set; }

        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurants  { get; set; }

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }
        public void OnGet()
        {
            /// inserted comments
            Message = config["Message"];
            Restaurants = restaurantData.GetRestaurantsByName(SearchTerm);
        }
    }
}