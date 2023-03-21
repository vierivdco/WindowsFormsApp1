using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            String opcion;
            int a, b;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Resta de dos números");
                Console.WriteLine("[3] Producto de dos números");
                Console.WriteLine("[4] Cociente de dos números");
                Console.WriteLine("[5] imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[6] Los primeros 10 números primos");
                Console.WriteLine("[7] Convertir grados C a F");
                Console.WriteLine("[8] Convertir grados F a C");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La diferencia de {0} y {1} es {2}", a, b, Resta(a, b));
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El producto de {0} y {1} es {2}", a, b, Multi(a, b));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La división de {0} entre {1} es {2}", a, b, Division(a, b));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Calculando...");
                        Primos();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese el número de grados C");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La conversión de {0} grados C a F es igual a {1}", a, Cel(a));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese el número de grados F");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La conversión de {0} grados F a C es igual a {1}", a, Far(a));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));
        }
        static int Suma(int a, int b)
        {
            return a + b;
        }
        
        static void Raiz()
        {
            for  (int i = 1; i < 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}",i,Math.Sqrt(i));
            }
        }

        static int Resta(int a, int b)
        {
            return a - b;
        }

        static int Multi(int a, int b)
        {
            return a * b;
        }

        static int Division(int a, int b)
        {
            return a / b;
        }

        static void Primos() {
            int cont = 0;
            int n = 2;

            while (cont < 10)
            {
                bool isPrime = true;

                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(n + " ");
                    cont++;
                }

                n++;
            }

        }

        static int Cel(int a)
        {
            return ((9 * a) / 5) + 32;
        }

        static int Far(int a)
        {
            return (5 * (a - 32)) / 9;
        }
    }
}
