﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Obtener valores de los textbox -numeros//
            string sNumeroA = this.textBox1.Text;
            string sNumeroB = this.textBox2.Text;

            //pasaje de string a tipo de dato int a los valores obtenidos//
            int numeroA = int.Parse(sNumeroA);
            int numeroB = int.Parse(sNumeroB);

            //logica de la suma//
            int resultado = numeroA + numeroB;

            //muestra el resultado mediante el label 'resultado' y devuelve el resultado tipo string//
            this.resultado.Text = resultado.ToString();  
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
