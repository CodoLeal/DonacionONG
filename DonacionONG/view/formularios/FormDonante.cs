using DonacionONG.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DonacionONG.view.formularios
{
    public partial class FormDonante : Form
    {

        private List<Donante> listaDonantes;

        public FormDonante()
        {
            InitializeComponent();
            customProperties();
            
        }





        private void customProperties()
        {
            
        }

        public void cargarDonantes(List<Donante> listaDonantes)
        {
            this.listaDonantes = listaDonantes;
        }

    }
}
