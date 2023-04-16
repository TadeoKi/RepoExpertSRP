using System;
using System.Text;
using System.Collections;

namespace Library
{
    public class Appointment
    {
        ArrayList ListaFecha = new ArrayList();
        public string AppointmentDate { get ; set; }
        public string AppointmentTime { get ; set; }
        
        public Appointment(String date, String time)
        {
            this.AppointmentDate = date; 
            this.AppointmentTime = time;
        }

        public void Agendar(Paciente paciente, Doctor doctor) /*este metodo verifica los datos, luego crea una cita, asigna los paciente al doc y el doc al paciente */
        {
            if(Addme.CheckInfo(paciente,doctor) == true)
            {
                ListaFecha.Add(paciente);
                paciente.AsignarDoc(paciente, doctor);
                doctor.AsignarPaciente(paciente, doctor);
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine($"Para el {this.AppointmentDate} a las {this.AppointmentTime},\nse ha creado una cita para el paciente {paciente},\ncon el doctor {doctor}.");
            }
        }

        public override string ToString()
        {
            return $"{this.AppointmentDate}, {this.AppointmentTime} \n";
        }
        


    }
}
