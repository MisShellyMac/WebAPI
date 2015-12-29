using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using WebAPI_IndigoStuff.Models;
using Dapper;

namespace WebAPI_IndigoStuff.DataLayer
{
    public class RecordTypeRepository
    {
        private SqlConnection db = new SqlConnection("Server=tcp:indigostuff.database.windows.net,1433;Database=IndigoStuff;User ID=michelle@indigostuff;Password=Indigo!!;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public List<RecordType> GetAll()
        {
            return this.db.Query<RecordType>("select * from RecordTypes").ToList();
        }

        public RecordType Find(int id)
        {
            var dbArgs = new DynamicParameters();
            dbArgs.Add("id", id);


            return this.db.Query<DataRecord>("select * from RecordTypes where id=@id", dbArgs).First();
        }

        public void Add(RecordType recordtype)
        {
            db.Open();
            try
            {
                SqlCommand command = new SqlCommand(
                    "insert into RecordTypes (Description, MailTo, DateAdded, Purpose, ExpectedEndDate) values (@description, @mailto, @dateadded, @purpose, @expectedenddate)",
                    this.db);
                command.Parameters.AddWithValue("@description", recordtype.Description);
                command.Parameters.AddWithValue("@mailto", recordtype.MailTo);
                command.Parameters.AddWithValue("@dateadded", recordtype.DateAdded);
                command.Parameters.AddWithValue("@purpose", recordtype.Purpose);
                command.Parameters.AddWithValue("@expectedenddate", recordtype.ExpectedEndDate);
                command.ExecuteNonQuery();
            }
            finally
            {
                db.Close();
            }
        }

        public void Update(RecordType recordtype)
        {
            db.Open();
            try
            {
                SqlCommand command = new SqlCommand(
                    "update RecordTypes set Description=@description, MailTo=@mailto, DateAdded=@dateadded, Purpose=@purpose, ExpectedEndDate=@expectedenddate where id = @id",
                    this.db);
                command.Parameters.AddWithValue("@description", recordtype.Description);
                command.Parameters.AddWithValue("@mailto", recordtype.MailTo);
                command.Parameters.AddWithValue("@dateadded", recordtype.DateAdded);
                command.Parameters.AddWithValue("@purpose", recordtype.Purpose);
                command.Parameters.AddWithValue("@expectedenddate", recordtype.ExpectedEndDate);
                command.Parameters.AddWithValue("@id", recordtype.Id);
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
                SqlCommand command = new SqlCommand("delete from RecordTypes where id = @id", this.db);
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
