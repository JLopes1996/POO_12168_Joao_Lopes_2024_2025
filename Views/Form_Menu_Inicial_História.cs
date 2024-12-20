using System;
using System.Windows.Forms;

namespace Jardim_Zoológico.Menu_Inicio
{
    /// <summary>
    /// Formulário de Menu Inicial da História
    /// </summary>

    public partial class Form_Menu_Inicial_História : Form
    {
        #region Inicialização

        /// <summary>
        /// Função que inicializa o formulário
        /// </summary>
        public Form_Menu_Inicial_História()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Descrição da história do jardim zoológico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void História_Load(object sender, EventArgs e)
    {
        {
            // Definir o texto extenso no TextBox
            textBox_História_Texto.Text = "Este projeto foi desenvolvido para a disciplina de Programação Orientada a Objetos (POO) com o objetivo de simular a gestão de um Jardim zoológico. \r\n\r\n"
            + "Através de uma interface interativa, o sistema permite a gestão de animais, bilhetes, espetáculos e outros serviços oferecidos aos visitantes (clientes). \r\n\r\n"
            + "O projeto abrange a criação e manipulação de dados como o registo de funcionários, venda de bilhetes e registo de eventos. \r\n\r\n"
            + "Através do uso de conceitos de POO, como classes e objetos, a simulação pretende replicar a rotina diária de um zoológico, oferecendo uma experiência educativa e prática no desenvolvimento de software.  \r\n\r\n"
            + "Aluno: João Carlos da Silva Lopes, 12168. \r\n\r\n" + "Docente: Érnesto Casanova.";
        }
    }


        /// <summary>
        /// Botão que permite voltar ao Menu Inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Voltar_Menu_Inicial_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de Menu_Inicio_1
            Form_Menu_Inicial Menu_Inicio_1 = new Form_Menu_Inicial();
            Menu_Inicio_1.Show();

            // Fechar o formulário
            this.Hide();
        }

        #endregion
    }
}