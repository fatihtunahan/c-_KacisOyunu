using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_Proje_Kacis_Oyunu
{
    public partial class Seviye2 : Form
    {
        private SaniyeSayaci saniyeSayaci;
        private int canHakki;
        private bool duraklatildi = false;

        public Seviye2()
        {
        }

        // Seviye2 constructor'ı içerisinde kullanıcı can ve saniye sayacını başlatıyoruz.
        public Seviye2(int canHakki,SaniyeSayaci saniyeSayaci)
        {
            InitializeComponent();
            this.canHakki = canHakki;
            this.saniyeSayaci = saniyeSayaci;
            saniyeSayaci.SaniyeDegisti += SaniyeSayaci_SaniyeDegisti;
            label8.Text = canHakki.ToString();

        }
        private void SaniyeSayaci_SaniyeDegisti(object sender, EventArgs e)
        {
            if (saniyeSayaci != null)
            {
                label7.Text = saniyeSayaci.GetSaniye().ToString();
            }
        }

        // Klavye tuşlarına basıldığında gerçekleşen olay.
        private void Seviye2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                duraklatildi = !duraklatildi; // Durma durumunu tersine çevir
                if (duraklatildi)
                {
                    // Duraklatma işlemlerini gerçekleştirin
                    saniyeSayaci.StopTimer();
                    // İsterseniz başka duraklatma işlemleri de ekleyebilirsiniz.
                }
                else
                {
                    // Devam ettirme işlemlerini gerçekleştirin

                    // İsterseniz başka devam ettirme işlemleri de ekleyebilirsiniz.
                }
            }
            if (e.KeyCode == Keys.Enter && duraklatildi)
            {
                duraklatildi = false; // Durma durumunu false olarak ayarlayın
                                      // Devam ettirme işlemlerini gerçekleştirin

                // İsterseniz başka devam ettirme işlemleri de ekleyebilirsiniz.
            }
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            if (e.KeyCode == Keys.Right) { x = x + 5; }
            if (e.KeyCode == Keys.Left) { x = x - 5; }
            if (e.KeyCode == Keys.Down) { y = y + 5; }
            if (e.KeyCode == Keys.Up) { y = y - 5; }
            pictureBox1.Location = new Point(x, y);
            // Eğer resim belirli bir noktaya ulaşırsa bir sonraki seviyeye geç.
            if (pictureBox1.Right >= pictureBox26.Left)
            {

                Seviye3 seviye3 = new Seviye3(canHakki,saniyeSayaci);
                this.Hide();
                seviye3.Show();
                this.Close();
            }
            // Eğer resim belirli bir noktaya ulaşırsa can sayısını azalt.
            if (pictureBox1.Right >= pictureBox28.Left &&
             pictureBox1.Left <= pictureBox28.Right &&
             pictureBox1.Bottom >= pictureBox28.Top &&
             pictureBox1.Top <= pictureBox28.Bottom)
            {

                pictureBox28.Visible = true;
                canHakki--; // Can sayısını azalt
                label8.Text = canHakki.ToString();
                if (canHakki == 0)
                {
                    MessageBox.Show("Can hakkınız bitti! Oyun sona eriyor.");
                    this.Close();
                }
            }
            else if (pictureBox1.Right >= pictureBox27.Left &&
             pictureBox1.Left <= pictureBox27.Right &&
             pictureBox1.Bottom >= pictureBox27.Top &&
             pictureBox1.Top <= pictureBox27.Bottom)
            {

                pictureBox27.Visible = true;
                canHakki--; // Can sayısını azalt
                label8.Text = canHakki.ToString();
                if (canHakki == 0)
                {
                    MessageBox.Show("Can hakkınız bitti! Oyun sona eriyor.");
                    this.Close();
                }
            }
            else if (pictureBox1.Right >= pictureBox29.Left &&
            pictureBox1.Left <= pictureBox29.Right &&
            pictureBox1.Bottom >= pictureBox29.Top &&
            pictureBox1.Top <= pictureBox29.Bottom)
            {

                pictureBox29.Visible = true;
                canHakki--; // Can sayısını azalt
                label8.Text = canHakki.ToString();
                if (canHakki == 0)
                {
                    MessageBox.Show("Can hakkınız bitti! Oyun sona eriyor.");
                    this.Close();
                }
            }
            else if (pictureBox1.Right >= pictureBox30.Left &&
            pictureBox1.Left <= pictureBox30.Right &&
            pictureBox1.Bottom >= pictureBox30.Top &&
            pictureBox1.Top <= pictureBox30.Bottom)
            {

                pictureBox30.Visible = true;
                canHakki--; // Can sayısını azalt
                label8.Text = canHakki.ToString();
                if (canHakki == 0)
                {
                    MessageBox.Show("Can hakkınız bitti! Oyun sona eriyor.");
                    this.Close();
                }
            }
        }

        private void Seviye2_Load(object sender, EventArgs e)
        {
            label11.Text = KullaniciBilgiler.TextBoxValue;
            canHakki++;



        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }
    }
}
