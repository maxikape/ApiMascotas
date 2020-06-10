using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMascota.WebApi.Data.Entities
{
    public class Propietario
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int Edad { get; set; }

        public string Domicilio { get; set; }
    }
}
