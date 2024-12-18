using Jardim_Zoológico.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Jardim_Zoológico.Registos
{
    public partial class Registos : Form
    {
        public Cliente NewCliente { get; private set; }
        
        private static readonly string FilePathClientes = "clientes.json";
        
        private static readonly string FilePathFuncionarios = "funcionarios.json";

        public Registos()
        {
            InitializeComponent();
        }

        private void btn_Registar_Click_1(object sender, EventArgs e)
        {
            string username = textBox_Username.Text;
            string password = textBox_Password.Text;
            string nif = textBox_NIF.Text;
            string contacto = textBox_Contacto.Text;

            // Verifica se todos os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(nif) || string.IsNullOrWhiteSpace(contacto))
            {
                MessageBox.Show("Todos os campos são de preenchimento obrigatório.");
                return;
            }

            var clientes = new List<Cliente>();
            var funcionarios = new List<Funcionario>();

            // Verifica se o arquivo de clientes existe e carrega os dados
            if (File.Exists(FilePathClientes))
            {
                try
                {
                    string json = File.ReadAllText(FilePathClientes);
                    clientes = JsonConvert.DeserializeObject<List<Cliente>>(json) ?? new List<Cliente>();
                }
                catch (JsonException ex)
                {
                    MessageBox.Show($"Erro ao ler JSON: {ex.Message}");
                    return;
                }

            // Verifica se o arquivo de funcionários existe e carrega os dados
            if (File.Exists(FilePathFuncionarios))
            {
                try
                {
                    string jsonFuncionarios = File.ReadAllText(FilePathFuncionarios);
                    funcionarios = JsonConvert.DeserializeObject<List<Funcionario>>(jsonFuncionarios) ?? new List<Funcionario>();
                 }
                catch (JsonException ex)
                {
                    MessageBox.Show($"Erro ao ler JSON de funcionários: {ex.Message}");
                    return;
                }
             }

                // Verifica se o username já existe como cliente ou funcionário
                if (clientes.Exists(u => u.Nome == username || funcionarios.Exists(f => f.Nome == username)) || clientes.Exists (u => u.NIF == nif))
                {
                    MessageBox.Show("Username ou nif já existe.");
                    return;
                }

                // Encontrar o maior Id existente na lista de clientes
                int maxId = clientes.Any() ? clientes.Max(c => c.Id) : 0;

                // Atribuir um novo Id para o cliente (incrementar o maior Id existente)
                int newId = maxId + 1;

                // Criação do novo cliente com todos os parâmetros
                Cliente newCliente = new Cliente(newId, username, nif, contacto, password, null);

                // Adicionar o novo cliente à lista
                clientes.Add(newCliente);

                // Serializar e salvar os dados atualizados
                string updatedJson = JsonConvert.SerializeObject(clientes, Formatting.Indented);
                File.WriteAllText(FilePathClientes, updatedJson);

                MessageBox.Show("Cliente registado com sucesso!");
                this.DialogResult = DialogResult.OK;

                Menu_Inicio.Menu_Inicio_1 menuInicio = new Menu_Inicio.Menu_Inicio_1();
                menuInicio.Show();
                this.Close();
            }
        }

        private void Registos_Load(object sender, EventArgs e)
        {

        }

        private void btn_Inicio_Login_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de Menu_Inicio_1
            Menu_Inicio.Menu_Inicio_1 Menu_Inicio_1 = new Menu_Inicio.Menu_Inicio_1();
            Menu_Inicio_1.Show();

            // Fechar o formulário
            this.Hide();
        }

        private void label_Titulo_Click(object sender, EventArgs e)
        {

        }
    }
}