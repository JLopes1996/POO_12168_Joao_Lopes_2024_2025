using System;
using System.Windows.Forms;

namespace Jardim_Zoológico.Menu_Inicio
{
    /// <summary>
    /// Formulário de Menu Inicial do Horário
    /// </summary>
    public partial class Form_Menu_Inicial_Horário : Form
    {
        #region Inicialização

        /// <summary>
        /// Função que inicializa o formulário
        /// </summary>
        public Form_Menu_Inicial_Horário()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Descrição do horário do jardim zoológico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Horário_Load(object sender, EventArgs e)
        {
            {
                // Definir o texto extenso no TextBox
                textBox_Horário_Texto.Text = " O jardim zoológico encontra-se aberto todos os dias. \r\n\r\n" + 
                " Horário de abertura das bilheteiras: \r\n\r\n" + " - Verão (21.03 a 20.09) - 10h. \r\n" + " - Inverno (21.09 a 20.03) - 10h. \r\n\r\n"
                + " Horário de encerramento das bilheteiras: \r\n\r\n" + " - Verão (21.03 a 20.09) - 20h. \r\n" + " - Inverno (21.09 a 20.03) - 18h.";
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
            Form_Menu_Inicial Menu_Inicial = new Form_Menu_Inicial();
            Menu_Inicial.Show();

            // Fechar o formulário
            this.Hide();
        }

        #endregion
    }
}