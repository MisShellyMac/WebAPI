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
        public IEnumerable<RecordType> Get()
        {
            RecordTypeRepository r = new RecordTypeRepository();
            return r.GetAll();
        }

        // GET api/recordtypes/5
        public RecordType Get(int id)
        {
            RecordTypeRepository r = new RecordTypeRepository();
            return r.Find(id);
        }

        // POST api/recordtypes
        public void Post([FromBody]string value)
        {
        }

        // PUT api/recordtypes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/recordtypes/5
        public void Delete(int id)
        {
        }

    }
}