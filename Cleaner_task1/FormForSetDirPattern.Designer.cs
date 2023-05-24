namespace Cleaner_task1
{
    partial class FormForSetDirPattern
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
            this.labelForSetDirPattern = new System.Windows.Forms.Label();
            this.textBoxForSetFilePattern = new System.Windows.Forms.TextBox();
            this.buttonSaveChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelForSetDirPattern
            // 
            this.labelForSetDirPattern.AutoSize = true;
            this.labelForSetDirPattern.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelForSetDirPattern.Location = new System.Drawing.Point(58, 22);
            this.labelForSetDirPattern.Name = "labelForSetDirPattern";
            this.labelForSetDirPattern.Size = new System.Drawing.Size(183, 15);
            this.labelForSetDirPattern.TabIndex = 0;
            this.labelForSetDirPattern.Text = "Установите паттерн для папки:";
            // 
            // textBoxForSetFilePattern
            // 
            this.textBoxForSetFilePattern.Location = new System.Drawing.Point(58, 52);
            this.textBoxForSetFilePattern.Name = "textBoxForSetFilePattern";
            this.textBoxForSetFilePattern.Size = new System.Drawing.Size(178, 23);
            this.textBoxForSetFilePattern.TabIndex = 1;
            // 
            // buttonSaveChange
            // 
            this.buttonSaveChange.BackColor = System.Drawing.Color.Lime;
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
            // FormForSetDirPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 138);
            this.Controls.Add(this.buttonSaveChange);
            this.Controls.Add(this.textBoxForSetFilePattern);
            this.Controls.Add(this.labelForSetDirPattern);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormForSetDirPattern";
            this.Text = "FormForSetFilePattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelForSetDirPattern;
        public TextBox textBoxForSetFilePattern;
        private Button buttonSaveChange;
    }
}