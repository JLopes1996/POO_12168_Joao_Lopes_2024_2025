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
    public partial class Horário : Form
    {
        public Horário()
        {
            InitializeComponent();
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
