using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPExceptions
{
    public class Medico
    {
        private string nombre;
        public string Nombre 
        {
            get { return nombre; }
            set 
            {
                
                if (value.Trim().Length < 1)
                {
                    throw new Exception("Debe ingresar un nombre.");
                }
                else if (value.Trim().Length > 50)
                {

                    throw new Exception("El nombre debe tener entre 1 y 50 caracteres.");
                }    
                
                else{ nombre = value; }

            }
        }

        public Medico(string nombre) 
        {
            Nombre = nombre;
        }

    }
}
