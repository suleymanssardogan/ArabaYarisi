using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //bitiş koordinatı
        int bitis_cizgisi = 644;
        bool gameRunning = false; // Oyun durumu kontrolü
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            //Finish
            if (!gameRunning) return;


            if (e.KeyCode == Keys.W)
            {
                pictureBox7.Left += 15;
            }

            if (e.KeyCode == Keys.P)
            {
                pictureBox8.Left += 15;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!gameRunning) // Eğer oyun başlamadıysa
            {
                pictureBox7.Left = 0; // Arabayı başlangıç pozisyonuna getir
                pictureBox8.Left = 0; // Arabayı başlangıç pozisyonuna getir
                timer1.Start(); // Zamanlayıcıyı başlat
                gameRunning = true; // Oyun durumunu güncelle

                button1.Text = "Başlatıldı"; // Buton yazısını değiştir
                button1.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Başlat";
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Araba 1 sona geldi ise
            if (pictureBox7.Left >= bitis_cizgisi)
            {
                //zamanlayıcı durdur
                timer1.Stop();
                gameRunning = false;
                MessageBox.Show("Araba 1 Kazandı");

                //Yeniden başlat butonu aktif hale gelir
                button1.Text = "Yeniden Başlat";
                button1.Enabled = true;

            }

            else if (pictureBox8.Left >= bitis_cizgisi)
            {
                //zamanlayıcı durdur
                timer1.Stop();
                gameRunning = false;
                button1.Enabled = true;
                MessageBox.Show("Araba 2 Kazandı");

                //Yeniden başlat butonu aktif hale gelir
                button1.Text = "Yeniden Başlat";

            }
        }
    }
}
