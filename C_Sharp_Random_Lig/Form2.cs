using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Random_Lig
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int gspuan = 0;
        int bspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label4.Text = a.ToString();
            label5.Text = b.ToString();
            label7.Text = c.ToString();
            label6.Text = d.ToString();

            if (Convert.ToInt32(label4.Text) > Convert.ToInt32(label5.Text))
            {
                bspuan = bspuan + 3;
                label13.Text = bspuan.ToString();
            }
            if (Convert.ToInt32(label4.Text) < Convert.ToInt32(label5.Text))
            {
                fbpuan = fbpuan + 3;
                label11.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label4.Text) == Convert.ToInt32(label5.Text))
            {
                bspuan = bspuan + 1;
                fbpuan = fbpuan + 1;
                label13.Text = bspuan.ToString();
                label11.Text = fbpuan.ToString();
            }



            if (Convert.ToInt32(label7.Text) > Convert.ToInt32(label6.Text))
            {
                bjkpuan = bjkpuan + 3;
                label12.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label7.Text) < Convert.ToInt32(label6.Text))
            {
                gspuan = gspuan + 3;
                label16.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label7.Text) == Convert.ToInt32(label6.Text))
            {
                bjkpuan = bjkpuan + 1;
                gspuan = gspuan + 1;
                label12.Text = bjkpuan.ToString();
                label16.Text = gspuan.ToString();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;

            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label25.Text = a.ToString();
            label24.Text = b.ToString();
            label18.Text = c.ToString();
            label17.Text = d.ToString();

            if (Convert.ToInt32(label25.Text) > Convert.ToInt32(label24.Text))
            {
                bspuan = bspuan + 3;
                label13.Text = bspuan.ToString();
            }
            if (Convert.ToInt32(label25.Text) < Convert.ToInt32(label24.Text))
            {
                bjkpuan = bjkpuan + 3;
                label11.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label25.Text) == Convert.ToInt32(label24.Text))
            {
                bspuan = bspuan + 1;
                bjkpuan = bjkpuan + 1;
                label13.Text = bspuan.ToString();
                label11.Text = bjkpuan.ToString();
            }



            if (Convert.ToInt32(label18.Text) > Convert.ToInt32(label17.Text))
            {
                fbpuan = fbpuan + 3;
                label12.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label18.Text) < Convert.ToInt32(label17.Text))
            {
                gspuan = gspuan + 3;
                label16.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label18.Text) == Convert.ToInt32(label17.Text))
            {
                fbpuan = fbpuan + 1;
                gspuan = gspuan + 1;
                label12.Text = fbpuan.ToString();
                label16.Text = gspuan.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Visible = true;

            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label35.Text = a.ToString();
            label34.Text = b.ToString();
            label30.Text = c.ToString();
            label29.Text = d.ToString();

            if (Convert.ToInt32(label35.Text) > Convert.ToInt32(label34.Text))
            {
                gspuan = gspuan + 3;
                label16.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label35.Text) < Convert.ToInt32(label34.Text))
            {
                bjkpuan = bjkpuan + 3;
                label12.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label25.Text) == Convert.ToInt32(label24.Text))
            {
                gspuan = gspuan + 1;
                bjkpuan = bjkpuan + 1;
                label16.Text = gspuan.ToString();
                label12.Text = bjkpuan.ToString();
            }



            if (Convert.ToInt32(label30.Text) > Convert.ToInt32(label29.Text))
            {
                fbpuan = fbpuan + 3;
                label11.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label30.Text) < Convert.ToInt32(label29.Text))
            {
                bspuan = bspuan + 3;
                label13.Text = bspuan.ToString();
            }
            if (Convert.ToInt32(label30.Text) == Convert.ToInt32(label29.Text))
            {
                fbpuan = fbpuan + 1;
                bspuan = bspuan + 1;
                label11.Text = fbpuan.ToString();
                label13.Text = bspuan.ToString();
            }


            
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32 (label13 .Text)> Convert.ToInt32 (label12.Text) && Convert.ToInt32(label13.Text) > Convert.ToInt32(label11.Text) && Convert.ToInt32(label13.Text) > Convert.ToInt32(label16.Text))
            {
                label39.Text = "Bursaspor Şampiyon!";
                axWindowsMediaPlayer1.URL = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.png";
            }
            if (Convert.ToInt32(label12.Text) > Convert.ToInt32(label13.Text) && Convert.ToInt32(label12.Text) > Convert.ToInt32(label11.Text) && Convert.ToInt32(label12.Text) > Convert.ToInt32(label16.Text))
            {
                label39.Text = "Beşiktaş Şampiyon!";
                axWindowsMediaPlayer1.URL = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bjk.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bjk.png";
            }
            if (Convert.ToInt32(label11.Text) > Convert.ToInt32(label12.Text) && Convert.ToInt32(label11.Text) > Convert.ToInt32(label13.Text) && Convert.ToInt32(label11.Text) > Convert.ToInt32(label16.Text))
            {
                label39.Text = "Fenerbahçe Şampiyon!";
                axWindowsMediaPlayer1.URL = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\fb.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\fb.png";
            }
            if (Convert.ToInt32(label16.Text) > Convert.ToInt32(label12.Text) && Convert.ToInt32(label16.Text) > Convert.ToInt32(label13.Text) && Convert.ToInt32(label16.Text) > Convert.ToInt32(label13.Text))
            {
                label39.Text = "Galatasaray Şampiyon!";
                axWindowsMediaPlayer1.URL = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\gs.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\gs.png";
            }





            if (Convert.ToInt32(label13.Text) == Convert.ToInt32(label12.Text))
            {
                label39.Text = "Bursaspor Şampiyon!";
                axWindowsMediaPlayer1.URL = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.png";
            }
            if (Convert.ToInt32(label13.Text) == Convert.ToInt32(label11.Text))
            {
                label39.Text = "Bursaspor Şampiyon!";
                axWindowsMediaPlayer1.URL = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.png";
            }
            if (Convert.ToInt32(label13.Text) == Convert.ToInt32(label16.Text))
            {
                label39.Text = "Bursaspor Şampiyon!";
                axWindowsMediaPlayer1.URL = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.png";
            }


            if (Convert.ToInt32(label12.Text) == Convert.ToInt32(label13.Text))
            {
                label39.Text = "Bursaspor Şampiyon!";
                axWindowsMediaPlayer1.URL = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.png";
            }
            if (Convert.ToInt32(label12.Text) == Convert.ToInt32(label11.Text))
            {
                label39.Text = "Bursaspor Şampiyon!";
                axWindowsMediaPlayer1.URL = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.png";
            }
            if (Convert.ToInt32(label12.Text) == Convert.ToInt32(label16.Text))
            {
                label39.Text = "Bursaspor Şampiyon!";
                axWindowsMediaPlayer1.URL = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.png";
            }


            if (Convert.ToInt32(label11.Text) == Convert.ToInt32(label12.Text))
            {
                label39.Text = "Bursaspor Şampiyon!";
                axWindowsMediaPlayer1.URL = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.png";
            }
            if (Convert.ToInt32(label11.Text) == Convert.ToInt32(label13.Text))
            {
                label39.Text = "Bursaspor Şampiyon!";
                axWindowsMediaPlayer1.URL = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.png";
            }
            if (Convert.ToInt32(label11.Text) == Convert.ToInt32(label16.Text))
            {
                label39.Text = "Bursaspor Şampiyon!";
                axWindowsMediaPlayer1.URL = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.png";
            }


            if (Convert.ToInt32(label16.Text) == Convert.ToInt32(label12.Text))
            {
                label39.Text = "Bursaspor Şampiyon!";
                axWindowsMediaPlayer1.URL = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.png";
            }
            if (Convert.ToInt32(label16.Text) == Convert.ToInt32(label11.Text))
            {
                label39.Text = "Bursaspor Şampiyon!";
                axWindowsMediaPlayer1.URL = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.png";
            }
            if (Convert.ToInt32(label16.Text) == Convert.ToInt32(label13.Text))
            {
                label39.Text = "Bursaspor Şampiyon!";
                axWindowsMediaPlayer1.URL = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\bs.png";
            }
        }
    }
}
