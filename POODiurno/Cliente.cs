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

        public ICollection<Contacto> Contactos = new List<Contacto>();

        public ICollection<Funcionario> Funcionarios = new List<Funcionario>(); 
        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.Append($"Denominacao Social: { DenominacaoSocial }")
              .Append($"NIF: { NIF}")
              .AppendLine()
              .AppendLine("\t*** CONTACTOS ***");
            foreach(var contacto in Contactos)
            {
                sb.AppendLine($"\t{contacto.Nome} é {contacto.CargoDesempenhado}");
            };
            sb.AppendLine();
            sb.Append("\t*** FUNCIONÁRIOS***");
            sb.AppendLine();
            foreach(var funcionario in Funcionarios)
            {
                sb.Append($"\t{funcionario}");
            }

            return sb.ToString();
        }
        
        }
            

}


