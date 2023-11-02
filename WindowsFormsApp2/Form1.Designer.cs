namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNumeratore1 = new System.Windows.Forms.TextBox();
            this.textBoxDenominatore1 = new System.Windows.Forms.TextBox();
            this.textBoxNumeratore2 = new System.Windows.Forms.TextBox();
            this.textBoxDenominatore2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CalcolaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNumeratore1
            // 
            this.textBoxNumeratore1.Location = new System.Drawing.Point(12, 28);
            this.textBoxNumeratore1.Name = "textBoxNumeratore1";
            this.textBoxNumeratore1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeratore1.TabIndex = 0;
            // 
            // textBoxDenominatore1
            // 
            this.textBoxDenominatore1.Location = new System.Drawing.Point(12, 54);
            this.textBoxDenominatore1.Name = "textBoxDenominatore1";
            this.textBoxDenominatore1.Size = new System.Drawing.Size(100, 20);
            this.textBoxDenominatore1.TabIndex = 1;
            // 
            // textBoxNumeratore2
            // 
            this.textBoxNumeratore2.Location = new System.Drawing.Point(12, 89);
            this.textBoxNumeratore2.Name = "textBoxNumeratore2";
            this.textBoxNumeratore2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeratore2.TabIndex = 2;
            // 
            // textBoxDenominatore2
            // 
            this.textBoxDenominatore2.Location = new System.Drawing.Point(12, 115);
            this.textBoxDenominatore2.Name = "textBoxDenominatore2";
            this.textBoxDenominatore2.Size = new System.Drawing.Size(100, 20);
            this.textBoxDenominatore2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // CalcolaButton
            // 
            this.CalcolaButton.Location = new System.Drawing.Point(12, 179);
            this.CalcolaButton.Name = "CalcolaButton";
            this.CalcolaButton.Size = new System.Drawing.Size(75, 23);
            this.CalcolaButton.TabIndex = 6;
            this.CalcolaButton.Text = "Calcolo";
            this.CalcolaButton.UseVisualStyleBackColor = true;
            this.CalcolaButton.Click += new System.EventHandler(this.CalcolaButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numeratore 1 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Denominatore 1 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numeratore 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Denominatore 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Operazione che si vuole eseguire";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Somma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Sottrazione";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Moltiplica";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 295);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Divisione";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 324);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Valore decimale";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 353);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "elevamento ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 355);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Esponente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcolaButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxDenominatore2);
            this.Controls.Add(this.textBoxNumeratore2);
            this.Controls.Add(this.textBoxDenominatore1);
            this.Controls.Add(this.textBoxNumeratore1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumeratore1;
        private System.Windows.Forms.TextBox textBoxDenominatore1;
        private System.Windows.Forms.TextBox textBoxNumeratore2;
        private System.Windows.Forms.TextBox textBoxDenominatore2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CalcolaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
    }
}

