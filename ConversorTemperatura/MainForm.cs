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
                {
                    //Celsius pra Fahrenheit
                   /* double numero, resultado1;
                    numero = double.Parse(txtNumero.Text);
                    resultado1 = numero * 1.8 + 32;
                    txtResultado1.Text; */
                        
                    //Celsius pra Kelvin
                    double numero, resultado2;
                    numero = double.Parse(txtNumero.Text);
                    resultado2 = numero - 273.15;
                    txtResultado2.ToString(); 
                    // txtResultado2.Text; 
                }
            }
            /* else

            if (radioFahrenheit.Checked)
            {
                //Fahrenheit pra Celsius
                double numero, resultado1;
                numero = double.parse(txtNumero.Text);
                resultado1 = (numero - 32) / 1,8;
                txtResultado1.Text;

                //Fahrenheit pra Kelvin
                double numero, resultado2;
                numero = double.parse(txtNumero.Text);
                resultado2 = (numero + 459, 67) * 5 / 9;
                txtResultado2.Text;
            }
            else 

            if (radioKelvin.Checked)
            {
                //Kelvin pra Celsius
                double numero, resultado1;
                numero = double.parse(txtNumero.Text);
                resultado1 = numero - 273,15;
                txtResultado1.Text;

                //Kelvin pra Fahrenheit
                double numero, resultado2;
                numero = double.parse(txtNumero.Text);
                resultado2 = (numero + 459, 67);
                txtResultado2.Text; 
            }*/

        }

    }
}
