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
		void BtnConverterTemperaturaClick(object sender, EventArgs e)
		{
			//Celsius pra Fahrenheit e Kelvin
			{
				if (BoxConverterDe.SelectedIndex.SelectedIndex == -1)
				{
					MessageBox.Show("Por favor selecione um tipo de temperatura para converter para outros", "Aviso");
				}
			}
			else(BoxConverterDe.GetItemText(BoxConverterDe.SelectedItem)
			   {
			   	
			   }
			
			//Fahrenheit pra Celsius e Kelvin

			//Kelvin pra Celsius e Fahrenheit

			
			   
		}
    }
}
