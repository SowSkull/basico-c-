﻿using System;

namespace CoreEscuela
{
    class Escuela
    {
        public string nombre;
        public string direccion;
        public int añoFundacion;
        public string ceo;
        public void Timbrar()
        {
            Console.Beep(3000,3000);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("Hello World!");
          var miEscuela = new Escuela();

          miEscuela.nombre = "Platzi Academy";
          miEscuela.direccion = "carrera 9 calle 72";
          miEscuela.añoFundacion = 2017;
          Console.WriteLine("Aqui timbrooooo");
          miEscuela.Timbrar();
        }
    }
}
