using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PUBG.Data;

namespace PUBG.Controllers
{
    public class BaseController : Controller
    {
        protected readonly ApplicationDbContext context;

        public BaseController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
    }
}