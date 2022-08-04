using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0785_Tarefa2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private static  Boolean Validar_Hora(int hora,string titulo)
        {
            if(hora>=0 && hora <= 23)
            {
                return true;
            }
            else
            {
                MessageBox.Show("A hora deve estar compreendida entre 0 e 23", titulo,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private static Boolean Validar_Minuto(int minuto,string titulo)
        {
            if (minuto >= 0 && minuto <= 59)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Deve indicar minuto entre 0 e 59", titulo,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            //verificar se a hora partida está preenchida
            if (txt_hp.Text.Length == 0)
            {
                MessageBox.Show("Deve indicar a hora de partida", "Partida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_hp.Clear();
                txt_hp.Focus();
                return;
            }
            int hp=Convert.ToInt32(txt_hp.Text);

            // verificar se está entre 0 e 23
            if(!Validar_Hora(hp,"Partida"))
            {
                txt_hp.Clear();
                txt_hp.Focus();
                return;
            }

            //verificar se minuto partida está preenchido
            if (txt_mp.Text.Length == 0)
            {
                MessageBox.Show("Deve indicar minuto de partida", "Partida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_mp.Clear();
                txt_mp.Focus();
                return;
            }
            int mp = Convert.ToInt32(txt_mp.Text);

            // verificar se está entre 0 e 59
            if (!Validar_Minuto(mp,"Partida"))
            {
                txt_mp.Clear();
                txt_mp.Focus();
                return;
            }


            //-------------------------------------------------------------------------------------------------------
            
            //verificar se a hora duração está preenchida
            if (txt_hd.Text.Length == 0)
            {
                MessageBox.Show("Deve indicar a hora de duração", "Duração",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_hd.Clear();
                txt_hd.Focus();
                return;
            }
            int hd = Convert.ToInt32(txt_hd.Text);

            // verificar se está entre 0 e 23
            if (!Validar_Hora(hd,"Duração"))
            {
                txt_hd.Clear();
                txt_hd.Focus();
                return;
            }

            //verificar se minuto duração está preenchido
            if (txt_md.Text.Length == 0)
            {
                MessageBox.Show("Deve indicar minuto de duração", "Duração",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_md.Clear();
                txt_md.Focus();
                return;
            }
            int md = Convert.ToInt32(txt_md.Text);

            // verificar se está entre 0 e 59
            if (!Validar_Minuto(md,"Duração"))
            {
                txt_md.Clear();
                txt_md.Focus();
                return;
            }


            // -- 

            int hc = (hp + hd);
            int mc = (mp + md);

            if (mc > 59)
            {
                hc++;
                mc -= 60;
            }

            if (hc > 23)
            {
                hc -= 24;
                lbl_situacao.Text = "O voo chegou no dia seguinte";
            }
            else
            {
                lbl_situacao.Text = "O voo chegou no próprio dia.";
            }

            lbl_hc.Text = hc.ToString();
            lbl_mc.Text = mc.ToString();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_hp.Clear();
            txt_mp.Clear();
            txt_hd.Clear();
            txt_md.Clear();
            lbl_hc.ResetText();
            lbl_mc.ResetText();
            lbl_situacao.ResetText();
        }

        private void txt_hp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Deve inserir um número.","Erro", 
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                e.Handled = true;
            }
                

        }

        private void txt_hp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Deve inserir um número.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txt_mp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_hd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_hd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Deve inserir um número.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txt_md_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Deve inserir um número.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
