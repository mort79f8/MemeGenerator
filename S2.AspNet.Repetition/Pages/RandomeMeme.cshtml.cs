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
    public class RandomeMemeModel : PageModel
    {
        private MemeCreationRepository memeCreationRepository = new MemeCreationRepository();

        public MemeImage MemeImg { get; set; }
        public MemeCreation MemeCreated { get; set; }


        //private int id;
        //private MemeImage memeImg;
        //private DateTime timeStamp;
        //private string memeText;
        //private string position;
        //private string color;
        //private string size;

        //public int Id { get => id; set => id = value; }
        //public MemeImage MemeImg { get => memeImg; set => memeImg = value; }
        //public DateTime TimeStamp { get => timeStamp; set => timeStamp = value; }
        //public string MemeText { get => memeText; set => memeText = value; }
        //public string Position { get => position; set => position = value; }
        //public string Color { get => color; set => color = value; }
        //public string Size { get => size; set => size = value; }

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