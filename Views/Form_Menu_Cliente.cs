using System;
using System.Windows.Forms;

namespace Jardim_Zoológico.Menu_Clientes
{
    /// <summary>
    /// Formulário do menu principal para os clientes.
    /// </summary>
    public partial class Form_Menu_Cliente : Form
    {
        #region Inicialização

        public Form_Menu_Cliente()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento acionado quando o botão "Listar Bilhetes" é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Listar_Bilhetes_Click(object sender, EventArgs e)
        {
            // Abre o formulário de listar bilhetes
            Form_Listar_Bilhetes_Cliente formListarBilhetesCliente = new Form_Listar_Bilhetes_Cliente();
            formListarBilhetesCliente.ShowDialog();
        }

        #endregion
    }
}
