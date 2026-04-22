using System;
using System.Collections.Generic;
using System.Text;

namespace DonacionONG.model
{
    internal class Proyecto
    {
        private int idProyecto;
        private string nombreProyecto;
        private string descripcionProyecto;
        private double costoProyecto;

        public int IdProyecto 
        {
            get => idProyecto; set => idProyecto = value; 
        }
        public string NombreProyecto 
        { 
            get => nombreProyecto;
            set => nombreProyecto = value; 
        }
        public string DescripcionProyecto 
        { 
            get => descripcionProyecto; set => descripcionProyecto = value; 
        }
        public double CostoProyecto 
        { 
            get => costoProyecto; set => costoProyecto = value; 
        }
    }
}
