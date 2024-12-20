using Jardim_Zoológico.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Jardim_Zoológico.Menu_Clientes;

namespace Jardim_Zoológico.Sistema_Login
{
    /// <summary>
    /// Formulário para fazer login no sistema.
    /// </summary>
    public partial class Form_Sistema_Login : Form
    {
        // Caminho para a lista de clientes
        private static readonly string FilePathClientes = "clientes.json";

        // Caminho para a lista de funcionários
        private static readonly string FilePathFuncionarios = "funcionarios.json";

        #region Inicialização

        /// <summary>
        /// Inicializa o formulário de login.
        /// </summary>
        public Form_Sistema_Login()
        {
            InitializeComponent();

            EnsureFileExists();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Verifica se os ficheiros JSON existem e cria-os se não existirem.
        /// </summary>
        private void EnsureFileExists()
        {
            // Se o ficheiro clientes.json não existir, cria um ficheiro JSON vazio
            if (!File.Exists(FilePathClientes))
                File.WriteAllText(FilePathClientes, "[]");

            //Se o ficheiro fuincionarios.json não existir, cria um ficheiro JSON vazio e um gerente
            if (!File.Exists(FilePathFuncionarios))
            {
                // Criação do Gerente Inicial, com os parâmetros necessários
                var gerenteInicial = new Funcionario(
                id: 1,
                nome: "Administrador",
                cargo: "Gerente",
                dataDeEntrada: DateTime.Parse("2024-01-01"),
                salário: 5000.0f,
                password: "12345",
                contacto: "123456789"
                );

                // Adiciona o gerente inicial à lista de funcionários
                var funcionarios = new List<Funcionario> { gerenteInicial };

                // Serializa a lista para JSON e grava no arquivo
                File.WriteAllText(FilePathFuncionarios, JsonConvert.SerializeObject(funcionarios, Formatting.Indented));
            }
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Botão para fazer login no sistema.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = textBox_Username.Text;
            string password = textBox_Password.Text;

            // Flag para verificar se o login foi bem-sucedido
            bool loginBemSucedido = false;

            // Primeiro, verifica se os dados inseridos correspondem a um funcionário
            if (File.Exists(FilePathFuncionarios))
            {
                string jsonFuncionarios = File.ReadAllText(FilePathFuncionarios);
                var funcionarios = JsonConvert.DeserializeObject<List<Funcionario>>(jsonFuncionarios);

                // Encontra o funcionário com o username e password fornecidos
                var funcionario = funcionarios.Find(f => f.Nome == username && f.Password == password);

                // Se o funcionário for encontrado
                if (funcionario != null)
                {
                    MessageBox.Show("Login de Funcionário bem-sucedido!");

                    // Verifica se é o Administrador
                    if (funcionario.Cargo == "Gerente" || funcionario.Cargo == "Funcionario")
                    {
                        // Se for gerente ou funcionário, navega para o menu de funcionários
                        Jardim_Zoológico.Menu_Funcionários.Form_Menu_Funcionarios menuFuncionario = new Jardim_Zoológico.Menu_Funcionários.Form_Menu_Funcionarios(funcionario);
                        menuFuncionario.Show();
                        this.Hide();
                        loginBemSucedido = true; // Marca o login como bem-sucedido
                    }
                    else
                    {
                        MessageBox.Show("Acesso restrito apenas a funcionários.");
                    }
                }
            }

            // Se não for funcionário, verifica se é cliente

            // Só verifica o cliente se o login do funcionário falhar
            if (!loginBemSucedido && File.Exists(FilePathClientes))
            {
                string jsonClientes = File.ReadAllText(FilePathClientes);
                var clientes = JsonConvert.DeserializeObject<List<Cliente>>(jsonClientes);

                // Encontra o cliente com o username e password fornecidos
                var cliente = clientes.Find(c => c.Nome == username && c.Password == password);

                // Se o cliente for encontrado
                if (cliente != null)
                {
                    MessageBox.Show("Login de Cliente bem-sucedido!");

                    // Abre o menu do cliente
                    Form_Menu_Cliente menuCliente = new Form_Menu_Cliente(); // Passa o cliente logado
                    menuCliente.Show();
                    this.Hide();
                    loginBemSucedido = true; // Marca o login como bem-sucedido
                }
            }

            // Se nenhum login foi bem-sucedido
            if (!loginBemSucedido)
            {
                MessageBox.Show("Os dados estão incorretos.");
            }
        }

        /// <summary>
        /// Botão para registar um novo cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Registar_Click(object sender, EventArgs e)
        {
            // Exibe o formulário de registro para o cliente
            Registos.Form_Registos registosForm = new Registos.Form_Registos();
            if (registosForm.ShowDialog() == DialogResult.OK)
            {
                // Cliente registrado com sucesso, vai para o menu inicial
                this.Hide();
            }
        }

        private void Sistema_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Botão para voltar ao menu inicial.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Inicio_Login_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de Menu_Inicio_1
            Menu_Inicio.Form_Menu_Inicial Menu_Inicio_1 = new Menu_Inicio.Form_Menu_Inicial();
            Menu_Inicio_1.Show();

            // Fechar o formulário
            this.Hide();
        }

        #endregion

    }
}