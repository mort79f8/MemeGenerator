using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;

namespace S2.AspNet.Repetition.Pages
{
    public class IndexModel : PageModel
    {
        public string InsertImagesUrl(int memeImage)
        {
            return $"/Img/meme{memeImage}.png";
        }
    }

}