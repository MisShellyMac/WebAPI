using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebAPI_IndigoStuff.DataLayer;
using WebAPI_IndigoStuff.Models;

namespace WebAPI_IndigoStuff.Controllers
{
   
    public class RecordTypesController : ApiController
    {

        // GET api/recordtypes
        public IEnumerable<DataRecord> Get()
        {
            DataRecordRepository r = new DataRecordRepository();
            return r.GetAll();
        }

        // GET api/recordtypes/5
        public DataRecord Get(int id)
        {
            DataRecordRepository r = new DataRecordRepository();
            return r.Find(id);
        }

        // POST api/recordtypes
        public void Post([FromBody]DataRecord recordType)
        {
            DataRecordRepository r = new DataRecordRepository();
            r.Add(recordType);
        }

        // PUT api/recordtypes/5
        public void Put(int id, [FromBody]DataRecord recordType)
        {
            recordType.Id = id;

            DataRecordRepository r = new DataRecordRepository();
            r.Update(recordType);
        }

        // DELETE api/recordtypes/5
        public void Delete(int id)
        {
            DataRecordRepository r = new DataRecordRepository();
            r.Remove(id);
        }

    }

}