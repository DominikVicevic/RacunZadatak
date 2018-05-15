namespace VicevicDominikRacun
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzr = new System.Windows.Forms.Button();
            this.richTxtBoxIspis = new System.Windows.Forms.RichTextBox();
            this.txtBoxUnos = new System.Windows.Forms.TextBox();
            this.btnIspis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ukupan iznos racuna";
            // 
            // btnIzr
            // 
            this.btnIzr.Location = new System.Drawing.Point(212, 117);
            this.btnIzr.Name = "btnIzr";
            this.btnIzr.Size = new System.Drawing.Size(75, 23);
            this.btnIzr.TabIndex = 2;
            this.btnIzr.Text = "Izracunaj";
            this.btnIzr.UseVisualStyleBackColor = true;
            this.btnIzr.Click += new System.EventHandler(this.btnIzr_Click);
            // 
            // richTxtBoxIspis
            // 
            this.richTxtBoxIspis.Location = new System.Drawing.Point(54, 192);
            this.richTxtBoxIspis.Name = "richTxtBoxIspis";
            this.richTxtBoxIspis.Size = new System.Drawing.Size(233, 209);
            this.richTxtBoxIspis.TabIndex = 3;
            this.richTxtBoxIspis.Text = "";
            // 
            // txtBoxUnos
            // 
            this.txtBoxUnos.Location = new System.Drawing.Point(139, 46);
            this.txtBoxUnos.Name = "txtBoxUnos";
            this.txtBoxUnos.Size = new System.Drawing.Size(148, 20);
            this.txtBoxUnos.TabIndex = 4;
            this.txtBoxUnos.TextChanged += new System.EventHandler(this.txtBoxUnos_TextChanged);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(76, 116);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 23);
            this.btnIspis.TabIndex = 5;
            this.btnIspis.Text = "Ispiši sve";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 422);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.txtBoxUnos);
            this.Controls.Add(this.richTxtBoxIspis);
            this.Controls.Add(this.btnIzr);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Račun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzr;
        private System.Windows.Forms.RichTextBox richTxtBoxIspis;
        private System.Windows.Forms.TextBox txtBoxUnos;
        private System.Windows.Forms.Button btnIspis;
    }
}

