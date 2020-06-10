using ApiMascota.WebApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMascota.WebApi.Data
{
    public class ApiMascotasContext : DbContext
    {
        public ApiMascotasContext(DbContextOptions<ApiMascotasContext> options) : base(options)
        {


        }

        public DbSet<Propietario> Propietarios { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }




    }
}
