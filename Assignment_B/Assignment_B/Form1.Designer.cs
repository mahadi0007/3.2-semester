namespace Assignment_B
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.amountTaka = new System.Windows.Forms.TextBox();
            this.convertToCombo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.convert_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.error);
            this.groupBox1.Controls.Add(this.textBox_Result);
            this.groupBox1.Controls.Add(this.amountTaka);
            this.groupBox1.Controls.Add(this.convertToCombo);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.convert_btn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(73, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Currency Converter";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_Result.Location = new System.Drawing.Point(64, 264);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.Size = new System.Drawing.Size(491, 26);
            this.textBox_Result.TabIndex = 8;
            this.textBox_Result.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // amountTaka
            // 
            this.amountTaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.amountTaka.Location = new System.Drawing.Point(307, 68);
            this.amountTaka.Name = "amountTaka";
            this.amountTaka.Size = new System.Drawing.Size(248, 26);
            this.amountTaka.TabIndex = 7;
            // 
            // convertToCombo
            // 
            this.convertToCombo.AllowDrop = true;
            this.convertToCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.convertToCombo.FormattingEnabled = true;
            this.convertToCombo.Items.AddRange(new object[] {
            "Rupee",
            "USD",
            "Euro",
            "Canadian dollar",
            "Austrailan dollar"});
            this.convertToCombo.Location = new System.Drawing.Point(307, 116);
            this.convertToCombo.Name = "convertToCombo";
            this.convertToCombo.Size = new System.Drawing.Size(248, 28);
            this.convertToCombo.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(64, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // convert_btn
            // 
            this.convert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_btn.Location = new System.Drawing.Point(480, 335);
            this.convert_btn.Name = "convert_btn";
            this.convert_btn.Size = new System.Drawing.Size(75, 23);
            this.convert_btn.TabIndex = 3;
            this.convert_btn.Text = "Convert";
            this.convert_btn.UseVisualStyleBackColor = true;
            this.convert_btn.Click += new System.EventHandler(this.convert_btn_click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Converted Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Convert To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter amount (in Taka) ";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(175, 307);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 25);
            this.error.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button convert_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox convertToCombo;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.TextBox amountTaka;
        private System.Windows.Forms.Label error;
    }
}

