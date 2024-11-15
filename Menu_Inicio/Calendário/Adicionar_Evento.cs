using System;
using System.Windows.Forms;

namespace Jardim_Zoológico.Menu_Inicio.Calendário
{
    public partial class Adicionar_EventoForm : Form
    {
        private object textBox_DescriçãoEvento;

        public string Descrição_Evento { get; private set; }

        public Adicionar_EventoForm()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            Descrição_Evento = Texto_Evento.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Texto_Evento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
