using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Wilfredo Valentin Feliz Caba 2024-0158
namespace Práctica_OOP_Polimorfismo
{

    //Se debe crear una aplicación que realice el cálculo del salario mensual de los docentes por hora,
    //los docentes de contrato fijo y los empleados administrativos.

    //En el caso de los docentes por hora, se asignará una tarifa de 800 por cada hora trabajada.Asimismo,
    //la aplicación deberá contemplar el cálculo de bonificaciones para los empleados administrativos
    //y los docentes de contrato fijo, tomando en cuenta que si empleado o docente alcanzo la meta entonces se
    //le paga un salario en caso contrario se le paga la mitad.

    public abstract class Empleado
    {
        private int id;
        private string nombres;
        private string apellidos;
        protected decimal sueldoBruto;

        public Empleado(int id, string nombres, string apellidos)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;

        }

        public abstract decimal calcular();

        public int Id
        {
            get { return id; }
        }
        public string Nombres
        {
            get { return nombres; }
        }
        public string Apellidos
        {
            get { return apellidos; }
        }
        public decimal SueldoBruto
        {
            get { return sueldoBruto; }
            protected set { sueldoBruto = (value < 0) ? 0 : value; }
        }


    }


    public class EmpleadoFijo : Empleado
    {
        private decimal sueldoFijo;
        private decimal bono;
        private bool meta;

        public EmpleadoFijo(int id, string nombres, string apellidos, decimal sueldoFijo) : base(id, nombres, apellidos)
        {
            SueldoFijo = sueldoFijo;

        }

        public decimal Bono
        {
            get { return bono; }
            set { bono = (value < 0) ? 0 : value; }
        }
        public bool Meta
        {
            get { return meta; }
            set { meta = value; }
        }

        public decimal SueldoFijo
        {
            get { return sueldoFijo; }
            protected set { sueldoFijo = (value < 0) ? 0 : value; }
        }

        public override decimal calcular()
        {
            if (meta)
            {
                SueldoBruto = sueldoFijo + bono;
                return sueldoBruto;
            }
            else
            {
                SueldoBruto = sueldoFijo / 2;
                return sueldoBruto;
            }

        }
    }

    public class DocenteContratoFijo : EmpleadoFijo
    {
        private decimal mesesContrato;

        public DocenteContratoFijo(int id, string nombres, string apellidos, decimal sueldoFijo, decimal mesesContrato) : base(id, nombres, apellidos, sueldoFijo)
        {
            MesesContrato = mesesContrato;
        }

        public decimal MesesContrato
        {
            get { return mesesContrato; }
            protected set { mesesContrato = (value < 0) ? 0 : value; }
        }
    }
    public class EmpleadoAdministrativo : EmpleadoFijo
    {
        private string puesto;

        public EmpleadoAdministrativo(int id, string nombres, string apellidos, decimal sueldoFijo, string puesto) : base(id, nombres, apellidos, sueldoFijo)
        {
            Puesto = puesto;
        }

        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }

    }


    public class DocentePorHora : Empleado
    {
        private const decimal tarifa = 800;
        private decimal horasTrabajadas;

        public DocentePorHora(int id, string nombres, string apellidos, decimal horasTrabajadas) : base(id, nombres, apellidos)
        {
            Horas = horasTrabajadas;
        }

        public decimal Horas
        {
            get { return horasTrabajadas; }
            set
            {
                horasTrabajadas = (value < 0) ? 0 : value;
            }
        }

        public override decimal calcular()
        {
            SueldoBruto = tarifa * horasTrabajadas;
            return sueldoBruto;
        }
    }





}

