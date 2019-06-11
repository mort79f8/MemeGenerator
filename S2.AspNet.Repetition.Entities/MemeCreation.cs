using System;
using System.Collections.Generic;
using System.Text;

namespace S2.AspNet.Repetition.Entities
{
    public class MemeCreation
    {
        private int id;
        private MemeImage memeImg;
        private DateTime timeStamp;
        private string memeText;
        private string position;
        private string color;
        private string size;

        public MemeCreation()
        {
        }

        public MemeCreation(int id, MemeImage memeImg, DateTime timeStamp, string memeText, string position, string color, string size)
        {
            Id = id;
            MemeText = memeText;
            TimeStamp = timeStamp;
            MemeText = memeText;
            Position = position;
            Color = color;
            Size = size;
        }

        public int Id { get => id; set => id = value; }
        public MemeImage MemeImg { get => memeImg; set => memeImg = value; }
        public DateTime TimeStamp { get => timeStamp; set => timeStamp = value; }
        public string MemeText { get => memeText; set => memeText = value; }
        public string Position { get => position; set => position = value; }
        public string Color { get => color; set => color = value; }
        public string Size { get => size; set => size = value; }
    }
}
