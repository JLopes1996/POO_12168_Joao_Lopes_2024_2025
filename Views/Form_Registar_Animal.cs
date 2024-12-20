using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Jardim_Zoológico.Models;

namespace Jardim_Zoológico.Menu_Funcionarios
{
    /// <summary>
    /// Formulário para registar um animal.
    /// </summary>
    public partial class Form_Registar_Animal : Form
    {
        #region Ficheiro

        /// <summary>
        /// Caminho para as várias listas.
        /// </summary>
        // Lista dos funcionários
        private string FilePathAnimais = "animais.json";

        private string FilePathFuncionarios = "funcionarios.json";

        private string FilePathJaulas = "jaulas.json";

        #endregion

        #region Inicialização

        /// <summary>
        /// Função para inicializar o formulário.
        /// </summary>
        public Form_Registar_Animal()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Define os valores iniciais dos ComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Registar_Animal_Load(object sender, EventArgs e)
        {
            comboBox_Tipo_Comida.Items.Add("Carne");
            comboBox_Tipo_Comida.Items.Add("Peixe");
            comboBox_Tipo_Comida.Items.Add("Herviboro");


            comboBox_Capacidade.Items.Add("Pequena");
            comboBox_Capacidade.Items.Add("Média");
            comboBox_Capacidade.Items.Add("Grande");

            // Carregar todos os funcionários (presumivelmente de um arquivo JSON ou banco de dados)
            List<Funcionario> todosFuncionarios = CarregarFuncionarios(); // Este método é apenas um exemplo

            // Filtrando os funcionários que são veterinários
            List<Funcionario> veterinarios = todosFuncionarios.Where(f => f.Cargo == "Veterinário").ToList();

            // Preenchendo a ComboBox com a lista de veterinários
            comboBox_Veterinário.DataSource = veterinarios;
            comboBox_Veterinário.DisplayMember = "Nome";  // Exibir o nome na ComboBox
            comboBox_Veterinário.ValueMember = "Id";     // Associar o Id ao valor da ComboBox
        }

        /// <summary>
        /// Regista um novo animal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Registar_Click(object sender, EventArgs e)
        {
            // Dados do animal
            string nome = textBox_Nome.Text;
            DateTime idade = dateTimePicker_Idade.Value;
            string tipoAnimal = textBox_Tipo_Animal.Text;

            // Validação dos campos
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(tipoAnimal))
            {
                MessageBox.Show("Preencha todos os campos sobre o Animal.");
                return;
            }

            // Dados da comida
            string tipo = comboBox_Tipo_Comida.Text;
            int quantidade = int.Parse(textBox_Quantidade_Comida.Text);
            DateTime validade = dateTimePicker_Validade.Value;
            string origem = textBox_Origem_Comida.Text;

            // Validação dos campos
            if (string.IsNullOrWhiteSpace(tipo) || quantidade <= 0 || string.IsNullOrWhiteSpace(origem))
            {
                MessageBox.Show("Preencha todos os campos sobre a Comida.");
                return;
            }

            // Dados do veterinário
            Funcionario veterinarioSelecionado = (Funcionario)comboBox_Veterinário.SelectedItem;
            
            if (veterinarioSelecionado == null)
            {
                MessageBox.Show("Selecione um veterinário.");
                return;
            }

            int veterinarioId = veterinarioSelecionado.Id;
            string veterinarioNome = veterinarioSelecionado.Nome;

            // Lê a lista de animais
            List<Animal> animais = new List<Animal>();

            // Se existir o arquivo, carrega os dados
            if (File.Exists(FilePathAnimais))
            {
                animais = JsonConvert.DeserializeObject<List<Animal>>(File.ReadAllText(FilePathAnimais)) ?? new List<Animal>();
            }

            // Verifica se já existe um animal com o mesmo nome
            if (animais.Any(a => a.Nome == nome))
            {
                MessageBox.Show("Já existe um animal com esse nome.");
                return;
            }

            // Encontrar o maior Id existente
            int maxId = animais.Any() ? animais.Max(f => f.Id) : 0;

            // Atribuir um novo Id para o Animal
            int newId = maxId + 1;

            // Cria o objeto Comida
            Comida comida = new Comida(tipo, quantidade, validade, origem);

            // Cria o objeto Jaula e salva no JSON
            int novoIdJaula = GerarIdJaula();
            Jaula jaula = new Jaula(GerarIdJaula(), comboBox_Capacidade.Text); // Atribuindo o ID gerado, a capacidade e o funcionário responsável

            // Carregar lista de jaulas
            var listaJaulas = new List<Jaula>();
            if (File.Exists(FilePathJaulas))
            {
                listaJaulas = JsonConvert.DeserializeObject<List<Jaula>>(File.ReadAllText(FilePathJaulas)) ?? new List<Jaula>();
            }

            // Localizar a jaula pelo ID ou criar uma nova
            Jaula jaulaSelecionada = listaJaulas.FirstOrDefault(j => j.Id == GerarIdJaula());
            if (jaulaSelecionada == null)
            {
                // Cria uma nova jaula se não existir
                jaulaSelecionada = new Jaula(GerarIdJaula(), comboBox_Capacidade.Text);
                listaJaulas.Add(jaulaSelecionada);
            }

            // Cria o objeto Veterinário
            Veterinario veterinario = new Veterinario(veterinarioId, veterinarioNome, veterinarioSelecionado.Contacto);

            // Cria novo animal
            Animal novoAnimal = new Animal(newId, nome, idade, tipoAnimal, comida, jaula, veterinario);

            //Adiciona o animal à lista
            animais.Add(novoAnimal);

            // Adicionar o animal à jaula
            jaulaSelecionada.Animais.Add(novoAnimal);

            // Atualizar o arquivo de jaulas
            File.WriteAllText(FilePathJaulas, JsonConvert.SerializeObject(listaJaulas, Formatting.Indented));

            // Atualiza o arquivo animal
            File.WriteAllText(FilePathAnimais, JsonConvert.SerializeObject(animais, Formatting.Indented));

            MessageBox.Show("Animal registado com sucesso!");

            this.Close();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Método para gerar um novo Id para a jaula.
        /// </summary>
        /// <returns></returns>
        private int GerarIdJaula()
        {
            // Se o arquivo de jaulas não existir, começa o Id com 1
            if (!File.Exists(FilePathJaulas))
                return 1;

            // Lê as jaulas existentes
            var jaulas = JsonConvert.DeserializeObject<List<Jaula>>(File.ReadAllText(FilePathJaulas)) ?? new List<Jaula>();

            // Retorna o próximo Id
            return jaulas.Count > 0 ? jaulas.Max(j => j.Id) + 1 : 1;
        }

        /// <summary>
        /// Método para carregar a lista de funcionários.
        /// </summary>
        /// <returns></returns>
        private List<Funcionario> CarregarFuncionarios()
        {
            // Se existir o arquivo, carrega os dados
            if (File.Exists(FilePathFuncionarios))
            {
                return JsonConvert.DeserializeObject<List<Funcionario>>(File.ReadAllText(FilePathFuncionarios)) ?? new List<Funcionario>();
            }

            return new List<Funcionario>();
        }

        #endregion
    }
}
