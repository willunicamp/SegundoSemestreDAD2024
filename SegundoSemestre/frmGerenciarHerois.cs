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
    public partial class frmGerenciarHerois : Form
    {
        public frmGerenciarHerois()
        {
            InitializeComponent();
            // Maximiza a janela principal ao iniciar
            this.WindowState = FormWindowState.Maximized;
        }

        private void itemHerois_Click(object sender, EventArgs e)
        {
            // Vamos supor que você tenha um formulário chamado "frmGerenciarHerois"
            // para listar e gerenciar os heróis.

            // Boas prática: verificar se a janela já está aberta.
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmHerois)
                {
                    form.Activate(); // Se já existe, apenas traz para frente.
                    return;          // E para a execução do método.
                }
            }

            // Se o loop terminou e não encontrou a janela, cria uma nova.
            frmHerois janela = new frmHerois();
            janela.MdiParent = this; // Define que este formulário é o "pai". Essencial!
            janela.Show();
        }

        private void itemRaca_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmRaca)
                {
                    form.Activate(); 
                    return;         
                }
            }

            frmRaca janela = new frmRaca();
            janela.MdiParent = this; 
            janela.Show();
        }

        private void itemClasses_Click(object sender, EventArgs e)
        {

            foreach (Form form in this.MdiChildren)
            {
                if (form is frmClasse)
                {
                    form.Activate(); 
                    return;          
                }
            }

            frmClasse janela = new frmClasse();
            janela.MdiParent = this; 
            janela.Show();
        }
    }
}
