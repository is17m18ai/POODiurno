using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POODiurno
{
    class Contacto
    {
        public string Nome { get; set; }
        public string CargoDesempenhado { get; set; }
        public string ContactoTelefonico { get; set; }
        public override string ToString()
        {
            return $"NOME: {Nome} é {CargoDesempenhado}";
        }
        
    }
}
