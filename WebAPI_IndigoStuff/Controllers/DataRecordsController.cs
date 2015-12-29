using System.Collections.Generic;
using System.Web.Http;
using WebAPI_IndigoStuff.DataLayer;
using WebAPI_IndigoStuff.Models;

namespace WebAPI_IndigoStuff.Controllers
{

    public class DataRecordsController : ApiController
    {

        // GET api/DataRecords
        public IEnumerable<DataRecord> Get()
        {
            DataRecordRepository r = new DataRecordRepository();
            return r.GetAll();
        }

        // GET api/DataRecords/5
        public DataRecord Get(int id)
        {
            DataRecordRepository r = new DataRecordRepository();
            return r.Find(id);
        }

        // POST api/DataRecords
        public void Post([FromBody]DataRecord dataRecord)
        {
            DataRecordRepository r = new DataRecordRepository();
            r.Add(dataRecord);
        }

        // PUT api/DataRecords/5
        public void Put(int id, [FromBody]DataRecord dataRecord)
        {
            dataRecord.Id = id;

            DataRecordRepository r = new DataRecordRepository();
            r.Update(dataRecord);
        }

        // DELETE api/DataRecords/5
        public void Delete(int id)
        {
            DataRecordRepository r = new DataRecordRepository();
            r.Remove(id);
        }

    }

}
