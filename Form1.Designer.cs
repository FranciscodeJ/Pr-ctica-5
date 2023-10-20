namespace Práctica__5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            button2 = new Button();
            button3 = new Button();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Felix Titling", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(92, 203);
            label1.Name = "label1";
            label1.Size = new Size(128, 33);
            label1.TabIndex = 0;
            label1.Text = "Altura";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(242, 111);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(551, 298);
            button1.Name = "button1";
            button1.Size = new Size(158, 47);
            button1.TabIndex = 2;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(987, 261);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Felix Titling", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(562, 485);
            label2.Name = "label2";
            label2.Size = new Size(155, 33);
            label2.TabIndex = 4;
            label2.Text = "Volumen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Felix Titling", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(562, 392);
            label3.Name = "label3";
            label3.Size = new Size(189, 33);
            label3.TabIndex = 5;
            label3.Text = "Area total";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Felix Titling", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(92, 394);
            label4.Name = "label4";
            label4.Size = new Size(161, 33);
            label4.TabIndex = 6;
            label4.Text = "Area base";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Felix Titling", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(92, 485);
            label5.Name = "label5";
            label5.Size = new Size(220, 33);
            label5.TabIndex = 7;
            label5.Text = "Area lateral";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Felix Titling", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(92, 111);
            label6.Name = "label6";
            label6.Size = new Size(110, 33);
            label6.TabIndex = 8;
            label6.Text = "Radio";
            label6.Click += label6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Felix Titling", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Gold;
            label8.Location = new Point(305, 29);
            label8.Name = "label8";
            label8.Size = new Size(649, 33);
            label8.TabIndex = 10;
            label8.Text = "Introduce las DImensiones del Cilindro";
            label8.Click += label8_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(328, 298);
            button2.Name = "button2";
            button2.Size = new Size(158, 47);
            button2.TabIndex = 11;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(92, 298);
            button3.Name = "button3";
            button3.Size = new Size(158, 47);
            button3.TabIndex = 12;
            button3.Text = "Calcular";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(757, 483);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(155, 34);
            textBox7.TabIndex = 13;
            textBox7.TextChanged += textBox2_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(757, 390);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(155, 34);
            textBox6.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(332, 485);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(154, 34);
            textBox5.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(332, 392);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(154, 34);
            textBox4.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(242, 201);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 34);
            textBox2.TabIndex = 17;
            textBox2.TextChanged += textBox6_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1286, 595);
            Controls.Add(textBox2);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Button button2;
        private Button button3;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox2;
    }
}