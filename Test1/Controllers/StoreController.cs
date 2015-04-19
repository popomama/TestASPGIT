using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test1.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "Hello from Store.Index()";
            //return View();
        }

        //public string Browse()
        //{
        //    return "Hello from Store.Browse()";
        //    //return View();
        //}

        public string Browse(string genre)
        {
            return     HttpUtility.HtmlEncode("tore.Browse, Genre = " + genre);
        }

        // GET: /Store/Details
        public string Details(int id)
        {
            return "Hello from Store.Details() " + id;
        }
    }
}