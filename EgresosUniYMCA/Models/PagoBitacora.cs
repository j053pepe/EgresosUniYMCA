﻿using System;
using System.Collections.Generic;

namespace EgresosUniYMCA.Models
{
    public partial class PagoBitacora
    {
        public int PagoId { get; set; }
        public string ReferenciaId { get; set; }
        public int AlumnoId { get; set; }
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public int SubperiodoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public int CuotaId { get; set; }
        public decimal Cuota { get; set; }
        public decimal Promesa { get; set; }
        public int EstatusId { get; set; }
        public bool EsEmpresa { get; set; }
        public bool EsAnticipado { get; set; }
        public int PeriodoAnticipadoId { get; set; }
        public string Observaciones { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaBitacora { get; set; }
    }
}
