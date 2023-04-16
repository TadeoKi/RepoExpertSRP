using System;
using System.Text;
using System.Collections;


namespace Library
{
    public class Paciente
    {
        ArrayList ListaDoctor = new ArrayList();
        public string Nombre { get ; }
        public string Apellido { get ; }
        public string Edad { get ;  }
        public string Sexo { get ;  }
        public string Ci { get ;  }
        public string Numtel { get ;  }

        public Paciente(String nombre, String apellido, String edad, String sexo, String ci, String numtel)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Ci = ci;
            this.Numtel = numtel;
        }

        public void AsignarDoc(Paciente paciente, Doctor doctor)  /*Este metodo verifica los datos y luego le asigna un doc al paciente*/
        {
            if(Addme.CheckInfo(paciente,doctor) == true)
            {
                ListaDoctor.Add(doctor);
                Console.WriteLine($"Se ha asignado al doctor {doctor} \n con el paciente {paciente} \n");
            }
            else
            {
                Console.WriteLine($"Ingrse los datos nuevamente \n");
            }
        }

        public override string ToString()
        {
            return $"{this.Nombre} {this.Apellido} (ci:{this.Ci},tel:{this.Numtel}) de {this.Edad} años y genero {this.Sexo}";
        }  
    }    
}
