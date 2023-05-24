namespace Cleaner_task1
{
    partial class FormArchiveMode
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
            this.labelArchiveMode = new System.Windows.Forms.Label();
            this.radioButtonZip = new System.Windows.Forms.RadioButton();
            this.radioButtonRar = new System.Windows.Forms.RadioButton();
            this.buttonSaveChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelArchiveMode
            // 
            this.labelArchiveMode.AutoSize = true;
            this.labelArchiveMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelArchiveMode.Location = new System.Drawing.Point(58, 22);
            this.labelArchiveMode.Name = "labelArchiveMode";
            this.labelArchiveMode.Size = new System.Drawing.Size(178, 15);
            this.labelArchiveMode.TabIndex = 0;
            this.labelArchiveMode.Text = "Выберите режим архивации";
            // 
            // radioButtonZip
            // 
            this.radioButtonZip.AutoSize = true;
            this.radioButtonZip.Location = new System.Drawing.Point(72, 58);
            this.radioButtonZip.Name = "radioButtonZip";
            this.radioButtonZip.Size = new System.Drawing.Size(42, 19);
            this.radioButtonZip.TabIndex = 1;
            this.radioButtonZip.TabStop = true;
            this.radioButtonZip.Tag = "1";
            this.radioButtonZip.Text = "Zip";
            this.radioButtonZip.UseVisualStyleBackColor = true;
            this.radioButtonZip.CheckedChanged += new System.EventHandler(this.radioButtonZip_CheckedChanged);
            // 
            // radioButtonRar
            // 
            this.radioButtonRar.AutoSize = true;
            this.radioButtonRar.Location = new System.Drawing.Point(170, 58);
            this.radioButtonRar.Name = "radioButtonRar";
            this.radioButtonRar.Size = new System.Drawing.Size(42, 19);
            this.radioButtonRar.TabIndex = 2;
            this.radioButtonRar.TabStop = true;
            this.radioButtonRar.Tag = "2";
            this.radioButtonRar.Text = "Rar";
            this.radioButtonRar.UseVisualStyleBackColor = true;
            this.radioButtonRar.CheckedChanged += new System.EventHandler(this.radioButtonRar_CheckedChanged);
            // 
            // buttonSaveChange
            // 
            this.buttonSaveChange.BackColor = System.Drawing.Color.Lime;
            this.buttonSaveChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveChange.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveChange.Location = new System.Drawing.Point(58, 98);
            this.buttonSaveChange.Name = "buttonSaveChange";
            this.buttonSaveChange.Size = new System.Drawing.Size(178, 28);
            this.buttonSaveChange.TabIndex = 3;
            this.buttonSaveChange.Text = "Save ";
            this.buttonSaveChange.UseVisualStyleBackColor = false;
            this.buttonSaveChange.Click += new System.EventHandler(this.buttonSaveChange_Click);
            // 
            // FormArchiveMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 142);
            this.Controls.Add(this.buttonSaveChange);
            this.Controls.Add(this.radioButtonRar);
            this.Controls.Add(this.radioButtonZip);
            this.Controls.Add(this.labelArchiveMode);
            this.Name = "FormArchiveMode";
            this.Text = "FormArchiveMode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelArchiveMode;
        private RadioButton radioButtonZip;
        private RadioButton radioButtonRar;
        private Button buttonSaveChange;
    }
}