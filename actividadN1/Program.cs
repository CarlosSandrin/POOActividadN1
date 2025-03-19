using System;
using System.Net;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace ActividadN1
{
    //Crear 2 (dos) clases  con C# (visual studio o vs code) de alguna entidad del mundo real (pueden ser personas, casas, instituciones, etc..) definiendo al menos 3 atributos y 2 métodos que sean propios de la clase.

    //Para enviar la tarea, se debe cargar los archivos en un repositorio de GitHub y responder a éste foro con la url del mismo.

    //No se aceptaran archivos adjuntos ni documentos de texto.

    //Ejemplo para la creación de clases: https://github.com/lautaroifts11/hello_git archivo Program.cs

    //El foro se encontrará habilitado hasta el día domingo 23 de marzo a las 23:59.

    //Muchas gracias!

    public class Program
    {
        static void Main()
        {

            
            Persona persona1 = new Persona("Charly", 35);
            persona1.Saludar();
            persona1.tomarMate();
            Console.WriteLine("Ingrese una tecla para seguir.");
            Console.ReadKey();
            Tv Tele = new Tv("Sony", 500);
            Tele.PresentarTv();
            Tele.Encender();

        }

        public class Persona
        {
            public string nombre;
            public int edad;
            public int altura;
            public int peso;


            public Persona(string name, int age)
            {
                nombre = name;
                edad = age;
            }

            public void Saludar()
            {
                Console.WriteLine($"Hola, soy {nombre} y tengo {edad} años.");
            }

            public void tomarMate()
            {
                Console.WriteLine("Estoy tomando mates.");
            }
        }

        public class Tv
        {
            public string marca;
            public string color;
            public int alto;
            public int ancho;
            public int cantCanales;

            public Tv(string mark, int cantCan)
            {
                marca = mark;
                cantCanales = cantCan;
            }

            public void PresentarTv()
            {
                Console.WriteLine($"Este Televisor es de marca: {marca} y tiene {cantCanales} canales.");
            }

            public void Encender()
            {
                Console.WriteLine("El televisor se ha encendido.");
            }
        }

    }
}
