namespace Cleaner_task1
{
    partial class FormCleaner
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCleaner));
            buttonSetDirPatternsCleaner = new Button();
            listViewCleaner = new ListView();
            listBoxDirPatternsCleaner = new ListBox();
            listBoxFilePatternsCleaner = new ListBox();
            buttonFilePatternsCleaner = new Button();
            buttonClear = new Button();
            progressBar1 = new ProgressBar();
            buttonSetRootDir = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            textBoxRootDirCleaner = new TextBox();
            buttonAnalyzeCleaner = new Button();
            labelCount = new Label();
            pictureBox1 = new PictureBox();
            checkBoxToRecycle = new CheckBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            toolTip1 = new ToolTip(components);
            labelSizeFile = new Label();
            label1 = new Label();
            comboBoxRenamer = new ComboBox();
            textBoxSetRenamerPrefix = new TextBox();
            pictureBox6 = new PictureBox();
            buttonArchiver = new Button();
            pictureBox7 = new PictureBox();
            buttonRename = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // buttonSetDirPatternsCleaner
            // 
            buttonSetDirPatternsCleaner.BackColor = Color.Gold;
            buttonSetDirPatternsCleaner.Cursor = Cursors.Hand;
            buttonSetDirPatternsCleaner.FlatStyle = FlatStyle.Popup;
            buttonSetDirPatternsCleaner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSetDirPatternsCleaner.Location = new Point(788, 89);
            buttonSetDirPatternsCleaner.Name = "buttonSetDirPatternsCleaner";
            buttonSetDirPatternsCleaner.Size = new Size(111, 27);
            buttonSetDirPatternsCleaner.TabIndex = 0;
            buttonSetDirPatternsCleaner.Text = "Set Dir Patterns";
            buttonSetDirPatternsCleaner.UseVisualStyleBackColor = false;
            buttonSetDirPatternsCleaner.Click += buttonSetDirPatterns_Click;
            // 
            // listViewCleaner
            // 
            listViewCleaner.CheckBoxes = true;
            listViewCleaner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listViewCleaner.Location = new Point(12, 2);
            listViewCleaner.Name = "listViewCleaner";
            listViewCleaner.Size = new Size(770, 551);
            listViewCleaner.TabIndex = 1;
            listViewCleaner.UseCompatibleStateImageBehavior = false;
            listViewCleaner.View = View.List;
            // 
            // listBoxDirPatternsCleaner
            // 
            listBoxDirPatternsCleaner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxDirPatternsCleaner.FormattingEnabled = true;
            listBoxDirPatternsCleaner.ItemHeight = 15;
            listBoxDirPatternsCleaner.Location = new Point(788, 132);
            listBoxDirPatternsCleaner.Name = "listBoxDirPatternsCleaner";
            listBoxDirPatternsCleaner.Size = new Size(265, 64);
            listBoxDirPatternsCleaner.TabIndex = 2;
            // 
            // listBoxFilePatternsCleaner
            // 
            listBoxFilePatternsCleaner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxFilePatternsCleaner.FormattingEnabled = true;
            listBoxFilePatternsCleaner.ItemHeight = 15;
            listBoxFilePatternsCleaner.Location = new Point(788, 248);
            listBoxFilePatternsCleaner.Name = "listBoxFilePatternsCleaner";
            listBoxFilePatternsCleaner.Size = new Size(265, 64);
            listBoxFilePatternsCleaner.TabIndex = 3;
            // 
            // buttonFilePatternsCleaner
            // 
            buttonFilePatternsCleaner.BackColor = Color.RoyalBlue;
            buttonFilePatternsCleaner.Cursor = Cursors.Hand;
            buttonFilePatternsCleaner.FlatStyle = FlatStyle.Popup;
            buttonFilePatternsCleaner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFilePatternsCleaner.Location = new Point(788, 215);
            buttonFilePatternsCleaner.Name = "buttonFilePatternsCleaner";
            buttonFilePatternsCleaner.Size = new Size(111, 27);
            buttonFilePatternsCleaner.TabIndex = 4;
            buttonFilePatternsCleaner.Text = "Set File Patterns";
            buttonFilePatternsCleaner.UseVisualStyleBackColor = false;
            buttonFilePatternsCleaner.Click += buttonFilePatterns_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.IndianRed;
            buttonClear.Cursor = Cursors.Hand;
            buttonClear.FlatStyle = FlatStyle.Popup;
            buttonClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClear.Location = new Point(799, 559);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(209, 31);
            buttonClear.TabIndex = 8;
            buttonClear.Text = "CLEAR";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Thistle;
            progressBar1.Cursor = Cursors.No;
            progressBar1.ForeColor = Color.LightGray;
            progressBar1.Location = new Point(799, 559);
            progressBar1.MarqueeAnimationSpeed = 60;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(209, 31);
            progressBar1.Step = 0;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 9;
            // 
            // buttonSetRootDir
            // 
            buttonSetRootDir.BackColor = Color.FromArgb(192, 255, 255);
            buttonSetRootDir.Cursor = Cursors.Hand;
            buttonSetRootDir.FlatStyle = FlatStyle.Popup;
            buttonSetRootDir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSetRootDir.Location = new Point(788, 19);
            buttonSetRootDir.Name = "buttonSetRootDir";
            buttonSetRootDir.Size = new Size(111, 27);
            buttonSetRootDir.TabIndex = 11;
            buttonSetRootDir.Text = "Set Root Dir";
            buttonSetRootDir.UseVisualStyleBackColor = false;
            buttonSetRootDir.Click += buttonSetRootDir_Click;
            // 
            // textBoxRootDirCleaner
            // 
            textBoxRootDirCleaner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxRootDirCleaner.Location = new Point(788, 55);
            textBoxRootDirCleaner.Name = "textBoxRootDirCleaner";
            textBoxRootDirCleaner.Size = new Size(265, 23);
            textBoxRootDirCleaner.TabIndex = 12;
            // 
            // buttonAnalyzeCleaner
            // 
            buttonAnalyzeCleaner.BackColor = Color.LawnGreen;
            buttonAnalyzeCleaner.Cursor = Cursors.Hand;
            buttonAnalyzeCleaner.FlatStyle = FlatStyle.Popup;
            buttonAnalyzeCleaner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAnalyzeCleaner.Location = new Point(790, 337);
            buttonAnalyzeCleaner.Name = "buttonAnalyzeCleaner";
            buttonAnalyzeCleaner.Size = new Size(237, 27);
            buttonAnalyzeCleaner.TabIndex = 5;
            buttonAnalyzeCleaner.Text = "Analyze";
            buttonAnalyzeCleaner.UseVisualStyleBackColor = false;
            buttonAnalyzeCleaner.Click += buttonAnalyze_Click;
            // 
            // labelCount
            // 
            labelCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCount.Location = new Point(12, 559);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(89, 19);
            labelCount.TabIndex = 6;
            labelCount.Text = "Count:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1014, 558);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // checkBoxToRecycle
            // 
            checkBoxToRecycle.Checked = true;
            checkBoxToRecycle.CheckState = CheckState.Checked;
            checkBoxToRecycle.Location = new Point(1062, 567);
            checkBoxToRecycle.Name = "checkBoxToRecycle";
            checkBoxToRecycle.Size = new Size(20, 17);
            checkBoxToRecycle.TabIndex = 10;
            checkBoxToRecycle.Text = "Move to recycle";
            checkBoxToRecycle.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(905, 84);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(905, 211);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1029, 337);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(905, 9);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(55, 42);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // labelSizeFile
            // 
            labelSizeFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSizeFile.Location = new Point(626, 559);
            labelSizeFile.Name = "labelSizeFile";
            labelSizeFile.Size = new Size(157, 15);
            labelSizeFile.TabIndex = 18;
            labelSizeFile.Text = "File size: ";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(790, 428);
            label1.Name = "label1";
            label1.Size = new Size(201, 19);
            label1.TabIndex = 33;
            label1.Text = "Enter file prefix:";
            // 
            // comboBoxRenamer
            // 
            comboBoxRenamer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxRenamer.FormattingEnabled = true;
            comboBoxRenamer.Items.AddRange(new object[] { "Generate for UUID", "Generate for Number", "Generate for Name" });
            comboBoxRenamer.Location = new Point(790, 391);
            comboBoxRenamer.Name = "comboBoxRenamer";
            comboBoxRenamer.Size = new Size(260, 23);
            comboBoxRenamer.TabIndex = 32;
            comboBoxRenamer.Text = "Choose rename mode";
            // 
            // textBoxSetRenamerPrefix
            // 
            textBoxSetRenamerPrefix.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxSetRenamerPrefix.Location = new Point(790, 450);
            textBoxSetRenamerPrefix.Name = "textBoxSetRenamerPrefix";
            textBoxSetRenamerPrefix.Size = new Size(260, 23);
            textBoxSetRenamerPrefix.TabIndex = 31;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(1014, 522);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(39, 31);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 37;
            pictureBox6.TabStop = false;
            // 
            // buttonArchiver
            // 
            buttonArchiver.BackColor = Color.Goldenrod;
            buttonArchiver.Cursor = Cursors.Hand;
            buttonArchiver.FlatStyle = FlatStyle.Popup;
            buttonArchiver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonArchiver.Location = new Point(799, 522);
            buttonArchiver.Name = "buttonArchiver";
            buttonArchiver.Size = new Size(209, 31);
            buttonArchiver.TabIndex = 36;
            buttonArchiver.Text = "Arhive";
            buttonArchiver.UseVisualStyleBackColor = false;
            buttonArchiver.Click += buttonArchiver_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1014, 485);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(39, 33);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 35;
            pictureBox7.TabStop = false;
            // 
            // buttonRename
            // 
            buttonRename.BackColor = Color.DodgerBlue;
            buttonRename.Cursor = Cursors.Hand;
            buttonRename.FlatStyle = FlatStyle.Popup;
            buttonRename.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRename.Location = new Point(799, 485);
            buttonRename.Name = "buttonRename";
            buttonRename.Size = new Size(209, 31);
            buttonRename.TabIndex = 34;
            buttonRename.Text = "Rename";
            buttonRename.UseVisualStyleBackColor = false;
            buttonRename.Click += buttonRename_Click;
            // 
            // FormCleaner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 600);
            Controls.Add(pictureBox6);
            Controls.Add(buttonArchiver);
            Controls.Add(pictureBox7);
            Controls.Add(buttonRename);
            Controls.Add(label1);
            Controls.Add(comboBoxRenamer);
            Controls.Add(textBoxSetRenamerPrefix);
            Controls.Add(labelSizeFile);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxRootDirCleaner);
            Controls.Add(buttonSetRootDir);
            Controls.Add(checkBoxToRecycle);
            Controls.Add(progressBar1);
            Controls.Add(buttonClear);
            Controls.Add(labelCount);
            Controls.Add(buttonAnalyzeCleaner);
            Controls.Add(buttonFilePatternsCleaner);
            Controls.Add(listBoxFilePatternsCleaner);
            Controls.Add(listBoxDirPatternsCleaner);
            Controls.Add(listViewCleaner);
            Controls.Add(buttonSetDirPatternsCleaner);
            Name = "FormCleaner";
            Text = "File Combine";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSetDirPatternsCleaner;
        private ListView listViewCleaner;
        private Button buttonFilePatternsCleaner;
        private Button buttonClear;
        private ProgressBar progressBar1;
        private Button buttonSetRootDir;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textBoxRootDirCleaner;
        private Button buttonAnalyzeCleaner;
        private Label labelCount;
        public ListBox listBoxDirPatternsCleaner;
        public ListBox listBoxFilePatternsCleaner;
        private PictureBox pictureBox1;
        private CheckBox checkBoxToRecycle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private ToolTip toolTip1;
        private Label labelSizeFile;
        private Label label1;
        private ComboBox comboBoxRenamer;
        private TextBox textBoxSetRenamerPrefix;
        private PictureBox pictureBox6;
        private Button buttonArchiver;
        private PictureBox pictureBox7;
        private Button buttonRename;
    }
}