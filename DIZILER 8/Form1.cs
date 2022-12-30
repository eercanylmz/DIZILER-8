using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIZILER_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] name = new string[10];
        string[] dıstrıct = new string[10];
        string[] telephone = new string[11];
        int i = 0;
        void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            name[i] = textBox1.Text;
            dıstrıct[i] = textBox2.Text;
            telephone[i] = textBox3.Text;
            i++;
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i--;
            label9.Text = name[i];
            label8.Text = dıstrıct[i];
            label7.Text = telephone[i];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
