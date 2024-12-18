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
    public partial class Form_Registar_Funcionário : Form
    {
        // Lista dos funcionários
        private string FilePathFuncionarios = "funcionarios.json";

        public Form_Registar_Funcionário()
        {
            InitializeComponent();
        }

        private void Form_Registar_Funcionário_Load(object sender, EventArgs e)
        {
            {
                comboBox_Cargo.Items.Add("Funcionario");
            }
        }

        private void btn_Registar_Click(object sender, EventArgs e)
        {
            {
                string nome = textBox_Nome.Text;
                string cargo = comboBox_Cargo.SelectedItem?.ToString(); //Funcionário
                DateTime dataDeEntrada = DateTime.Parse(textBox_Data_De_Entrada.Text);
                float salário = float.Parse(textBox_Salário.Text);
                string password = textBox_Password.Text; 

                // Validação básica
                if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cargo) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Todos os campos são obrigatórios.");
                    return;
                }

                // Validação da data
                if (!DateTime.TryParse(textBox_Data_De_Entrada.Text, out dataDeEntrada))
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

                // Verifica se o funcionário já existe
                List<Funcionario> funcionarios = new List<Funcionario>();

                // Se existir o arquivo, carrega os dados
                if (File.Exists(FilePathFuncionarios))
                {
                    funcionarios = JsonConvert.DeserializeObject<List<Funcionario>>(File.ReadAllText(FilePathFuncionarios)) ?? new List<Funcionario>();
                }

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
                Funcionario novoFuncionario = new Funcionario(newId, nome, cargo, dataDeEntrada, salário, password);
                funcionarios.Add(novoFuncionario);

                // Salva no arquivo JSON
                File.WriteAllText(FilePathFuncionarios, JsonConvert.SerializeObject(funcionarios, Formatting.Indented));

                MessageBox.Show("Funcionário registado com sucesso!");

                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
