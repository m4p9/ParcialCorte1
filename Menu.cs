﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialCorte1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modulo1Formulario nuevo = new Modulo1Formulario();
            nuevo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modulo3Formulario nuevo = new Modulo3Formulario();
            nuevo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modulo5Formulario nuevo = new Modulo5Formulario();
            nuevo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Modulo2 nuevo = new Modulo2();
            nuevo.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Modulo4 nuevo = new Modulo4();
            nuevo.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Modulo6 nuevo = new Modulo6();
            nuevo.Show();
        }
    }
}
