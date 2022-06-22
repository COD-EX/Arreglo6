using System;

namespace Arreglo6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mostrar las notas del examen parcial, oral y final de 3 alumnos, si el promedio es mayor a 11.5 se debe mostrar un mensaje de APROBADOS, caso contrario DESAPROBADO.
            string[] nombre = new string[3];
            double[] examenParcial = new double[3];
            double[] examenOral = new double[3];
            double[] examenFinal = new double[3];

            double promedio1 = 0;
            double promedio2 = 0;
            double promedio3 = 0;

            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("Ingrese nombre del estudiante " + i);
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingrese su examen Parcial");
                examenParcial[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese su examen Oral");
                examenOral[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese su examen Final");
                examenFinal[i] = Convert.ToDouble(Console.ReadLine());
                

                promedio1 = (examenParcial[0] + examenOral[0] + examenFinal[0])/3;
                promedio2 = (examenParcial[1] + examenOral[1] + examenFinal[1])/3;
                promedio3 = (examenParcial[2] + examenOral[2] + examenFinal[2])/3;

            }
            if (promedio1 >= 11.5)
            {
                Console.WriteLine("Primer alumno " + nombre[0]);
                Console.WriteLine("Promedio es " + promedio1);
                Console.WriteLine("APROBADO");
            }
            else
            {
                Console.WriteLine("Primer alumno " + nombre[0]);
                Console.WriteLine("Promedio es " + promedio1);
                Console.WriteLine("DESAPROBADO");
            }
            if (promedio2 >= 11.5)
            {
                Console.WriteLine("Segundo alumno " + nombre[1]);
                Console.WriteLine("Promedio es " + promedio2);
                Console.WriteLine("APROBADO");
            }
            else
            {
                Console.WriteLine("Segundo alumno " + nombre[1]);
                Console.WriteLine("Promedio es " + promedio2);
                Console.WriteLine("DESAPROBADO");
            }
            if (promedio3 >= 11.5)
            {
                Console.WriteLine("Tercer alumno " + nombre[2]);
                Console.WriteLine("Promedio es " + promedio3);
                Console.WriteLine("APROBADO");
            }
            else
            {
                Console.WriteLine("Tercer alumno " + nombre[2]);
                Console.WriteLine("Promedio es " + promedio3);
                Console.WriteLine("DESAPROBADO");
            }
            Console.WriteLine("-----------------------------------------");
            if (promedio1 > promedio2 && promedio1 > promedio3)
            {
                Console.WriteLine("Primero puesto " + "Alumno " + nombre[0]);
            }
            else if(promedio2 > promedio3){
                Console.WriteLine("Primero puesto " + "Alumno " + nombre[1]);
            }
            else
            {
                Console.WriteLine("Primero puesto " + "Alumno " + nombre[2]);
            }
            Console.ReadKey();
        }
    }
}
