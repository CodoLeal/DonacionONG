using System;
using System.Collections.Generic;
using System.Text;

namespace DonacionONG.model
{
    internal class Donante
    {
        private int idDonante;
        private string nombreDonante;
        private string rutDonante;
        private string telefonoDonante;
        private double montoDonado;

        public Donante(int idDonante, string nombreDonante, string rutDonante, string telefonoDonante, double montoDonado)
        {
            this.idDonante = idDonante;
            this.nombreDonante = nombreDonante;
            this.rutDonante = rutDonante;
            this.telefonoDonante = telefonoDonante;
            this.montoDonado = montoDonado;
        }

        public int IdDonante { get => idDonante; set => idDonante = value; }
        public string NombreDonante { get => nombreDonante; set => nombreDonante = value; }
        public string RutDonante { get => rutDonante; set => rutDonante = value; }
        public string TelefonoDonante { get => telefonoDonante; set => telefonoDonante = value; }
        public double MontoDonado { get => montoDonado; set => montoDonado = value; }   
    }
}
