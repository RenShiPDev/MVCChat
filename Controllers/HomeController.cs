using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCChat.Models;
using System.Diagnostics;

namespace MVCChat.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext db;
        public HomeController(AppDbContext AppDbContexts)
        {
            db = AppDbContexts;
        }

        public async Task<IActionResult> Index()
        {
            ViewMessages vm = new ViewMessages();
            vm.Text = lastText;
            vm.Messages = await db.Messages.ToListAsync();
            return View(vm);
        }

        string lastText;
        [HttpPost]
        public async Task<IActionResult> Create(Message msg)
        {
            var aaa = msg.Text;
            lastText = msg.Text;

            db.Messages.Add(msg);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
