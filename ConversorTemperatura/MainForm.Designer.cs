﻿/*
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
			this.btnConverterTemperatura = new System.Windows.Forms.Button();
			this.boxConverterDe = new System.Windows.Forms.ComboBox();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.lblNumTemperatura = new System.Windows.Forms.Label();
			this.lblConverter = new System.Windows.Forms.Label();
			this.txtResultado1 = new System.Windows.Forms.TextBox();
			this.txtResultado2 = new System.Windows.Forms.TextBox();
			this.lblTemperatura1 = new System.Windows.Forms.Label();
			this.lblTemperatura2 = new System.Windows.Forms.Label();
			this.pnlBanner.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlBanner
			// 
			this.pnlBanner.Controls.Add(this.lblConversor);
			this.pnlBanner.Location = new System.Drawing.Point(12, 10);
			this.pnlBanner.Name = "pnlBanner";
			this.pnlBanner.Size = new System.Drawing.Size(293, 66);
			this.pnlBanner.TabIndex = 0;
			// 
			// lblConversor
			// 
			this.lblConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConversor.Location = new System.Drawing.Point(14, 12);
			this.lblConversor.Name = "lblConversor";
			this.lblConversor.Size = new System.Drawing.Size(229, 45);
			this.lblConversor.TabIndex = 0;
			this.lblConversor.Text = "Conversor de Temperatura Celsius/Fahrenheit/Kelvin";
			// 
			// btnConverterTemperatura
			// 
			this.btnConverterTemperatura.Location = new System.Drawing.Point(129, 188);
			this.btnConverterTemperatura.Name = "btnConverterTemperatura";
			this.btnConverterTemperatura.Size = new System.Drawing.Size(77, 40);
			this.btnConverterTemperatura.TabIndex = 1;
			this.btnConverterTemperatura.Text = "Converter Temperatura";
			this.btnConverterTemperatura.UseVisualStyleBackColor = true;
			this.btnConverterTemperatura.Click += new System.EventHandler(this.BtnConverterTemperaturaClick);
			// 
			// boxConverterDe
			// 
			this.boxConverterDe.BackColor = System.Drawing.SystemColors.Window;
			this.boxConverterDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.boxConverterDe.FormattingEnabled = true;
			this.boxConverterDe.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.boxConverterDe.Items.AddRange(new object[] {
			"Celsius",
			"Fahrenheit\t",
			"Kelvin"});
			this.boxConverterDe.Location = new System.Drawing.Point(12, 161);
			this.boxConverterDe.Name = "boxConverterDe";
			this.boxConverterDe.Size = new System.Drawing.Size(122, 21);
			this.boxConverterDe.TabIndex = 2;
			this.boxConverterDe.SelectedIndexChanged += new System.EventHandler(this.BoxConverterDeSelectedIndexChanged);
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(12, 122);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(122, 20);
			this.txtNumero.TabIndex = 3;
			this.txtNumero.TextChanged += new System.EventHandler(this.TxtNumeroTextChanged);
			// 
			// lblNumTemperatura
			// 
			this.lblNumTemperatura.AutoSize = true;
			this.lblNumTemperatura.Location = new System.Drawing.Point(9, 106);
			this.lblNumTemperatura.Name = "lblNumTemperatura";
			this.lblNumTemperatura.Size = new System.Drawing.Size(67, 13);
			this.lblNumTemperatura.TabIndex = 4;
			this.lblNumTemperatura.Text = "Temperatura";
			this.lblNumTemperatura.Click += new System.EventHandler(this.lblNumTemperatura_Click);
			// 
			// lblConverter
			// 
			this.lblConverter.AutoSize = true;
			this.lblConverter.Location = new System.Drawing.Point(9, 145);
			this.lblConverter.Name = "lblConverter";
			this.lblConverter.Size = new System.Drawing.Size(56, 13);
			this.lblConverter.TabIndex = 5;
			this.lblConverter.Text = "Converter:";
			// 
			// txtResultado1
			// 
			this.txtResultado1.Location = new System.Drawing.Point(206, 122);
			this.txtResultado1.Name = "txtResultado1";
			this.txtResultado1.Size = new System.Drawing.Size(122, 20);
			this.txtResultado1.TabIndex = 3;
			// 
			// txtResultado2
			// 
			this.txtResultado2.Location = new System.Drawing.Point(206, 162);
			this.txtResultado2.Name = "txtResultado2";
			this.txtResultado2.Size = new System.Drawing.Size(122, 20);
			this.txtResultado2.TabIndex = 3;
			// 
			// lblTemperatura1
			// 
			this.lblTemperatura1.AutoSize = true;
			this.lblTemperatura1.Location = new System.Drawing.Point(249, 106);
			this.lblTemperatura1.Name = "lblTemperatura1";
			this.lblTemperatura1.Size = new System.Drawing.Size(0, 13);
			this.lblTemperatura1.TabIndex = 6;
			// 
			// lblTemperatura2
			// 
			this.lblTemperatura2.AutoSize = true;
			this.lblTemperatura2.Location = new System.Drawing.Point(249, 146);
			this.lblTemperatura2.Name = "lblTemperatura2";
			this.lblTemperatura2.Size = new System.Drawing.Size(0, 13);
			this.lblTemperatura2.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 247);
			this.Controls.Add(this.lblTemperatura2);
			this.Controls.Add(this.lblTemperatura1);
			this.Controls.Add(this.lblConverter);
			this.Controls.Add(this.lblNumTemperatura);
			this.Controls.Add(this.txtResultado2);
			this.Controls.Add(this.txtResultado1);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.boxConverterDe);
			this.Controls.Add(this.btnConverterTemperatura);
			this.Controls.Add(this.pnlBanner);
			this.Name = "MainForm";
			this.Text = "ConversorTemperatura";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.pnlBanner.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        private System.Windows.Forms.Button btnConverterTemperatura;
        private System.Windows.Forms.ComboBox boxConverterDe;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumTemperatura;
        private System.Windows.Forms.Label lblConverter;
        private System.Windows.Forms.TextBox txtResultado1;
        private System.Windows.Forms.TextBox txtResultado2;
        private System.Windows.Forms.Label lblTemperatura1;
        private System.Windows.Forms.Label lblTemperatura2;
    }
}
