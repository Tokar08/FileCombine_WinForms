using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cleaner_task1
{
    public partial class FormForSetDirPattern : Form
    {
        public FormForSetDirPattern()
        {
            InitializeComponent();
        }

        public string? newDirPattern;
        private void buttonSaveChange_Click(object sender, EventArgs e)
        {
            newDirPattern = textBoxForSetFilePattern.Text;

            if (string.IsNullOrEmpty(newDirPattern))
            {
                MessageBox.Show("Не введено значение", "Warning", MessageBoxButtons.RetryCancel);
            }
            else
            { 
                Close();
            }
             
            
            
          

        }
    }
}

