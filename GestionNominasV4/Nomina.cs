using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNominasV4
{
    public class Nomina
    {
        // CONSTANTES INTERNAS DE LA CLASE

        private const int LIMITE_HORAS = 60;

        private const int MINIMO_HORAS = 0;

        private const int HORAS_SEMANALES = 35;

        private const float INCR_EXTRA = 1.5f;




        private const float SALARIO_MAX = 22.5f;

        private const float SALARIO_MIN = 1.0f;


        // MIEMBROS - CAMPOS - ATRIBUTOS

        private string? _nombre;
        private string? _apellidos;
        private string? _puesto;

        private int _horasTrabajadas;
        private float _salarioHora;
     
        // Datos Calculados


        ////////////////
        // PROPIEDADES// (Las propiededas siempren empiezan por mayuscula, sin parentesis)
        ////////////////



        /// <summary>
        /// Nombre del trabajador
        /// </summary>
        public string Nombre
        {
            get
            {   // lectura 
                return _nombre;
            }

            set
            {   // Escritura
                _nombre = value;
            }
        }

        /// <summary>
        /// Apellidos del trabajador
        /// </summary>
        public string Apellidos
        {
            get
            {
                return _apellidos;
            }

            set 
            { 
                _apellidos = value;
            }
        }

        /// <summary>
        /// Puesto del trabajador
        /// </summary>
        public string Puesto
        {
            get
            {
                return _puesto;
            }

            set
            {
                _puesto = value;
            }
        }

        /// <summary>
        /// Horas trabajadas
        /// </summary>
        public int HorasTrabajadas
        {
            get // Se activa cuando se consulta e valor del miembro |Devolver el valor del miembro privado
                // Resultado = ----.HorasTrabajadas - 10;
            {

                // if (HorasExtra() == null) throw new Exception($"No se a establecido las horas trabajadas");

                return _horasTrabajadas;
            }
            set // Se activa cuando se le asigna a la Propiedad un valor
                // Ejemplo: -----.HorasTrabajadas = 34;
            {
                // Comprobación 1: Horas no superiores al límite
                if (value > LIMITE_HORAS) throw new Exception($"Horas {value} son superores al {LIMITE_HORAS}");
                // Comprobación 2: Horas inferiores o iguales a 0
                if (value <= MINIMO_HORAS) throw new Exception($"Horas inferiores o iguales a {MINIMO_HORAS}");



                _horasTrabajadas = value;
            }
        }

        /// <summary>
        /// Salario que percibe el trabajador por hora trabajada
        /// </summary>
        public float SalarioHora
        {
            get 
            {
                // Comprobacipnes
                if (_salarioHora == 0) throw new Exception("Salario no establecido");
                // Devolución del valor del miembro asociado
                return _salarioHora;
            }
            set
            {
                //Validación del dato proporcionado SOLO EL DATO PROPORCIONADO
                // Comprobación 1: Horas no superiores al límite
                if (value > SALARIO_MAX) throw new Exception($"Horas {value} son superiores al {SALARIO_MAX}");
                // Comprobación 2: Horas inferiores o iguales a 1
                if (value <= SALARIO_MIN) throw new Exception($"Horas inferiores o iguales a {MINIMO_HORAS}");

                // Establecer el valor al miembro asociado

                _salarioHora = value;
            } 
        }












       
        /////////////////////
        // MÉTODOS PRIVADOS//
        /////////////////////
       
        /// <summary>
        /// Devolucion de las horas Extra realizadas por el trabajador
        /// </summary>
        /// <returns>Horas Extra</returns>
        public int HorasExtra()
        {
            int horasEx = 0;

            // PROCESO
            if (HorasTrabajadas > HORAS_SEMANALES) horasEx = HorasTrabajadas - HORAS_SEMANALES;
    ;

            // SALIDA - METODO
            return horasEx;
        }

        /// <summary>
        /// Cálculo del Salario Extra del trabajador
        /// </summary>
      
        public float SalarioExtra()
        {

            // RECURSOS

            float salEx = 0;

            // PROCESO

            salEx = HorasExtra() * SalarioHora * INCR_EXTRA;

            // SALIDA - METODO

            return salEx;

        }

        /// <summary>
        /// Calculo del salario base del trabajador
        /// </summary>
        
        public float SalarioBase()
        {

            float SalBase = 0;

            if (HorasTrabajadas > HORAS_SEMANALES) SalBase = HORAS_SEMANALES * SalarioHora;
            else SalBase = HorasTrabajadas * SalarioHora;

            return SalBase;
        }

        /// <summary>
        /// Cálculo del Salario los impuestos
        /// </summary>
        /// <returns></returns>

        public float Impuestos()
        {


            float impu = 0;
            // CONSTANTES
            const float PORCENTAJE_IMP = 0.16f;

            // RECURSOS LOCALES
            // PROCESO
            // SALIDA - Método
            impu = SalarioBruto() * PORCENTAJE_IMP;

            return impu;
        }


        /// <summary>
        /// Cálculo del Salario Bruto del trabajador
        /// </summary>
        /// <returns></returns>

        public float SalarioBruto()
        {
            // CONSTANTES
            // RECURSOS LOCALES
            float SalBruto = 0;
            // PROCESO
            SalBruto = SalarioBase() + SalarioExtra();

            // SALIDA - Método

            return SalBruto;
        }

        /// <summary>
        /// Cálculo del Salario Neto del trabajador
        /// </summary>
        /// <returns></returns>
        public float SalarioNeto()
        {
            // CONSTANTES
            // RECURSOS LOCALES
            float SalarioNeto = 0;

            // PROCESO
            // SALIDA - Método
            SalarioNeto = SalarioBruto() - Impuestos();

            return SalarioNeto;
        }





    }
}
