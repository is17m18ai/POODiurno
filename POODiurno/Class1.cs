using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POODiurno
{
    class Program
    {
       static void Main(string[] args)
        {
            Cliente cli = new Cliente();
            cli.DenominacaoSocial = "Ismai";
            cli.NIF = "123456789";
            Contactos prof = new Contactos();
            prof.Nome = "Jose Lapa";
            prof.CargoDesempenhado = "Aluno";
            cli.Contactos.Add(prof);

            var categorias = new[]
            {
                new Categoria { Descricao = "Docente", VencimentoBase = 1000},
                new Categoria { Descricao = "Administrativo", VencimentoBase = 900},
                new Categoria { Descricao = "Operacional", VencimentoBase = 800},
            };

            Funcionario f = new Funcionario { NIF = "123", NISS = "123",
                Nome = "Funcionario 1", Categoria = categorias[0], };
            cli.Funcionario.Add(f);
                

            Console.Out.WriteLine("    ***Cliente***    ");
            Console.WriteLine($"NOME: {cli.DenominacaoSocial}");
            Console.WriteLine($"NIF: { cli.NIF}");
            Console.WriteLine("    ***contactos***    ");
            foreach(Contactos c in cli.Contactos)
            {
                Console.WriteLine($"    {c.Nome} é {c.CargoDesempenhado}");
            }



        }
    }
}
