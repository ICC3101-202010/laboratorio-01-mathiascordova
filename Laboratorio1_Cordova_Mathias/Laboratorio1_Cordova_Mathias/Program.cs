using System;

namespace nombre
{

    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Bob","Kunga");
            Console.WriteLine(persona.Name());
            persona.Lanzar();
            
        }
    }

}