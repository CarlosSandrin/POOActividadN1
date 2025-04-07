using System;

//1.Diseño de clase para un autobús:
//• Crea una clase llamada "Autobús" que herede de la clase "Vehículo". Agrega
//atributos específicos como capacidad de pasajeros, número de puertas, número de
//asientos, etc. Implementa métodos para carga y descarga de pasajeros.

//2. Diseño de clase para un vehículo:
//• Define una clase llamada "Vehículo" con atributos como modelo, marca, año,
//número de serie, etc. Incluye métodos para arrancar, detener, acelerar y frenar, que a
//su vez sea clase padre de 3 clases más.

namespace EjerciciosClase3
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Vehiculo
    {
        public string Marca;
        public string Modelo;
        public int Anio;
        public int NumeroSerie;
        public bool EsAutomatico;
        

        public void arrancar()
        {
            Console.WriteLine($"El Vehiculo está en movimiento --->");
        }

        public void detener()
        {
            Console.WriteLine($"El Vehiculo está detenido");
        }

        public void acelerar()
        {
            Console.WriteLine($"El Vehiculo está acelerando");
        }

        public void frenar()
        {
            Console.WriteLine($"El Vehiculo está frenando");
        }

        //arrancar, detener, acelerar y frenar,

    }

    class Autobus : Vehiculo
    {
        public int CantidadPasajeros;
        public int NumeroAsientos;
        public int CantidadPuertas;
        public int Linea;

        public void CargaDePasajeros()
        {
            Console.WriteLine($"El autobus se detiene y comienzan a subir pasajeros...");
        }

        public void DescargaDePasajeros()
        {
            Console.WriteLine($"El autobus se detiene y comienzan a bajar pasajeros...");
        }
    }

    class Coche : Vehiculo
    {
        public int CantidadDeRuedas;
        public int CapacidadBaul;
        public int CantidadPuertas;

        public void llenarBaul()
        {
            Console.WriteLine($"Se llena baul...");
        }

        public void realizarGiros()
        {
            Console.WriteLine($"El auto dobla...");
        }

        class Avion : Vehiculo
        {
            public int CantidadDeRuedas;
            public int CapacidadValijero;
            public int CantidadPuertas;
            public int CantidadDeAlas;

            public void despegar()
            {
                Console.WriteLine($"El avión puede despegar...");
            }

            public void aterrizar()
            {
                Console.WriteLine($"El avión puede aterrizar...");
            }
        }
    }

//    3. Diseño de clase para un animal:
//• Define una clase "Animal" con atributos como especie, edad, género, etc. Incluye
//métodos para alimentar, reproducir y hacer sonidos característicos, que a su vez sea
//clase padre de 2 clases más con sus métodos y atributos cada una.

    class Animal
    {
        public string Nombre;
        public int Edad;
        public string Especie;
        public string Genero;
        public string sonido;
        public void Comer()
        {
            Console.WriteLine($"El animal está comiendo...");
        }
        public void Reproducir()
        {
            Console.WriteLine($"El animal está durmiendo...");
        }
        public void SonidoCaracteristico()
        {
            Console.WriteLine($"El animal está" + this.sonido);
        }
    }

    class Perro : Animal
    {
        public string Raza;
        public string Color;
        public string Tamaño;
        public void Ladrar()
        {
            Console.WriteLine($"El perro está ladrando...");
        }
        public void Aullar()
        {
            Console.WriteLine($"El perro está aullando...");
        }
    }

    class Gato : Animal
    {
        public string Raza;
        public string Color;
        public string Tamaño;
        public void Maullar()
        {
            Console.WriteLine($"El gato está maullando...");
        }
        public void Ronronear()
        {
            Console.WriteLine($"El gato está ronroneando...");
        }
    }
//    4. Diseño de clase para un libro:
//• Define una clase llamada "Libro" con atributos como título, autor, año de
//publicación, género, etc.Incluye métodos para abrir, cerrar y leer.
//5. Diseño de clase para una biblioteca:
//• Crea una clase "Biblioteca" con atributos como nombre, ubicación, horario de
//apertura, etc.Define métodos para agregar libros al inventario, prestar libros,
//devolver libros y buscar libros por título o autor.
    class Biblioteca
    {
        public string Nombre;
        public string Ubicacion;
        public string HorarioApertura;
        public string HorarioCierre;
        public void AgregarLibro()
        {
            Console.WriteLine($"Se agrega un libro a la biblioteca...");
        }
        public void PrestarLibro()
        {
            Console.WriteLine($"Se presta un libro de la biblioteca...");
        }
        public void DevolverLibro()
        {
            Console.WriteLine($"Se devuelve un libro a la biblioteca...");
        }
        public void BuscarLibro()
        {
            Console.WriteLine($"Se busca un libro en la biblioteca...");
        }
    }

    class Libro : Biblioteca
    {
        public string Titulo;
        public string Autor;
        public int AnioPublicacion;
        public string Genero;
        public void Abrir()
        {
            Console.WriteLine($"Se abre el libro...");
        }
        public void Leer()
        {
            Console.WriteLine($"Se lee el libro...");
        }
        public void Cerrar()
        {
            Console.WriteLine($"Se cierra el libro...");
        }
    }
    
    class Revista : Biblioteca
    {
        public string Titulo;
        public string Autor;
        public int AnioPublicacion;
        public string Genero;
        public void Abrir()
        {
            Console.WriteLine($"Se abre la revista...");
        }
        public void Leer()
        {
            Console.WriteLine($"Se lee la revista...");
        }
        public void Cerrar()
        {
            Console.WriteLine($"Se cierra la revista...");
        }
    }

//   6 Diseño de clase para un cajero automático:
//• Crea una clase "CajeroAutomático" con atributos como ubicación, número de serie,
//saldo disponible, etc.Implementa métodos para retirar dinero, depositar dinero y
//consultar saldo.
    class CajeroAutomatico
    {
        public string Ubicacion;
        public int NumeroSerie;
        public double SaldoDisponible;
        public void RetirarDinero()
        {
            Console.WriteLine($"Se retira dinero del cajero automático...");
        }
        public void DepositarDinero()
        {
            Console.WriteLine($"Se deposita dinero en el cajero automático...");
        }
        public void ConsultarSaldo()
        {
            Console.WriteLine($"Se consulta el saldo del cajero automático...");
        }
    }
//    7. Diseño de clase para un sistema de gestión de empleados:
//• Define clases para representar empleados, departamentos, roles, etc.Incluye métodos
//para agregar empleados, asignar roles, calcular salarios, etc.
    class Empleado
    {
        public string Nombre;
        public string Apellido;
        public int Edad;
        public string Puesto;
        public double Sueldo;
        public void Trabajar()
        {
            Console.WriteLine($"El empleado está trabajando...");
        }
        public void Descansar()
        {
            Console.WriteLine($"El empleado está descansando...");
        }
    }

}
