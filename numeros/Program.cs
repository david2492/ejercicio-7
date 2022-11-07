using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace numeros_consola
{
    class Program
    {

        static void Main(string[] args)
        {
            int num, num1 = 0, num2 = 0, num3 = 0, num4 =0 , num5 = 0, num6 =0 , num7 = 0, num8 = 0;
            int cont3= 0, cont4= 0, cont5 = 0, cont6 = 0;
            int cont = 0; 
            int pot = 0; //potencia
            
            

            do
            {                
                Console.WriteLine("Ingrese ingrese un entero de 3 a 6");
                num = int.Parse(Console.ReadLine());

                if (num >= 3 && num <= 6)
                {
                    cont++;
                    if (cont == 1) num1 = num;
                    if (cont == 2) num2 = num;
                    if (cont == 3) num3 = num;
                    if (cont == 4) num4 = num;
                    if (cont == 5) num5 = num;
                    if (cont == 6) num6 = num;
                    if (cont == 7) num7 = num;
                    if (cont == 8) num8 = num;

                    if (num == 3) cont3++;
                    if (num == 4) cont4++;
                    if (num == 5) cont5++;
                    if (num == 6) cont6++;
                }
                else
                {
                    Console.WriteLine("ERROR: Valor fuera de rango");
                    Console.WriteLine("Ingrese ingrese un entero de 3 a 6");                    
                }

            } while (cont < 8);


            Console.WriteLine("Los numeros ingresados Fueron:");
            Console.WriteLine("> " + num1.ToString());
            Console.WriteLine("> " + num2.ToString());
            Console.WriteLine("> " + num3.ToString());
            Console.WriteLine("> " + num4.ToString());
            Console.WriteLine("> " + num5.ToString());
            Console.WriteLine("> " + num6.ToString());
            Console.WriteLine("> " + num7.ToString());
            Console.WriteLine("> " + num8.ToString());



            Console.WriteLine("RESULTADOS DE LOS NUMEROS INGRESADOS");
            pot = 1;
            for (int i = 1; i<= cont3; i++)
            {
                pot *= 3;
            }
            Console.WriteLine("El Numero 3 fue ingresado  " + cont3.ToString() + " veces, 3 a la " + cont3.ToString() + " es " + pot);

            pot = 1;
            for (int i = 1; i <= cont4; i++)
            {
                pot *= 4;
            }
            Console.WriteLine("El Numero 4 fue ingresado  " + cont4.ToString() + " veces, 4 a la " + cont4.ToString() + " es " + pot);

            pot = 1;
            for (int i = 1; i <= cont5; i++)
            {
                pot *= 5;
            }
            Console.WriteLine("El Numero 5 fue ingresado  " + cont5.ToString() + " veces, 5 a la " + cont5.ToString() + " es " + pot);

            pot = 1;
            for (int i = 1; i <= cont6; i++)
            {
                pot *= 6;
            }
            Console.WriteLine("El Numero 6 fue ingresado  " + cont6.ToString() + " veces, 6 a la " + cont6.ToString() + " es " + pot);


            Console.ReadKey();
        }

    }
}
