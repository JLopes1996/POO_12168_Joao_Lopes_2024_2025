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
    public partial class Bilhetes : Form
    {
        public Bilhetes()
        {
            InitializeComponent();
        }

        private void Bilhetes_Load(object sender, EventArgs e)
        {
            {
                // Definir o texto extenso no TextBox
                textBox_Bilhetes_Texto.Text = "Texto sobre os bilhetes " +
                "Preço sobre os bilhetes. ";
            }
        }

        private void btn_Inicio_Login_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de Menu_Inicio_1
            Menu_Inicio_1 Menu_Inicio_1 = new Menu_Inicio_1();
            Menu_Inicio_1.Show();

            // Fechar o formulário
            this.Hide();
        }
    }
}
