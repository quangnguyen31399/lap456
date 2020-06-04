using NguyenLeHongQuang_lab456.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenLeHongQuang_lab456.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Create()
        {
            return View();
        }
    }
}