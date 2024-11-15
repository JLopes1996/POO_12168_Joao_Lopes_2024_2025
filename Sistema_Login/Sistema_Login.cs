using Jardim_Zoológico.Registos;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using static Jardim_Zoológico.Registos.Registos;

namespace Jardim_Zoológico.Sistema_Login
{
    public partial class Sistema_Login : Form
    {
        private static readonly string FilePath = "utilizadores.json";

        public Sistema_Login()
        {
            InitializeComponent();
            EnsureFileExists();
        }

        private void EnsureFileExists()
        {
            if (!File.Exists(FilePath))
            {
                File.WriteAllText(FilePath, "[]"); // Cria um arquivo JSON vazio
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sistema_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = textBox_Username.Text;
            string password = textBox_Password.Text;

            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                var users = DeserializeUsers(json);

                if (users.Exists(u => u.Username == username && u.Password == password))
                {
                    MessageBox.Show("Login bem-sucedido!");

                    //COLOCAR AQUI O MENU QUE QUERO ABRIR APÓS EFETUAR O LOGIN

                    // Abrir o formulário Menu_Principal
                    //Menu_Principal_1 menuPrincipal = new Menu_Principal_!();
                    //menuPrincipal.Show();

                    // Fechar o formulário de login
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username ou Password incorretos.");
                }
            }
            else
            {
                MessageBox.Show("Nenhum user registado.");
            }
        }

        private void btn_Registar_Click(object sender, EventArgs e)
        {
            // Exibir o formulário de registo para obter os dados do novo usuário
            Jardim_Zoológico.Registos.Registos registosForm = new Jardim_Zoológico.Registos.Registos();
            if (registosForm.ShowDialog() == DialogResult.OK)
            {
                // Obter o novo usuário do formulário de registo
                Jardim_Zoológico.Registos.Registos.User new_user = registosForm.NewUser;

                // Converter o usuário do formulário de registo para o tipo de usuário do sistema de login
                User loginUser = new User
                {
                    Username = new_user.Username,
                    Password = new_user.Password
                };

                // Ler o conteúdo existente do arquivo
                string json = File.ReadAllText(FilePath);
                var users = DeserializeUsers(json);

                // Adicionar o novo usuário à lista
                users.Add(loginUser);

                // Remover duplicados
                users = RemoveDuplicateUsers(users);

                // Serializar a lista atualizada de volta para JSON com formatação legível
                string updatedJson = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText(FilePath, updatedJson);

                MessageBox.Show("Usuário registado com sucesso!");
            }
        }

        private void Sistema_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private List<User> DeserializeUsers(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                return new List<User>();
            }

            try
            {
                return JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
            }
            catch (JsonException)
            {
                MessageBox.Show("Erro ao ler o arquivo de usuários. O arquivo pode estar corrompido.");
                return new List<User>();
            }
        }

        private List<User> RemoveDuplicateUsers(List<User> users)
        {
            var uniqueUsers = new HashSet<string>();
            var distinctUsers = new List<User>();

            foreach (var user in users)
            {
                if (uniqueUsers.Add(user.Username))
                {
                    distinctUsers.Add(user);
                }
            }

            return distinctUsers;
        }

        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        private void btn_Inicio_Login_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de Menu_Inicio_1
            Menu_Inicio.Menu_Inicio_1 Menu_Inicio_1 = new Menu_Inicio.Menu_Inicio_1();
            Menu_Inicio_1.Show();

            // Fechar o formulário
            this.Hide();
        }
    }
}