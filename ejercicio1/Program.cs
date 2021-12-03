using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Calculando pesos a dólares o dólares a pesos

● Escriba un algoritmo que le permita al usuario seleccionar qué tipo de
conversión quiere realizar y recibir el valor que desea convertir. El sistema
debe hacer el cálculo y mostrar en pantalla el resultado de la conversión.
*/
        const double dolar=3914; //se crea la constante dolar, es una variable que no cambiara de valor.
        int conversion=0;        //variable donde digitaremos la conversion que deseamos.
        double cantidad;         //el valor que deseamos convertir.
        double total=0;          //variable donde se va almacenar la conversion ya realizada.

            

            Console.WriteLine("¿Que deseas convertir?"); //preguntamos la conversion que se quiere realizar
            Console.WriteLine("--Escribe 1 si lo que deseas es convertir es de pesos a dolares");  //se dan las opciones para elegir la conversion
            Console.WriteLine("--Escribe 2 si lo que deseas es convertir es de dolares a pesos");
            Console.WriteLine("conversion:"); //listo para recibir el dato

          /*creamos un bucle con el while para asegurar que en caso de que no elija alguna de las dos opciones disponibles,
          se genere una advertencia y de la posibilidad de elegir otra vez una opción*/ 

            while (conversion !=1 && conversion !=2) 
            {
                conversion=int.Parse(Console.ReadLine());
                if (conversion !=1 && conversion !=2)
                {
                Console.WriteLine("esa conversion no existe, digita el numero que corresponde a una conversion disponible");
                }
            }

            

            /*por ultimo ponemos un condicional if que permitira generar por un lado la conversion de pesos a dolares y por el otro lado 
              generar la conversion de dolares a pesos */

            if (conversion==1)
            {
                Console.WriteLine("digita la cantidad de pesos colombianos que deseas convetir a dolares:");
                cantidad=int.Parse(Console.ReadLine());
                total=cantidad/dolar;
                Console.WriteLine($"Esta es la cantidad en dolares que tienes: {total} $ ");

            }
            else
            {
                Console.WriteLine("digita la cantidad de dolares que deseas convetir a pesos colombianos:");
                cantidad=int.Parse(Console.ReadLine());
                total=cantidad*dolar;
                Console.WriteLine($"Esta es la cantidad en pesos colombianos que tienes: {total} pesos ");
            }




        }
    }
}
