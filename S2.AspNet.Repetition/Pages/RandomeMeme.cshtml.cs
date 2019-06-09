using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace S2.AspNet.Repetition.Pages
{
    public class RandomeMemeModel : PageModel
    {
        public int NumberOfImages { get; set; }

        public NewMemeModel newMeme = new NewMemeModel();
        private Random rng = new Random();
        List<string> MemeTextList = new List<string>()

        {
            "Like a Boss",
            "Hurra",
            "Random is random!",
            "Drink while young",
            "Memes are weird",
            "i am your weifu?",
            "DUH"
        };

        List<string> MemeColorList = new List<string>()
        {
            "text-color-white",
            "text-color-black",
            "text-color-red"
        };

        List<string> MemeSizeList = new List<string>()
        {
            "text-size-small",
            "text-size-medium",
            "text-size-large"
        };

        List<String> MemeTextPosition = new List<string>()
        {
            "top-left",
            "top-center",
            "top-right",
            "centered",
            "bottom-left",
            "bottom-center",
            "bottom-right"
        };

        List<string> MemeNameList = new List<string>()
        {
            "Random meme 1",
            "Random meme 2",
            "Random meme 3",
            "Random meme 4"
        };
        public void OnGet()
        {
            NumberOfImages = 7;
            GenerateRandomMeme();
        }

        public void GenerateRandomMeme()
        {
            newMeme.SelectedImageUrl = $"/img/meme" + rng.Next(1, NumberOfImages + 1) + ".png";
            newMeme.MemeName = MemeNameList[rng.Next(0, MemeNameList.Count())];
            newMeme.MemeText = MemeTextList[rng.Next(0, MemeTextList.Count())];
            newMeme.TextSize = MemeSizeList[rng.Next(0, MemeSizeList.Count())];
            newMeme.TextPosition = MemeTextPosition[rng.Next(0, MemeTextPosition.Count())];
            newMeme.TextColor = MemeColorList[rng.Next(0, MemeColorList.Count())];
        }
    }
}