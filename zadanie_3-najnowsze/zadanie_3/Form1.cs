using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_3
{
    public partial class Form1 : Form
    {
        double a, b, c, x_0, x_1, x_2;
        double delta;


        List<PointF> pkt_sinus_x = new List<PointF>();
        List<PointF> pkt_cosus_y = new List<PointF>();  

        private double Zamiana_Rad(int kat)
        {
            return (Math.PI * kat) / 180;
        }

        private double wart_sin_x(int kat)
        {
            double rad = Zamiana_Rad(kat);
            return Math.Sin(rad);
        }

        private double wart_cos_x(int kat)
        {
            double rad = Zamiana_Rad(kat);
            return Math.Cos(rad);
        }

        private void Punkty(int zasieg)
        {
            for (int i = 0; i< zasieg; i++)
            {
                float sin_y = (float)wart_sin_x(i) * (-1);
                float cos_y = (float)wart_cos_x(i) * (-1);

                float sinus_skala = pictureBox1.Height / 2;
                float cosus_skala = pictureBox1.Height / 2;
                float offset_prawo = 40;

                pkt_sinus_x.Add(new PointF(i, sin_y * sinus_skala + sinus_skala + offset_prawo));
                pkt_cosus_y.Add(new PointF(i, cos_y * cosus_skala + cosus_skala + offset_prawo));
            }            
        }

        private void Refresh()
        {
            pictureBox1.Invalidate();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // sin(x)
            Graphics p = this.CreateGraphics();
            Pen pen_black = new Pen(Brushes.Black, 1.0F);

            Console.WriteLine("lalalala");

            if (pkt_sinus_x.Count > 0)
            {
                //p.DrawCurve(pen_black, pkt_sinus_x.ToArray());
                p.DrawLine(pen_black, 0, (pictureBox1.Height / 2)+40, 1000, (pictureBox1.Height / 2)+40);
                p.DrawLine(pen_black, 1, 1, 1, 420); // pionowa linia na poczatku
                p.DrawLine(pen_black, 2, 40, 10, 40); // linia ograniczajaca z gory
                p.DrawLine(pen_black, 2, 385, 10, 385); // linia ograniczajaca z gory
                p.DrawLine(pen_black, 180, 210, 180, 195); //linia Pi/2 nr 1
                p.DrawLine(pen_black, 360, 210, 360, 195); //linia Pi nr 2
                p.DrawLine(pen_black, 540, 210, 540, 195); //linia Pi/2 nr 3
                p.DrawLine(pen_black, 720, 210, 720, 195); //linia Pi nr 2
            }
        }

        string temp;

        


        private void button_sinX_Click(object sender, EventArgs e)
        {
            button_cosX.Enabled = false;
            button_sinX.Enabled = false;
            double koord_x, koord_y;
            Punkty(1000);
            Refresh();


            temp = (string)textBox_tryg_Input.Text;
            if (double.TryParse(temp, out koord_x))
            {
                Console.WriteLine(koord_x);
            }

            Graphics gr = this.CreateGraphics();
            Pen pen_red = new Pen(Brushes.Red, 1.0F);
            Pen pen_black = new Pen(Brushes.Black, 1.0F);


            float sin_y = (float)wart_sin_x((int)koord_x);
            sin_y = sin_y * (pictureBox1.Height / 2);
            Console.WriteLine(sin_y);
            textBox_wynik_tryg.Text = sin_y.ToString();


            gr.DrawLine(pen_red, 1, sin_y, (float)koord_x, sin_y);
            gr.DrawCurve(pen_black, pkt_sinus_x.ToArray());


            /*
            float offset_X = 200, offset_Y = 80, skala = 40;
            float sin_start = 0, sin_stop = 0;
            

            Graphics g = this.CreateGraphics();
            Pen pen_black = new Pen(Brushes.Black, 1.0F);

            

            for (float x=0; x<=500; x=x+2.5F)
            {
                sin_start = ((float)Math.Sin(x)* skala) + offset_Y;
                sin_stop = ((float)Math.Sin(x+2.5F)* skala) + offset_Y;

                g.DrawLine(pen_black, x + offset_X, sin_start, x + 2.5F + offset_X, sin_stop);

                sin_stop = sin_start;

            }
            */

        }

        private void button_cosX_Click(object sender, EventArgs e)
        {
            button_cosX.Enabled = false;
            button_sinX.Enabled = false;
            double koord_x, koord_y;
            Punkty(1000);
            Refresh();


            temp = (string)textBox_tryg_Input.Text;
            if (double.TryParse(temp, out koord_x))
            {
                Console.WriteLine(koord_x);
            }

            Graphics gr = this.CreateGraphics();
            Pen pen_red = new Pen(Brushes.Blue, 1.0F);
            Pen pen_black = new Pen(Brushes.Black, 1.0F);


            float cos_y = (float)wart_cos_x((int)koord_x);
            cos_y = cos_y * (pictureBox1.Height / 2);
            Console.WriteLine(cos_y);
            textBox_wynik_tryg.Text = cos_y.ToString();


            gr.DrawLine(pen_red, 1, cos_y, (float)koord_x, cos_y);
            gr.DrawCurve(pen_black, pkt_cosus_y.ToArray());
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        //
        //
        // funkcja kwadratow
        //
        //

        private void button_kwadratowa_Click(object sender, EventArgs e)
        {
        
            List<PointF> kwadratowa = new List<PointF>();

            Graphics p = this.CreateGraphics();
            Pen pen_black = new Pen(Brushes.Black, 1.0F);
            Pen pen_red = new Pen(Brushes.Red, 1.0F);

            p.DrawLine(pen_black, 1, 180, 1000, 180); // poziomma linia na poczatku
            p.DrawLine(pen_black, 1+400, 1, 1+400, 420); // pionowa linia na poczatku
            

            temp = (string)textBox_inputA.Text;
            if (double.TryParse(temp, out a))
            {
                Console.WriteLine("a: " + a);
                //Console.WriteLine(a.GetType());
            }

            temp = (string)textBox_inputB.Text;
            if (double.TryParse(temp, out b))
            {
                Console.WriteLine("b: " + b);
            }

            temp = (string)textBox_inputC.Text;
            if (double.TryParse(temp, out c))
            {
                Console.WriteLine("c: " + c);
            }

            delta = ((b * b) - (4 * a * c));
            Console.WriteLine(delta);

            if (delta > 0)
            {
                
                delta = Math.Sqrt((double)delta);
                x_1 = ((b * -1) - delta)+20;
                x_2 = ((b * -1) + delta)+20;

                Console.WriteLine("miejsca zerowe");
                Console.WriteLine("x_1: " + x_1);
                Console.WriteLine("x_2: " + x_2);

                textBox_x_1.Text = "x1: " + x_1;
                textBox_x_2.Text = "x2: " + x_2;

                float koord_p = (float)(b / (2 * a) * (-1));
                float koord_q = (float)((-1) * (delta / (4 * a)));

                kwadratowa.Add(new PointF(0, (float)x_1));
                kwadratowa.Add(new PointF(koord_p, koord_q));
                kwadratowa.Add(new Point(0, (int)x_2));


                p.DrawCurve(pen_red, kwadratowa.ToArray());


            }
            else if (delta == 0)
            {
                x_1 = ((b * -1)/ 2*a);
                Console.WriteLine("x_1: " + x_1);
                textBox_x_1.Text = "x0: " + x_1;
            }
            else 
            {
                Console.WriteLine("brak miejsc zerowych");
                textBox_x_1.Text = "brak miejsc zerowych";
            }
        
        }
    }
}
