using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Espanhol
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EDUARDO ARAUJO SILVA \n" +
                "MATHEUS DOS SANTOS MOREIRA\n" +
                "SAMUEL SANTOS SOUZA\n" +
                "PEDRO PLACIDO\n" +
                "JOSÉ HENRIQUE \n" +
                "RENAN LEITE\n" +
                "JOEL NETO \n" +
                "ALLAN VICTOR \n" +
                "RICHELLY TRINDADE \n" +
                "MICHELLY MAYUMI \n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            Application.Exit();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
