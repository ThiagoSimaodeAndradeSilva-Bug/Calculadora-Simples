using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, soma;

            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);

            //.Parse ou .Covert.To servem para conversão de string para o tipo de variável escolhida (Double, char ,bool etc...)

            // - subtração | + adição | * multiplicação | / divisão | % resto da divisão

            // > maior que | >= maior ou igual a | < menor que | <= menor ou igual a | == igual a | != diferente

            soma = num1 + num2;

            label6.Text = soma.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
