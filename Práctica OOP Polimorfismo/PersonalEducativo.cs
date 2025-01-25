using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_OOP_Polimorfismo
{

    //Se debe crear una aplicación que realice el cálculo del salario mensual de los docentes por hora,
    //los docentes de contrato fijo y los empleados administrativos.

    //En el caso de los docentes por hora, se asignará una tarifa de 800 por cada hora trabajada.Asimismo,
    //la aplicación deberá contemplar el cálculo de bonificaciones para los empleados administrativos
    //y los docentes de contrato fijo, tomando en cuenta que si empleado o docente alcanzo la meta entonces se
    //le paga un salario en caso contrario se le paga la mitad.

    public class PersonalEducativo
    {
        int id;
        string nombres;
        string apellidos;
        

        public PersonalEducativo(int id, string nombres, string apellidos)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            
        }
        public int CalcularSueldo()
        {
            
        }

    }

    public class DocentePorHora : PersonalEducativo
    {
        int tarifa;
        int horasTrabajadas;
        int sueldo;
        
        public DocentePorHora(int id, string nombres, string apellidos, int tarifa ) : base(id, nombres, apellidos)
        {
            this.tarifa = tarifa;
        }

        public override int CalcularSueldo(int horasTrabajadas)
        {
            sueldo = tarifa * horasTrabajadas;
            return sueldo;
        }
        
    

    }

    public class DocenteContratoFijo : PersonalEducativo
    {
        int sueldoFijo;
        int sueldoFinal;
        public DocenteContratoFijo(int id, string nombres, string apellidos ) : base(id, nombres, apellidos)
        {
        }

        public override int CalcularSueldo()
        {
            return CalcularSueldo();
        }

        public int otorgarBono(int bonificacion)
        {
            
        }
    }

    public class EmpleadosAdministrativos : PersonalEducativo
    {
        public EmpleadosAdministrativos(int id, string nombres, string apellidos ) : base(id, nombres, apellidos)
        {
        }

        public override int CalcularSueldo()
        {
            return CalcularSueldo();
        }
    }


}
