using System;
using System.Windows.Forms;

namespace Jardim_Zoológico.Menu_Inicio
{
    /// <summary>
    /// Formulário de Menu Inicial dos Serviços 
    /// </summary>
    public partial class Form_Menu_Inicial_Serviços : Form
    {
        #region Inicialização

        /// <summary>
        /// Função que inicializa o formulário
        /// </summary>
        public Form_Menu_Inicial_Serviços()
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
        private void Serviços_Load(object sender, EventArgs e)
        {
            {
                // Definir o texto extenso no TextBox
                textBox_Serviços_Texto.Text = " - Visitas guiadas. \r\n\r\n" + " - Fotografias com os animais. \r\n\r\n"
                + " - Espetáculos. \r\n\r\n" + " - Zona de restauração. \r\n\r\n" + " - Acessos a pessoas com mobilidade reduzida. \r\n\r\n";
            }
        }

        /// <summary>
        /// Botão que permite voltar ao Menu Inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Voltar_Menu_Inicial__Click(object sender, EventArgs e)
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