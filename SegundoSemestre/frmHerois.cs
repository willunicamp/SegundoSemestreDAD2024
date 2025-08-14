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
        public frmHerois()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // String de conexão com o banco de dados MySQL
            string connectionString = "Server=localhost;Database=herois;Uid=root;Pwd=dd8893;";

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

                        // IMPORTANTE: Como exercício, estamos usando valores fixos (hardcoded)
                        // O desafio para casa será substituir isso por uma seleção dinâmica.
                        // comando.Parameters.AddWithValue("@id_classe", 1); // Ex: 1 = Guerreiro
                        // comando.Parameters.AddWithValue("@id_raca", 1);   // Ex: 1 = Humano

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
