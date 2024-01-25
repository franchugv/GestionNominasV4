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
            
            item.Nombre = Interfaz.LeerCadena("nombre");
            item.Apellidos = Interfaz.LeerCadena("apellidos");
            item.Puesto = Interfaz.LeerCadena("puesto");

            item.HorasTrabajadas = Interfaz.LeerHorasTrabajadas("horas trababjadas", item);
            item.SalarioHora = Interfaz.LeerSalarioHoras("salario hora", item);


            // PROCESO

            // SALIDA


            Interfaz.MostrarNomina(item);


        }
    }
}