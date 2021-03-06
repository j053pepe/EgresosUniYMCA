﻿using System;
using System.Collections.Generic;

namespace EgresosUniYMCA.Models
{
    public partial class Docente
    {
        public Docente()
        {
            DocenteEstudio = new HashSet<DocenteEstudio>();
        }

        public int DocenteId { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public DateTime? FechaAlta { get; set; }
        public TimeSpan? HoraAlta { get; set; }
        public int? Anio { get; set; }
        public int? PeriodoId { get; set; }
        public int? UsuarioId { get; set; }
        public int? EstatusId { get; set; }

        public virtual DocenteDetalle DocenteDetalle { get; set; }
        public virtual ICollection<DocenteEstudio> DocenteEstudio { get; set; }
    }
}
