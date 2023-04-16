using System;
using System.Text;
using System.Collections;

namespace Library
{
    public class Doctor
    {   
        ArrayList ListaPacientes = new ArrayList();
        public string Nombre { get ; }
        public string Apellido { get ; }
        public string Especialidad { get ;  }

        public Doctor(String nombre, String apellido, String especialidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Especialidad = especialidad;
        }

        public void AsignarPaciente(Paciente paciente, Doctor doctor)   /*Este metodo verifica los datos y le asigna paciente a un doc*/
        {
            if(Addme.CheckInfo(paciente,doctor) == true)
            {
                ListaPacientes.Add(paciente);
                Console.WriteLine($"Se ha agendado al paciente {paciente},\ncon el doctor {doctor}.\n");
            }
            else
            {
                Console.WriteLine($"Ingrse los datos nuevamente \n");
            }
        }

        public override string ToString()
        {
            return $"{this.Nombre} {this.Apellido} de especialidad {this.Especialidad}";
        }
    }   
}
