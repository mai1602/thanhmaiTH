using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Baitap.Models;

    public class LTQDD : DbContext
    {
        public LTQDD (DbContextOptions<LTQDD> options)
            : base(options)
        {
        }

        public DbSet<Baitap.Models.LopHoc> LopHoc { get; set; } = default!;
    }
