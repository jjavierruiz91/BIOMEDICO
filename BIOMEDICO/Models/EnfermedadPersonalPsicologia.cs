//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BIOMEDICO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EnfermedadPersonalPsicologia
    {
        public int IdPersonal { get; set; }
        public string SustanciasPsicoactivasPer { get; set; }
        public string EnferMentalesPer { get; set; }
        public string DiabetesPer { get; set; }
        public string EnferCoronariasPer { get; set; }
        public string ObesidadPer { get; set; }
        public string CancerPer { get; set; }
        public string HipertensionPer { get; set; }
        public string EnferAlergicasPer { get; set; }
        public string AsmaPer { get; set; }
        public string ComplicacionesPartoPer { get; set; }
        public string LesionesPer { get; set; }
        public string CualesLesionesPer { get; set; }
        public string TrabajoConcentrarsePer { get; set; }
        public string DolorMuscularPer { get; set; }
        public string PartoCesareaPer { get; set; }
        public string PartoNormalPer { get; set; }
        public string LesionadoActualPer { get; set; }
        public string DificultadSueñoPer { get; set; }
        public string DolorCabezaPer { get; set; }
        public string CirugiasPer { get; set; }
        public string ApetitoPer { get; set; }
        public string CansadoPer { get; set; }
        public string OtroPer { get; set; }
        public string HistoriadelProblemaPer { get; set; }
        public Nullable<int> IdDatosDemograficos { get; set; }
    
        public virtual DemograficoPsicologia DemograficoPsicologia { get; set; } = new DemograficoPsicologia();
    }
}
