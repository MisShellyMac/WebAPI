using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using WebAPI_IndigoStuff.Models;
using Dapper;

namespace WebAPI_IndigoStuff.DataLayer
{
    public class DataRecordRepository
    {
        private SqlConnection db = new SqlConnection("Server=tcp:indigostuff.database.windows.net,1433;Database=IndigoStuff;User ID=michelle@indigostuff;Password=Indigo!!;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public List<DataRecord> GetAll()
        {
            return this.db.Query<DataRecord>("select * from DataRecords").ToList();
        }

        public DataRecord Find(int id)
        {
            var dbArgs = new DynamicParameters();
            dbArgs.Add("id", id);


            return this.db.Query<DataRecord>("select * from DataRecords where id=@id", dbArgs).First();
        }

        public void Add(DataRecord datarecord)
        {
            db.Open();
            try
            {
                SqlCommand command = new SqlCommand(
                    "insert into DataRecords (Data, DateAdded) values (@data, @dateadded)",
                    this.db);
                command.Parameters.AddWithValue("@data", datarecord.Data);
                command.Parameters.AddWithValue("@dateadded", datarecord.DateAdded);       
            }
            finally
            {
                db.Close();
            }
        }

        public void Update(DataRecord datarecord)
        {
            db.Open();
            try
            {
                SqlCommand command = new SqlCommand(
                    "update DataRecords set Data=@data, DateAdded=@dateadded where id = @id",
                    this.db);
                command.Parameters.AddWithValue("@data", datarecord.Data);
                command.Parameters.AddWithValue("@dateadded", datarecord.DateAdded);
                command.Parameters.AddWithValue("@id", datarecord.Id);
                command.ExecuteNonQuery();
            }
            finally
            {
                db.Close();
            }
        }

        public void Remove(int id)
        {
            db.Open();
            try
            {
                SqlCommand command = new SqlCommand("delete from DataRecords where id = @id", this.db);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            finally
            {
                db.Close();
            }
        }
    }
}
