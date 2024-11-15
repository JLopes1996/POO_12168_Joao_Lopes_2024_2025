using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Jardim_Zoológico.Menu_Inicio
{
    public partial class Calendário : Form
    {
        // Dicionário para armazenar eventos
        private Dictionary<DateTime, string> eventos;

        public Calendário()
        {
            InitializeComponent();
            eventos = new Dictionary<DateTime, string>();
        }

        private void btn_Inicio_Login_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de Menu_Inicio_1
            Menu_Inicio_1 Menu_Inicio_1 = new Menu_Inicio_1();
            Menu_Inicio_1.Show();

            // Fechar o formulário
            this.Hide();
        }

        // Manipulador de evento para mudança de data no calendário
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Obter a data selecionada
            DateTime dataSelecionada = monthCalendar1.SelectionRange.Start;

            // Exibir eventos para a data selecionada
            ExibirEventos(dataSelecionada);
        }

        // Manipulador de evento para clique no botão de adicionar evento
        private void btn_Add_Evento_Click(object sender, EventArgs e)
        {
            // Obter a data selecionada
            DateTime dataSelecionada = monthCalendar1.SelectionRange.Start;

            // Abrir o formulário para adicionar evento
            using (Menu_Inicio.Calendário.Adicionar_Evento adicionarEventoForm = new Menu_Inicio.Calendário.Adicionar_Evento())
            {
                if (adicionarEventoForm.ShowDialog() == DialogResult.OK)
                {
                    // Obter a descrição do evento
                    string novoEvento = adicionarEventoForm.Descrição_Evento;

                    // Adicionar o evento
                    AdicionarEvento(dataSelecionada, novoEvento);

                    // Atualizar a exibição dos eventos
                    ExibirEventos(dataSelecionada);
                }
            }
        }

        // Método para exibir eventos na TextBox
        private void ExibirEventos(DateTime data)
        {
            if (eventos.ContainsKey(data))
            {
                textBox1_Eventos.Text = eventos[data];
            }
            else
            {
                textBox1_Eventos.Text = "Nenhum evento para esta data.";
            }
        }

        // Método para adicionar eventos
        private void AdicionarEvento(DateTime data, string evento)
        {
            if (eventos.ContainsKey(data))
            {
                eventos[data] = evento;
            }
            else
            {
                eventos.Add(data, evento);
            }
        }
    }
}
