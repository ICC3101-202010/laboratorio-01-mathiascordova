using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_Cordova_Mathias
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Bob", "Kunga");
            Console.WriteLine(persona.Name());
            persona.Lanzar();

        }
    }

}

