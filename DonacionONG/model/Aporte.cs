using System;
using System.Collections.Generic;
using System.Text;

namespace DonacionONG.model
{
    internal class Aporte
    {
        private int idAporte;
        private double montoAporte;
        private DateTime fechaAporte;
        private int donanteAporte;
        private int proyectoAporte;

        public Aporte(int idAporte, double montoAporte, DateTime fechaAporte, int donanteAporte, int proyectoAporte)
        {
            this.idAporte = idAporte;
            this.montoAporte = montoAporte;
            this.fechaAporte = fechaAporte;
            this.donanteAporte = donanteAporte;
            this.proyectoAporte = proyectoAporte;
        }

        public int IdAporte { get => idAporte; set => idAporte = value; }
        public double MontoAporte { get => montoAporte; set => montoAporte = value; }
        public DateTime FechaAporte { get => fechaAporte; set => fechaAporte = value; }
        public int DonanteAporte { get => donanteAporte; set => donanteAporte = value; }
        public int ProyectoAporte { get => proyectoAporte; set => proyectoAporte = value; }
    }
}
