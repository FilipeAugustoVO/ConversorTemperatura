/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 03/10/2018
 * Time: 17:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ConversorTemperatura
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel pnlBanner;
		private System.Windows.Forms.Label lblConversor;
		private System.Windows.Forms.TextBox txtConverterCelsius;
		private System.Windows.Forms.Button btnConverterCelsius;
		private System.Windows.Forms.TextBox txtConverterFahrenheit;
		private System.Windows.Forms.Button btnConverterFahrenheit;
		private System.Windows.Forms.TextBox txtConverterKelvin;
		private System.Windows.Forms.Button btnConverterKelvin;
		private System.Windows.Forms.Label lblConverterCelsius;
		private System.Windows.Forms.Label lblConverterFahrenheit;
		private System.Windows.Forms.Label lblConverterKelvin;
		private System.Windows.Forms.TextBox txtConvertidoCelsiusFahrenheit;
		private System.Windows.Forms.Label lblConvertidoCelsiusFahrenheit;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label lblConvertidoCelsiusKelvin;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtConvertidoFahrenheitKelvin;
		private System.Windows.Forms.Label lblConvertidoFahrenheitKelvin;
		private System.Windows.Forms.TextBox txtConvertidoFahrenheitCelsius;
		private System.Windows.Forms.Label lblConvertidoFahrenheitCelsius;
		private System.Windows.Forms.TextBox txtConvertidoKelvinCelsius;
		private System.Windows.Forms.TextBox txtConvertidoKelvinFahrenheit;
		private System.Windows.Forms.Label lblConvertidoKelvinCelsius;
		private System.Windows.Forms.Label lblFahrenheit;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlBanner = new System.Windows.Forms.Panel();
			this.lblConversor = new System.Windows.Forms.Label();
			this.txtConverterCelsius = new System.Windows.Forms.TextBox();
			this.btnConverterCelsius = new System.Windows.Forms.Button();
			this.txtConverterFahrenheit = new System.Windows.Forms.TextBox();
			this.btnConverterFahrenheit = new System.Windows.Forms.Button();
			this.txtConverterKelvin = new System.Windows.Forms.TextBox();
			this.btnConverterKelvin = new System.Windows.Forms.Button();
			this.lblConverterCelsius = new System.Windows.Forms.Label();
			this.lblConverterFahrenheit = new System.Windows.Forms.Label();
			this.lblConverterKelvin = new System.Windows.Forms.Label();
			this.txtConvertidoCelsiusFahrenheit = new System.Windows.Forms.TextBox();
			this.lblConvertidoCelsiusFahrenheit = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.lblConvertidoCelsiusKelvin = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtConvertidoFahrenheitKelvin = new System.Windows.Forms.TextBox();
			this.lblConvertidoFahrenheitKelvin = new System.Windows.Forms.Label();
			this.txtConvertidoFahrenheitCelsius = new System.Windows.Forms.TextBox();
			this.lblConvertidoFahrenheitCelsius = new System.Windows.Forms.Label();
			this.txtConvertidoKelvinCelsius = new System.Windows.Forms.TextBox();
			this.txtConvertidoKelvinFahrenheit = new System.Windows.Forms.TextBox();
			this.lblConvertidoKelvinCelsius = new System.Windows.Forms.Label();
			this.lblFahrenheit = new System.Windows.Forms.Label();
			this.pnlBanner.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlBanner
			// 
			this.pnlBanner.Controls.Add(this.lblConversor);
			this.pnlBanner.Location = new System.Drawing.Point(12, 10);
			this.pnlBanner.Name = "pnlBanner";
			this.pnlBanner.Size = new System.Drawing.Size(477, 66);
			this.pnlBanner.TabIndex = 0;
			// 
			// lblConversor
			// 
			this.lblConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConversor.Location = new System.Drawing.Point(14, 12);
			this.lblConversor.Name = "lblConversor";
			this.lblConversor.Size = new System.Drawing.Size(451, 45);
			this.lblConversor.TabIndex = 0;
			this.lblConversor.Text = "Conversor de Temperatura Celsius/Fahrenheit/Kelvin";
			// 
			// txtConverterCelsius
			// 
			this.txtConverterCelsius.Location = new System.Drawing.Point(12, 107);
			this.txtConverterCelsius.Name = "txtConverterCelsius";
			this.txtConverterCelsius.Size = new System.Drawing.Size(100, 20);
			this.txtConverterCelsius.TabIndex = 1;
			// 
			// btnConverterCelsius
			// 
			this.btnConverterCelsius.Location = new System.Drawing.Point(12, 133);
			this.btnConverterCelsius.Name = "btnConverterCelsius";
			this.btnConverterCelsius.Size = new System.Drawing.Size(100, 34);
			this.btnConverterCelsius.TabIndex = 2;
			this.btnConverterCelsius.Text = "Converter Temperatura";
			this.btnConverterCelsius.UseVisualStyleBackColor = true;
			this.btnConverterCelsius.Click += new System.EventHandler(this.BtnConverterCelsiusClick);
			// 
			// txtConverterFahrenheit
			// 
			this.txtConverterFahrenheit.Location = new System.Drawing.Point(12, 235);
			this.txtConverterFahrenheit.Name = "txtConverterFahrenheit";
			this.txtConverterFahrenheit.Size = new System.Drawing.Size(100, 20);
			this.txtConverterFahrenheit.TabIndex = 1;
			// 
			// btnConverterFahrenheit
			// 
			this.btnConverterFahrenheit.Location = new System.Drawing.Point(12, 261);
			this.btnConverterFahrenheit.Name = "btnConverterFahrenheit";
			this.btnConverterFahrenheit.Size = new System.Drawing.Size(100, 34);
			this.btnConverterFahrenheit.TabIndex = 2;
			this.btnConverterFahrenheit.Text = "Converter Temperatura";
			this.btnConverterFahrenheit.UseVisualStyleBackColor = true;
			// 
			// txtConverterKelvin
			// 
			this.txtConverterKelvin.Location = new System.Drawing.Point(12, 352);
			this.txtConverterKelvin.Name = "txtConverterKelvin";
			this.txtConverterKelvin.Size = new System.Drawing.Size(100, 20);
			this.txtConverterKelvin.TabIndex = 1;
			// 
			// btnConverterKelvin
			// 
			this.btnConverterKelvin.Location = new System.Drawing.Point(12, 378);
			this.btnConverterKelvin.Name = "btnConverterKelvin";
			this.btnConverterKelvin.Size = new System.Drawing.Size(100, 34);
			this.btnConverterKelvin.TabIndex = 2;
			this.btnConverterKelvin.Text = "Converter Temperatura";
			this.btnConverterKelvin.UseVisualStyleBackColor = true;
			// 
			// lblConverterCelsius
			// 
			this.lblConverterCelsius.Location = new System.Drawing.Point(12, 81);
			this.lblConverterCelsius.Name = "lblConverterCelsius";
			this.lblConverterCelsius.Size = new System.Drawing.Size(100, 23);
			this.lblConverterCelsius.TabIndex = 3;
			this.lblConverterCelsius.Text = "Celsius";
			this.lblConverterCelsius.Click += new System.EventHandler(this.Label1Click);
			// 
			// lblConverterFahrenheit
			// 
			this.lblConverterFahrenheit.Location = new System.Drawing.Point(12, 209);
			this.lblConverterFahrenheit.Name = "lblConverterFahrenheit";
			this.lblConverterFahrenheit.Size = new System.Drawing.Size(100, 23);
			this.lblConverterFahrenheit.TabIndex = 3;
			this.lblConverterFahrenheit.Text = "Fahrenheit";
			// 
			// lblConverterKelvin
			// 
			this.lblConverterKelvin.Location = new System.Drawing.Point(12, 326);
			this.lblConverterKelvin.Name = "lblConverterKelvin";
			this.lblConverterKelvin.Size = new System.Drawing.Size(100, 23);
			this.lblConverterKelvin.TabIndex = 3;
			this.lblConverterKelvin.Text = "Kelvin";
			// 
			// txtConvertidoCelsiusFahrenheit
			// 
			this.txtConvertidoCelsiusFahrenheit.Location = new System.Drawing.Point(186, 107);
			this.txtConvertidoCelsiusFahrenheit.Name = "txtConvertidoCelsiusFahrenheit";
			this.txtConvertidoCelsiusFahrenheit.Size = new System.Drawing.Size(100, 20);
			this.txtConvertidoCelsiusFahrenheit.TabIndex = 1;
			// 
			// lblConvertidoCelsiusFahrenheit
			// 
			this.lblConvertidoCelsiusFahrenheit.Location = new System.Drawing.Point(186, 81);
			this.lblConvertidoCelsiusFahrenheit.Name = "lblConvertidoCelsiusFahrenheit";
			this.lblConvertidoCelsiusFahrenheit.Size = new System.Drawing.Size(100, 23);
			this.lblConvertidoCelsiusFahrenheit.TabIndex = 3;
			this.lblConvertidoCelsiusFahrenheit.Text = "Fahrenheit";
			this.lblConvertidoCelsiusFahrenheit.Click += new System.EventHandler(this.Label1Click);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(292, 107);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 1;
			// 
			// lblConvertidoCelsiusKelvin
			// 
			this.lblConvertidoCelsiusKelvin.Location = new System.Drawing.Point(292, 81);
			this.lblConvertidoCelsiusKelvin.Name = "lblConvertidoCelsiusKelvin";
			this.lblConvertidoCelsiusKelvin.Size = new System.Drawing.Size(100, 23);
			this.lblConvertidoCelsiusKelvin.TabIndex = 3;
			this.lblConvertidoCelsiusKelvin.Text = "Kelvin";
			this.lblConvertidoCelsiusKelvin.Click += new System.EventHandler(this.Label1Click);
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(186, 235);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 20);
			this.textBox6.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(186, 209);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 3;
			this.label6.Text = "Celsius";
			this.label6.Click += new System.EventHandler(this.Label1Click);
			// 
			// txtConvertidoFahrenheitKelvin
			// 
			this.txtConvertidoFahrenheitKelvin.Location = new System.Drawing.Point(292, 235);
			this.txtConvertidoFahrenheitKelvin.Name = "txtConvertidoFahrenheitKelvin";
			this.txtConvertidoFahrenheitKelvin.Size = new System.Drawing.Size(100, 20);
			this.txtConvertidoFahrenheitKelvin.TabIndex = 1;
			// 
			// lblConvertidoFahrenheitKelvin
			// 
			this.lblConvertidoFahrenheitKelvin.Location = new System.Drawing.Point(292, 209);
			this.lblConvertidoFahrenheitKelvin.Name = "lblConvertidoFahrenheitKelvin";
			this.lblConvertidoFahrenheitKelvin.Size = new System.Drawing.Size(100, 23);
			this.lblConvertidoFahrenheitKelvin.TabIndex = 3;
			this.lblConvertidoFahrenheitKelvin.Text = "Kelvin";
			this.lblConvertidoFahrenheitKelvin.Click += new System.EventHandler(this.Label1Click);
			// 
			// txtConvertidoFahrenheitCelsius
			// 
			this.txtConvertidoFahrenheitCelsius.Location = new System.Drawing.Point(186, 235);
			this.txtConvertidoFahrenheitCelsius.Name = "txtConvertidoFahrenheitCelsius";
			this.txtConvertidoFahrenheitCelsius.Size = new System.Drawing.Size(100, 20);
			this.txtConvertidoFahrenheitCelsius.TabIndex = 1;
			// 
			// lblConvertidoFahrenheitCelsius
			// 
			this.lblConvertidoFahrenheitCelsius.Location = new System.Drawing.Point(186, 209);
			this.lblConvertidoFahrenheitCelsius.Name = "lblConvertidoFahrenheitCelsius";
			this.lblConvertidoFahrenheitCelsius.Size = new System.Drawing.Size(100, 23);
			this.lblConvertidoFahrenheitCelsius.TabIndex = 3;
			this.lblConvertidoFahrenheitCelsius.Text = "Celsius";
			this.lblConvertidoFahrenheitCelsius.Click += new System.EventHandler(this.Label1Click);
			// 
			// txtConvertidoKelvinCelsius
			// 
			this.txtConvertidoKelvinCelsius.Location = new System.Drawing.Point(186, 352);
			this.txtConvertidoKelvinCelsius.Name = "txtConvertidoKelvinCelsius";
			this.txtConvertidoKelvinCelsius.Size = new System.Drawing.Size(100, 20);
			this.txtConvertidoKelvinCelsius.TabIndex = 1;
			// 
			// txtConvertidoKelvinFahrenheit
			// 
			this.txtConvertidoKelvinFahrenheit.Location = new System.Drawing.Point(292, 352);
			this.txtConvertidoKelvinFahrenheit.Name = "txtConvertidoKelvinFahrenheit";
			this.txtConvertidoKelvinFahrenheit.Size = new System.Drawing.Size(100, 20);
			this.txtConvertidoKelvinFahrenheit.TabIndex = 1;
			// 
			// lblConvertidoKelvinCelsius
			// 
			this.lblConvertidoKelvinCelsius.Location = new System.Drawing.Point(186, 326);
			this.lblConvertidoKelvinCelsius.Name = "lblConvertidoKelvinCelsius";
			this.lblConvertidoKelvinCelsius.Size = new System.Drawing.Size(100, 23);
			this.lblConvertidoKelvinCelsius.TabIndex = 3;
			this.lblConvertidoKelvinCelsius.Text = "Celsius";
			this.lblConvertidoKelvinCelsius.Click += new System.EventHandler(this.Label1Click);
			// 
			// lblFahrenheit
			// 
			this.lblFahrenheit.Location = new System.Drawing.Point(292, 326);
			this.lblFahrenheit.Name = "lblFahrenheit";
			this.lblFahrenheit.Size = new System.Drawing.Size(100, 23);
			this.lblFahrenheit.TabIndex = 3;
			this.lblFahrenheit.Text = "Fahrenheit";
			this.lblFahrenheit.Click += new System.EventHandler(this.Label1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 426);
			this.Controls.Add(this.lblConverterKelvin);
			this.Controls.Add(this.lblConverterFahrenheit);
			this.Controls.Add(this.lblConvertidoCelsiusKelvin);
			this.Controls.Add(this.lblFahrenheit);
			this.Controls.Add(this.lblConvertidoFahrenheitKelvin);
			this.Controls.Add(this.lblConvertidoKelvinCelsius);
			this.Controls.Add(this.lblConvertidoFahrenheitCelsius);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblConvertidoCelsiusFahrenheit);
			this.Controls.Add(this.lblConverterCelsius);
			this.Controls.Add(this.btnConverterKelvin);
			this.Controls.Add(this.btnConverterFahrenheit);
			this.Controls.Add(this.txtConvertidoKelvinFahrenheit);
			this.Controls.Add(this.btnConverterCelsius);
			this.Controls.Add(this.txtConvertidoKelvinCelsius);
			this.Controls.Add(this.txtConvertidoFahrenheitKelvin);
			this.Controls.Add(this.txtConvertidoFahrenheitCelsius);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.txtConverterKelvin);
			this.Controls.Add(this.txtConvertidoCelsiusFahrenheit);
			this.Controls.Add(this.txtConverterFahrenheit);
			this.Controls.Add(this.txtConverterCelsius);
			this.Controls.Add(this.pnlBanner);
			this.Name = "MainForm";
			this.Text = "ConversorTemperatura";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.pnlBanner.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
