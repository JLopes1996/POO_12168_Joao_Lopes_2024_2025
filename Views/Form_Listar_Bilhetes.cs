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
    /// Formulário para listar os bilhetes.
    /// </summary>
    public partial class Form_Listar_Bilhetes : Form
    {
        #region Ficheiro

        /// <summary>
        /// Caminho para a lista de bilhetes.
        /// </summary>
        private const string FilePathBilhetes = "bilhetes.json";

        #endregion

        #region Inicialização

        public Form_Listar_Bilhetes()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Lista os bilhetes no DataGridView.
        /// </summary>
        private void Listar_Bilhetes()
        {
            // Verifica se o arquivo de animais existe
            if (File.Exists(FilePathBilhetes))
            {
                try
                {
                    // Lê o conteúdo do arquivo JSON
                    string jsonbilhetes = File.ReadAllText(FilePathBilhetes);
                    var bilhetes = JsonConvert.DeserializeObject<List<Bilhete>>(jsonbilhetes);

                    // Verifica se a lista de animais não está vazia
                    if (bilhetes != null && bilhetes.Any())
                    {
                        // Exibe os dados no DataGridView
                        dataGridView_Listar_Bilhetes.DataSource = bilhetes.Select(b => new
                        {
                            b.Id,
                            b.Nome,
                            b.Tipo,
                            b.Horario,
                            b.Duracao
                        }).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não há bilhetes registados.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar os dados dos bilhetes: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Arquivo de bilhetes não encontrado.");
            }
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento acionado quando o botão "Listar Bilhetes" é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ver_Bilhetes_Click(object sender, EventArgs e)
        {
            Listar_Bilhetes();
        }

        #endregion
    }
}