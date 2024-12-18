using Jardim_Zoológico.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jardim_Zoológico.Menu_Funcionarios;

namespace Jardim_Zoológico.Menu_Funcionários
{
    public partial class Form_Menu_Funcionarios : Form
    {
        private Funcionario funcionario;

        public Form_Menu_Funcionarios(Funcionario funcionarioLogado)
        {
            InitializeComponent();
            funcionario = funcionarioLogado;
        }

        private void Menu_Funcionarios_Load(object sender, EventArgs e)
        {

        }

        private void btn_Registar_Funcionário_Click(object sender, EventArgs e)
        {
            {
                // Verifica se o funcionário logado é gerente
                if (funcionario.Cargo == "Gerente")
                {
                    Form_Registar_Funcionário Form_RegistarFuncionário = new Form_Registar_Funcionário();
                    Form_RegistarFuncionário.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Somente o gerente pode registar novos funcionários.");
                }
            }
        }

        private void btn_Listar_Funcionários_Click(object sender, EventArgs e)
        {
            // Abre o formulário de listar funcionários
            Form_Listar_Funcionários formListarFuncionarios = new Form_Listar_Funcionários();
            formListarFuncionarios.ShowDialog();
        }
    }
}
