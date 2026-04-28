using DonacionONG.model;
using DonacionONG.view.formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DonacionONG.view
{
    public partial class Dashboard : Form
    {
        private List<Donante> listaDonantes = new List<Donante>();
        public Dashboard()
        {
            InitializeComponent();
            customProperties();
        }












        void customProperties()
        {
            pintarDgv();
        }

        void cargarDonantes()
        {
            Donante d = new Donante(1, "Bárbara", "22.344.902-3", "+569 8475 9621", 2500000);
            Donante d1 = new Donante(2, "Juan", "22.584.932-1", "+569 8475 9621", 2500000);
            Donante d2 = new Donante(3, "Vicente", "22.976.902-9", "+569 8475 9621", 2500000);
            Donante d3 = new Donante(4, "Allan", "22.187.937-5", "+569 8475 9621", 2500000);
            Donante d4 = new Donante(5, "Luis", "22.752.847-0", "+569 8475 9621", 2500000);
            Donante d5 = new Donante(6, "Francisco", "22.835.018-4", "+569 8475 9621", 2500000);

            listaDonantes.Add(d);
            listaDonantes.Add(d1);
            listaDonantes.Add(d2);
            listaDonantes.Add(d3);
            listaDonantes.Add(d4);
            listaDonantes.Add(d5);
        }

        void pintarDgv()
        {
            cargarDonantes();
            var bindingList = new BindingList<Donante>(listaDonantes);
            tablaDonantes.DataSource = bindingList;
            tablaDonantes.AutoGenerateColumns = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void donantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDonante formDonante = new FormDonante();
            formDonante.Show();
        }

        private void aportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAporte formAporte = new FormAporte();
            formAporte.Show();
        }

        private void proyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProyecto formProyecto = new FormProyecto();
            formProyecto.Show();
        }
    }
}
