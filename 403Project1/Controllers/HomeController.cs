using _403Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403Project1.Controllers
{
    public class HomeController : Controller
    {

        public static List<FAQ> faqs = new List<FAQ>();

        List<string> subjectList = new List<string>();

    // GET: Home
    public ActionResult Index()
        {
            FAQ newFAQ = new FAQ();
            newFAQ.QuestionPoster = "Future Missionary 1";
            newFAQ.Question = "How many missionaries are there in this mission?";
            newFAQ.AnswerPoster = "Previous Missionary 1";
            newFAQ.Answer = "There are always anywhere from 150 to 200 missionaries in this mission at a time";

            faqs.Add(newFAQ);

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

        public ActionResult MissionFAQ()
        {
            return View(faqs);
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