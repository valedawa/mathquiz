
namespace mathquiz2
{
    partial class CalculadoraBasica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraBasica));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxv1 = new System.Windows.Forms.TextBox();
            this.textBoxv2 = new System.Windows.Forms.TextBox();
            this.buttonSuma = new System.Windows.Forms.Button();
            this.buttonResta = new System.Windows.Forms.Button();
            this.buttonMultiplicacion = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Stay Gracious", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora Basica";
            // 
            // textBoxv1
            // 
            this.textBoxv1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxv1.Location = new System.Drawing.Point(17, 59);
            this.textBoxv1.Name = "textBoxv1";
            this.textBoxv1.Size = new System.Drawing.Size(50, 33);
            this.textBoxv1.TabIndex = 1;
            // 
            // textBoxv2
            // 
            this.textBoxv2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxv2.Location = new System.Drawing.Point(108, 59);
            this.textBoxv2.Name = "textBoxv2";
            this.textBoxv2.Size = new System.Drawing.Size(56, 33);
            this.textBoxv2.TabIndex = 2;
            // 
            // buttonSuma
            // 
            this.buttonSuma.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSuma.Location = new System.Drawing.Point(212, 59);
            this.buttonSuma.Name = "buttonSuma";
            this.buttonSuma.Size = new System.Drawing.Size(40, 33);
            this.buttonSuma.TabIndex = 3;
            this.buttonSuma.Text = "+";
            this.buttonSuma.UseVisualStyleBackColor = false;
            this.buttonSuma.Click += new System.EventHandler(this.buttonSuma_Click);
            // 
            // buttonResta
            // 
            this.buttonResta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonResta.Location = new System.Drawing.Point(258, 59);
            this.buttonResta.Name = "buttonResta";
            this.buttonResta.Size = new System.Drawing.Size(40, 33);
            this.buttonResta.TabIndex = 4;
            this.buttonResta.Text = "-";
            this.buttonResta.UseVisualStyleBackColor = false;
            this.buttonResta.Click += new System.EventHandler(this.buttonResta_Click);
            // 
            // buttonMultiplicacion
            // 
            this.buttonMultiplicacion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMultiplicacion.Location = new System.Drawing.Point(212, 98);
            this.buttonMultiplicacion.Name = "buttonMultiplicacion";
            this.buttonMultiplicacion.Size = new System.Drawing.Size(40, 32);
            this.buttonMultiplicacion.TabIndex = 5;
            this.buttonMultiplicacion.Text = "/";
            this.buttonMultiplicacion.UseVisualStyleBackColor = false;
            this.buttonMultiplicacion.Click += new System.EventHandler(this.buttonMultiplicacion_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDivision.Location = new System.Drawing.Point(258, 98);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(40, 32);
            this.buttonDivision.TabIndex = 6;
            this.buttonDivision.Text = "x";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(134, 142);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(118, 20);
            this.textBoxResultado.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightPink;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Resultado";
            // 
            // CalculadoraBasica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mathquiz2.Properties.Resources.descarga__3_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(352, 207);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMultiplicacion);
            this.Controls.Add(this.buttonResta);
            this.Controls.Add(this.buttonSuma);
            this.Controls.Add(this.textBoxv2);
            this.Controls.Add(this.textBoxv1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculadoraBasica";
            this.Text = "Calculadora Basica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxv1;
        private System.Windows.Forms.TextBox textBoxv2;
        private System.Windows.Forms.Button buttonSuma;
        private System.Windows.Forms.Button buttonResta;
        private System.Windows.Forms.Button buttonMultiplicacion;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Label label2;
    }
}