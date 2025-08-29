using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoSemestre
{
    public partial class frmHerois : Form
    {
        // String de conexão com o banco de dados MySQL
        private string connectionString = "Server=localhost;Database=herois;Uid=root;Pwd=dd8893;";

        public frmHerois()
        {
            InitializeComponent();
        }

        private void frmHerois_Load(object sender, EventArgs e)
        {
            CarregarClasses();
            CarregarRacas();
            CarregarHerois();
        }

        private void CarregarRacas()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string sqlQuery = "SELECT id, nome, pv_por_nivel FROM raca ORDER BY nome";

                    using (MySqlCommand comando = new MySqlCommand(sqlQuery, conexao))
                    {
                        using (MySqlDataReader leitor = comando.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                RacaComboBoxItem item = new RacaComboBoxItem();
                                item.Id = leitor.GetInt32("id");
                                item.Nome = leitor.GetString("nome");
                                item.PvPorNivel = leitor.GetInt32("pv_por_nivel");
                                cmbRaca.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar classes: " + ex.Message);
            }
        }

        private void CarregarClasses()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string sqlQuery = "SELECT id, nome FROM classe ORDER BY nome";

                    using (MySqlCommand comando = new MySqlCommand(sqlQuery, conexao))
                    {
                        using (MySqlDataReader leitor = comando.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                ClasseComboBoxItem item = new ClasseComboBoxItem();
                                item.Value = leitor.GetInt32("id");
                                item.Text = leitor.GetString("nome");
                                cmbClasse.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar classes: " + ex.Message);
            }
        }

        private void CarregarHerois()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string sqlQuery = "SELECT id, nome, nivel, id_raca, id_classe, descricao FROM heroi ORDER BY nome";

                    using (MySqlCommand comando = new MySqlCommand(sqlQuery, conexao))
                    {
                        using (MySqlDataReader leitor = comando.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                HeroiListBoxItem item = new HeroiListBoxItem();
                                item.Id = leitor.GetInt32("id");
                                item.Nome = leitor.GetString("nome");
                                item.Nivel= leitor.GetInt32("nivel");
                                item.Descricao = leitor.GetString("descricao");
                                item.IdRaca = leitor.GetInt32("id_raca");
                                item.IdClasse = leitor.GetInt32("id_classe");
                                lstHerois.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar herois: " + ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Pegando os valores dos controles da tela
            string nome = txtNome.Text;
            int nivel = (int)numNivel.Value; // Convertendo o valor do NumericUpDown para int
            string descricao = txtDescricao.Text;
            int id_raca = ((RacaComboBoxItem)cmbRaca.SelectedItem).Id;
            int id_classe = ((ClasseComboBoxItem)cmbClasse.SelectedItem).Value;

            // Validação simples para o nome
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("O campo Nome é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // A instrução SQL para inserir um novo herói
            string sqlQuery = "INSERT INTO heroi (nome, nivel, descricao, id_raca, id_classe) VALUES (@nome, @nivel, @descricao, @id_raca, @id_classe)";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();

                    using (MySqlCommand comando = new MySqlCommand(sqlQuery, conexao))
                    {
                        // Adicionando os parâmetros para evitar SQL Injection
                        comando.Parameters.AddWithValue("@nome", nome);
                        comando.Parameters.AddWithValue("@nivel", nivel);
                        comando.Parameters.AddWithValue("@descricao", descricao);
                        comando.Parameters.AddWithValue("@id_raca", id_raca);
                        comando.Parameters.AddWithValue("@id_classe", id_classe);

                      // Executa o comando (INSERT não retorna dados, por isso NonQuery)
                        comando.ExecuteNonQuery();


                        MessageBox.Show("Herói cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpa os campos para um novo cadastro
                        txtNome.Clear();
                        numNivel.Value = 1;
                        txtDescricao.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar herói: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstHerois_SelectedIndexChanged(object sender, EventArgs e)
        {
            HeroiListBoxItem heroiSelecionado = (HeroiListBoxItem)lstHerois.SelectedItem;
            txtNome.Text = heroiSelecionado.Nome;
            txtDescricao.Text = heroiSelecionado.Descricao;
            numNivel.Value = (int)heroiSelecionado.Nivel;

            // Usa LINQ para encontrar o primeiro item que satisfaz a condição
            var classeParaSelecionar = cmbClasse.Items.Cast<ClasseComboBoxItem>().FirstOrDefault(item => item.Value == heroiSelecionado.IdClasse);
            cmbClasse.SelectedItem = classeParaSelecionar;

            var racaParaSelecionar = cmbRaca.Items.Cast<RacaComboBoxItem>().FirstOrDefault(item => item.Id == heroiSelecionado.IdRaca);
            txtPv.Text = (racaParaSelecionar.PvPorNivel * heroiSelecionado.Nivel).ToString();
            cmbRaca.SelectedItem = racaParaSelecionar;

        }

        private void cmbRaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            var racaSelecionada = (RacaComboBoxItem)cmbRaca.SelectedItem;
            txtPv.Text =  (racaSelecionada.PvPorNivel * numNivel.Value).ToString();
        }
    }
}
