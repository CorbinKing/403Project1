using _403Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/*Peter Madsen, Corbin King, Jake Saylor, Michael Jenkins*/

namespace _403Project1.Controllers
{
    public class HomeController : Controller
    {
        public static List<Mission> missions = new List<Mission>();


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

            Mission Portland = new Mission();
            Portland.mName = "Portland Oregon";
            Portland.mPresident = "Mikey Jenkins";
            Portland.mAddress = "123 Sesame St.";
            Portland.mLanguage = "Spanish";
            Portland.mClimate = "Rainy";
            Portland.mReligion = "Protestant";
            Portland.mFlag = "";
            missions.Add(Portland);

            Mission Seattle = new Mission();
            Seattle.mName = "Seattle Washington";
            Seattle.mPresident = "Peter Madsen";
            Seattle.mAddress = "555 Ventura St.";
            Seattle.mLanguage = "Spanish";
            Seattle.mClimate = "Foggy";
            Seattle.mReligion = "Protestant";
            Seattle.mFlag = "";
            missions.Add(Seattle);

            Mission Los_Angeles = new Mission();
            Los_Angeles.mName = "Los_Angeles California";
            Los_Angeles.mPresident = "Jake Saylor";
            Los_Angeles.mAddress = "555 Wombat Way";
            Los_Angeles.mLanguage = "Vietnamese";
            Los_Angeles.mClimate = "Hot";
            Los_Angeles.mReligion = "Catholic";
            Los_Angeles.mFlag = "";
            missions.Add(Los_Angeles);

            ViewBag.MissionList = missionList;
            return View();
        }

        [HttpPost]
        public ActionResult MissionFAQ(Mission myMission)
        {
            if (myMission.mNum == 0)
            {
                ViewBag.mName = "Seattle Washington";
                ViewBag.mPresident = "Peter Madsen";
                ViewBag.mAddress = "555 Ventura St.";
                ViewBag.mLanguage = "Spanish";
                ViewBag.mClimate = "Foggy";
                ViewBag.mReligion = "Protestant";
            }
            else if (myMission.mNum == 1)
            {
                ViewBag.mName = "Seattle Washington";
                ViewBag.mPresident = "Peter Madsen";
                ViewBag.mAddress = "555 Ventura St.";
                ViewBag.mLanguage = "Spanish";
                ViewBag.mClimate = "Foggy";
                ViewBag.mReligion = "Protestant";
            }
            else
            {
                ViewBag.mName = "Los_Angeles California";
                ViewBag.mPresident = "Jake Saylor";
                ViewBag.mAddress = "555 Wombat Way";
                ViewBag.mLanguage = "Vietnamese";
                ViewBag.mClimate = "Hot";
                ViewBag.mReligion = "Catholic";
            }

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