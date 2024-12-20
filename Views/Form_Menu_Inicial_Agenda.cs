using Jardim_Zoológico.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Jardim_Zoológico.Menu_Inicio
{
    /// <summary>
    /// Formulário para visualizar a agenda de espetáculos do jardim zoológico.
    /// </summary>
    public partial class Form_Menu_Inicial_Agenda : Form
    {

        // Lista de bilhetes
        private List<Bilhete> bilhetes;

        #region Inicialização

        public Form_Menu_Inicial_Agenda()
        {
            InitializeComponent();

            // Carregar os bilhetes do arquivo JSON
            bilhetes = CarregarBilhetes();

            // Associar o evento de alteração de data no calendário
            monthCalendar2.DateChanged += monthCalendar2_DateChanged;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Carregar os bilhetes do arquivo JSON.
        /// </summary>
        /// <returns></returns>
        public List<Bilhete> CarregarBilhetes()
        {
            // Caminho do arquivo JSON
            string filePath = "bilhetes.json";

            // Verificar se o arquivo existe
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Arquivo de bilhetes não encontrado!");
                return new List<Bilhete>();
            }

            // Ler o conteúdo do arquivo
            string json = File.ReadAllText(filePath);

            // Desserializar o conteúdo JSON na lista de bilhetes
            var bilhetes = JsonConvert.DeserializeObject<List<Bilhete>>(json);

            return bilhetes;
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento acionado quando o botão "Voltar" é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Voltar_Menu_Inicial_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de Menu_Inicio_1
            Form_Menu_Inicial Menu_Inicial = new Form_Menu_Inicial();
            Menu_Inicial.Show();

            // Fechar o formulário
            this.Hide();
        }

        /// <summary>
        /// Evento acionado quando a data do calendário é alterada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dataSelecionada = e.Start;

            // Filtrar os bilhetes para encontrar os espetáculos da data selecionada
            var espetaculosNoDia = bilhetes
                .Where(b => b.Horario.Date == dataSelecionada.Date)
                .Select(b => b.Nome) // Nome do espetáculo
                .ToList();

            // Exibir os espetáculos na TextBox
            textBox_Agenda_Texto.Text = "Espetáculos para o dia " + dataSelecionada.ToString("dd/MM/yyyy") + ": \n";

            if (espetaculosNoDia.Any())
            {
                foreach (var espetaculo in espetaculosNoDia)
                {
                    textBox_Agenda_Texto.AppendText(espetaculo + "\n");
                }
            }
            else
            {
                textBox_Agenda_Texto.Text += " Nenhum espetáculo programado para este dia.";
            }

        }
        
        #endregion
    }
}