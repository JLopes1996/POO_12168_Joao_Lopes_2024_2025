using Jardim_Zoológico.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Jardim_Zoológico.Menu_Funcionarios
{

    /// <summary>
    /// Formulário para registar um bilhete.
    /// </summary>
    public partial class Form_Registar_Bilhetes : Form
    {
        #region Inicialização

        /// <summary>
        /// Função para inicializar o formulário.
        /// </summary>
        public Form_Registar_Bilhetes()
        {
            InitializeComponent();

            CarregarAnimais();
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento para registar um bilhete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Registar_Bilhete_Click(object sender, EventArgs e)
        {
            // Dados do espetáculo
            string nome_do_espectaculo = textBox_Nome_Espetaculo.Text;
            DateTime horario_do_espectaculo = dateTimePicker_Horario_Espetaculo.Value;
            string duracao_do_espectaculo = textBox_Duracao_Espataculo.Text;
            Animal animal_do_espetaculo = comboBox_Animal_Espetaculo.SelectedItem as Animal; // ComboBox com os animais existentes
            string local_do_espectaculo = textBox_Local_Espetaculo.Text;
            string capacidade_do_espectaculo = comboBox_Capacidade_Espetaculo.SelectedItem.ToString(); // Pequena, Média, Grande
            string descricao_do_espectaculo = textBox_Descricao_Espetaculo.Text;

            // Verificação de campos obrigatórios
            if (string.IsNullOrWhiteSpace(nome_do_espectaculo) || string.IsNullOrWhiteSpace(local_do_espectaculo))
            {
                MessageBox.Show("Preencha todos os campos sobre o espetáculo.");
                return;
            }

            //Dados do bilhete
            float precoBilhete = float.Parse(textBox_Preço_Bilhete.Text);
            string tipoBilhete = comboBox_Tipo_Bilhete.SelectedItem.ToString(); // Adulto, Criança, etc.

            // Verificação de campos obrigatórios
            if (precoBilhete <= 0 || string.IsNullOrWhiteSpace(tipoBilhete))
            {
                MessageBox.Show("Preencha todos os campos sobre o bilhete.");
                return;
            }

            if (precoBilhete <= 0)
            {
                MessageBox.Show("O valor do bilhete deve ser maior que zero.");
                return;
            }

            // Carregar bilhetes existentes
            List<Bilhete> bilhetes = new List<Bilhete>();

            if (File.Exists("bilhetes.json"))
            {
                bilhetes = JsonConvert.DeserializeObject<List<Bilhete>>(File.ReadAllText("bilhetes.json")) ?? new List<Bilhete>();
            }

            // Gerar novo Id para o bilhete
            int novoIdBilhete = bilhetes.Any() ? bilhetes.Max(b => b.Id) + 1 : 1;

            // Criar o objeto Bilhete com os dados do espetáculo e bilhete
            Bilhete novoBilhete = new Bilhete(nome_do_espectaculo, horario_do_espectaculo, duracao_do_espectaculo, animal_do_espetaculo, local_do_espectaculo, capacidade_do_espectaculo, descricao_do_espectaculo, novoIdBilhete, precoBilhete, tipoBilhete);

            // Adicionar o bilhete à lista
            bilhetes.Add(novoBilhete);

            // Salvar no arquivo JSON
            File.WriteAllText("bilhetes.json", JsonConvert.SerializeObject(bilhetes, Formatting.Indented));

            MessageBox.Show("Bilhete registado com sucesso!");
            this.Close(); // Fecha o formulário
        }

        /// <summary>
        /// Evento para carregar os animais na ComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Registar_Bilhetes_Load_1(object sender, EventArgs e)
        {
            comboBox_Capacidade_Espetaculo.Items.Add("Pequena");
            comboBox_Capacidade_Espetaculo.Items.Add("Média");
            comboBox_Capacidade_Espetaculo.Items.Add("Grande");

            comboBox_Tipo_Bilhete.Items.Add("Criança");
            comboBox_Tipo_Bilhete.Items.Add("Adulto");
            comboBox_Tipo_Bilhete.Items.Add("Idoso");
        }

        /// <summary>
        /// Evento para exibir informações do animal selecionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_Animal_Espetaculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se há um item selecionado
            if (comboBox_Animal_Espetaculo.SelectedItem != null)
            {
                // Obter o animal selecionado
                Animal animalSelecionado = (Animal)comboBox_Animal_Espetaculo.SelectedItem;

                // Exibir as informações do animal em Labels ou TextBoxes
                label_AnimalTipo.Text = $"Tipo: {animalSelecionado.Tipo}";
            }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Método para carregar a lista de animais.
        /// </summary>
        private void CarregarAnimais()
        {
            string filePath = "animais.json"; // Caminho do arquivo JSON que contém os animais

            if (File.Exists(filePath))
            {
                try
                {
                    // Lê o conteúdo do arquivo JSON
                    string jsonAnimais = File.ReadAllText(filePath);
                    var animais = JsonConvert.DeserializeObject<List<Animal>>(jsonAnimais); // Supondo que a classe Animal exista

                    if (animais != null && animais.Any())
                    {
                        // Preenche a ComboBox com os nomes dos animais
                        comboBox_Animal_Espetaculo.DataSource = animais;
                        comboBox_Animal_Espetaculo.DisplayMember = "Nome"; // Nome do animal exibido
                    }
                    else
                    {
                        MessageBox.Show("Nenhum animal encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar os animais: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Arquivo de animais não encontrado.");
            }
        }

        #endregion
    }
}