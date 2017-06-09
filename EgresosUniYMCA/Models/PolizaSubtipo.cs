﻿using System;
using System.Collections.Generic;

namespace EgresosUniYMCA.Models
{
    public partial class PolizaSubtipo
    {
        public PolizaSubtipo()
        {
            PolizaConfiguracion = new HashSet<PolizaConfiguracion>();
            PolizaConsecutivo = new HashSet<PolizaConsecutivo>();
            PolizaCuadre = new HashSet<PolizaCuadre>();
            PolizaNumeracion = new HashSet<PolizaNumeracion>();
            ReferenciadoArchivoBitacora = new HashSet<ReferenciadoArchivoBitacora>();
        }

        public int PolizaSubtipoId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<PolizaConfiguracion> PolizaConfiguracion { get; set; }
        public virtual ICollection<PolizaConsecutivo> PolizaConsecutivo { get; set; }
        public virtual ICollection<PolizaCuadre> PolizaCuadre { get; set; }
        public virtual ICollection<PolizaNumeracion> PolizaNumeracion { get; set; }
        public virtual ICollection<ReferenciadoArchivoBitacora> ReferenciadoArchivoBitacora { get; set; }
    }
}
