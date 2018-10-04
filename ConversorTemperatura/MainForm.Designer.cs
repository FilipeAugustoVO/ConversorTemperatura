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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.btnConverterTemperatura.Location = new System.Drawing.Point(12, 188);
            this.btnConverterTemperatura.Name = "btnConverterTemperatura";
            this.btnConverterTemperatura.Size = new System.Drawing.Size(77, 40);
            this.btnConverterTemperatura.TabIndex = 1;
            this.btnConverterTemperatura.Text = "Converter Temperatura";
            this.btnConverterTemperatura.UseVisualStyleBackColor = true;
            // 
            // boxConverterDe
            // 
            this.boxConverterDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxConverterDe.FormattingEnabled = true;
            this.boxConverterDe.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit\t",
            "Kelvin"});
            this.boxConverterDe.Location = new System.Drawing.Point(12, 161);
            this.boxConverterDe.Name = "boxConverterDe";
            this.boxConverterDe.Size = new System.Drawing.Size(122, 21);
            this.boxConverterDe.TabIndex = 2;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(12, 122);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(122, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // lblNumTemperatura
            // 
            this.lblNumTemperatura.AutoSize = true;
            this.lblNumTemperatura.Location = new System.Drawing.Point(12, 106);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 247);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConverter);
            this.Controls.Add(this.lblNumTemperatura);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
