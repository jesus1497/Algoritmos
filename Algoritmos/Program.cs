using System;
using System.Linq;

namespace Algoritmos
{
    class Program
    {
        static void tablero()
        {
            int i;
            int j;
            Console.WriteLine("Tamaño del tablero?");
            int x = int.Parse(Console.ReadLine());
            for (i = 0; i < x; i++)
            {
                for (j = 0; j < x; j++)
                {
                    if (((j % 2 == 0) && (i % 2 == 1)) || ((i % 2 == 0) && (j % 2 == 1)))
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write("X");
                    }
                }
                Console.WriteLine();
            }
        }
        static void triangulo()
        {
            int x, y, i, j, k;
            Console.WriteLine("Tamaño del rombo?");
            x = int.Parse(Console.ReadLine());
            y = x;
            //For para generar el espacio blanco
            for (i = 0; i < x; i++)
            {
                for (k = 0; k < y; k++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
                y = y - 1;
            }
        }
        static void rombo()
        {
            int x, y, i, j, k;
            Console.WriteLine("Tamaño del rombo?");
            x = int.Parse(Console.ReadLine());
            y = x;
            for (i = 0; i < x; i++)
            {
                for (k = 0; k < y - 1; k++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j <= i; j++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
                y = y - 1;
            }
            for (i = x - 1; i > 0; i--)
            {
                for (k = 0; k < y + 1; k++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
                y = y + 1;
            }
        }
        static void trianguloPascal()
        {
            int pisos, y;
            int[] arreglo = new int[1];
            int i, j, k;
            //Mostramos un mensaje y capturarlos el dato ingresado desde la consola
            Console.WriteLine("Ingrese el numero de pisos");
            pisos = int.Parse(Console.ReadLine());
            y = pisos;
            //Declaramos el primer ciclo for que va recorrer dependiendo el dato ingresado
            //que esta almacenado en la variable pisos
            for (i = 1; i <= pisos; i++)
            {
                //colocamos un arreglo y colocamos la variable i del ciclo for que sera el tamaño que tendra
                //el arreglo cada vez que el ciclo for se ejecute
                int[] pascal = new int[i];
                //ciclo for que se decrementa para formar el triangulo
                for (j = 1; j < y; j++)
                {
                    Console.Write(" ");
                }
                /*Console.WriteLine("");
                y = y - 1;*/
                //ciclo for que genera la suma de las cifras
                for (k = 0; k < i; k++)
                {
                    //Condicion que evalua la variable del ciclo for
                    if (k == 0 || k == (i - 1))
                    {
                        pascal[k] = 1;
                    }
                    else
                    {
                        //sumamos los numeros que estan en cada posicion
                        //del arreglo para formar el triangulo
                        pascal[k] = arreglo[k] + arreglo[k - 1];
                    }
                    Console.Write(pascal[k]);
                    Console.Write(" ");
                }
                arreglo = pascal;//Para mantener la fila anterior
                Console.WriteLine(" ");
                y = y - 1;
            }
        }
        static void reloj()
        {
            double hora;
            double minutos;
            Console.WriteLine("Introduce hora");
            hora = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce minutos");
            minutos = double.Parse(Console.ReadLine());
            double minT = 60;
            double anguloH = 30;//angulo d c/hora
            double anguloM = 6;//angulo de c/minuto
            double angulo;//Calculo del angulo en horas
            double regla = (minutos * anguloH) / minT;
            double anguloMinH = anguloM * minutos;
            angulo = anguloH * hora;
            angulo = angulo + regla;
            //anguloMinH = anguloMinH*anguloH;
            if ((hora * 5) < minutos)
            {
                angulo = anguloMinH - angulo;
            }
            else
            {
                angulo = angulo - anguloMinH;
            }
            Console.WriteLine("Angulo de la hora  " + hora + ":" + minutos);
            Console.WriteLine(angulo);

        }
        static void mcdu()
        {
            int x;
            Console.WriteLine("Introduce un numero > 0 & <= 9999");
            x = int.Parse(Console.ReadLine());
            int m, c, d, u;
            m = (x / 1000);
            c = (x - (m * 1000)) / 100;
            d = (x - (m * 1000) - (c * 100)) / 10;
            u = (x - (m * 1000) - (c * 100) - (d * 10));
            Console.WriteLine("Millares: {0}, Centenas: {1}, Decenas: {2}, Unidades: {3}",m,c,d,u);
        }
        static void chicharronera()
        {
            int a, b, c;
            Console.WriteLine("Dada la ecuacion: Ax^2 + Bx + C");
            a = int.Parse(Console.ReadLine());
        }
        static void x(int number){
            if(number>0){
                x(number / 2);
                Console.WriteLine(number%2);
            }
        }
        static void palindromo()
        {
            Console.WriteLine("Introduce una palabra y te diré si es palíndroma :) ");
            String palabra = Console.ReadLine();
            if (esPalindroma(palabra)) 
                Console.WriteLine("Es palíndroma");
            else 
                Console.WriteLine("NO es palíndroma");
        }
        static Boolean esPalindroma(String cadena)
        {
            Console.WriteLine("Función llamada con => " + cadena);
            if (cadena.Length < 2) 
                return true;
            Console.WriteLine("Izquierda " + cadena[0]);
            Console.WriteLine("Derecha " + cadena[cadena.Length - 1]);
            Console.WriteLine();
            if ((cadena[0] == cadena[cadena.Length - 1]))
            {
                return esPalindroma(cadena.Substring(1, cadena.Length - 2));
            }
            else
            {
                Console.WriteLine(cadena[0]);
                Console.WriteLine(cadena[0] != cadena.Length - 1);
                if ((!cadena[0].Equals(cadena[cadena.Length - 1])) || (cadena[0].Equals("")))
                {
                    return esPalindroma(cadena.Substring(1, cadena.Length - 1));
                }
                else
                {
                    if((!cadena[0].Equals(cadena[cadena.Length - 1])) || (cadena[cadena.Length - 1].Equals("")))
                    {
                        return esPalindroma(cadena.Substring(0, cadena.Length - 2));
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        static void fibonnaci()
        {
            int a, b, c,i;
            a = 0;
            b = 1;
            Console.WriteLine("Hasta que numero de la serie?");
            int x = int.Parse(Console.ReadLine());
            for(i=0;i<x;i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write(c);
                Console.Write(" ");
            }
        }
        static void factorial()
        {
            int i, j;
            j = 1;
            Console.WriteLine("Hasta que numero factorial?");
            int x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                Console.Write("0=1");
            }
            else
            {
                Console.Write(j);
                for (i = 2; i <= x; i++)
                {
                    j = i * j;
                    Console.Write("x" + i);
                }
                Console.Write("=" + j);
            }
        }
        static void Main(string[] args)
        {
            //tablero();
            //triangulo();
            //rombo();
            //trianguloPascal();
            //reloj();
            //mcdu();
            //chicharronera();
            //palindromo();
            //fibonnaci();
            //factorial();
            x(45);
        }
    }
}
