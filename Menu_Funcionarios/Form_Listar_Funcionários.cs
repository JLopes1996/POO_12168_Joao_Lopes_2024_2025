using Jardim_Zoológico.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Jardim_Zoológico.Menu_Funcionarios
{
    public partial class Form_Listar_Funcionários : Form
    {
        // Caminho para o arquivo JSON onde os dados dos funcionários estão armazenados
        private const string FilePathFuncionarios = "funcionarios.json"; // Ajuste para o seu caminho real

        public Form_Listar_Funcionários()
        {
            InitializeComponent();
        }

        private void Listar_Funcionários_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ver_Funcionários_Click(object sender, EventArgs e)
        {
            Listar_Funcionarios();
        }

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
    }
}
