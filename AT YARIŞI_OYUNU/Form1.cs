using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT_YARIŞI_OYUNU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsoluzaklık, ikinciatsoluzaklık, ucuncuatsoluzaklık;
        Random rastgele = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {

            int sayac = Convert.ToInt32(label7.Text);
            sayac++;
            label7.Text = sayac.ToString();



            int birinciatgenisligi = pictureBox1.Width;
            int ikinciatgenisligi = pictureBox2.Width;
            int ucuncuatgenisligi = pictureBox3.Width;

            int bıtısuzaklıgı = label5.Left;
            pictureBox1.Left = pictureBox1.Left+rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);
            if (pictureBox1.Left>pictureBox2.Left+5&&pictureBox1.Left> pictureBox3.Left)
            {
                label6.Text = "birinci at öndee";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "ikinci at öndee";
            }
            if (pictureBox3.Left > pictureBox1.Left && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "üçüncü at öndee";
            }

            if (birinciatgenisligi + pictureBox1.Left>= bıtısuzaklıgı)
            {
                timer1.Stop();
                MessageBox.Show("1.at kazandı !!!!!");
            }
            if (ikinciatgenisligi+ pictureBox2.Left >= bıtısuzaklıgı)
            {
                timer1.Stop();
                MessageBox.Show("2.atkazandı !!!!!");
                if (ucuncuatgenisligi + pictureBox3.Left >= bıtısuzaklıgı)
                {
                    timer1.Stop();
                    MessageBox.Show("3at kazandı !!!!!");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsoluzaklık = pictureBox1.Left;
            ikinciatsoluzaklık = pictureBox1.Left;
            ucuncuatsoluzaklık = pictureBox3.Left;
            

             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
