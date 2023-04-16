using System;
using Library;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {            
            Paciente Paciente1 = new Paciente("Tadeo","Ki","21","Masculino","50624558","095412777"); /*creando paciente*/
            Paciente Paciente2 = new Paciente("Tomas","Ki","","Masculino","","");                    /*creando paciente incorrecto*/
            Doctor Doctor1 = new Doctor("Hendry","Henderson","Neurocirujano");                       /*creando doctor*/  
            Doctor Doctor2 = new Doctor("Kevin","Peterson","");                                      /*creando doctor incorrecto*/
            Appointment Cita1 = new Appointment("24/04/23","16:30");                                 /*creando cita*/
            Appointment Cita2 = new Appointment("26/04/23","");                                      /*creando cita incorrecta*/

            //Doctor1.AsignarPaciente(Paciente1, Doctor1);                                /*Cada doctor puede tener una lista de pacientes*/
            //Paciente1.AsignarDoc(Paciente1, Doctor1);                                   /*Cada paciente puede tener un doctor asignado*/

            Cita1.Agendar(Paciente1, Doctor1);



            
        }
    }
}
