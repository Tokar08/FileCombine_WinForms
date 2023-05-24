
namespace Cleaner_task1
{
    public partial class FormForSetFilePattern : Form
    {
        public FormForSetFilePattern()
        {
            InitializeComponent();
        }
        public string? newFilePattern;
        private void buttonSaveChange_Click(object sender, EventArgs e)
        {
            newFilePattern = textBoxForSetFilePattern.Text;

            if (string.IsNullOrEmpty(newFilePattern))
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
