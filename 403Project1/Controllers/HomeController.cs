using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403Project1.Controllers
{
    public class HomeController : Controller
    {

    List<string> subjectList = new List<string>();

    // GET: Home
    public ActionResult Index()
        {
            return View();
        }

        public ActionResult Missions()
        {
            List<SelectListItem> missionList = new List<SelectListItem>()
            {
                new SelectListItem
                    {
                        Text = "Portland Oregon", Value = "0"
                    },
                new SelectListItem
                    {
                        Text = "Seattle Washington", Value = "1"
                    },
                new SelectListItem
                    {
                        Text = "Los Angles California", Value = "2"
                    }
            };

            ViewBag.MissionList = missionList;
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Contact()
        {
            List<SelectListItem> subjectList = new List<SelectListItem>()
            {
                new SelectListItem
                    {
                        Text = "", Value = "0"
                    },
                new SelectListItem
                    {
                        Text = "Subject One", Value = "1"
                    },
                new SelectListItem
                    {
                        Text = "Subject Two", Value = "2"
                    }
            };

            ViewBag.SelectList = subjectList;
            return View();
        }
    }
}