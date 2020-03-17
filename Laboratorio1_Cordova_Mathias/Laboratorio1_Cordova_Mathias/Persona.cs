using System;
using System.Collections.Generic;
using System.Text;

namespace nombre
{
    public class Persona
    {
        public string Nombre;
        public string Apellido;

        public void Lanzar()
        {
            Random random = new Random();
            Console.WriteLine(random.Next(0, 3));
        }

    }
}