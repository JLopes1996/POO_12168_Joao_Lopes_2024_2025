using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Jardim_Zoológico
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Menu_Principal_FormClosed);
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Menu_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
