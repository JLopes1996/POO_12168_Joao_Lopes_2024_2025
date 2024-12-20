using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jardim_Zoológico.Models;
using Newtonsoft.Json;
using System.IO;

namespace Jardim_Zoológico.Menu_Clientes
{
    public partial class Form_Listar_Bilhetes_Cliente : Form
    {
        // Lista dos bilhetes
        private const string FilePathBilhetes = "bilhetes.json";

        public Form_Listar_Bilhetes_Cliente()
        {
            InitializeComponent();
        }

        private void btn_Ver_Bilhetes_Click(object sender, EventArgs e)
        {
            Listar_Bilhetes();
        }

        private void Listar_Bilhetes()
        {
            // Verifica se o arquivo de animais existe
            if (File.Exists(FilePathBilhetes))
            {
                try
                {
                    // Lê o conteúdo do arquivo JSON
                    string jsonbilhetes = File.ReadAllText(FilePathBilhetes);
                    var bilhetes = JsonConvert.DeserializeObject<List<Bilhete>>(jsonbilhetes);

                    // Verifica se a lista de animais não está vazia
                    if (bilhetes != null && bilhetes.Any())
                    {
                        // Exibe os dados no DataGridView
                        dataGridView_Listar_Bilhetes.DataSource = bilhetes.Select(b => new
                        {
                            b.Id,
                            b.Nome,
                            b.Tipo,
                            b.Horario,
                            b.Duracao,
                            b.Preco
                        }).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não há bilhetes registados.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar os dados dos bilhetes: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Arquivo de bilhetes não encontrado.");
            }
        }

        private void ComprarBilhete(int idBilhete, string tipo, float preco, string nomeEspetaculo)
        {
            // Vamos supor que você tenha um arquivo ou lista de compras do cliente
            string arquivoCompras = "compras.json";

            // Simula a compra do bilhete. Aqui você pode associar o cliente a uma compra.
            Compra novaCompra = new Compra(idBilhete, tipo, preco, nomeEspetaculo, DateTime.Now);

            // Armazenar a compra em um arquivo JSON (ou em uma lista)
            List<Compra> compras = new List<Compra>();

            if (File.Exists(arquivoCompras))
            {
                string jsonCompras = File.ReadAllText(arquivoCompras);
                compras = JsonConvert.DeserializeObject<List<Compra>>(jsonCompras);
            }

            compras.Add(novaCompra);

            // Salvar novamente no arquivo JSON
            string jsonNovo = JsonConvert.SerializeObject(compras, Formatting.Indented);
            File.WriteAllText(arquivoCompras, jsonNovo);

            MessageBox.Show("Compra realizada com sucesso!");
        }

        private void btn_Comprar_Bilhete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Listar_Bilhetes.SelectedRows.Count > 0)
            {
                // Pega a linha selecionada no DataGridView
                DataGridViewRow row = dataGridView_Listar_Bilhetes.SelectedRows[0];

                // Obtém o ID do bilhete selecionado
                int idBilheteSelecionado = (int)row.Cells["Id"].Value;
                string tipoBilhete = (string)row.Cells["Tipo"].Value;
                float precoBilhete = (float)row.Cells["Preco"].Value;
                string nomeEspetaculo = (string)row.Cells["Nome"].Value;

                // Aqui você pode criar o objeto de compra, talvez associando um cliente
                // Simulação de uma compra - registra a compra do bilhete
                ComprarBilhete(idBilheteSelecionado, tipoBilhete, precoBilhete, nomeEspetaculo);

                MessageBox.Show("Bilhete comprado com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione um bilhete para comprar.");
            }
        }
    }
}
