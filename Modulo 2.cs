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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lado;
            int altura;
            lado = int.Parse(BaseC.Text);
            altura = int.Parse(AlturaC.Text);

            int Res = lado * altura;

            MessageBox.Show("EL AREA DEL CUADRADO ES:" + Res + " ", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
