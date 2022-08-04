using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aleatorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            if(btn_gerar.Text == "Gerar")
            {
                timer1.Start();
                btn_gerar.Text = "Parar";
                btn_gerar.ForeColor = Color.Red;
            }
            else
            {
                timer1.Stop();
                btn_gerar.Text = "Gerar";
                btn_gerar.ForeColor = Color.Green;
                lbl1.Text = "0";
                lbl2.Text = "0";
                lbl3.Text = "0";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Vamos usar a classe random do C#

            /* Para instanciar(declarar) uma variavel de uma classe obrigatoriamente temos que
            usar o construtor new */

            Random Aleatorio = new Random();

            lbl_numero.Text = Aleatorio.Next(1, 4).ToString();

            if(Convert.ToInt32(lbl_numero.Text) == 1)
            {
                lbl1.Text = (Convert.ToInt32(lbl1.Text) + 1).ToString();
            }
            else  if(Convert.ToInt32(lbl_numero.Text) == 2)
            {
                lbl2.Text = (Convert.ToInt32(lbl2.Text) + 1).ToString();
            }
            else
            {
                lbl3.Text = (Convert.ToInt32(lbl3.Text) + 1).ToString();
            }
        }
    }
}
