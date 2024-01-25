using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionNominasV4
{
    public static class Interfaz
    {
        public static string? LeerCadena(string dato)
        {
            // RECURSOS
            string? cadena = null;
            bool esValido;
            

            // ENTRADA
        

            do
            {
                esValido = true;

                // Entrada - Interfaz en Modo Texto
                Console.Write($"Introduzca su {dato}: ");
                cadena = Console.ReadLine();


                try
                {
                    Comprobaciones.ValidarCadena(cadena);
                }
                catch(Exception Error)
                {
                    esValido = false;
                    Console.WriteLine($"Error: {Error.Message}");

                    Console.WriteLine("Pulse ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();


                }

            } while (!esValido);

            Console.WriteLine("Pulse ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();



            // SALIDA

            return cadena;
        }


        public static int LeerHorasTrabajadas(string dato, Nomina objeto)
        {
            // VARIABLES
            string aux = null;  // char[] aux;
            bool esValido;

            do
            {
                esValido = true;

                // Entrada - Interfaz en Modo Texto
                Console.Write($"Introduzca {dato}: ");
                aux = Console.ReadLine();

                try
                {
                    // Proceso de Validación
                    objeto.HorasTrabajadas = Comprobaciones.ValidarHoras(aux);
                }
                catch (Exception Error)
                {
                    // SALIDA - Retroalimentación de Errores
                    esValido = false;   // Actualización del detector de errores
                    Console.WriteLine($"Error: {Error.Message}");

                    Console.WriteLine("Pulse ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                }

                Console.WriteLine("Pulse ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();

            } while (!esValido);

            return objeto.HorasTrabajadas;

        }



        public static float LeerSalarioHoras(string dato, Nomina objeto)
        {
            // VARIABLES
            float horas = 0;
            string aux = null;  // char[] aux;
            bool esValido;

            do
            {
                esValido = true;

                // Entrada - Interfaz en Modo Texto
                Console.Write($"Introduzca {dato}: ");
                aux = Console.ReadLine();

                try
                {
                    // Proceso de Validación
                    objeto.SalarioHora = Comprobaciones.ValidarSalarioHora(aux);
                }
                catch (Exception Error)
                {
                    // SALIDA - Retroalimentación de Errores
                    esValido = false;   // Actualización del detector de errores
                    Console.WriteLine($"Error: {Error.Message}");

                    Console.WriteLine("Pulse ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                }

                Console.WriteLine("Pulse ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();

            } while (!esValido);

            // SALIDA - Método
            return objeto.SalarioHora;
        }





        #region MÉTODOS DE SALIDA DE DATOS

        /// <summary>
        /// Muestra una línea de asteriscos
        /// </summary>
        public static void MostrarLinea()
        {
            Console.WriteLine("***********************************************************************");
        }

        /// <summary>
        /// Muestra los datos del empleado
        /// </summary>
        /// <param name="name">Nombre del Empleado</param>
        /// <param name="surname">Apellidos del Empleado</param>
        /// <param name="job">Puesto de Trabajo</param>
        public static void MostrarEmpleado(string name, string surname, string job)
        {
            Console.WriteLine($"Puesto:\t{job}");
            Console.WriteLine($"Nombre:\t{name}\tApellidos:\t{surname}");
        }

        /// <summary>
        /// Muestra los datos del trabajo realizado en la semana por el empleado
        /// </summary>
        /// <param name="horasT">Horas Trabajadas</param>
        /// <param name="horasE">Horas Extra</param>
        /// <param name="salarioH">Salario por Hora de Trabajo</param>
        public static void MostrarDatosSemana(int horasT, int horasE, float salarioH)
        {
            Console.WriteLine($"\tHoras Trabajadas:\t{horasT} Horas\tHoras Extra:\t{horasE} Horas");
            Console.WriteLine($"\tPrecio por Hora:\t{salarioH} Euros/Hora");
        }

        /// <summary>
        /// Muestra los Honorarios del Empleado
        /// </summary>
        /// <param name="sBase">Salario Base</param>
        /// <param name="sExtra">Salario Extra</param>
        public static void MostrarHonorarios(float sBase, float sExtra)
        {
            Console.WriteLine($"\tSalario Base:\t{sBase} Euros\tSalario Extra:\t{sExtra} Euros");
        }

        /// <summary>
        /// Muestra la Nómina del Empleado
        /// </summary>
        /// <param name="sBruto">Salario Bruto</param>
        /// <param name="tasas">Impuestos</param>
        /// <param name="sNeto">Salario Neto</param>
        public static void MostrarNomina(float sBruto, float tasas, float sNeto)
        {
            Console.WriteLine($"\tSalario Bruto:\t{sBruto} Euros");
            Console.WriteLine($"\tImpuestos:\t{tasas} Euros");
            Console.WriteLine($"\tSalario Neto:\t{sNeto}  Euros");
        }

        #endregion


        public static void MostrarNomina(Nomina OBJ)
        {

            Console.Clear();

            Console.WriteLine($"\n******************************************************\n");


            Console.WriteLine($"\tNombre: {OBJ.Nombre}");
            Console.WriteLine($"\tApellidos: {OBJ.Apellidos}");
            Console.WriteLine($"\tPuesto: {OBJ.Puesto}");

            Console.WriteLine($"\n******************************************************\n");

            Console.WriteLine($"\tHoras trabajadas: {OBJ.HorasTrabajadas}");
            Console.WriteLine($"\tSalario Hora: {OBJ.SalarioHora}");

            Console.WriteLine($"\n******************************************************\n");


            Console.WriteLine($"\tHoras Extra: {OBJ.HorasExtras}");

            Console.WriteLine($"\tSalario Base: {OBJ.SalariosBase}");

            Console.WriteLine($"\n******************************************************\n");


            Console.WriteLine($"\tSalario Neto: {OBJ.SalariosNeto}");
            Console.WriteLine($"\tSalario Bruto: {OBJ.SalariosBruto}");
            Console.WriteLine($"\tSalario Neto: {OBJ.SalariosNeto}");
            Console.WriteLine($"\tSalario Extra: {OBJ.SalariosExtra}");

            Console.WriteLine($"\n******************************************************\n");

        }






    }
}

