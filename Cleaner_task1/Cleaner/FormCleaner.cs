using FileCombine;
using FileCombine.Archiver.Exceptions;
using FileCombine.Archiver;
using FIleCombine;
using FIleCombine.Renamer;
using Shell32;
using System.IO;


namespace Cleaner_task1
{
    public partial class FormCleaner : Form
    {
        public FormCleaner()
        {
            InitializeComponent();
            progressBar1.Visible = false;

            toolTip1.SetToolTip(checkBoxToRecycle, "Удалить файл без возможности восстановления");
            checkBoxToRecycle.Checked = false;
        }

        public Finder finderCleaner = new Finder();
        public Shell shell = new Shell();
        public string Param { get; set; }

        public string[] dirPatterns =
          {
            ".vs",
            ".DS_Store",
            "Debug",
            "bin",
            "debug",
            "obj",
            "tools",
            "examples"
          };

        public string[] filePatterns =
        {
            "*.exe",
            "*.jpg",
            "*.txt",
            "*.wav",
            "*.mp3",
            "*.mp4",
            "*.pdf",
            "*.docx",
            "*.png",
            "*.ram",
            "*.zip",
            "*.xlsx",
            "*.xls",
            "*.wpd",
            "*.rar",
            "*.pptx",
            "*.bmp",
    };


        public void buttonSetRootDir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBoxRootDirCleaner.Text = folderBrowserDialog1.SelectedPath;
                Array.Sort(dirPatterns);
                listBoxDirPatternsCleaner.Items.AddRange(dirPatterns);
                Array.Sort(filePatterns);
                listBoxFilePatternsCleaner.Items.AddRange(filePatterns);
                Param = textBoxRootDirCleaner.Text;

            }



        }

        public void buttonAnalyze_Click(object sender, EventArgs e)
        {
            try
            {

                finderCleaner.DirMasks = dirPatterns;
                finderCleaner.FileMasks = filePatterns;
                finderCleaner.FindAll(textBoxRootDirCleaner.Text);
                ObjectContainer container = finderCleaner.Container;


                finderCleaner.Container.Dirs.ForEach(dir =>
                {
                    listViewCleaner.Items.Add(dir.FullName);
                    labelCount.Text = "Count: " + listViewCleaner.Items.Count.ToString();
                    labelSizeFile.Text = "File size: " + GetFileSize(dir.FullName).ToString() + " B";
                });

                finderCleaner.Container.Files.ForEach(file =>
                {
                    listViewCleaner.Items.Add(file.FullName);
                    labelCount.Text = "Count: " + listViewCleaner.Items.Count.ToString();
                    labelSizeFile.Text = "File size: " + GetFileSize(file.FullName).ToString() + " B";
                });



            }
            catch
            {
                MessageBox.Show("Вы не ввели путь к данным! Попробуйте еще раз.", "Warning");
            }
        }




        private void buttonClear_Click(object sender, EventArgs e)
        {
            var checkedItems = listViewCleaner.CheckedItems;

            foreach (ListViewItem item in checkedItems)
            {
                while (progressBar1.Value != 100)
                {
                    progressBar1.Visible = true;
                    progressBar1.Value += 20;
                    Thread.Sleep(500);
                    progressBar1.Visible = false;

                }
                if (!checkBoxToRecycle.Checked)
                {
                    Folder RecyclingBin = shell.NameSpace(10);
                    RecyclingBin.MoveHere(item.Text);

                    listViewCleaner.Items.Remove(item);
                }
                else
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(item.Text);
                    FileInfo fileI = new FileInfo(item.Text);

                    if (fileI.Exists)
                    {
                        File.Delete(fileI.FullName);
                        listViewCleaner.Items.Remove(item);
                    }
                    else
                    {
                        Directory.Delete(directoryInfo.FullName);
                        listViewCleaner.Items.Remove(item);
                    }

                }

            }


        }
        public void buttonSetDirPatterns_Click(object sender, EventArgs e)
        {
            try
            {
                FormForSetDirPattern FrmForSetDirPattern = new FormForSetDirPattern();
                FrmForSetDirPattern.ShowDialog();

                listBoxDirPatternsCleaner.Items.Add(FrmForSetDirPattern.newDirPattern);

                var listToPush = dirPatterns.ToList();

                listToPush.Add(FrmForSetDirPattern.newDirPattern);

                dirPatterns = listToPush.ToArray();
            }
            catch
            {
                MessageBox.Show("Вы не ввели значение! Попробуйте еще раз.", "Warning");
            }


        }
        private void buttonFilePatterns_Click(object sender, EventArgs e)
        {
            try
            {
                FormForSetFilePattern FrmForSetFilePattern = new FormForSetFilePattern();
                FrmForSetFilePattern.ShowDialog();

                listBoxFilePatternsCleaner.Items.Add(FrmForSetFilePattern.newFilePattern);

                var listToPush = filePatterns.ToList();

                listToPush.Add(FrmForSetFilePattern.newFilePattern);

                filePatterns = listToPush.ToArray();

            }
            catch
            {
                MessageBox.Show("Вы не ввели значение! Попробуйте  еще раз.", "Warning");
            }

        }


        private long GetFileSize(string path)
        {
            long totalSize = 0;
            foreach (ListViewItem item in listViewCleaner.Items)
            {
                path = item.Text;
                long fileSize = new FileInfo(path).Length;
                totalSize += fileSize;
            }
            return totalSize;
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(textBoxRootDirCleaner.Text);
            List<FileInfo> files = new List<FileInfo>(dir.GetFiles());

            var track_selection = comboBoxRenamer.SelectedItem;

            if (track_selection == comboBoxRenamer.Items[0])
            {
                Renamer renamer = new(files, RenamerMode.UUID);
                renamer.Rename(textBoxSetRenamerPrefix.Text);
            }
            else if (track_selection == comboBoxRenamer.Items[1])
            {
                Renamer renamer = new(files, RenamerMode.AUTOINCREMENT);
                renamer.Rename(textBoxSetRenamerPrefix.Text);

            }
            else if (track_selection == comboBoxRenamer.Items[2])
            {
                Renamer renamer = new(files, RenamerMode.RANDOMNAME);
                renamer.Rename(textBoxSetRenamerPrefix.Text);

            }
            else
                MessageBox.Show("Select rename mode!", "Warning!", MessageBoxButtons.RetryCancel);


            ClearListView(listViewCleaner);
            UpdateInfoListView(files);
        }
        private void ClearListView(ListView listView)
        {
            foreach (ListViewItem item in listView.Items)
            {
                listViewCleaner.Items.Remove(item);
            }
        }
        private void UpdateInfoListView(List<FileInfo> filesInfo)
        {
            foreach (FileInfo file in filesInfo)
            {
                listViewCleaner.Items.Add(file.FullName);
            }

        }

        private void buttonArchiver_Click(object sender, EventArgs e)
        {
            FormArchiveMode formArchiveMode = new();
            formArchiveMode.ShowDialog();
            ArchiveEngine engine = new ArchiveEngine(formArchiveMode.arcMode);

            try
            {
                engine.CompressDirectory(textBoxRootDirCleaner.Text);
            }
            catch (ArchiverException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


}
