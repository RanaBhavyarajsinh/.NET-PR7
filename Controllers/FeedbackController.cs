using System.Collections.Generic;
using System.Web.Mvc;
using pr7.Models;

namespace pr7.Controllers
{
    public class FeedbackController : Controller
    {
        private static List<Feedback> feedbackList = new List<Feedback>();

        // First Page
        public ActionResult Index()
        {
            return View();
        }

        // Give Feedback Page
        public ActionResult Create()
        {
            return View();
        }

        // Submit Feedback
        [HttpPost]
        public ActionResult Create(Feedback feedback)
        {
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