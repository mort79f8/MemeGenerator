using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;
using S2.AspNet.Repetition.Entities;
using S2.AspNet.Repetition.DAL;

namespace S2.AspNet.Repetition.Pages
{
    public class IndexModel : PageModel
    {
        private MemeImageRepository memeImageRepository = new MemeImageRepository();
        public List<MemeImage> MemeImages { get; set; }
        public void OnGet()
        {
            MemeImages = memeImageRepository.GetAll();
        }

        public string InsertImagesUrl(int memeImage)
        {
            return $"/Img/meme{memeImage}.png";
        }
    }

}