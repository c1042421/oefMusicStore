using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicStore.Data;
using MusicStore.Models;
using Microsoft.AspNetCore.Authorization;

namespace MusicStore.Areas.Admin.Controllers
{
    [Area("Admin")]
  
    public class MaintainController : Controller
    {
        private readonly StoreContext _context;

        public MaintainController(StoreContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}
