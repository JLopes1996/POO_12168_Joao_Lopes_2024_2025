using Jardim_Zoológico.Models;
using System;
using System.Windows.Forms;
using Jardim_Zoológico.Menu_Funcionarios;

namespace Jardim_Zoológico.Menu_Funcionários
{
    /// <summary>
    /// Formulário do menu principal para os funcionários.
    /// </summary>
    public partial class Form_Menu_Funcionarios : Form
    {
        /// <summary>
        /// Funcionário logado no sistema.
        /// </summary>
        private Funcionario funcionario;

        #region Inicialização

        /// <summary>
        /// Inicializa o formulário do menu de funcionários.
        /// </summary>
        /// <param name="funcionarioLogado">Funcionário logado no sistema</param>
        public Form_Menu_Funcionarios(Funcionario funcionarioLogado)
        {
            InitializeComponent();
            funcionario = funcionarioLogado;
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento acionado quando o botão "Registar Funcionário" é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Evento acionado quando o botão "Listar Funcionários" é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Listar_Funcionários_Click(object sender, EventArgs e)
        {
            // Abre o formulário de listar funcionários
            Form_Listar_Funcionários formListarFuncionarios = new Form_Listar_Funcionários();
            formListarFuncionarios.ShowDialog();
        }

        /// <summary>
        /// Evento acionado quando o botão "Registar Animal" é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Registar_Animal_Click(object sender, EventArgs e)
        {
            {
                Form_Registar_Animal formRegistarAnimal = new Form_Registar_Animal();
                formRegistarAnimal.ShowDialog();
            }
        }

        /// <summary>
        /// Evento acionado quando o botão "Listar Animais" é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Listar_Animal_Click(object sender, EventArgs e)
        {
            // Abre o formulário de listar animais
            Form_Listar_Animais formListarAnimais = new Form_Listar_Animais();
            formListarAnimais.ShowDialog();
        }

        /// <summary>
        /// Evento acionado quando o botão "Registar Bilhete" é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Registar_Bilhete_Click(object sender, EventArgs e)
        {
            Form_Registar_Bilhetes formRegistarBilhetes = new Form_Registar_Bilhetes();
            formRegistarBilhetes.ShowDialog();
        }

        /// <summary>
        /// Evento acionado quando o botão "Listar Bilhetes" é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Listar_Bilhetes_Click(object sender, EventArgs e)
        {
            // Abre o formulário de listar bilhetes
            Form_Listar_Bilhetes formListarbilhetes = new Form_Listar_Bilhetes();
            formListarbilhetes.ShowDialog();
        }

        #endregion
    }
}