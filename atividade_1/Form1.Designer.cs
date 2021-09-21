
namespace atividade_1
{
    partial class Form1
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
            this.labelA = new System.Windows.Forms.Label();
            this.valorA = new System.Windows.Forms.TextBox();
            this.labelN = new System.Windows.Forms.Label();
            this.valorN = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.msgError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(37, 34);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(56, 13);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "Valor de A";
            // 
            // valorA
            // 
            this.valorA.Location = new System.Drawing.Point(39, 50);
            this.valorA.Name = "valorA";
            this.valorA.Size = new System.Drawing.Size(100, 20);
            this.valorA.TabIndex = 1;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(37, 87);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(57, 13);
            this.labelN.TabIndex = 2;
            this.labelN.Text = "Valor de N";
            // 
            // valorN
            // 
            this.valorN.Location = new System.Drawing.Point(40, 103);
            this.valorN.Name = "valorN";
            this.valorN.Size = new System.Drawing.Size(100, 20);
            this.valorN.TabIndex = 3;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(169, 50);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(58, 13);
            this.resultado.TabIndex = 4;
            this.resultado.Text = "Resultado:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // msgError
            // 
            this.msgError.AutoSize = true;
            this.msgError.Location = new System.Drawing.Point(37, 149);
            this.msgError.Name = "msgError";
            this.msgError.Size = new System.Drawing.Size(35, 13);
            this.msgError.TabIndex = 6;
            this.msgError.Text = "label1";
            this.msgError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 221);
            this.Controls.Add(this.msgError);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.valorN);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.valorA);
            this.Controls.Add(this.labelA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TextBox valorA;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox valorN;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label msgError;
    }
}

