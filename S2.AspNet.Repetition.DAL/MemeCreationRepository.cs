using S2.AspNet.Repetition.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2.AspNet.Repetition.DAL
{
    public class MemeCreationRepository : RepositoryBase
    {

        public int Insert(MemeCreation memeCreation)
        {
            if (memeCreation.MemeImg.Id != 0)
            {
                string sql = $"INSERT INTO MemeCreations VALUES ({memeCreation.MemeImg.Id}, {memeCreation.TimeStamp.ToString("yyyy-MM-dd HH:mm:ss")},{memeCreation.MemeText}, {memeCreation.Position}, {memeCreation.Color}, {memeCreation.Size})";

                return ExecuteNonQuery(sql);
            }
            else
            {
                return 0;
            }
        }

    }
}
