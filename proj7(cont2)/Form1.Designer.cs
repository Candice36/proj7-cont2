
namespace proj7_cont2_
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
            this.txtNumTerms = new System.Windows.Forms.Label();
            this.txtActual = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNumTerms
            // 
            this.txtNumTerms.AutoSize = true;
            this.txtNumTerms.Location = new System.Drawing.Point(227, 72);
            this.txtNumTerms.Name = "txtNumTerms";
            this.txtNumTerms.Size = new System.Drawing.Size(49, 13);
            this.txtNumTerms.TabIndex = 0;
            this.txtNumTerms.Text = "# Terms:";
            // 
            // txtActual
            // 
            this.txtActual.AutoSize = true;
            this.txtActual.Location = new System.Drawing.Point(341, 193);
            this.txtActual.Name = "txtActual";
            this.txtActual.Size = new System.Drawing.Size(40, 13);
            this.txtActual.TabIndex = 1;
            this.txtActual.Text = "Actual:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(325, 287);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(405, 72);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 36);
            this.textBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtActual);
            this.Controls.Add(this.txtNumTerms);
            this.Name = "Form1";
            this.Text = "Approximate PI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNumTerms;
        private System.Windows.Forms.Label txtActual;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox textBox2;
    }
}

