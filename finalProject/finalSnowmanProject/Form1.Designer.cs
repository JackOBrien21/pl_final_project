namespace finalSnowmanProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bottomCircle = new System.Windows.Forms.PictureBox();
            this.topCircle   = new System.Windows.Forms.PictureBox();
            this.middleCircle = new System.Windows.Forms.PictureBox();
            this.leftArm   = new System.Windows.Forms.PictureBox();
            this.rightArm = new System.Windows.Forms.PictureBox();
            this.hat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hat)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(71, 140);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(353, 340);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(640, 152);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 116);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.bottomCircle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.bottomCircle.Location = new System.Drawing.Point(353, 183);
            this.bottomCircle.Margin = new System.Windows.Forms.Padding(0);
            this.bottomCircle.Name = "pictureBox1";
            this.bottomCircle.Size = new System.Drawing.Size(100, 104);
            this.bottomCircle.TabIndex = 5;
            this.bottomCircle.TabStop = false;
            // 
            // pictureBox3
            // 
            this.topCircle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.topCircle.Location = new System.Drawing.Point(372, 63);
            this.topCircle.Margin = new System.Windows.Forms.Padding(0);
            this.topCircle.Name = "pictureBox3";
            this.topCircle.Size = new System.Drawing.Size(59, 60);
            this.topCircle.TabIndex = 6;
            this.topCircle.TabStop = false;
            this.topCircle.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox2
            // 
            this.middleCircle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.middleCircle.Location = new System.Drawing.Point(366, 115);
            this.middleCircle.Margin = new System.Windows.Forms.Padding(0);
            this.middleCircle.Name = "pictureBox2";
            this.middleCircle.Size = new System.Drawing.Size(75, 77);
            this.middleCircle.TabIndex = 7;
            this.middleCircle.TabStop = false;
            // 
            // pictureBox4
            // 
            this.leftArm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.leftArm.Location = new System.Drawing.Point(303, 78);
            this.leftArm.Margin = new System.Windows.Forms.Padding(0);
            this.leftArm.Name = "pictureBox4";
            this.leftArm.Size = new System.Drawing.Size(73, 84);
            this.leftArm.TabIndex = 8;
            this.leftArm.TabStop = false;
            this.leftArm.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.rightArm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.rightArm.Location = new System.Drawing.Point(437, 78);
            this.rightArm.Margin = new System.Windows.Forms.Padding(0);
            this.rightArm.Name = "pictureBox5";
            this.rightArm.Size = new System.Drawing.Size(76, 82);
            this.rightArm.TabIndex = 9;
            this.rightArm.TabStop = false;
            // 
            // pictureBox6
            // 
            this.hat.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.hat.Location = new System.Drawing.Point(366, 47);
            this.hat.Margin = new System.Windows.Forms.Padding(0);
            this.hat.Name = "pictureBox6";
            this.hat.Size = new System.Drawing.Size(75, 35);
            this.hat.TabIndex = 10;
            this.hat.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hat);
            this.Controls.Add(this.rightArm);
            this.Controls.Add(this.leftArm);
            this.Controls.Add(this.middleCircle);
            this.Controls.Add(this.topCircle);
            this.Controls.Add(this.bottomCircle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bottomCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox bottomCircle;
        private System.Windows.Forms.PictureBox middleCircle;
        private System.Windows.Forms.PictureBox topCircle;
        private System.Windows.Forms.PictureBox leftArm;
        private System.Windows.Forms.PictureBox rightArm;
        private System.Windows.Forms.PictureBox hat;
    }
}

