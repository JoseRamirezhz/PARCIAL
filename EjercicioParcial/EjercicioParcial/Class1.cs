using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioParcial
{
    public class Class1
    {
         public void Multiplicar() 
        {
            int resp = 0; 
             int n1;
             int n2;
             int num1;
             Console.WriteLine("ingrese un numero: ");
             num1 = int.Parse(Console.ReadLine());
             if (num1 > 1 && num1 > 0)
             {
                 Console.WriteLine("ingrese otro nuevo numero: ");
                 num1 = int.Parse(Console.ReadLine());
             }
            
            if (num1 == 1)
            {
                Console.WriteLine("ingrese un numero entero: ");
                 n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese un numero entero: ");
                 n2 = int.Parse(Console.ReadLine());
                resp = n1 * n2;
            }
            else {
                if (num1 == 0)
                {
                    Console.WriteLine("el producto de 0 por cualquier numero  es 0 ");
                } 
            }
            Console.WriteLine("La multiplicacion de los numero es: " + resp);
        }

         public void Dividir() 
         {

             Console.WriteLine("-------------------------------------------- ");
             int num1; 
             int n1;
             int n2;
             int resp = 0;
             Console.WriteLine("ingrese un numero: ");
             num1 = int.Parse(Console.ReadLine());
             if (num1 > 2 && num1 <2)
             {
                 Console.WriteLine("ingrese otro nuevo numero: ");
                 num1 = int.Parse(Console.ReadLine());
             }

              if (num1 == 2)
            {
                Console.WriteLine("ingrese un numero entero: ");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese un numero entero: ");
                n2 = int.Parse(Console.ReadLine());
                if (n1 > 0 && n2 > 0)
                {
                    resp = n1 / 2;
                }
                else
                { 
                 if(n1 == 0 && n2 >2)
                 {
                     Console.WriteLine("---ERROR---");
                 }
                }
                
            }
              Console.WriteLine(" la division de los numero es: "+ resp);
            
         }
         public void capturar() 
         {
             string nombre = "";
             int num;
             Console.WriteLine("ingrese el numero 3 para pedir nombres: ");
             num = int.Parse(Console.ReadLine());
             if (num == 3) 
             {
                 for (int i = 0; i <= 5; i++ )
                 {
                     Console.WriteLine("ingrese nombre: " + i);
                      nombre = Console.ReadLine();
                 }
                 Console.WriteLine(nombre);
             }
         }
    }
}
