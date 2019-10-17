using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timmer_calisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;

            button_cikis.Visible = false;
            button_yeniden.Visible = false;


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        int sayac = 0;
        Random rastgele = new Random();


        private void timer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;

            sayac++;
            label_süre.Text = sayac.ToString();
       
            pictureBox1.Left += rastgele.Next(2,9);
            pictureBox2.Left += rastgele.Next(2,9);
            pictureBox3.Left += rastgele.Next(2,9);

            int bir = lbl_panel1.Left;
            int iki = lbl_panel2.Left;
            int üc = lbl_panel3.Left;


            if (pictureBox1.Left > pictureBox2.Left & pictureBox1.Left > pictureBox3.Left)
            {
                lbl_yorum.Text = "Birinci At önde götürüyor";
            }


            if (pictureBox2.Left > pictureBox1.Left & pictureBox2.Left > pictureBox3.Left)
            {
                lbl_yorum.Text = "İkinci At atak yaptı";
            }

            if (pictureBox3.Left > pictureBox2.Left & pictureBox3.Left > pictureBox1.Left)
            {
                lbl_yorum.Text = "Üçüncü At öne geçti";
            }



            if (pictureBox1.Left >= bir)
            {
                timer.Stop();
               
                button_yeniden.Visible = true;
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                lbl_yorum.Text = "BİRİNCİ AT KAZANDI!!!";
               
            }
            if (pictureBox2.Left >= iki)
            {
                timer.Stop();
               
                button_yeniden.Visible = true;
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                lbl_yorum.Text = "İKİNCİ AT KAZANDI!!!";
               
            }
            if (pictureBox3.Left >= üc)
            {
                timer.Stop();
               
                button_yeniden.Visible = true;
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                lbl_yorum.Text= "ÜÇÜNCÜ AT KAZANDI!!!";
                
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
            button1.Visible = false;
            button_cikis.Visible = true;

        }

        private void button_yeniden_Click(object sender, EventArgs e)
        {
            timer.Stop();
            button1.Enabled = false;
            button_cikis.Visible = true;
            button_yeniden.Visible = false;
           
            lbl_yorum.Text = "";

            label_süre.Text = "";
            sayac = 0;

            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            timer.Start();
           
           

        }

        private void button_cikis_Click(object sender, EventArgs e)
        {


            if (timer.Enabled == true)
            {
                timer.Enabled = false;
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;

                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Oyun devam ediyor", "Yinede çıkmak istermisiniz?", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {

                    Application.Exit();

                }
                else
                {
                    timer.Enabled = true;

                }

            }
            else
            {
                Application.Exit();
            }


        }
    }
}
