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
    public class NewMemeModel : PageModel
    {
        private MemeCreationRepository memeCreationRepository = new MemeCreationRepository();
        private MemeImageRepository memeImageRepository = new MemeImageRepository();

        private MemeImage memeImage = new MemeImage();
        private MemeCreation memeCreation = new MemeCreation();

        [BindProperty(SupportsGet = true)]
        public string ImageSelected { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MemeText { get; set; } = "";
        [BindProperty(SupportsGet = true)]
        public string TextPosition { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MemeName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string TextSize { get; set; }
        [BindProperty(SupportsGet = true)]
        public string TextColor { get; set; }
        public void OnGet()
        {
            memeImage = memeImageRepository.GetMemeImage(ImageSelected);
            memeCreation.MemeImg = memeImage;
            memeCreation.TimeStamp = DateTime.Now;
            memeCreation.MemeText = MemeText;
            memeCreation.Position = TextPosition;
            memeCreation.Color = TextColor;
            memeCreation.Size = TextSize;
            memeCreationRepository.Insert(memeCreation);
        }
    
    }   
}