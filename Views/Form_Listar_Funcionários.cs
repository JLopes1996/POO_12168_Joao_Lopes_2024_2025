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
    /// Formulário para listar os funcionários.
    /// </summary>
    public partial class Form_Listar_Funcionários : Form
    {
        #region Ficheiro

        /// <summary>
        /// Caminho para a lista de funcionários.
        /// </summary>
        private const string FilePathFuncionarios = "funcionarios.json";

        #endregion

        #region Inicialização
        
        public Form_Listar_Funcionários()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Lista os funcionários no DataGridView.
        /// </summary>
        private void Listar_Funcionarios()
        {
            // Verifica se o arquivo de funcionários existe
            if (File.Exists(FilePathFuncionarios))
            {
                try
                {
                    // Lê o conteúdo do arquivo JSON
                    string jsonFuncionarios = File.ReadAllText(FilePathFuncionarios);
                    var funcionarios = JsonConvert.DeserializeObject<List<Funcionario>>(jsonFuncionarios);

                    // Verifica se a lista de funcionários não está vazia
                    if (funcionarios != null && funcionarios.Any())
                    {
                        // Exibe os dados no DataGridView
                        dataGridView_Listar_Funcionarios.DataSource = funcionarios.Select(f => new
                        {
                            f.Id,
                            f.Nome,
                            f.Cargo,
                            f.DataDeEntrada,
                            f.Contacto
                        }).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não há funcionários registados.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar dados dos funcionários: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Arquivo de funcionários não encontrado.");
            }
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento acionado quando o botão "Listar Funcionários" é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ver_Funcionários_Click(object sender, EventArgs e)
        {
            Listar_Funcionarios();
        }

        #endregion
    }
}
