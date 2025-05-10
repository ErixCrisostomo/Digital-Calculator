
namespace CalculatorAppLab4
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
            textBox1 = new TextBox();
            input = new TextBox();
            btn_CE = new Button();
            btn_mod = new Button();
            btn_Del = new Button();
            btn_add = new Button();
            btn_minus = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_multiply = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_divide = new Button();
            btn_3 = new Button();
            btn_2 = new Button();
            btn_1 = new Button();
            btn_equal = new Button();
            btn_dec = new Button();
            btn_0 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.Gray;
            textBox1.Font = new Font("Microsoft New Tai Lue", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Info;
            textBox1.Location = new Point(15, 33);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 73);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // input
            // 
            input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            input.BackColor = SystemColors.MenuBar;
            input.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            input.Location = new Point(15, 134);
            input.Margin = new Padding(4, 5, 4, 5);
            input.Name = "input";
            input.Size = new Size(394, 36);
            input.TabIndex = 1;
            input.TextChanged += input_TextChanged;
            // 
            // btn_CE
            // 
            btn_CE.BackColor = Color.RosyBrown;
            btn_CE.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CE.Location = new Point(15, 219);
            btn_CE.Margin = new Padding(4, 5, 4, 5);
            btn_CE.Name = "btn_CE";
            btn_CE.Size = new Size(84, 84);
            btn_CE.TabIndex = 2;
            btn_CE.Text = "CE";
            btn_CE.UseVisualStyleBackColor = false;
            btn_CE.Click += btn_CE_Click;
            // 
            // btn_mod
            // 
            btn_mod.BackColor = Color.RosyBrown;
            btn_mod.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_mod.Location = new Point(198, 253);
            btn_mod.Margin = new Padding(4, 5, 4, 5);
            btn_mod.Name = "btn_mod";
            btn_mod.Size = new Size(84, 50);
            btn_mod.TabIndex = 4;
            btn_mod.Text = "%";
            btn_mod.UseVisualStyleBackColor = false;
            btn_mod.Click += btn_mod_Click;
            // 
            // btn_Del
            // 
            btn_Del.BackColor = Color.RosyBrown;
            btn_Del.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Del.Location = new Point(106, 253);
            btn_Del.Margin = new Padding(4, 5, 4, 5);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(84, 50);
            btn_Del.TabIndex = 3;
            btn_Del.Text = "⌫";
            btn_Del.UseVisualStyleBackColor = false;
            btn_Del.Click += btn_Del_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Firebrick;
            btn_add.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.Gainsboro;
            btn_add.Location = new Point(289, 219);
            btn_add.Margin = new Padding(4, 5, 4, 5);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(118, 84);
            btn_add.TabIndex = 5;
            btn_add.Text = "+";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_minus
            // 
            btn_minus.BackColor = Color.Firebrick;
            btn_minus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_minus.ForeColor = Color.Gainsboro;
            btn_minus.Location = new Point(289, 316);
            btn_minus.Margin = new Padding(4, 5, 4, 5);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(118, 84);
            btn_minus.TabIndex = 9;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = false;
            btn_minus.Click += btn_minus_Click;
            // 
            // btn_9
            // 
            btn_9.BackColor = Color.White;
            btn_9.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_9.Location = new Point(198, 316);
            btn_9.Margin = new Padding(4, 5, 4, 5);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(84, 84);
            btn_9.TabIndex = 8;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = false;
            btn_9.Click += btn_9_Click;
            // 
            // btn_8
            // 
            btn_8.BackColor = Color.White;
            btn_8.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_8.Location = new Point(106, 316);
            btn_8.Margin = new Padding(4, 5, 4, 5);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(84, 84);
            btn_8.TabIndex = 9;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = false;
            btn_8.Click += btn_8_Click;
            // 
            // btn_7
            // 
            btn_7.BackColor = Color.White;
            btn_7.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_7.Location = new Point(15, 316);
            btn_7.Margin = new Padding(4, 5, 4, 5);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(84, 84);
            btn_7.TabIndex = 6;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = false;
            btn_7.Click += btn_7_Click;
            // 
            // btn_multiply
            // 
            btn_multiply.BackColor = Color.Firebrick;
            btn_multiply.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_multiply.ForeColor = Color.Gainsboro;
            btn_multiply.Location = new Point(288, 409);
            btn_multiply.Margin = new Padding(4, 5, 4, 5);
            btn_multiply.Name = "btn_multiply";
            btn_multiply.Size = new Size(118, 84);
            btn_multiply.TabIndex = 13;
            btn_multiply.Text = "*";
            btn_multiply.UseVisualStyleBackColor = false;
            btn_multiply.Click += btn_multiply_Click;
            // 
            // btn_6
            // 
            btn_6.BackColor = Color.White;
            btn_6.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_6.Location = new Point(198, 409);
            btn_6.Margin = new Padding(4, 5, 4, 5);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(84, 84);
            btn_6.TabIndex = 12;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = false;
            btn_6.Click += btn_6_Click;
            // 
            // btn_5
            // 
            btn_5.BackColor = Color.White;
            btn_5.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_5.Location = new Point(105, 409);
            btn_5.Margin = new Padding(4, 5, 4, 5);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(84, 84);
            btn_5.TabIndex = 11;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = false;
            btn_5.Click += btn_5_Click;
            // 
            // btn_4
            // 
            btn_4.BackColor = Color.White;
            btn_4.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_4.Location = new Point(14, 409);
            btn_4.Margin = new Padding(4, 5, 4, 5);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(84, 84);
            btn_4.TabIndex = 10;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = false;
            btn_4.Click += btn_4_Click;
            // 
            // btn_divide
            // 
            btn_divide.BackColor = Color.Firebrick;
            btn_divide.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_divide.ForeColor = Color.Gainsboro;
            btn_divide.Location = new Point(289, 503);
            btn_divide.Margin = new Padding(4, 5, 4, 5);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(118, 84);
            btn_divide.TabIndex = 17;
            btn_divide.Text = "/";
            btn_divide.UseVisualStyleBackColor = false;
            btn_divide.Click += btn_divide_Click;
            // 
            // btn_3
            // 
            btn_3.BackColor = Color.White;
            btn_3.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_3.Location = new Point(198, 503);
            btn_3.Margin = new Padding(4, 5, 4, 5);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(84, 84);
            btn_3.TabIndex = 16;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = false;
            btn_3.Click += btn_3_Click;
            // 
            // btn_2
            // 
            btn_2.BackColor = Color.White;
            btn_2.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_2.Location = new Point(106, 503);
            btn_2.Margin = new Padding(4, 5, 4, 5);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(84, 84);
            btn_2.TabIndex = 15;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = false;
            btn_2.Click += btn_2_Click;
            // 
            // btn_1
            // 
            btn_1.BackColor = Color.White;
            btn_1.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_1.Location = new Point(15, 503);
            btn_1.Margin = new Padding(4, 5, 4, 5);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(84, 84);
            btn_1.TabIndex = 14;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = false;
            btn_1.Click += btn_1_Click;
            // 
            // btn_equal
            // 
            btn_equal.BackColor = Color.Firebrick;
            btn_equal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_equal.ForeColor = Color.Gainsboro;
            btn_equal.Location = new Point(288, 597);
            btn_equal.Margin = new Padding(4, 5, 4, 5);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(118, 84);
            btn_equal.TabIndex = 21;
            btn_equal.Text = "=";
            btn_equal.UseVisualStyleBackColor = false;
            btn_equal.Click += btn_equal_Click;
            // 
            // btn_dec
            // 
            btn_dec.BackColor = Color.RosyBrown;
            btn_dec.Location = new Point(196, 597);
            btn_dec.Margin = new Padding(4, 5, 4, 5);
            btn_dec.Name = "btn_dec";
            btn_dec.Size = new Size(84, 48);
            btn_dec.TabIndex = 20;
            btn_dec.Text = "•";
            btn_dec.UseVisualStyleBackColor = false;
            btn_dec.Click += btn_dec_Click;
            // 
            // btn_0
            // 
            btn_0.BackColor = Color.RosyBrown;
            btn_0.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_0.Location = new Point(14, 597);
            btn_0.Margin = new Padding(4, 5, 4, 5);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(175, 84);
            btn_0.TabIndex = 18;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = false;
            btn_0.Click += btn_0_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Cal_BG;
            pictureBox1.Location = new Point(-8, -178);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(440, 905);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuText;
            ClientSize = new Size(425, 716);
            Controls.Add(btn_equal);
            Controls.Add(btn_dec);
            Controls.Add(btn_0);
            Controls.Add(btn_divide);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(btn_multiply);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_minus);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_add);
            Controls.Add(btn_mod);
            Controls.Add(btn_Del);
            Controls.Add(btn_CE);
            Controls.Add(input);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Basic Calculator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_dec;
        private System.Windows.Forms.Button btn_0;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}

