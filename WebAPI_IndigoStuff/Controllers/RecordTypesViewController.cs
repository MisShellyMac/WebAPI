using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPI_IndigoStuff.DataLayer;
using WebAPI_IndigoStuff.Models;

namespace WebAPI_IndigoStuff.Controllers
{
    public class RecordTypesViewController : Controller
    {
        public ActionResult Index()
        {
            RecordTypeRepository r = new RecordTypeRepository();
            var recordTypes = r.GetAll();
            return View(recordTypes);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            RecordType recordtype = new RecordType();
            recordtype.Description = collection.GetValue("Description").AttemptedValue.ToString();
            recordtype.MailTo = collection.GetValue("MailTo").AttemptedValue.ToString();
            recordtype.DateAdded = DateTime.Parse(collection.GetValue("DateAdded").AttemptedValue.ToString());
            recordtype.Purpose = collection.GetValue("Purpose").AttemptedValue.ToString();
            recordtype.ExpectedEndDate = DateTime.Parse(collection.GetValue("ExpectedEndDate").AttemptedValue.ToString());

            RecordTypeRepository r = new RecordTypeRepository();
            r.Add(recordtype);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            RecordTypeRepository r = new RecordTypeRepository();
            RecordType recordtype = r.Find(id);
            return View(recordtype);
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            RecordType recordtype = new RecordType();
            recordtype.Description = collection.GetValue("Description").AttemptedValue.ToString();
            recordtype.MailTo = collection.GetValue("MailTo").AttemptedValue.ToString();
            recordtype.DateAdded = DateTime.Parse(collection.GetValue("DateAdded").AttemptedValue.ToString());
            recordtype.Purpose = collection.GetValue("Purpose").AttemptedValue.ToString();
            recordtype.ExpectedEndDate = DateTime.Parse(collection.GetValue("ExpectedEndDate").AttemptedValue.ToString());
            recordtype.Id = id;

            RecordTypeRepository r = new RecordTypeRepository();
            r.Update(recordtype);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            RecordTypeRepository r = new RecordTypeRepository();
            RecordType recordtype = r.Find(id);
            return View(recordtype);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            RecordTypeRepository r = new RecordTypeRepository();
            r.Remove(id);

            return RedirectToAction("Index");
        }
    }
}

