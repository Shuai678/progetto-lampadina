namespace provaforms2
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            imageList1 = new ImageList(components);
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(85, 115);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(193, 140);
            button1.TabIndex = 0;
            button1.Text = "accendi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(85, 378);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(193, 140);
            button2.TabIndex = 1;
            button2.Text = "spegni";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.spento1;
            pictureBox1.Location = new Point(744, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 304);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F);
            button3.Location = new Point(409, 115);
            button3.Name = "button3";
            button3.Size = new Size(199, 140);
            button3.TabIndex = 3;
            button3.Text = "alza";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(409, 378);
            button4.Name = "button4";
            button4.Size = new Size(199, 140);
            button4.TabIndex = 4;
            button4.Text = "abbassa ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 750);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ImageList imageList1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button4;
    }
}
