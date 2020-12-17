using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace WordPerMinute
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        int sayac = 0;
        int count = 0;

        public Form1()
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;

            string[] x = richTextBox1.Text.Split(new char[] { ' ', ',', '.','\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in x)
            {

                list.Add(item.ToString());
            };

        }



        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Stop();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            TimerLabel.Text = sayac.ToString();

            WordCountLabel.Text = count.ToString();
            for (int i = 0; i < list.Count; i++)
            {
                if (textBox1.Text == list[i])
                {
                    list.Remove(list[i]);
                    count++;
                    textBox1.Text = null;
                }
                
            }



            //if (sayac == 60)
            //{
            //    textBox1.Enabled = false;
            //    timer1.Stop();
            //    TimerLabel.Text = "Süreniz Doldu";

            //}

        }




        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            timer1.Start();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }


    }

}

