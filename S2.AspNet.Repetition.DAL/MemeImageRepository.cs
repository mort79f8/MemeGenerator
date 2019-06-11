using S2.AspNet.Repetition.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace S2.AspNet.Repetition.DAL
{
    class MemeImageRepository : RepositoryBase
    {
        public List<MemeImage> GetAll()
        {
            string sql = "SELECT * FROM MemeImages";

            DataTable data = ExecuteQuery(sql);

            return HandleData(data);
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
    }
}
