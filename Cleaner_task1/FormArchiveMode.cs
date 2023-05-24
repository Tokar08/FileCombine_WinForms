using FileCombine.Archiver;

namespace Cleaner_task1
{
    public partial class FormArchiveMode : Form
    {
        public FormArchiveMode()
        {
            InitializeComponent();
        }
        public ArchiveEngineMode arcMode { get; set; }

        private void buttonSaveChange_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButtonZip_CheckedChanged(object sender, EventArgs e)
        {
            arcMode = ArchiveEngineMode.Zip;
        }

        private void radioButtonRar_CheckedChanged(object sender, EventArgs e)
        {
            arcMode = ArchiveEngineMode.Rar;
        }
    }
}
