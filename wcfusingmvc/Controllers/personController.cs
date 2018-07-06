using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wcfusingmvc.ServiceReference1;

namespace wcfusingmvc.Controllers
{
    public class personController : Controller
    {
        // GET: person
        public ActionResult GetPersons()
        {
            Service1Client ser = new Service1Client();
            List<person> li = ser.GetPersons().ToList();
            //List<person> li=ser.GetPersons().ToList();
            ViewBag.list = li;
            return View();
        }
        public ActionResult Insert()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Insert(person pobj)
        {
            Service1Client serv = new Service1Client();
            serv.Insert(pobj);
            return View();
        }

        public ActionResult Updateperson()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Updateperson(person pobj)
        {
            Service1Client cvr = new Service1Client();
            cvr.Update(pobj);
           
            return View();

        }
        public ActionResult Deleteperson()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Deleteperson(String id)
        {
            Service1Client s = new Service1Client();
            s.Delete(id);
            return View();
        }

    }
}