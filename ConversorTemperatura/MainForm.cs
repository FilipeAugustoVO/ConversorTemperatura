/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 03/10/2018
 * Time: 17:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ConversorTemperatura
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void BtnConverterCelsiusClick(object sender, EventArgs e)
		{
	
		}

        private void lblNumTemperatura_Click(object sender, EventArgs e)
        {

        }
        void BoxConverterDeSelectedIndexChanged(object sender, EventArgs e)
        {

        }
		
		void TxtNumeroTextChanged(object sender, EventArgs e)
		{
	
		}

        private void btnConverterTemperatura_Click_1(object sender, EventArgs e)

        {
            if (radioCelsius.Checked)
            {
                
                //Celsius para Fahrenheit e Kelvin
                double numero, resultado1, resultado2;
                numero = double.Parse(txtNumero.Text);
                txtResultado1.Text = Convert.ToString(resultado1 = numero * 1.8 + 32);
                txtResultado2.Text = Convert.ToString(resultado2 = numero + 273.15);
                
            }
            else

            if (radioFahrenheit.Checked)
            {
                //Fahrenheit pra Celsius e Kelvin
                double numero, resultado1, resultado2;
                numero = double.Parse(txtNumero.Text);
                txtResultado1.Text = Convert.ToString(resultado1 = (numero - 32) / 1.8);
                txtResultado2.Text = Convert.ToString(resultado2 = (numero + 459.67) * 5 / 9);              
            }
            else 

            if (radioKelvin.Checked)
            {
                //Kelvin para Celsius e Fahrenheit
                double numero, resultado1, resultado2;
                numero = double.Parse(txtNumero.Text);
                txtResultado1.Text = Convert.ToString(resultado1 = numero - 273.15);
                txtResultado2.Text = Convert.ToString(resultado2 = (numero + 459.67));              
            }

        }

    }
}
