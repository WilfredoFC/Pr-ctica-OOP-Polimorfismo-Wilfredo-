using Práctica_OOP_Polimorfismo;
using System.Diagnostics.Contracts;
//Wilfredo Valentin Feliz Caba 2024-0158
namespace OOP_Polifmorfismo
{

    //Se debe crear una aplicación que realice el cálculo del salario mensual de los docentes por hora,
    //los docentes de contrato fijo y los empleados administrativos.
    //En el caso de los docentes por hora, se asignará una tarifa de 800 por cada hora trabajada.Asimismo,
    //la aplicación deberá contemplar el cálculo de bonificaciones para los empleados administrativos
    //y los docentes de contrato fijo, tomando en cuenta que si empleado o docente alcanzo la meta entonces se
    //le paga un salario en caso contrario se le paga la mitad.

    class Proyect
    {
        static void Main(string[] args)
        {
            
            Empleado docentePorHora = new DocentePorHora(1, "Wilfredo", "Feliz", 70);
            EmpleadoFijo docenteContratoFijo = new DocenteContratoFijo(2, "Mariana", "Martinez", 20000, 20);

            docenteContratoFijo.Bono = 5500;
            docenteContratoFijo.Meta = true;

            EmpleadoFijo empleadoAdministrativo = new EmpleadoAdministrativo(3, "Carlos", "Caraballo", 75000, "Director");

            empleadoAdministrativo.Bono = 3700;
            empleadoAdministrativo.Meta = false;

            
            Console.WriteLine($"Salario de {docentePorHora.Nombres} {docentePorHora.Apellidos}: {docentePorHora.calcular():C}");
            Console.WriteLine($"Salario de {docenteContratoFijo.Nombres} {docenteContratoFijo.Apellidos}: {docenteContratoFijo.calcular():C}");
            Console.WriteLine($"Salario de {empleadoAdministrativo.Nombres} {empleadoAdministrativo.Apellidos}: {empleadoAdministrativo.calcular():C}");

            

        }
    }

}
