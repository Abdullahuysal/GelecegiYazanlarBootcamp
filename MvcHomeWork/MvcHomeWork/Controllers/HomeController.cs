using Microsoft.AspNetCore.Mvc;
using MvcHomeWork.Models;
using MvcHomeWork.Models.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcHomeWork.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User user)
        {
            BirthdayDbContext dbContext = new BirthdayDbContext();
            participant participant = new participant();
            participant.FirstName = user.FirstName;
            participant.SecondName = user.SecondName;
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            dbContext.Participants.Add(participant);
            dbContext.SaveChanges();
            return Redirect("/Home/Participants");
        }
        public IActionResult Participants()
        {
            BirthdayDbContext dbContext = new BirthdayDbContext();
            IEnumerable<participant> katılımcılar = new List<participant>();
            katılımcılar = dbContext.Participants.Select(x => x).ToList();
            ViewBag.data = katılımcılar;
            return View();
        }
    }
}
