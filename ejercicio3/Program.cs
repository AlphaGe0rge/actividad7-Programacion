using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 3. Jugando con números

● Cree un algoritmo que dado un número de tres cifras, haga los siguiente:
o Si es par: invierta el número.
o Si es impar: muestre en pantalla la suma de los extremos e invierta el
número.
o Si es número primo: calcule el cuadrado del número ingresado y el
cuadrado de los extremos.*/

           int numero=0;   //variable que va almacenar el numero de tres cifras
           int invertido=0; // variable que mostrara los numeros invertidos
           int residuo=0;
           int decena=0;
           int centena=0;
           int unidad=0;
           int suma=0;      // aqui se almacenara la suma de los dos extremos del numero
        
           Console.WriteLine("Digita un numero de tres cifras");
            
        //se crea un bucle que nos permita volver a ingresar el numero en caso de que no sea de tres cifras

           while(numero<99 || numero>1000){

         numero=int.Parse(Console.ReadLine());

           if (numero<99 || numero>1000)
           {
                Console.WriteLine("ese numero no es de tres cifras");
                 Console.WriteLine("Digita un numero de tres cifras:");
           }
            
           }
           //condicional if en caso de que sea numero par

           
            Console.WriteLine("----------------------------------------");
            if (numero%2==0)
            {
                Console.WriteLine("El numero que digitastes es par.");
                residuo=numero%100;
                centena=(numero-residuo)/100;
                decena=(residuo-(residuo%10))/10;
                unidad=residuo%10;
                unidad*=100;
                decena*=10;

                invertido=unidad+decena+centena;
            
            Console.WriteLine($"este es tu numero invertido: {invertido}");
            }

            //Condicional en caso de que sea numero impar o primo

            else if (numero%2 !=0)
            {
                Console.WriteLine("El numero que digitastes es impar y primo");
 

                residuo=numero%100;
                centena=(numero-residuo)/100;
                decena=(residuo-(residuo%10))/10;
                unidad=residuo%10;
                suma=centena+unidad;

                Console.WriteLine($"la suma del extremo {centena} y el extremo {unidad} nos da: {suma}");

                double potencia_numero= Math.Pow(numero, 2);
                double potencia_izquierda = Math.Pow(centena, 2);
                double potencia_derecha = Math.Pow(unidad, 2);


                unidad=suma%10;
                decena=(suma-unidad)/10;
                unidad*=10;
                invertido=unidad+decena;
                Console.WriteLine($"La parte invertidad de la suma de los extremos nos da: {invertido}");

                Console.WriteLine($"tu numero elevado al cuadrado da: {potencia_numero}");
                Console.WriteLine($"El extremo izquierdo  del numero elevado al cuadrado da: {potencia_izquierda}");
                Console.WriteLine($"El extremo derecho del numero elevado al cuadrado da: {potencia_derecha}");

               
            }

         




            

        }
    }
}
