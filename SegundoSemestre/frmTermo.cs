using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoSemestre
{
    public partial class frmTermo : Form
    {
        private List<string> palavras = new List<string>();
        private string palavraSecreta = "";
        private int tentativas = 0;
        private const int MaxTentativas = 6;
        public frmTermo()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de texto|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                palavras = File.ReadAllLines(ofd.FileName).ToList();

                if (palavras.Count > 0)
                {
                    var rand = new Random();
                    palavraSecreta = palavras[rand.Next(palavras.Count)];
                    tentativas = 0;
                    lstFeedback.Items.Clear();
                    lblTentativas.Text = "Tentativas: 0/6";
                    MessageBox.Show("Lista carregada! Palavra sorteada.");
                }
                else
                {
                    MessageBox.Show("Nenhuma palavra válida com 5 letras encontrada.");
                }
            }
        }
        private string AvaliarPalpite(string palpite)
        {
            char[] resultado = new char[5];

            for (int i = 0; i < 5; i++)
            {
                if (palpite[i] == palavraSecreta[i])
                    resultado[i] = '*'; // verde
                else if (palavraSecreta.Contains(palpite[i]))
                    resultado[i] = '?'; // amarelo
                else
                    resultado[i] = '!'; // cinza
            }

            return new string(resultado);
        }

        private void ReiniciarJogo()
        {
            palavraSecreta = "";
            tentativas = 0;
            lblTentativas.Text = "Tentativas: 0/6";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string palpite = txtPalavra.Text.Trim().ToLower();

            if (palpite.Length != 5 || !palavras.Contains(palpite))
            {
                MessageBox.Show("Digite uma palavra válida de 5 letras.");
                return;
            }

            tentativas++;
            lblTentativas.Text = $"Tentativas: {tentativas}/{MaxTentativas}";

            string resultado = AvaliarPalpite(palpite);
            lstFeedback.Items.Add($"{palpite.ToUpper()} -> {resultado}");

            if (palpite == palavraSecreta)
            {
                MessageBox.Show("Parabéns! Você acertou!");
                ReiniciarJogo();
            }
            else if (tentativas >= MaxTentativas)
            {
                MessageBox.Show($"Você perdeu! A palavra era: {palavraSecreta.ToUpper()}");
                ReiniciarJogo();
            }

            txtPalavra.Clear();
            txtPalavra.Focus();
        }


    }
}
