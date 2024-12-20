using Jardim_Zoológico.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Jardim_Zoológico.Menu_Funcionarios
{
    /// <summary>
    /// Formulário para listar os animais.
    /// </summary>
    public partial class Form_Listar_Animais : Form
    {
        #region Ficheiro

        /// <summary>
        /// Caminho para a lista de animnais.
        /// </summary>
        private const string FilePathAnimais = "animais.json";

        #endregion

        #region Inicialização

        /// <summary>
        /// Função para inicializar o formulário.
        /// </summary>
        public Form_Listar_Animais()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Lista os animais no DataGridView.
        /// </summary>
        private void Listar_Animais()
        {
            // Verifica se o arquivo de animais existe
            if (File.Exists(FilePathAnimais))
            {
                try
                {
                    // Lê o conteúdo do arquivo JSON
                    string jsonAnimais = File.ReadAllText(FilePathAnimais);
                    var animais = JsonConvert.DeserializeObject<List<Animal>>(jsonAnimais);

                    // Verifica se a lista de animais não está vazia
                    if (animais != null && animais.Any())
                    {
                        // Exibe os dados no DataGridView
                        dataGridView_Listar_Animais.DataSource = animais.Select(a => new
                        {
                            a.Id,
                            a.Nome,
                            a.Tipo,
                            Jaula = a.Jaula != null ? $"Jaula {a.Jaula.Id} ({a.Jaula.Capacidade})" : "Sem jaula", // ID e capacidade da jaula
                            Veterinario = a.Veterinario != null ? $"{a.Veterinario.Nome} (ID: {a.Veterinario.Id})" : "Sem veterinário" // Nome e ID do veterinário
                        }).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não há animais registados.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar os dados dos animais: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Arquivo de animais não encontrado.");
            }
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento acionado quando o botão "Listar Animais" é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ver_Animais_Click(object sender, EventArgs e)
        {
            Listar_Animais();
        }

        #endregion
    }
}