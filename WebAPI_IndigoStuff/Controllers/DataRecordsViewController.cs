using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPI_IndigoStuff.DataLayer;
using WebAPI_IndigoStuff.Models;

namespace WebAPI_IndigoStuff.Controllers
{
    public class DataRecordsViewController : Controller
    {
        public ActionResult Index()
        {
            DataRecordRepository r = new DataRecordRepository();
            var dataRecords = r.GetAll();
            return View(dataRecords);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            DataRecord datarecord = new DataRecord();
            datarecord.Data = collection.GetValue("Data").AttemptedValue.ToString(); 
            datarecord.DateAdded = DateTime.Parse(collection.GetValue("DateAdded").AttemptedValue.ToString());
            DataRecordRepository r = new DataRecordRepository();
            r.Add(datarecord);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            DataRecordRepository r = new DataRecordRepository();
            DataRecord datarecord = r.Find(id);
            return View(datarecord);
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            DataRecord datarecord = new DataRecord();
            datarecord.Data = collection.GetValue("Data").AttemptedValue.ToString();
            datarecord.DateAdded = DateTime.Parse(collection.GetValue("DateAdded").AttemptedValue.ToString());
            datarecord.Id = id;

            DataRecordRepository r = new DataRecordRepository();
            r.Update(datarecord);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            DataRecordRepository r = new DataRecordRepository();
            DataRecord datarecord = r.Find(id);
            return View(datarecord);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            DataRecordRepository r = new DataRecordRepository();
            r.Remove(id);

            return RedirectToAction("Index");
        }
    }
}

