namespace zadanie_3
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_kwadratowa = new System.Windows.Forms.Button();
            this.textBox_inputA = new System.Windows.Forms.TextBox();
            this.textBox_inputB = new System.Windows.Forms.TextBox();
            this.textBox_inputC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_sinX = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_tryg_Input = new System.Windows.Forms.TextBox();
            this.button_cosX = new System.Windows.Forms.Button();
            this.textBox_x_1 = new System.Windows.Forms.TextBox();
            this.textBox_x_2 = new System.Windows.Forms.TextBox();
            this.textBox_wynik_tryg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_kwadratowa
            // 
            this.button_kwadratowa.Location = new System.Drawing.Point(150, 520);
            this.button_kwadratowa.Name = "button_kwadratowa";
            this.button_kwadratowa.Size = new System.Drawing.Size(108, 104);
            this.button_kwadratowa.TabIndex = 0;
            this.button_kwadratowa.Text = "Rozwiąż funkcję kwadratowa";
            this.button_kwadratowa.UseVisualStyleBackColor = true;
            this.button_kwadratowa.Click += new System.EventHandler(this.button_kwadratowa_Click);
            // 
            // textBox_inputA
            // 
            this.textBox_inputA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_inputA.Location = new System.Drawing.Point(12, 492);
            this.textBox_inputA.Name = "textBox_inputA";
            this.textBox_inputA.Size = new System.Drawing.Size(114, 31);
            this.textBox_inputA.TabIndex = 1;
            this.textBox_inputA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputB
            // 
            this.textBox_inputB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_inputB.Location = new System.Drawing.Point(12, 554);
            this.textBox_inputB.Name = "textBox_inputB";
            this.textBox_inputB.Size = new System.Drawing.Size(114, 31);
            this.textBox_inputB.TabIndex = 2;
            this.textBox_inputB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputC
            // 
            this.textBox_inputC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_inputC.Location = new System.Drawing.Point(11, 619);
            this.textBox_inputC.Name = "textBox_inputC";
            this.textBox_inputC.Size = new System.Drawing.Size(114, 31);
            this.textBox_inputC.TabIndex = 3;
            this.textBox_inputC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Współczynnik a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Współczynnik b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(11, 598);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Współczynnik c:";
            // 
            // button_sinX
            // 
            this.button_sinX.Location = new System.Drawing.Point(446, 543);
            this.button_sinX.Name = "button_sinX";
            this.button_sinX.Size = new System.Drawing.Size(75, 59);
            this.button_sinX.TabIndex = 8;
            this.button_sinX.Text = "sin(x)";
            this.button_sinX.UseVisualStyleBackColor = true;
            this.button_sinX.Click += new System.EventHandler(this.button_sinX_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(778, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 345);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // textBox_tryg_Input
            // 
            this.textBox_tryg_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_tryg_Input.Location = new System.Drawing.Point(446, 492);
            this.textBox_tryg_Input.Name = "textBox_tryg_Input";
            this.textBox_tryg_Input.Size = new System.Drawing.Size(177, 31);
            this.textBox_tryg_Input.TabIndex = 10;
            this.textBox_tryg_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_cosX
            // 
            this.button_cosX.Location = new System.Drawing.Point(548, 543);
            this.button_cosX.Name = "button_cosX";
            this.button_cosX.Size = new System.Drawing.Size(75, 59);
            this.button_cosX.TabIndex = 11;
            this.button_cosX.Text = "cos(x)";
            this.button_cosX.UseVisualStyleBackColor = true;
            this.button_cosX.Click += new System.EventHandler(this.button_cosX_Click);
            // 
            // textBox_x_1
            // 
            this.textBox_x_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_x_1.Location = new System.Drawing.Point(282, 520);
            this.textBox_x_1.Name = "textBox_x_1";
            this.textBox_x_1.Size = new System.Drawing.Size(147, 31);
            this.textBox_x_1.TabIndex = 12;
            this.textBox_x_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_x_2
            // 
            this.textBox_x_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_x_2.Location = new System.Drawing.Point(282, 593);
            this.textBox_x_2.Name = "textBox_x_2";
            this.textBox_x_2.Size = new System.Drawing.Size(147, 31);
            this.textBox_x_2.TabIndex = 13;
            this.textBox_x_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_wynik_tryg
            // 
            this.textBox_wynik_tryg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_wynik_tryg.Location = new System.Drawing.Point(641, 525);
            this.textBox_wynik_tryg.Name = "textBox_wynik_tryg";
            this.textBox_wynik_tryg.Size = new System.Drawing.Size(147, 31);
            this.textBox_wynik_tryg.TabIndex = 14;
            this.textBox_wynik_tryg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 658);
            this.Controls.Add(this.textBox_wynik_tryg);
            this.Controls.Add(this.textBox_x_2);
            this.Controls.Add(this.textBox_x_1);
            this.Controls.Add(this.button_cosX);
            this.Controls.Add(this.textBox_tryg_Input);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_sinX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_inputC);
            this.Controls.Add(this.textBox_inputB);
            this.Controls.Add(this.textBox_inputA);
            this.Controls.Add(this.button_kwadratowa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_kwadratowa;
        private System.Windows.Forms.TextBox textBox_inputA;
        private System.Windows.Forms.TextBox textBox_inputB;
        private System.Windows.Forms.TextBox textBox_inputC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_sinX;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_tryg_Input;
        private System.Windows.Forms.Button button_cosX;
        private System.Windows.Forms.TextBox textBox_x_1;
        private System.Windows.Forms.TextBox textBox_x_2;
        private System.Windows.Forms.TextBox textBox_wynik_tryg;
    }
}

