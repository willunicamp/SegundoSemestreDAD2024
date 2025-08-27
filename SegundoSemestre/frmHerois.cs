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
                                ComboBoxItem item = new ComboBoxItem();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Pegando os valores dos controles da tela
            string nome = txtNome.Text;
            int nivel = (int)numNivel.Value; // Convertendo o valor do NumericUpDown para int
            string descricao = txtDescricao.Text;

            // Validação simples para o nome
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("O campo Nome é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // A instrução SQL para inserir um novo herói
            string sqlQuery = "INSERT INTO heroi (nome, nivel, descricao) VALUES (@nome, @nivel, @descricao)";

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


    }
}
