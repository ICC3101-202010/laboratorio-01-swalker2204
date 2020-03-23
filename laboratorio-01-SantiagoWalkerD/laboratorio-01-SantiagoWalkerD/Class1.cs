using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorio_01_SantiagoWalkerD
{
    public class Person
    {
        public string nombre;
        public string apellido;

        public Person(string Anombre, string Aapellido)
        {
            this.nombre = Anombre;
            this.apellido = Aapellido;
        }
        public void GetLanzar()
        {
            Random Num = new Random();
            int valor = Num.Next(0, 3);
            {
                if (valor == 0)
                {
                    Console.WriteLine("piedra");
                }
                else if (valor == 1)
                {
                    Console.WriteLine("papel");
                }
                else if (valor == 2)
                {
                    Console.WriteLine("tijera");
                }
            }
        }
    }
}
