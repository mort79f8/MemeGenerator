using S2.AspNet.Repetition.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using S2.AspNet.Repetition.DAL;
using System.Linq;

namespace S2.AspNet.Repetition.DAL
{
    public class MemeCreationRepository : RepositoryBase
    {
        MemeImageRepository MemeImage = new MemeImageRepository();
        Random rngNum = new Random();
        public int Insert(MemeCreation memeCreation)
        {
            if (memeCreation.MemeImg.Id != 0)
            {
                string sql = $"INSERT INTO MemeCreations VALUES ({memeCreation.MemeImg.Id}, '{memeCreation.TimeStamp.ToString("yyyy-MM-dd HH:mm:ss")}','{memeCreation.MemeText}', '{memeCreation.Position}', '{memeCreation.Color}', '{memeCreation.Size}')";

                return ExecuteNonQuery(sql);
            }
            else
            {
                return 0;
            }
        }

        public List<MemeCreation> GetAll()
        {
            string sql = "SELECT * FROM MemeCreations";

            DataTable data = ExecuteQuery(sql);

            return HandleData(data);
        }

        private List<MemeCreation> HandleData(DataTable dataTable)
        {
            List<MemeCreation> memeCreations = new List<MemeCreation>();

            foreach (DataRow row in dataTable.Rows)
            {
                MemeCreation memeCreation = new MemeCreation((int)row["Id"], MemeImage.GetMemeImage((int)row["MemeImg"]), (DateTime)row["TimeStamp"], (string)row["MemeText"], (string)row["Position"], (string)row["Color"], (string)row["Size"]);
                memeCreations.Add(memeCreation);
            }
            return memeCreations;
        }

        public MemeCreation GetRandomMeme()
        {
            List<MemeCreation> memeList = new List<MemeCreation>();
            memeList = GetAll();
            return memeList[rngNum.Next(1, memeList.Count)];
        }

        public MemeCreation GetLatestMeme()
        {
            string sql = "SELECT TOP(1) * FROM MemeCreations Order By TimeStamp DESC";

            DataTable data = ExecuteQuery(sql);

            return HandleData(data).FirstOrDefault();
        }
    }
}
