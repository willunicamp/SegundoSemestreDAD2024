using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoSemestre
{
    public partial class frmClasse : Form
    {
        // String de conexão com o banco de dados MySQL
        private string connectionString = "Server=localhost;Database=herois;Uid=root;Pwd=dd8893;";

        public frmClasse()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Pegando os valores dos controles da tela
            string nome = txtClasse.Text;

            // Validação simples para o nome
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("O campo Classe é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // A instrução SQL para inserir um novo herói
            string sqlQuery = "INSERT INTO classe (nome) VALUES (@nome)";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();

                    using (MySqlCommand comando = new MySqlCommand(sqlQuery, conexao))
                    {
                        // Adicionando os parâmetros para evitar SQL Injection
                        comando.Parameters.AddWithValue("@nome", nome);
   
                        // Executa o comando (INSERT não retorna dados, por isso NonQuery)
                        comando.ExecuteNonQuery();


                        MessageBox.Show("Classe cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpa os campos para um novo cadastro
                        txtClasse.Clear();
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
