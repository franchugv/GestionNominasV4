namespace GestionNominasV4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RESCURSOS

            Nomina item;

            // IMICIALIZACION

            item = new Nomina();

            // ENTRADA
            
            item.nombre = Interfaz.LeerCadena("nombre");
            item.apellidos = Interfaz.LeerCadena("apellidos");
            item.puesto = Interfaz.LeerCadena("puesto");

            item.HorasTrabajadas = Interfaz.LeerHorasTrabajadas("horas trababjadas", item);
            item.SalarioHora = Interfaz.LeerSalarioHoras("salario hora", item);


            // PROCESO

            // SALIDA


            Interfaz.MostrarNomina(item);






            


        }
    }
}