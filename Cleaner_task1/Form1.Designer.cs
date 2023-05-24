namespace Cleaner_task1
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
            buttonOpenCleaner = new Button();
            MainLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            progressBar1 = new ProgressBar();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonOpenCleaner
            // 
            buttonOpenCleaner.ForeColor = Color.FromArgb(0, 0, 192);
            buttonOpenCleaner.Location = new Point(130, 236);
            buttonOpenCleaner.Margin = new Padding(4, 2, 4, 2);
            buttonOpenCleaner.Name = "buttonOpenCleaner";
            buttonOpenCleaner.Size = new Size(154, 31);
            buttonOpenCleaner.TabIndex = 0;
            buttonOpenCleaner.Text = "Download application";
            buttonOpenCleaner.UseVisualStyleBackColor = true;
            buttonOpenCleaner.Click += buttonOpenCleaner_Click;
            // 
            // MainLabel
            // 
            MainLabel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainLabel.ForeColor = Color.Gold;
            MainLabel.Location = new Point(80, 9);
            MainLabel.Margin = new Padding(4, 0, 4, 0);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(262, 28);
            MainLabel.TabIndex = 1;
            MainLabel.Text = "Добро пожаловать в File Combine!";
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(3, 51);
            label1.Name = "label1";
            label1.Size = new Size(339, 23);
            label1.TabIndex = 2;
            label1.Text = "Благодаря этому приложению Вы можете:";
            // 
            // label2
            // 
            label2.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(3, 84);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 3;
            label2.Text = "- Очищать ";
            // 
            // label3
            // 
            label3.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(3, 122);
            label3.Name = "label3";
            label3.Size = new Size(156, 23);
            label3.TabIndex = 4;
            label3.Text = "- Переименовывать ";
            // 
            // label4
            // 
            label4.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(3, 160);
            label4.Name = "label4";
            label4.Size = new Size(129, 23);
            label4.TabIndex = 5;
            label4.Text = "- Архивировать ";
            // 
            // label5
            // 
            label5.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(28, 198);
            label5.Name = "label5";
            label5.Size = new Size(386, 23);
            label5.TabIndex = 6;
            label5.Text = "Для начала работы требуется загрузить приложение ";
            // 
            // progressBar1
            // 
            progressBar1.Cursor = Cursors.AppStarting;
            progressBar1.Location = new Point(12, 235);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(402, 32);
            progressBar1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 290);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 284);
            Controls.Add(progressBar1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MainLabel);
            Controls.Add(buttonOpenCleaner);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.RoyalBlue;
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "Welcome!";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpenCleaner;
        private Label MainLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
    }
}