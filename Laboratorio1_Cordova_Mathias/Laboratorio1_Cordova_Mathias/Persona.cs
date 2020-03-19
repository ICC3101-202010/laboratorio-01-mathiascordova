using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_Cordova_Mathias
{
    public class Persona
    {
        private string Nombre;
        private string Apellido;
        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;

        }

        public void Lanzar()
        {
            Random random = new Random();
            Console.WriteLine(random.Next(0, 3));
        }

        public string Name()
        {
            return $"{Nombre} {Apellido}";


        }

    }
}

