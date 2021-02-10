using Microsoft.EntityFrameworkCore;
using Parcial1_AP2_VictorPalma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_AP2_VictorPalma.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulos> Articulos { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }
}
