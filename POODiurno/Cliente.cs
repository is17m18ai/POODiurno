using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POODiurno
{
    class Cliente
    {
        //atributos
            // string nif;
            //string denominacaoSocial, resudenciaFiscal;
            //double volumeNegociosAnoAnterior = 0d; 

        //propriedades
        public string NIF { get; set; }
        public string DenominacaoSocial { get; set; }
        public string ResidenciaFiscal { get; set; }
        public double VolumeNegocios { get; set; }
        public ICollection<Contactos> Contactos =
            new List<Contactos>();
        public ICollection<Funcionario> Funcionario 
            = new List<Funcionario>(); 
        
        }
            

}


