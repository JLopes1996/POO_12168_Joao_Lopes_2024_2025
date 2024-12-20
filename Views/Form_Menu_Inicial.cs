using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jardim_Zoológico.Menu_Inicio
{
    /// <summary>
    /// Formulário do menu inicial.
    /// </summary>
    public partial class Form_Menu_Inicial : Form

    {
        #region Inicialização

        public Form_Menu_Inicial()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento acionado quando o botão "Login" é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Inicio_Login_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de login
            Sistema_Login.Form_Sistema_Login Login = new Sistema_Login.Form_Sistema_Login();
            //Login.FormClosed += (s, args) => this.Show(); // Reexibir Menu_Inicio_1 quando o formulário de login for fechado
            Login.Show();
            // Fechar o formulário
            this.Hide();
        }


        /// <summary>
        /// Evento acionado quando o botão "Registo" é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Inicio_Registo_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de Registo
            Registos.Form_Registos Login = new Registos.Form_Registos();
            Login.Show();

            // Fechar o formulário
            this.Hide();
        }

        /// <summary>
        /// Evento acionado quando o botão "Bilhetes" é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Visitar_Bilhetes_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de bilhetes
            Form_Menu_Inicial_Bilhetes Bilhetes = new Form_Menu_Inicial_Bilhetes();
            Bilhetes.Show();

            // Fechar o formulário
            this.Hide();
        }

        /// <summary>
        /// Evento acionado quando o botão "Regras" é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Visitar_Regras_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de informações.
            Form_Menu_Inicial_Regras Informações = new Form_Menu_Inicial_Regras();
            Informações.Show();

            // Fechar o formulário
            this.Hide();
        }

        /// <summary>
        /// Evento acionado quando o botão "Horário" é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Visitar_Horário_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de horário.
            Form_Menu_Inicial_Horário Horário = new Form_Menu_Inicial_Horário();
            Horário.Show();

            // Fechar o formulário
            this.Hide();
        }

        /// <summary>
        /// Evento acionado quando o botão "Agenda" é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Visitar_Agenda_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de horário.
            Form_Menu_Inicial_Agenda Agenda = new Form_Menu_Inicial_Agenda();
            Agenda.Show();

            // Fechar o formulário
            this.Hide();
        }

        /// <summary>
        /// Evento acionado quando o botão "Serviços" é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Visitar_Serviços_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de horário.
            Form_Menu_Inicial_Serviços Serviços = new Form_Menu_Inicial_Serviços();
            Serviços.Show();

            // Fechar o formulário
            this.Hide();
        }

        /// <summary>
        /// Evento acionado quando o botão "Animais" é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Conhecer_Animais_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de bilhetes
            Form_Menu_Inicial_Animais Animais = new Form_Menu_Inicial_Animais();
            Animais.Show();

            // Fechar o formulário
            this.Hide();
        }

        /// <summary>
        /// Evento acionado quando o botão "História" é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Conhecer_História_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de bilhetes
            Form_Menu_Inicial_História História = new Form_Menu_Inicial_História();
            História.Show();

            // Fechar o formulário
            this.Hide();
        }

        #endregion
    }
}