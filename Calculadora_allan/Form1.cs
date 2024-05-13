using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_allan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double valor1 = 0;
        double valor2 = 0;
        string operador = "";



        private void btn1_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text == "0")
            {
                txt_Resultado.Text = "7";
            }
            else
            {
                txt_Resultado.Text = txt_Resultado.Text + "7";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text == "0")
            {
                txt_Resultado.Text = "8";
            }
            else
            {
                txt_Resultado.Text = txt_Resultado.Text + "8";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text == "0")
            {
                txt_Resultado.Text = "9";
            }
            else
            {
                txt_Resultado.Text = txt_Resultado.Text + "9";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text == "0")
            {
                txt_Resultado.Text = "4";
            }
            else
            {
                txt_Resultado.Text = txt_Resultado.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text == "0")
            {
                txt_Resultado.Text = "5";
            }
            else
            {
                txt_Resultado.Text = txt_Resultado.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text == "0")
            {
                txt_Resultado.Text = "6";
            }
            else
            {
                txt_Resultado.Text = txt_Resultado.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text == "0")
            {
                txt_Resultado.Text = "1";
            }
            else
            {
                txt_Resultado.Text = txt_Resultado.Text + "1";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text == "0")
            {
                txt_Resultado.Text = "2";
            }
            else
            {
                txt_Resultado.Text = txt_Resultado.Text + "2";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text == "0")
            {
                txt_Resultado.Text = "3";
            }
            else
            {
                txt_Resultado.Text = txt_Resultado.Text + "3";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + "0";

        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (this.txt_Resultado.Text.Contains(".") == false)
            {
                this.txt_Resultado.Text = this.txt_Resultado.Text + ".";
            }
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Resultado.Text))
            {
                valor1 = Convert.ToDouble(this.txt_Resultado.Text);
            }
            //valor1 = Convert.ToDouble(this.txt_Resultado.Text);
            operador = "*";
            this.txt_Resultado.Clear();
            this.txt_Resultado.Focus();
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Resultado.Text))
            {
                valor1 = Convert.ToDouble(this.txt_Resultado.Text);
            }
            operador = "/";
            this.txt_Resultado.Clear();
            this.txt_Resultado.Focus();
        }

        private void btmodulo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Resultado.Text))
            {
                valor1 = Convert.ToDouble(this.txt_Resultado.Text);
            }
            operador = "%";
            this.txt_Resultado.Clear();
            this.txt_Resultado.Focus();
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Resultado.Text))
            {
                valor1 = Convert.ToDouble(this.txt_Resultado.Text);
            }

            operador = "-";
            this.txt_Resultado.Clear();
            this.txt_Resultado.Focus();
        }

        private void btnmas_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Resultado.Text))
            {
                valor1 = Convert.ToDouble(this.txt_Resultado.Text);
            }
            operador = "+";
            this.txt_Resultado.Clear();
            this.txt_Resultado.Focus();
        }

        private void btnexponente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Resultado.Text))
            {
                valor1 = Convert.ToDouble(this.txt_Resultado.Text);
            }
            operador = "^";
            this.txt_Resultado.Clear();
            this.txt_Resultado.Focus();
        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Resultado.Text))
            {
                valor1 = Convert.ToDouble(this.txt_Resultado.Text);
            }
            operador = "√";
            this.txt_Resultado.Clear();
            this.txt_Resultado.Focus();

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Resultado.Text))
            {
                valor2 = Convert.ToDouble(this.txt_Resultado.Text);
            }

            double resultado = 0;

            switch (operador)
            {
                case "+":

                    resultado = valor1 + valor2;
                    this.txt_Resultado.Text = Convert.ToString(valor2 + valor1);
                    this.txt_Resultado.Text = resultado.ToString("N");

                    break;

                case "-":

                    resultado = valor1 - valor2;
                    this.txt_Resultado.Text = Convert.ToString(valor1 - valor2);
                    this.txt_Resultado.Text = resultado.ToString("N");

                    break;

                case "/":

                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                        this.txt_Resultado.Text = Convert.ToString(valor1 / valor2);
                        this.txt_Resultado.Text = resultado.ToString("N");
                    }
                    else
                    {
                        txt_Resultado.Text = "No sé puede dividir entre cero";
                        MessageBox.Show("No sé puede dividir entre cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    break;

                case "*":

                    resultado = valor2 * valor1;
                    this.txt_Resultado.Text = Convert.ToString(valor2 * valor1);
                    this.txt_Resultado.Text = resultado.ToString("N");

                    break;

                case "%":

                    resultado = valor1 % valor2;
                    this.txt_Resultado.Text = Convert.ToString(valor1 % valor2);
                    this.txt_Resultado.Text = resultado.ToString("N");

                    break;

                case "^":

                    resultado = Math.Pow(valor1, valor2);
                    this.txt_Resultado.Text = Convert.ToString(Math.Pow(valor1, valor2));
                    this.txt_Resultado.Text = resultado.ToString("N");

                    break;

                case "√":

                    resultado = Math.Pow(valor1, 1.0 / valor2);
                    this.txt_Resultado.Text = Convert.ToString(Math.Pow(valor1, 1.0 / valor2));
                    this.txt_Resultado.Text = resultado.ToString("N");

                    break;
            }

            string operacion = $"{valor1} {operador} {valor2} = {resultado.ToString("N")}";
            Lst_Historial.Items.Add(operacion);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            txt_Resultado.Text = "0";
        }

        private void btnhistorial_Click(object sender, EventArgs e)
        {
            StreamWriter Archivo = new StreamWriter("C:\\Users\\Usuario\\OneDrive\\Desktop\\Historial Calculadora.txt");
            Archivo.WriteLine("Operaciones: " + valor1 + operador + valor2 + "=" + this.txt_Resultado.Text);
            Archivo.Flush();
            Archivo.Close();

            System.Diagnostics.Process.Start("C:\\Users\\Usuario\\OneDrive\\Desktop\\Historial Calculadora.txt");
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {

            if (Numero(txt_Resultado.Text))
            {
                if (txt_Resultado.TextLength > 0)
                {
                    txt_Resultado.Text = txt_Resultado.Text.Substring(0, txt_Resultado.TextLength - 1);
                }
            }
            else
            {
                txt_Resultado.Clear();
                txt_Resultado.Text = "0";
            }

        }


        private bool Numero(string texto)
        {
            double numero;
            return double.TryParse(texto, out numero);
        }


    }
}
