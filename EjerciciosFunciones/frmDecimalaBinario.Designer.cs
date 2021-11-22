
namespace EjerciciosFunciones
{
    partial class frmDecimalaBinario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.check3 = new System.Windows.Forms.CheckBox();
            this.check4 = new System.Windows.Forms.CheckBox();
            this.check5 = new System.Windows.Forms.CheckBox();
            this.check6 = new System.Windows.Forms.CheckBox();
            this.check7 = new System.Windows.Forms.CheckBox();
            this.check8 = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un Entero";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(342, 26);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(161, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.check8);
            this.groupBox1.Controls.Add(this.check7);
            this.groupBox1.Controls.Add(this.check6);
            this.groupBox1.Controls.Add(this.check5);
            this.groupBox1.Controls.Add(this.check4);
            this.groupBox1.Controls.Add(this.check3);
            this.groupBox1.Controls.Add(this.check2);
            this.groupBox1.Controls.Add(this.check1);
            this.groupBox1.Location = new System.Drawing.Point(55, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equivalente en Binario";
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Location = new System.Drawing.Point(597, 89);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(15, 14);
            this.check1.TabIndex = 0;
            this.check1.UseVisualStyleBackColor = true;
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Location = new System.Drawing.Point(521, 89);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(15, 14);
            this.check2.TabIndex = 1;
            this.check2.UseVisualStyleBackColor = true;
            // 
            // check3
            // 
            this.check3.AutoSize = true;
            this.check3.Location = new System.Drawing.Point(433, 89);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(15, 14);
            this.check3.TabIndex = 2;
            this.check3.UseVisualStyleBackColor = true;
            // 
            // check4
            // 
            this.check4.AutoSize = true;
            this.check4.Location = new System.Drawing.Point(348, 89);
            this.check4.Name = "check4";
            this.check4.Size = new System.Drawing.Size(15, 14);
            this.check4.TabIndex = 3;
            this.check4.UseVisualStyleBackColor = true;
            // 
            // check5
            // 
            this.check5.AutoSize = true;
            this.check5.Location = new System.Drawing.Point(270, 89);
            this.check5.Name = "check5";
            this.check5.Size = new System.Drawing.Size(15, 14);
            this.check5.TabIndex = 4;
            this.check5.UseVisualStyleBackColor = true;
            // 
            // check6
            // 
            this.check6.AutoSize = true;
            this.check6.Location = new System.Drawing.Point(195, 89);
            this.check6.Name = "check6";
            this.check6.Size = new System.Drawing.Size(15, 14);
            this.check6.TabIndex = 5;
            this.check6.UseVisualStyleBackColor = true;
            // 
            // check7
            // 
            this.check7.AutoSize = true;
            this.check7.Location = new System.Drawing.Point(111, 89);
            this.check7.Name = "check7";
            this.check7.Size = new System.Drawing.Size(15, 14);
            this.check7.TabIndex = 6;
            this.check7.UseVisualStyleBackColor = true;
            // 
            // check8
            // 
            this.check8.AutoSize = true;
            this.check8.Location = new System.Drawing.Point(47, 89);
            this.check8.Name = "check8";
            this.check8.Size = new System.Drawing.Size(15, 14);
            this.check8.TabIndex = 7;
            this.check8.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(80, 301);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(185, 51);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmDecimalaBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "frmDecimalaBinario";
            this.Text = "Convierte un entero en Binario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox check8;
        private System.Windows.Forms.CheckBox check7;
        private System.Windows.Forms.CheckBox check6;
        private System.Windows.Forms.CheckBox check5;
        private System.Windows.Forms.CheckBox check4;
        private System.Windows.Forms.CheckBox check3;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.Button btnCalcular;
    }
}