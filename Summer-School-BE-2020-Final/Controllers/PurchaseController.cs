using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Summer_School_BE_2020_Final.Models;

namespace Summer_School_BE_2020_Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private ApplicationContext db { get; set; }
        public PurchaseController (ApplicationContext context)
        {
            db = context;
        
        }
        [Authorize]
        [HttpGet("ViewPurchase")]
        public Task<List<Purchase>> ViewPurchases()
        {

            return db.purchases.ToListAsync();
        
        }
    }
}
