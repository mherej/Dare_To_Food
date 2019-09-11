﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DareToFood.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DareToFood.Pages
{
    public class DetailsModel : PageModel
    {
        public Restaurant Restaurant { get; set; }

        public void OnGet()
        {
            Restaurant = new Restaurant();

        }
    }
}