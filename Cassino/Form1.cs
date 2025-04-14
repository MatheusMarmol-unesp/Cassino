using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cassino
{
    public partial class Form1 : Form
    {
        int[] roleta;
        Label[] labels;
        int[] tempos;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            roleta = new int[3];
            labels = new Label[] { lbl1, lbl2, lbl3 };
            tempos = new int[roleta.Length];
            
            for (int i = 0; i < roleta.Length; i++)
            {
                roleta[i] = r.Next(0, 3);
                tempos[i] = r.Next(0, 5001);      
            }   
            AtualizaTudo();
        }

        void AtualizaLabel(Label l, int i)
        {
            l.Text = i.ToString();
        }

        void AtualizaTudo()
        {
            for (int i = 0; i < roleta.Length; i++)
                AtualizaLabel(labels[i], roleta[i]);
            int controle = roleta[0];
            bool diff = roleta.Any(x => x != controle);
            if (!diff)
            {
                MessageBox.Show("Parabéns!");
            }
        }

        private void btGirar_Click(object sender, EventArgs e)
        {
            for(int i  = 0; i < roleta.Length; i++)
            {
                tempos[i] = r.Next(0, 5001);
                labels[i].ForeColor = Color.Black;
            }
            Array.Sort(tempos);
            tmrGiro.Enabled = true;
            btGirar.Enabled = false;
        }

        private void tmrGiro_Tick(object sender, EventArgs e)
        {
            bool girando = false;
            for (int i = 0; i < roleta.Length; i++)
            {
                if (tempos[i] > 0)
                {
                    tempos[i] -= tmrGiro.Interval;
                    girando |= true;
                    roleta[i]++;
                    if (roleta[i] == 3) roleta[i] = 0;
                    AtualizaLabel(labels[i], roleta[i]);
                }
                else
                {
                    labels[i].ForeColor = Color.Red;
                }
            }
            if (!girando)
            {
                tmrGiro.Enabled = false;
                btGirar.Enabled = true;

                lbxUltimos.Items.Add($"{roleta[0]}-{roleta[1]}-{roleta[2]}");
            }
        }

        List<string> jogadas;
        private void chbVitorias_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVitorias.Checked)
            {
                jogadas = new List<string>();
                foreach (string item in lbxUltimos.Items)
                    jogadas.Add(item);
                lbxUltimos.Items.Clear();
                foreach (string item in jogadas)
                {
                    string[] nums = item.Split('-');
                    if (nums[0] == nums[1] && nums[1] == nums[2])
                        lbxUltimos.Items.Add(item);
                }
            }
            else
            {
                lbxUltimos.Items.Clear();
                foreach (string item in jogadas)
                    lbxUltimos.Items.Add(item);
            }
        }
    }
}