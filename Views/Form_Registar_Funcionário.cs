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
    /// Formulário para registar um funcionário.
    /// </summary>
    public partial class Form_Registar_Funcionário : Form
    {
        // Caminho para a lista dos funcionários
        private string FilePathFuncionarios = "funcionarios.json";

        #region Inicialização

        /// <summary>
        /// Função para inicializar o formulário.
        /// </summary>
        public Form_Registar_Funcionário()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Função para carregar os cargos disponíveis.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Registar_Funcionário_Load(object sender, EventArgs e)
        {
            {
                comboBox_Cargo.Items.Add("Gerente");
                comboBox_Cargo.Items.Add("Limpeza");
                comboBox_Cargo.Items.Add("Veterinário");
            }
        }

        /// <summary>
        /// Botão para registar um funcionário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Registar_Click(object sender, EventArgs e)
        {
            {
                string nome = textBox_Nome.Text;
                string cargo = comboBox_Cargo.SelectedItem?.ToString(); //Funcionário
                DateTime dataDeEntrada = DateTime.Parse(dateTimePicker_Data_Entrada.Text);
                float salário = float.Parse(textBox_Salário.Text);
                string password = textBox_Password.Text; 
                string contacto = textBox_Contacto.Text;

                // Validação dos campos
                if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cargo) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Todos os campos são obrigatórios.");
                    return;
                }

                // Validação da data
                if (!DateTime.TryParse(dateTimePicker_Data_Entrada.Text, out dataDeEntrada))
                {
                    MessageBox.Show("Por favor, insira uma data válida no formato dd/MM/yyyy.");
                    return;
                }

                // Validação do salário
                if (!float.TryParse(textBox_Salário.Text, out salário))
                {
                    MessageBox.Show("Por favor, insira um valor numérico válido para o salário.");
                    return;
                }

                // Lê a lista de funcionários
                List<Funcionario> funcionarios = new List<Funcionario>();

                // Se existir o arquivo, carrega os dados
                if (File.Exists(FilePathFuncionarios))
                {
                    funcionarios = JsonConvert.DeserializeObject<List<Funcionario>>(File.ReadAllText(FilePathFuncionarios)) ?? new List<Funcionario>();
                }

                // Verifica se já existe um funcionário com o mesmo nome
                if (funcionarios.Any(f => f.Nome == nome))
                {
                    MessageBox.Show("Já existe um funcionário com esse nome.");
                    return;
                }

                // Encontrar o maior Id existente
                int maxId = funcionarios.Any() ? funcionarios.Max(f => f.Id) : 0;

                // Atribuir um novo Id para o funcionário
                int newId = maxId + 1;

                // Cria o novo funcionário
                Funcionario novoFuncionario = new Funcionario(newId, nome, cargo, dataDeEntrada, salário, password, contacto);

                //Adiciona o funcionário à lista
                funcionarios.Add(novoFuncionario);

                // Salva no arquivo JSON
                File.WriteAllText(FilePathFuncionarios, JsonConvert.SerializeObject(funcionarios, Formatting.Indented));

                MessageBox.Show("Funcionário registado com sucesso!");

                this.Close();
            }
        }

        #endregion
    }
}
