using System;
using System.Windows.Forms;

namespace Jardim_Zoológico.Menu_Inicio
{
    /// <summary>
    /// Formulário de Menu Inicial dos Bilhetes
    /// </summary>
    public partial class Form_Menu_Inicial_Bilhetes : Form
    {
        #region Inicialização

        /// <summary>
        /// Função que inicializa o formulário
        /// </summary>
        public Form_Menu_Inicial_Bilhetes()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos
        /// <summary>
        /// Descrição do preço dos bilhetes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bilhetes_Load(object sender, EventArgs e)
        {
            {
                // Definir o texto extenso no TextBox
                textBox_Bilhetes_Texto.Text =" - Criança (3- 12 anos) - 5,00€. \r\n\r\n" + " - Sénior (+ 66 anos) - 7,5 €. \r\n\r\n"
                + " - Forças de Segurança, equipas médicas, pessoas com incapacidade e <3 anos - 0, 00€. \r\n\r\n"
                + " - Para efetuar a compra do bilhete terá de efetuar registo, seguido de login. \r\n\r\n";
            }
        }

        /// <summary>
        /// Botão que permite voltar ao Menu Inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de Menu_Inicial
            Form_Menu_Inicial Menu_Inicial = new Form_Menu_Inicial();
            Menu_Inicial.Show();

            // Fechar o formulário
            this.Hide();
        }

        #endregion
    }
}
