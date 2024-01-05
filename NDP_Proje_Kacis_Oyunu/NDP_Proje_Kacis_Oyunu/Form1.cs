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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AVATARINIZI HAREKET ETTİRMEK İÇİN YÖN TUŞLARINI KULLANINIZ\n\n ↑ : YUKARI YÖN TUŞU\n ↓ : AŞAĞI YÖN TUŞU\n → : SAĞ YÖN TUŞU\n ← : SOL YÖN TUŞU\n\n Oyunu durdurmak için P tuşuna basınız.");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            KullaniciBilgiler.TextBoxValue = textBox1.Text;

            Seviye1 seviye1 = new Seviye1();
            seviye1.Show();
            Seviye2 seviye2 = new Seviye2();
   
            Seviye3 seviye3 = new Seviye3();    
           





        }
      

    }
}
