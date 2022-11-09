using MedPoint.Data;
using Microsoft.AspNetCore.Mvc;

namespace MedPoint.Controllers
{
    public class AccountsController : Controller
    {
        private readonly AppDBContext _context;
        public AccountsController(AppDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Users.ToList();
            return View(data);
        }
    }
}
