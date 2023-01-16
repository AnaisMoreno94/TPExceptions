using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPExceptions;

namespace WindowsExceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearMedicoVacio_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico = new Medico("");
                MessageBox.Show($"Medico Creado: {medico.Nombre}");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnCrearMedicoLargo_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico = new Medico("asdfgqtweuioksdhtuopemdhuslametuhdjspeutirasfjrtujspoerjas");
                MessageBox.Show($"Medico Creado: {medico.Nombre}");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnCrearMedico_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico = new Medico("Ana");
                MessageBox.Show($"Medico Creado: {medico.Nombre}");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
