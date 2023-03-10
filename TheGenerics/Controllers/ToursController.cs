using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheGenerics.Data;

namespace TheGenerics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToursController : ControllerBase
    {
        private readonly TheGenericsContext _context;

        public ToursController(TheGenericsContext context)
        {
            _context = context;
        }

        // GET: api/Tours
        [HttpGet]
        public Tour[] GetTour()
        {
            return _context.Tour.ToArray();
        }
    }
}
