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

namespace Espanhol
{
    public partial class Form1 : Form
    {
        private static string perguntass = File.ReadAllText(Directory.GetCurrentDirectory() + "/perguntas.txt");
        string[] pergunta = perguntass.Split(',');
        private static string respostass = File.ReadAllText(Directory.GetCurrentDirectory() + "/respostas.txt");
        string[] resposta = respostass.Split(',');
        public int respostaNumero = 0;
        public int perguntaNumero = 0;
        public int qtdAcertos = 0;


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            puxarPerguntasERespostas();
            rbx1.TabStop = false;
            rbx1.Checked = false;
            rbx2.TabStop = false;
            rbx2.Checked = false;
            rbx3.TabStop = false;
            rbx3.Checked = false;
            rbx4.TabStop = false;
            rbx4.Checked = false;
        }

        public void puxarPerguntasERespostas()
        {
            foreach (Control radiobutton in Controls.OfType<RadioButton>())
            {
                radiobutton.Name = "rbx_" + resposta[respostaNumero];
                if (resposta[respostaNumero].Contains("[CERTA]"))
                {
                    resposta[respostaNumero] = resposta[respostaNumero].Replace("[CERTA]", string.Empty);
                }
                radiobutton.Text = resposta[respostaNumero];
                respostaNumero++;
            }
            lbl_frase.Text = pergunta[perguntaNumero];
            perguntaNumero++;
        }

        public void verificarResposta()
        {
            foreach (Control radiobutton in Controls.OfType<RadioButton>())
            {
                if (radiobutton.Name.Contains("[CERTA]") && ((RadioButton)radiobutton).Checked)
                {
                    qtdAcertos++;
                    MessageBox.Show("Acerto feito");
                }
                ((RadioButton)radiobutton).Checked = false;

            }
            checarPerguntaNumero();
        }

        public void checarPerguntaNumero()
        {

            if (perguntaNumero == pergunta.Length)
            {
                if (qtdAcertos == 0)
                {
                    MessageBox.Show("No golpeó a ninguno,intenta de nuevo :)");
                }
                else
                {
                    MessageBox.Show("Felicitaciones, lo hiciste bien " + qtdAcertos + "!");
                }

            }
            else
            {
                puxarPerguntasERespostas();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verificarResposta();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {

            respostaNumero -= 8;
            perguntaNumero -= 2;
            if (perguntaNumero >= 0 && perguntaNumero < resposta.Length)
            {
                puxarPerguntasERespostas();
            }
            if (qtdAcertos > 0)
            {
                qtdAcertos -= 1;
            }


            else
            {
                var form2 = new Form2();
                this.Hide();
                form2.Show();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbx1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}