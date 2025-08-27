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
    public partial class frmRaca : Form
    {

        private string connectionString = "Server=localhost;Database=herois;Uid=root;Pwd=dd8893;";
        public frmRaca()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Pegando os valores dos controles da tela
            string nome = txtRaca.Text;
            int pv_nivel = (int)numPV.Value; // Convertendo o valor do NumericUpDown para int


            // Validação simples para o nome
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("O campo Classe é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // A instrução SQL para inserir um novo herói
            string sqlQuery = "INSERT INTO raca (nome, pv_por_nivel) VALUES (@nome, @pv)";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();

                    using (MySqlCommand comando = new MySqlCommand(sqlQuery, conexao))
                    {
                        // Adicionando os parâmetros para evitar SQL Injection
                        comando.Parameters.AddWithValue("@nome", nome);
                        comando.Parameters.AddWithValue("@pv", pv_nivel);


                        // Executa o comando (INSERT não retorna dados, por isso NonQuery)
                        comando.ExecuteNonQuery();


                        MessageBox.Show("Raça cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpa os campos para um novo cadastro
                        txtRaca.Clear();
                        numPV.ResetText();

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
