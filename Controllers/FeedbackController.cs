using System.Collections.Generic;
using System.Web.Mvc;
using pr7.Models;

namespace pr7.Controllers
{
    public class FeedbackController : Controller
    {
        private static List<Feedback> feedbackList = new List<Feedback>();

        public ActionResult Index()
        {
            return View();
        }

        // Give Feedback Page
        public ActionResult Create()
        {
            return View(new Feedback());
        }

        // Submit Feedback
        [HttpPost]
        public ActionResult Create(Feedback feedback)
        {
            if (!ModelState.IsValid)
            {
                return View(feedback);
            }

            feedback.Id = feedbackList.Count + 1;
            feedbackList.Add(feedback);

            return RedirectToAction("ViewFeedback");
        }

        // View Feedback Page
        public ActionResult ViewFeedback()
        {
            return View(feedbackList);
        }
    }
}