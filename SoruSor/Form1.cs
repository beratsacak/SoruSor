using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruSor
{
    public partial class Form1 : Form
    {
        private bool isMoving = false; // Fare tıklama durumunu izlemek için bir değişken

        public Form1()
        {
            InitializeComponent();
            button1.MouseEnter += Button1_MouseEnter;
            button1.MouseLeave += Button1_MouseLeave;
            button1.MouseDown += Button1_MouseDown;
            button1.MouseUp += Button1_MouseUp;
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            // Fare butonu butonun üstüne gelirse, butonun rastgele yeni bir konuma taşınır.
            if (!isMoving)
            {
                Random random = new Random();
                int x = random.Next(0, this.ClientSize.Width - button1.Width);
                int y = random.Next(0, this.ClientSize.Height - button1.Height);
                button1.Location = new System.Drawing.Point(x, y);
            }
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            // Fare butonun üstünden ayrıldığında hareket etme durumu sıfırlanır.
            isMoving = false;
        }

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            // Fare tıklamasını algıladığımızda, butonun hareket etme durumu aktif hale gelir.
            isMoving = true;
        }

        private void Button1_MouseUp(object sender, MouseEventArgs e)
        {
            // Fare tıklama bırakıldığında, butonun hareket etme durumu kapatılır.
            isMoving = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ADAMSINN","Nuri Hocadan Mesaj Var!!");

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
