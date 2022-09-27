using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudos1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region botao limpar
        private void BTN_LIMPAR_Click(object sender, EventArgs e)
        {
            TXT_R1.Clear();
            TXT_R3.Clear();
            TXT_R2.Clear();
            lbl_resultado.Text = "";
        }

        #endregion


        #region botao sair

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region botao calcular

        private void TXT_CALCULAR_Click(object sender, EventArgs e)
        {
            int R4, R5, R6, R1, R2, R3;

            R1 = int.Parse(TXT_R1.Text);
            R2 = int.Parse(TXT_R2.Text);
            R3 = int.Parse(TXT_R3.Text);

            R4 = (R1 * R2) / (R1 + R2 + R3);
            R5 = (R2 * R3) / (R1 + R2 + R3);
            R6 = (R1 * R3) / (R1 + R2 + R3);

            lbl_resultado.Text = "Seus valores convertidos sao de R4= " + Convert.ToString(R4) + " e R5= " + Convert.ToString(R5) + " e tambem de R6= " + Convert.ToString(R6);
        }

        #endregion


























































































































































































        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
