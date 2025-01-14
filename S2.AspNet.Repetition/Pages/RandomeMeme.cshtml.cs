﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using S2.AspNet.Repetition.DAL;
using S2.AspNet.Repetition.Entities;

namespace S2.AspNet.Repetition.Pages
{
    public class RandomeMemeModel : PageModel
    {
        private MemeCreationRepository memeCreationRepository = new MemeCreationRepository();

        public MemeImage MemeImg { get; set; }
        public MemeCreation MemeCreated { get; set; }

        public void OnGet()
        {
            GenerateMeme();
        }
        public void GenerateMeme()
        {
            MemeCreated = memeCreationRepository.GetRandomMeme();
            MemeImg = MemeCreated.MemeImg;
        }
    }
}