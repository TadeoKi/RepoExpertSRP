using System;
using System.Text;


namespace Library
{
    public class Addme
    {
        public static bool CheckInfo(Paciente paciente, Doctor doctor)   /* Con este metodo se verifican los datos ingresados*/
        {
            Console.WriteLine("Checking Information...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(paciente.Nombre))
            {
                Console.WriteLine("Se requiere el nombre del paciente\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(paciente.Apellido))
            {
                Console.WriteLine("Se requiere el apellido del paciente\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(paciente.Edad))
            {
                Console.WriteLine("Se requiere la edad del paciente\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(paciente.Sexo))
            {
                Console.WriteLine("Se requiere el sexo del paciente\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(paciente.Ci))
            {
                Console.WriteLine("Se requiere la cedula del paciente\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(paciente.Numtel))
            {
                Console.WriteLine("Se requiere el numero de telefono del paciente\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(doctor.Nombre))
            {
                Console.WriteLine("Se requiere el nombre del doctor\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(doctor.Apellido))
            {
                Console.WriteLine("Se requiere el apellido del doctor\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(doctor.Especialidad))
            {
                Console.WriteLine("Se requiere la especialidad del doctor\n");
                isValid = false;
            }


            if (isValid == true)
            {
                Console.WriteLine("Todos los datos ingresados son correctos\n");
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
    
}
