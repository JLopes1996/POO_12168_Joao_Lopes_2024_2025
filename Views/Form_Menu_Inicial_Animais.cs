using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jardim_Zoológico.Models;
using Newtonsoft.Json;
using System.IO;

namespace Jardim_Zoológico.Menu_Inicio
{
    /// <summary>
    /// Formulário para visualizar a lista de animais do jardim zoológico.
    /// </summary>
    public partial class Form_Menu_Inicial_Animais : Form
    {
        /// <summary>
        /// Lista de animais do jardim zoológico.
        /// </summary>
        private List<Animal> animais; // Supondo que você tenha uma classe Animal

        #region Inicialização

        public Form_Menu_Inicial_Animais()
        {
            InitializeComponent();

            // Carregar os animais do arquivo JSON
            animais = CarregarAnimais();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Método para carregar os animais do arquivo JSON.
        /// </summary>
        /// <returns></returns>
        public List<Animal> CarregarAnimais()
        {
            // Caminho do arquivo JSON
            string filePath = "animais.json";

            // Verificar se o arquivo existe
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Arquivo de animais não encontrado!");
                return new List<Animal>();
            }

            // Ler o conteúdo do arquivo
            string json = File.ReadAllText(filePath);

            // Desserializar o conteúdo JSON na lista de bilhetes
            var animais = JsonConvert.DeserializeObject<List<Animal>>(json);

            return animais;
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento acionado quando o botão "Voltar" é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Inicio_Login_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de Menu_Inicio_1
            Form_Menu_Inicial Menu_Inicial = new Form_Menu_Inicial();
            Menu_Inicial.Show();

            // Fechar o formulário
            this.Hide();
        }

        /// <summary>
        /// Evento acionado quando o formulário é carregado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Menu_Inicial_Animais_Load(object sender, EventArgs e)
        {
            // Verifique se a lista de animais está vazia
            if (animais == null || animais.Count == 0)
            {
                MessageBox.Show("Nenhum animal encontrado.");
                return;
            }

            // Exibir os animais na ListBox
            listBox_Animais.Items.Clear(); // Limpa os itens anteriores

            foreach (var animal in animais)
            {
                // Exibindo o nome, tipo e idade do animal
                listBox_Animais.Items.Add($"Nome: {animal.Nome},   Tipo: {animal.Tipo},   Data de Nascimento: {animal.DataDeNascimento}.");
            }
        }

        #endregion
    }
}
