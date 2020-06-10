﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMascota.WebApi.Data.Entities
{
    public class Mascota
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int Edad { get; set; }

        public string Raza { get; set; }
    }
}
