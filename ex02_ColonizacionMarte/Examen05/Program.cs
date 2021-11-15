using System;

namespace Examen05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Colonización a Marte - Envío de material a las planicies");
            Console.WriteLine("Se realizarán 15 lanzamientos de materiales necesarios para la colonización,");
            Console.WriteLine("que estarán ubicados en las planicies (A)cidalia, (E)lysium y (U)topia.");
            Console.WriteLine("Cada lanzamiento tiene un cargamento de hasta 10.000 kg.\n");

            Lanzamiento[] ArregloLanzamientos = new Lanzamiento[15];
            int i = 0;

            //inicializamos los arreglos que totalizan
            while (i < ArregloLanzamientos.Length)
            {
                ArregloLanzamientos[i] = new Lanzamiento();
                Console.WriteLine($"Ingrese en destino para el lanzamiento {i + 1}: ");
                ArregloLanzamientos[i].planicie = Console.ReadLine().ToUpper();
                if (ArregloLanzamientos[i].planicie == "A" || ArregloLanzamientos[i].planicie == "E" || ArregloLanzamientos[i].planicie == "U")
                {
                    bool valido = false;
                    while (valido == false)
                    {

                        try
                        {
                            Console.WriteLine($"Ingrese la carga con la que llegó el lanzamiento {i + 1}: ");
                            ArregloLanzamientos[i].carga = float.Parse(Console.ReadLine());

                            if (ArregloLanzamientos[i].carga <= 0 || ArregloLanzamientos[i].carga >= 10000)
                                Console.WriteLine("La carga del lanzamiento es un número no válido, intente nuevamente\n");
                            else
                            {
                                valido = true;
                                i++;
                            }

                        }
                        catch (FormatException error)
                        {
                            Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                            Console.WriteLine("Error: {0} \n", error.Message);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ingresaste un destino inválido. Intenta nuevamente! \n");
                }
            }

            //Aqui visualizamos resultados
            Console.WriteLine("\n\nResultados obtenidos de los lanzamientos:\n");
            Console.WriteLine("Las planicies son A(cidalia), E(lysium) y U(topia)\n");

            for (i = 0; i < ArregloLanzamientos.Length; i++)
            {
                Console.WriteLine($"Lanzamiento N°{i + 1}: ");
                Console.WriteLine($"Carga: {ArregloLanzamientos[i].carga} kg");
                Console.WriteLine($"Destino: {ArregloLanzamientos[i].planicie}");
                Console.WriteLine();
            }

        }

        /// <summary>
        /// Función que calcula el promedio de carga recibido en cada planicie segun el número de lanzamientos
        /// </summary>
        /// <param name="arregloLanzamientos">Total de lanzamientos por planicie</param>
        /// <param name="arregloCargas">Total Carga recibida por planicie</param>
        /// <returns>los promedios de carga recibidos por planicie</returns>
        /*static float[] CalculaPromedioEfectividad(int[] arregloLanzamientos, float[] arregloCargas)
        {
            float[] promedios = new float[3];

            //aqui calculamos el promedio, evitando la división por cero
            for (int i = 0; i < promedios.Length; i++)
            {
                //Si no hay lanzamientos, el promedio es cero
                if (arregloLanzamientos[i] == 0)
                    promedios[i] = 0;
                else
                    promedios[i] = arregloCargas[i] / arregloLanzamientos[i];
            }
            return promedios;
        }*/
    }
}
