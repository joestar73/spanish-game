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
        public bool acertoFeito;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            puxarPerguntasERespostas();
            desmarcarRadioButtons();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verificarResposta();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            desmarcarRadioButtons();
            respostaNumero -= 8; //Volta respostaNumero para a da questão anterior
            perguntaNumero -= 2; //Volta perguntaNumero para a da questão anterior
            if (perguntaNumero >= 0 && perguntaNumero < resposta.Length) //Verifica se perguntaNumero ainda é real
            {
                if (acertoFeito == true) //Lógica para checar o acerto feito e não deixar ter acertos infinitos
                {
                    acertoFeito = false;
                    qtdAcertos--;
                }
                puxarPerguntasERespostas();
            }
            else
            {
                var form2 = new Form2(); //Volta para o form principal
                this.Hide();
                form2.Show();
            }
        }
        public void puxarPerguntasERespostas()
        {
            foreach (Control radiobutton in Controls.OfType<RadioButton>()) //Loop para cada um das radiobuttons no painel
            {
                radiobutton.Name = "rbx_" + resposta[respostaNumero]; //Seta nome e texto do radiobutton para o do retirado do txt
                radiobutton.Text = resposta[respostaNumero];
                if (radiobutton.Text.Contains("[CERTA]"))
                {
                    radiobutton.Text = radiobutton.Text.Replace("[CERTA]", string.Empty); //Retira "[CERTA]" da resposta certa
                }
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
                    acertoFeito = true;
                }
                else { acertoFeito = false; }
                ((RadioButton)radiobutton).Checked = false;
            }
            checarPerguntaNumero();
        }

        public void checarPerguntaNumero()
        {
            if (perguntaNumero == pergunta.Length) //Verifica se as perguntas acabaram
            {
                if (qtdAcertos == 0)
                {
                    MessageBox.Show("No golpeó a ninguno, intenta de nuevo :)");
                }
                else
                {
                    MessageBox.Show("Felicitaciones, lo hiciste bien " + qtdAcertos + "!");
                }
                qtdAcertos = 0;
                Application.Restart();
            }
            else
            {
                puxarPerguntasERespostas();
            }
        }
        public void desmarcarRadioButtons()
        {
            foreach (Control radiobutton in Controls.OfType<RadioButton>()) //Loop para todas as radiobuttons
            {
                ((RadioButton)radiobutton).TabStop = false;
                ((RadioButton)radiobutton).Checked = false;
            }
        }
    }
}