using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cruzen.Data;
using Microsoft.AspNetCore.Authorization;
using System.Collections;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Cruzen.Controllers
{
    public class CruiseController : Controller
    {

        private readonly CruiseDBContext _context;
        public CruiseController(CruiseDBContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CruiseDump()
        {
            return View(_context.Cruise.ToList());
        }
        
        // GET: /<controller>/
        [HttpGet]
        [AllowAnonymous]
        public JsonResult GetCruises(string zip)
        {
            return new JsonResult (_context.Cruise
                .Include(c => c.Location)
                    .ThenInclude(l => l.State)
                .Include(c => c.Type)
                .Include(c => c.Status)
                //.Where(c => c.Location.Zip.Equals(zip))
                .ToList());
        }
    }
}
