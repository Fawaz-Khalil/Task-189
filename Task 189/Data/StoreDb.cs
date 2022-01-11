using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_189.Models;

namespace Task_189.Data
{
     public class StoreDb : DbContext
    {

      public StoreDb(DbContextOptions<StoreDb> options) : base(options)
        {

        }
            public DbSet<OrderModel> Orders { get; set; }
        }
    }

