using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            /*Ejercicio 2. Cálculos porcentajes

● Cree un algoritmo que lea la cantidad de estudiantes del curso
“Fundamentos de Programación y Algorítmica Básica”, “Introducción a la
ingeniería de software”, “Introducción a la modalidad virtual” y
“Habilidades de la comunicación”, una vez capturados estos valores por
pantalla el algoritmo debe hacer el cálculo del promedio de estudiantes
en los 4 cursos.

Se debe tener en cuenta que si alguno de estos cursos no abrió, es decir, tiene
cero (0) estudiantes, no se incluirá el curso en el promedio de estudiantes en
cursos.

*/

        int FPyAB; //cantidad de estudiantes en fundamentos de programación y algoritmica basica.
        int IIS;  //Cantidad de estudiantes en introducción a la ingenieria de software.
        int IMV;  //Cantidad de estudiantes en introduccion a la modalidad virtual.
        int HC;   //Cantidad de estudiantes en habilidades de la comunicación.
        int promedio=0; //total de estudiantes en los cuatro cursos
        int cont=0;

        // digitamos los estudiantes de cada curso

        Console.WriteLine("Digite la cantidad de estudiantes que hay en fundamentos de programación y"+"\n"+"algoritmica basica:");
        FPyAB=int.Parse(Console.ReadLine());
        Console.WriteLine("Digite la cantidad de estudiantes que hay en introducción a la ingenieria "+"\n"+"de software:");
        IIS=int.Parse(Console.ReadLine());
        Console.WriteLine("Digite la cantidad de estudiantes que hay en introducción a la modalidad virtual:");
        IMV=int.Parse(Console.ReadLine());
        Console.WriteLine("Digite la cantidad de estudiantes que hay en habilidades de la comunicación:");
        HC=int.Parse(Console.ReadLine());

         //creamos condiciones if para evitar que alguna clase que tenga 0 estudiantes no se incluya en el promedio

        Console.WriteLine($"-------------------------------------------------------------------------------------");
       
        if (FPyAB>0)
        {
         promedio+= FPyAB;  
         cont++;
        }
        if (IIS>0)
        {
           promedio+= IIS; 
           cont++;
        }
        if (IMV>0)
        {
            promedio+= IMV;
            cont++;
        }
        if (HC>0)
        {
            promedio+=HC;
            cont++;
        }
        promedio/=cont;

        // imprimimos el promedio

        Console.WriteLine($"El promedio de estudiantes por curso es de: {promedio} estudiantes");


 
        }
    }
}
