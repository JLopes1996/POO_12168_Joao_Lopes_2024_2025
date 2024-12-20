using System;
using System.Windows.Forms;

namespace Jardim_Zoológico.Menu_Inicio
{

    /// <summary>
    /// Formulário de Menu Inicial das Regras
    /// </summary>
    public partial class Form_Menu_Inicial_Regras : Form
    {
        #region Inicialização

        /// <summary>
        /// Função que inicializa o formulário
        /// </summary>
        public Form_Menu_Inicial_Regras()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Descrição das regras do jardim zoológico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Informações_Load(object sender, EventArgs e)
        {
            // Definir o texto extenso no TextBox
            textBox_Regras_Texto.Text =" - Não alimente em momento algum os animais. \r\n\r\n" + " - Mantenha sempre uma distância segura dos animais. \r\n\r\n" +
            " - É proibido o uso de flash fotográfico. \r\n\r\n" + " - Respeite as áreas exclusivas para funcionários. \r\n\r\n" +
            " - Mantenha o jardim zoológico limpo.";
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