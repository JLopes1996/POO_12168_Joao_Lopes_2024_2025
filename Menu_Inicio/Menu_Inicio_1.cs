using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jardim_Zoológico.Menu_Inicio
{
    public partial class Menu_Inicio_1 : Form

    {
        public Menu_Inicio_1()
        {
            InitializeComponent();
        }

        //BOTÃO PARA ACEDER AO LOGIN
        private void btn_Inicio_Login_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de login
            Sistema_Login.Sistema_Login Login = new Sistema_Login.Sistema_Login();
            //Login.FormClosed += (s, args) => this.Show(); // Reexibir Menu_Inicio_1 quando o formulário de login for fechado
            Login.Show();
            // Fechar o formulário
            this.Hide();
        }

        //BOTÃO PARA ACEDER AO REGISTO
        private void btn_Inicio_Registo_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de Registo
            Registos.Registos Login = new Registos.Registos();
            Login.Show();

            // Fechar o formulário
            this.Hide();
        }

        //BOTÃO PARA ACEDER Á INFORMAÇÃO SOBRE OS BILHETES
        private void btn_Visitar_Bilhetes_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de bilhetes
            Bilhetes Bilhetes = new Bilhetes();
            Bilhetes.Show();

            // Fechar o formulário
            this.Hide();
        }

        private void btn_Visitar_Informações_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de informações.
            Informações Informações = new Informações();
            Informações.Show();

            // Fechar o formulário
            this.Hide();
        }

        private void btn_Visitar_Horário_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de horário.
            Horário Horário = new Horário();
            Horário.Show();

            // Fechar o formulário
            this.Hide();
        }

        private void btn_Visitar_Agenda_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de horário.
            Agenda Agenda = new Agenda();
            Agenda.Show();

            // Fechar o formulário
            this.Hide();
        }

        private void btn_Visitar_Serviços_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de horário.
            Serviços Serviços = new Serviços();
            Serviços.Show();

            // Fechar o formulário
            this.Hide();
        }

        private void btn_Visitar_Calendário_Click(object sender, EventArgs e)
        {
            /*// Abrir o formulário de horário.
            Calendário Calendário = new Calendário();
            Calendário.Show();

            // Fechar o formulário
            this.Hide();*/
        }

        private void btn_Conhecer_Animais_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de bilhetes
            Animais Animais = new Animais();
            Animais.Show();

            // Fechar o formulário
            this.Hide();
        }

        private void btn_Conhecer_História_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de bilhetes
            História História = new História();
            História.Show();

            // Fechar o formulário
            this.Hide();
        }

        private void btn_Conhecer_Resumo_Diário_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de bilhetes
            Resumo_Diário Resumo_Diário = new Resumo_Diário();
            Resumo_Diário.Show();

            // Fechar o formulário
            this.Hide();
        }
    }
}
