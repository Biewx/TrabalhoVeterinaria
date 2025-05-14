using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_Patas_Cuidados
{
    public partial class telaPets : Form
    {
        
            public telaPets(string nomePet, string especie, string tutor, int numeroConsulta)
            {
                InitializeComponent();

                lblNomePet.Text = nomePet;
                lblEspecie.Text = especie;
                lblTutor.Text = tutor;
                lblNumConsulta.Text = numeroConsulta.ToString();
            }
        

        public telaPets()
        {
            InitializeComponent();
        }

        private void telaPets_Load(object sender, EventArgs e)
        {

        }

        private void lblContato_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
