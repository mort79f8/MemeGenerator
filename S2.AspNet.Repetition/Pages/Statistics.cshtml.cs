using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using S2.AspNet.Repetition.DAL;
using S2.AspNet.Repetition.Entities;

namespace S2.AspNet.Repetition.Pages
{
    public class StatisticsModel : PageModel
    {
        private MemeCreationRepository memeCreations = new MemeCreationRepository();
        private MemeImageRepository memeImages = new MemeImageRepository();
        public MemeCreation MemeCreation { get; set; }
        public MemeImage MemeImg { get; set; }

        public void OnGet()
        {
            GetLatestMeme();
        }

        public void GetLatestMeme()
        {
            MemeCreation = memeCreations.GetLatestMeme();
            MemeImg = MemeCreation.MemeImg;
        }

        public void MostUsedImage()
        {
            MemeImg = memeImages.GetMostUsed();
        }
    }
}