using S2.AspNet.Repetition.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace S2.AspNet.Repetition.DAL
{
    public class MemeImageRepository : RepositoryBase
    {
        public List<MemeImage> GetAll()
        {
            string sql = "SELECT * FROM MemeImages";

            DataTable data = ExecuteQuery(sql);

            return HandleData(data);
        }

        public MemeImage GetMemeImage(string url)
        {
            string sql = $"SELECT * FROM MemeImages WHERE (Url='{url}')";

            DataTable data = ExecuteQuery(sql);

            return HandleData(data).FirstOrDefault();
        }

        public MemeImage GetMemeImage(int memeId)
        {
            string sql = $"SELECT * FROM MemeImages WHERE (Id={memeId})";

            DataTable data = ExecuteQuery(sql);

            return HandleData(data).FirstOrDefault();
        }

        private List<MemeImage> HandleData(DataTable dataTable)
        {
            List<MemeImage> memeImages = new List<MemeImage>();

            foreach (DataRow row in dataTable.Rows)
            {
                MemeImage memeImage = new MemeImage((int)row["Id"], (string)row["Url"], (string)row["AltText"]);
                memeImages.Add(memeImage);
            }
            return memeImages;
        }

        public MemeImage GetMostUsed()
        {
            string sql = "SELECT TOP(1) MemeImg, url, alttext, COUNT(*) FROM MemeCreations JOIN MemeImages on MemeCreations.MemeImg = MemeImages.Id GROUP BY MemeImg, url, alttext ORDER BY COUNT(*) DESC";

            DataTable data = ExecuteQuery(sql);

            List<MemeImage> memeImages = new List<MemeImage>();

            foreach (DataRow row in data.Rows)
            {
                MemeImage memeImage = new MemeImage((int)row["MemeImg"], (string)row["Url"], (string)row["AltText"]);
                memeImages.Add(memeImage);
            }
            return memeImages.FirstOrDefault();
        }

        public string GetMostUsedPosition()
        {
            string sql = "SELECT TOP(1) Position, COUNT(*) FROM MemeCreations GROUP BY Position ORDER BY COUNT(*) DESC";

            DataTable data = ExecuteQuery(sql);

            List<string> positions = new List<string>();

            foreach (DataRow row in data.Rows)
            {
                string position = (string)row["Position"];
                positions.Add(position);
            }
            return positions.FirstOrDefault();
        }
        
    }
}
