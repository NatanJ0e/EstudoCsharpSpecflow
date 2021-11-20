using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Versatile.UIAutomatedTesting
{
    public class Teste
    {
        [Test]
       public void Test1() 
        {
            string nome = "Natan";
            int idade = 29;
            Boolean genero = true;

            Console.WriteLine($"Ola meu nome é {nome} tenho {idade} de idade e sou homem {genero}" );
        }

    }
}
