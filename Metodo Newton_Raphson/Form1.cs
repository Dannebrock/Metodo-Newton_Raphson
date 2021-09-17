using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodo_Newton_Raphson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double abs(double x)
        {
            if (x < 0)
                x = -(x);
            return x;
        }

      



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {


            double xini = 0, fxnovo = 0, fdxnovo = 0,xfinal  ; //fdxnovo = derivada de fdxnovo
            int k = 0;


            double xnovo = Convert.ToDouble(textBox1.Text);
            double erro = Convert.ToDouble(textBox2.Text);
            double numiter = Convert.ToInt16(textBox3.Text);

           

               do
            {

                
                



                    xini = xnovo;
                fxnovo = (xini * xini * xini) - 9 * xini + 3; //Inserir sua função
                                                              // principal
                fdxnovo = 3 * (xini * xini) - 9; //Inserir a derivada da função principal

                
                xnovo = xini - (fxnovo / fdxnovo);
                k += 1;


                xfinal = xnovo - xini;

                listBox1.Items.Add("Iteracao = " + k);
                listBox1.Items.Add("xIni = + " + xini);
                listBox1.Items.Add("xNovo = + " + xnovo);


            }

            while (abs(xnovo - xini) >= erro || abs(fxnovo) >= erro);


            if (k > numiter)
            {
                listBox1.Items.Add("Não convergiu em " + numiter + " iterações!!!");


            }
            else




                // listBox1.Items.Add("Iteracao = " + k);
                //listBox1.Items.Add("xIni = + " + xini);
                //listBox1.Items.Add("xNovo = + " + xnovo);

                

            xfinal = xnovo - xini;
            textBox4.Text = Convert.ToString(xfinal);
            textBox5.Text = Convert.ToString(xnovo);
        }







        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }

}
