using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Xml.Linq;

namespace sistema_Patas_Cuidados
{
    public partial class telaPrinciapal : Form
    {
        public telaPrinciapal()
        {
            InitializeComponent();
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void btAgendar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = Conexao.ObterConexao();

            string sql = @"INSERT INTO consultas 
                   (nome_pet, especie, tutor, contato, veterinario, numero_consulta, data_consulta, horario, motivo)
                   VALUES (@nome_pet, @especie, @tutor, @contato, @veterinario, @numero, @data, @horario, @motivo)";

            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@nome_pet", txtPet.Text);
                cmd.Parameters.AddWithValue("@especie", txtEspecie.Text);
                cmd.Parameters.AddWithValue("@tutor", txtTutor.Text);
                cmd.Parameters.AddWithValue("@contato", txtContato.Text);
                cmd.Parameters.AddWithValue("@veterinario", txtVeterinario.Text);
                cmd.Parameters.AddWithValue("@numero", Convert.ToInt32(txtNumeroConsulta.Text));
                cmd.Parameters.AddWithValue("@data", DateTime.Parse(txtData.Text));
                cmd.Parameters.AddWithValue("@horario", TimeSpan.Parse(txtHorario.Text));
                cmd.Parameters.AddWithValue("@motivo", txtMotivo.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Consulta agendada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao agendar: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void dgvConsultas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgvConsultas.Rows[e.RowIndex];

                string nomePet = linha.Cells["nome_pet"].Value.ToString();
                string especie = linha.Cells["especie"].Value.ToString();
                string tutor = linha.Cells["tutor"].Value.ToString();
                int numeroConsulta = Convert.ToInt32(linha.Cells["numero_consulta"].Value);

                telaPets prontuario = new telaPets(nomePet, especie, tutor, numeroConsulta);
                prontuario.Show();
                this.Hide();
            }
        }
    }
}
