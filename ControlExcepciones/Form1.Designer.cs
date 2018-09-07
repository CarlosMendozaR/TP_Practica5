namespace ControlExcepciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEdad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDivision = new System.Windows.Forms.Label();
            this.btnOperar = new System.Windows.Forms.Button();
            this.txtbEdad = new System.Windows.Forms.TextBox();
            this.txtbDivisor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEdad
            // 
            this.btnEdad.Location = new System.Drawing.Point(502, 51);
            this.btnEdad.Name = "btnEdad";
            this.btnEdad.Size = new System.Drawing.Size(115, 40);
            this.btnEdad.TabIndex = 0;
            this.btnEdad.Text = "Saber mi edad";
            this.btnEdad.UseVisualStyleBackColor = true;
            this.btnEdad.Click += new System.EventHandler(this.btnEdad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa tu fecha de nacimiento:";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(537, 102);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(12, 17);
            this.lbEdad.TabIndex = 2;
            this.lbEdad.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingresa un número con el que operar una división:";
            // 
            // lbDivision
            // 
            this.lbDivision.AutoSize = true;
            this.lbDivision.Location = new System.Drawing.Point(537, 225);
            this.lbDivision.Name = "lbDivision";
            this.lbDivision.Size = new System.Drawing.Size(12, 17);
            this.lbDivision.TabIndex = 4;
            this.lbDivision.Text = " ";
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(509, 175);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(103, 31);
            this.btnOperar.TabIndex = 5;
            this.btnOperar.Text = "Operación";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // txtbEdad
            // 
            this.txtbEdad.Location = new System.Drawing.Point(88, 102);
            this.txtbEdad.Name = "txtbEdad";
            this.txtbEdad.Size = new System.Drawing.Size(100, 22);
            this.txtbEdad.TabIndex = 6;
            // 
            // txtbDivisor
            // 
            this.txtbDivisor.Location = new System.Drawing.Point(88, 225);
            this.txtbDivisor.Name = "txtbDivisor";
            this.txtbDivisor.Size = new System.Drawing.Size(100, 22);
            this.txtbDivisor.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 320);
            this.Controls.Add(this.txtbDivisor);
            this.Controls.Add(this.txtbEdad);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.lbDivision);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDivision;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.TextBox txtbEdad;
        private System.Windows.Forms.TextBox txtbDivisor;
    }
}

