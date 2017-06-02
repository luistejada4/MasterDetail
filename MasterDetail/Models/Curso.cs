﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetail.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Estudiante> Estudiantes { get; set; }

    }
}