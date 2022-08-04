using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0785_App02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_resultado_Click(object sender, EventArgs e)
        {

        }

        private void btn_mais_Click(object sender, EventArgs e)
        {
            if (txt_1.Text.Length == 0)
            {
                MessageBox.Show("Deve inserir um número no 1º número");
                return;
            }
            if (txt_2.Text.Length == 0)
            {
                MessageBox.Show("Deve inserir um número no 2º número");
                return;
            }
            lbl_resultado.Text = (Convert.ToInt32(txt_1.Text)+Convert.ToInt32(txt_2.Text)).ToString();
        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            if(txt_1.Text.Length == 0)
            {
                MessageBox.Show("Deve inserir um número no 1º número");
                return;
            }
            if (txt_2.Text.Length == 0)
            {
                MessageBox.Show("Deve inserir um número no 2º número");
                return;
            }
            lbl_resultado.Text = (Convert.ToInt32(txt_1.Text)-Convert.ToInt32(txt_2.Text)).ToString();
        }

        private void btn_vezes_Click(object sender, EventArgs e)
        {
            if (txt_1.Text.Length == 0)
            {
                MessageBox.Show("Deve inserir um número no 1º número");
                return;
            }
            if (txt_2.Text.Length == 0)
            {
                MessageBox.Show("Deve inserir um número no 2º número");
                return;
            }
            lbl_resultado.Text = (Convert.ToInt32(txt_1.Text)*Convert.ToInt32(txt_2.Text)).ToString();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (txt_1.Text.Length == 0)
            {
                MessageBox.Show("Deve inserir um número no 1º número");
                return;
            }
            if (txt_2.Text.Length == 0)
            {
                MessageBox.Show("Deve inserir um número no 2º número");
                return;
            }
            lbl_resultado.Text = (Convert.ToInt32(txt_1.Text)/Convert.ToInt32(txt_2.Text)).ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_1.Clear();
            txt_2.Clear();
            lbl_resultado.ResetText();

        }
    }
}
