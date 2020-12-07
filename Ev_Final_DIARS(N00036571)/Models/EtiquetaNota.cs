using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ev_Final_DIARS_N00036571_.Models
{
    public class EtiquetaNota
    {
        public int Id { get; set; }
        public int Id_etiqueta { get; set; }
        public int IdNota { get; set; } 
        public Etiqueta Etiqueta { get; set; }
    }
}
