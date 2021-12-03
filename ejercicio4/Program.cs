using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 4. Jugando con operaciones básicas

● Cree un algoritmo que dados dos números enteros y un símbolo (+, -, * y /),
dé el cálculo correspondiente de acuerdo con el símbolo ingresado y
muestre en pantalla el resultado de la operación. Esta solución debe
implementar el operador “CASE”*/
             
              
             float numero1; //variable donde se almacena el primer numero
             float numero2; //variable donde se almacema el segundo numero
             float resultado=0; //variable donde se almacena el resultado
             char operacion=' '; //variable donde indicaremos la operacin que queremos
             int cont=0;  //variable que ayudara  a finalizar el bucle
                
            // se pide que ingresen los dos numeros

            Console.WriteLine("Digita el primer numero");
            numero1=int.Parse(Console.ReadLine());
            Console.WriteLine("Digita el segundo numero");
            numero2=int.Parse(Console.ReadLine());

            // generamos un ciclo para que en caso de digitar una operación erronea, se pueda volver a ingresar el dato correcto.

            Console.WriteLine("elige la operacion que deseas:");

            while(cont==0){
            
            
            operacion=char.Parse(Console.ReadLine());
            //dentro del ciclo agregamos el condicional switch, que nos permitira hacer una funcion de acuerdo a la operacion que elijamos

            switch (operacion)
            {
                case '+':
                resultado=numero1+numero2;
                cont=1;

                break;
                  case '-':
                resultado=numero1-numero2;
                cont=1;
                break;
                  case '*':
                resultado=numero1*numero2;
                cont=1;
                break;
                  case '/':
                resultado=numero1/numero2;
                cont=1;
                break;

                
                default:
                Console.WriteLine("Esa operacion no existe en este caso");
                Console.WriteLine("elige una operacion valida:");
                break;
            }
            }
            //imprimimos el resultado 
            
            Console.WriteLine($"el resultado de {numero1} {operacion} {numero2} es: {resultado}");
        



        }
    }
}
