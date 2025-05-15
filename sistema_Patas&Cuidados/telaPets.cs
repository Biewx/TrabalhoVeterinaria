using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;


namespace sistema_Patas_Cuidados
{
    public partial class telaPets : Form
    {

        public telaPets(string nomePet, string especie, string tutor, int numeroConsulta)
        {
            InitializeComponent();

            lblNomePet.Text = nomePet;
            lblEspecie2.Text = especie;
            lblTutor2.Text = tutor;
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

        private void lblNomePet_Click(object sender, EventArgs e)
        {

        }

        private void lblDiagnostico_Click(object sender, EventArgs e)
        {

        }

        private async void btnVerDiagnostico_Click(object sender, EventArgs e)
        {
            string sintomasDigitados = txtSintomas.Text.ToLower().Trim();

            if (string.IsNullOrEmpty(sintomasDigitados))
            {
                MessageBox.Show("Digite os sintomas.");
                return;
            }


            Dictionary<string, string> diagnosticos = new Dictionary<string, string>
            {
                 { "febre",
          "Febre pode indicar infecção, inflamação ou outras condições. Observe a duração e procure um veterinário. \n" +
          "Tratamento: manter hidratação e monitorar temperatura; medicamentos só com orientação." },

        { "dor no corpo",
          "Dor no corpo pode ser sinal de trauma, inflamação muscular ou doenças sistêmicas. \n" +
          "Tratamento: Recomenda-se repouso e avaliação veterinária para diagnóstico preciso." },

        { "espirro",
          "Espirros frequentes podem indicar alergias, irritação nasal ou infecções respiratórias. \n" +
          "Tratamento: Evitar ambientes com poeira e poluição, e consultar o veterinário se persistir." },

        { "tosse",
          "Tosse pode indicar problemas respiratórios, como bronquite, pneumonia ou parasitas pulmonares. \n" +
          "Tratamento: Procure atendimento veterinário para avaliação e tratamento adequado." },

        { "diarreia",
          "Diarreia pode indicar intoxicação alimentar, infecção, parasitas ou mudanças na dieta. \n" +
          "Tratamento: Mantenha hidratação e alimentação leve; se durar mais que 24h, consulte um veterinário." },

        { "vômito",
          "Vômitos repetidos exigem atenção, pois podem causar desidratação e indicar problemas digestivos. \n" +
          "Tratamento: Interrompa alimentos sólidos e procure ajuda veterinária se continuar." },

        { "letargia",
          "Letargia indica fraqueza, falta de energia, e pode estar associada a várias doenças. \n" +
          "Tratamento: Monitorar outros sintomas e buscar avaliação veterinária urgente." },

        { "coceira",
          "Coceira persistente pode indicar alergias, infestação por parasitas ou infecções de pele. \n" +
          "Tratamento: Evite banhos com produtos irritantes e consulte para tratamento adequado." },

        { "perda de apetite",
          "A perda de apetite pode ser sintoma de doença, estresse ou problema dentário. \n" +
          "Tratamento: Observe se há outros sinais e procure o veterinário se durar mais que 24h." },

        { "olhos vermelhos",
          "Olhos vermelhos podem indicar conjuntivite, alergias ou irritação. \n" +
          "Tratamento: Evite coçar e mantenha o ambiente limpo; avaliação veterinária é recomendada." },

        { "dificuldade para respirar",
          "Dificuldade respiratória é um sinal grave que requer atendimento veterinário imediato. \n" +
          "Tratamento: Mantenha o animal calmo e leve-o ao veterinário o quanto antes." },

        { "inchaço",
          "Inchaços podem indicar abscessos, alergias ou tumores. \n" +
          "Tratamento: Não tente espremer; procure um veterinário para diagnóstico e tratamento." },

        { "fraqueza",
          "Fraqueza pode estar associada a anemia, desidratação ou doenças crônicas. \n" +
          "Tratamento: Procure atendimento para avaliação completa." },

        { "perda de peso",
          "Perda de peso inesperada pode indicar parasitas, problemas digestivos ou doenças graves. \n" +
          "Tratamento: Investigue com um veterinário." },

        { "secreção nasal",
          "Secreção nasal pode indicar infecções respiratórias ou alergias. \n" +
          "Tratamento: Mantenha o ambiente limpo e procure avaliação se piorar." },

        { "mudança no comportamento",
          "Alterações no comportamento, como agressividade ou apatia, podem sinalizar dor ou doença. \n" +
          "Tratamento: Avalie junto com outros sintomas e consulte um veterinário." },

        { "sangramento",
          "Sangramentos, mesmo pequenos, podem indicar trauma ou problemas de coagulação. \n" +
          "Tratamento: Procure atendimento imediatamente." },

        { "dificuldade para urinar",
          "Dificuldade ou dor para urinar pode indicar infecção urinária ou bloqueios. \n" +
          "Tratamento: Procure ajuda veterinária urgente." },

        { "salivação excessiva",
          "Salivação excessiva pode ser sinal de problemas bucais, náuseas ou intoxicações. \n" +
          "Tratamento: Verifique a boca e procure orientação veterinária." }
            };

            string resultado = "";

            foreach (var item in diagnosticos)
            {
                if (sintomasDigitados.Contains(item.Key))
                {
                    resultado += item.Value + " ";
                }
            }

            if (string.IsNullOrEmpty(resultado))
            {
                resultado = "Nenhum diagnóstico encontrado para os sintomas informados.";
            }

            lblDiagnostico.Text = "Diagnóstico: " + resultado;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            telaConsultas consultas = new telaConsultas();
            consultas.Show();
            this.Close();
        }

        private void lblSintomas_Click(object sender, EventArgs e)
        {

        }
    }


}
