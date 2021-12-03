using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 5. Jugando con operaciones básicas

● Una empresa quiere hacer una compra de varios pasteles idénticos a una
panadería de la ciudad. La empresa, dependiendo del monto total de la
compra, decidirá qué hacer para pagar a la panadería, así:

o Si el monto total de la compra excede los $200.000, la empresa
tendrá la capacidad de invertir de su propio dinero un 60 % del
monto de la compra, pedir prestado al banco un 20% y el resto lo
pagará solicitando un crédito al fabricante.

o Si el monto total de la compra no excede de $200.000, la empresa
tendrá capacidad de invertir de su propio dinero un 80 % y el
restante 20 % lo pagará solicitando crédito al fabricante.

o La panadería cobra por concepto de intereses un 19 % sobre la
cantidad que se le pague a crédito.*/

            int monto_total;
            const double interes_panaderia = 0.19;
            double pago_empresa=0;
            double banco=0;
            double fabricante=0;
            double valor_pagar=0;

            Console.WriteLine("Digita el monto total a pagar");
            monto_total=int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------------");

            if (monto_total>200000)
            {
             pago_empresa=monto_total*0.60;
             banco=monto_total*0.20;
             fabricante=monto_total*0.20;
             valor_pagar=fabricante+(fabricante*interes_panaderia);
                
            }
            else
            {
             pago_empresa=monto_total*0.80;
             fabricante=monto_total*0.20; 
             valor_pagar=fabricante+(fabricante*interes_panaderia); 
            }
            Console.WriteLine($"El monto total de la compra es de: ${monto_total}");
            Console.WriteLine($"La empresa invertira un total de ${pago_empresa}");
            Console.WriteLine($"el banco invirtio ${banco}");
            Console.WriteLine($"se le pidio prestado al fabricante un total de ${fabricante}");
            Console.WriteLine($"debido al 19% de interes del fabricante, la empresa debera devolverle ${valor_pagar}");







            
        }
    }
}
