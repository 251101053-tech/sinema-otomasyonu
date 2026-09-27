using System;
using System.Drawing;
using System.Windows.Forms;

namespace sinema_odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 600;
            this.Height = 650;

            int sayac = 1;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button btn = new Button();
                    btn.Width = 50;
                    btn.Height = 50;
                    btn.Left = 20 + (j * 55);
                    btn.Top = 20 + (i * 55);
                    btn.Text = sayac.ToString();
                    btn.BackColor = Color.LightGray;

                    btn.MouseEnter += Buton_MouseEnter;
                    btn.MouseLeave += Buton_MouseLeave;
                    btn.Click += Buton_Click;

                    this.Controls.Add(btn);
                    sayac++;
                }
            }
        }

        private void Buton_MouseEnter(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            if (buton.BackColor != Color.DodgerBlue)
            {
                buton.BackColor = Color.Yellow;
            }
        }

        private void Buton_MouseLeave(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            if (buton.BackColor != Color.DodgerBlue)
            {
                buton.BackColor = Color.LightGray;
            }
        }

        private void Buton_Click(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            if (buton.BackColor == Color.DodgerBlue)
            {
                buton.BackColor = Color.LightGray;
            }
            else
            {
                buton.BackColor = Color.DodgerBlue;
            }
        }
    }
}
