using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POODiurno
{
    class Funcionario
    {
        public string NIF { get; set; }
        public string NISS { get; set; }
        public string Nome { get; set; }
        public Categoria Categoria { get; set; }
        public override string ToString()
        {
            
            return $"F: {Nome} ({NIF}) é {Categoria.Descricao} com vencimento base {Categoria.VencimentoBase:0.00} euros";
        }
        public DateTime DataNascimento { get; set; }
        public bool IsMesAniversario 
            => DataNascimento.Month == DateTime.Now.Month;
            
        }
    }
