using System;
using System.Collections.Generic;
using System.Text;

namespace S2.AspNet.Repetition.Entities
{
    class MemeImage
    {
        private int id;
        private string url;
        private string altText;

        public MemeImage()
        {
        }

        public MemeImage(int id, string url, string altText)
        {
            Id = id;
            Url = url;
            AltText = altText;
        }

        public int Id { get => id; set => id = value; }
        public string Url { get => url; set => url = value; }
        public string AltText { get => altText; set => altText = value; }

        
    }
}
