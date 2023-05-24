namespace Cleaner_task1
{
    partial class FormForSetFilePattern
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
            this.labelForSetFilePattern = new System.Windows.Forms.Label();
            this.textBoxForSetFilePattern = new System.Windows.Forms.TextBox();
            this.buttonSaveChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelForSetFilePattern
            // 
            this.labelForSetFilePattern.AutoSize = true;
            this.labelForSetFilePattern.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelForSetFilePattern.Location = new System.Drawing.Point(58, 22);
            this.labelForSetFilePattern.Name = "labelForSetFilePattern";
            this.labelForSetFilePattern.Size = new System.Drawing.Size(184, 15);
            this.labelForSetFilePattern.TabIndex = 0;
            this.labelForSetFilePattern.Text = "Установите паттерн для файла:";
            // 
            // textBoxForSetFilePattern
            // 
            this.textBoxForSetFilePattern.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxForSetFilePattern.Location = new System.Drawing.Point(58, 52);
            this.textBoxForSetFilePattern.Name = "textBoxForSetFilePattern";
            this.textBoxForSetFilePattern.Size = new System.Drawing.Size(178, 23);
            this.textBoxForSetFilePattern.TabIndex = 1;
            // 
            // buttonSaveChange
            // 
            this.buttonSaveChange.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonSaveChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveChange.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveChange.Location = new System.Drawing.Point(58, 98);
            this.buttonSaveChange.Name = "buttonSaveChange";
            this.buttonSaveChange.Size = new System.Drawing.Size(178, 28);
            this.buttonSaveChange.TabIndex = 2;
            this.buttonSaveChange.Text = "Save ";
            this.buttonSaveChange.UseVisualStyleBackColor = false;
            this.buttonSaveChange.Click += new System.EventHandler(this.buttonSaveChange_Click);
            // 
            // FormForSetFilePattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 138);
            this.Controls.Add(this.buttonSaveChange);
            this.Controls.Add(this.textBoxForSetFilePattern);
            this.Controls.Add(this.labelForSetFilePattern);
            this.Name = "FormForSetFilePattern";
            this.Text = "FormForSetFilePattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelForSetFilePattern;
        public TextBox textBoxForSetFilePattern;
        private Button buttonSaveChange;
    }
}