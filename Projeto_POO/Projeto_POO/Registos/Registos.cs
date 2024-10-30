using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Jardim_Zoológico.Registos
{
    public partial class Registos : Form
    {
        public User NewUser { get; private set; }

        private static readonly string FilePath = "utilizadores.json";

        public Registos()
        {
            InitializeComponent();
        }

        private void btn_Registar_Click_1(object sender, EventArgs e)
        {
            string username = textBox_Username.Text;
            string password = textBox_Password.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username e Password não podem estar vazios.");
                return;
            }

            var users = new List<User>();

            if (File.Exists(FilePath))
            {
                try
                {
                    string json = File.ReadAllText(FilePath);
                    users = JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
                }
                catch (JsonException ex)
                {
                    MessageBox.Show($"Erro ao ler JSON: {ex.Message}");
                    return;
                }

                if (users.Exists(u => u.Username == username))
                {
                    MessageBox.Show("Username já existe.");
                    return;
                }

                // Atribuir o novo usuário
                NewUser = new User { Username = username, Password = password };

                // Adicionar o novo usuário à lista
                users.Add(NewUser);

                // Remover duplicados
                users = RemoveDuplicateUsers(users);

                // Serializar a lista atualizada de volta para JSON com formatação legível
                string updatedJson = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText(FilePath, updatedJson);

                MessageBox.Show("Registo bem-sucedido!");
                this.DialogResult = DialogResult.OK;
                this.Close();
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
    }
}