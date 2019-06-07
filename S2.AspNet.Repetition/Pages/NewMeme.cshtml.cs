﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace S2.AspNet.Repetition.Pages
{
    public class NewMemeModel : PageModel
    {
        
        [BindProperty(SupportsGet = true)]
        public int ImageSelected { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MemeText { get; set; } = "";
        [BindProperty(SupportsGet = true)]
        public string TextPosition { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MemeName { get; set; }
        public string SelectedImageUrl { get; set; }
        public void OnGet()
        {
            SelectedImageUrl = $"/img/meme{ImageSelected}.png";

        }
    
    }
}