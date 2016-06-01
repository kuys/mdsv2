//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prototipo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pacientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pacientes()
        {
            this.Consultas = new HashSet<Consultas>();
        }
    
        public int IdPaciente { get; set; }
        public string Nome { get; set; }
        public int BI_CC { get; set; }
        public System.DateTime DataNascimento { get; set; }
        public int NºSNS { get; set; }
        public string Morada { get; set; }
        public string Contacto { get; set; }
        public int NIF { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consultas> Consultas { get; set; }

        public override string ToString()
        {
            return Nome + " | " + BI_CC + " | " + DataNascimento.ToShortDateString() + " | " + NºSNS + " | " + Morada + " | " + Contacto + " | " + NIF + " | " + Sexo + " | " + EstadoCivil;
        }
    }
}
