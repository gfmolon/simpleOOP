
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using Microsoft.VisualBasic;

namespace TesteOOP
{

    public class Program

    {
        private static void Main(string[] args)
        {

            var pessoa1 = new Guy();
            pessoa1.name = "Guilherme";
            pessoa1.cash = 100;

            var pessoa3 = new Guy() { cash = 100, name = "Angelo" };

            var pessoa2 = new Guy();
            pessoa2.name = "Vagner";
            pessoa2.cash = 100;

            var listaUsuarios = new List<Guy>();
            listaUsuarios.Add(pessoa1);
            listaUsuarios.Add(pessoa2);
            listaUsuarios.Add(pessoa3);

            Console.WriteLine(listaUsuarios[1].name);

            // transacoes

            pessoa1.GiveCash(1, pessoa2);
            pessoa2.GiveCash(1, pessoa3);
            pessoa1.GiveCash(50, pessoa3);

            Guy.mostrarLista(listaUsuarios);

            Guy.temGrana(pessoa1);


        }
    }




}
