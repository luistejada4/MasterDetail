﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetail.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }
    }
}