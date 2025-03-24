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
                roleta[i] = r.Next(0, 10);
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
            }

            tmrGiro.Enabled = true;
        }

        private void tmrGiro_Tick(object sender, EventArgs e)
        {
            bool girando = true;
            for (int i = 0; i < roleta.Length; i++)
            {
                if (tempos[i] > 0)
                {
                    tempos[i] -= tmrGiro.Interval;
                    girando |= true;
                    roleta[i]++;
                    if (roleta[i] == 10) roleta[i] = 0;
                    AtualizaLabel(labels[i], roleta[i]);
                }
            }
            if (!girando)
            {
                tmrGiro.Enabled = false;
                btGirar.Enabled = true;
            }
        }
    }
}
