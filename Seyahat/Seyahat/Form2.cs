﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seyahat
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add("1");
            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox6.Items.Add(comboBox2.Text);


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
