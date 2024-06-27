using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.IO;


namespace CleanFolders
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string directory;

        public MainWindow()
        {
            InitializeComponent();
            directory = "";

            List<string> fileType = new List<string> { ".rvt", ".rfa", ".pdf" };

            foreach (string type in fileType)
            {
                cmbFileType.Items.Add(type);
            }

            cmbFileType.SelectedIndex = 0;
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog selectFolder = new FolderBrowserDialog();
            selectFolder.ShowNewFolderButton = false;
            selectFolder.RootFolder = Environment.SpecialFolder.MyComputer;

            if (selectFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // get the selected folder path
                directory = selectFolder.SelectedPath;
                tbxFolder.Text = directory;
            }
        }       
       
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (directory == "")
            {
                System.Windows.Forms.MessageBox.Show("Please select a folder.");
                this.Close();
            }

            // set some variables

            int counter = 0;
            string logPath = "";

            string fileType = cmbFileType.SelectedItem.ToString();

            // create a list for the log

            List<string> deletedFileLog = new List<string>();
            deletedFileLog.Add("The following backup files have been deleted:");

            // get files from selected folder

            string[] files;

            if (cbxSubFolders.IsChecked == true)
            {
                files = Directory.GetFiles(directory, "*.r*", SearchOption.AllDirectories);
            }
            else
            {
                files = Directory.GetFiles(directory, "*.r*", SearchOption.TopDirectoryOnly);
            }

            if (cmbFileType.SelectedItem.ToString() == ".rvt")
            {
                // do some stuff
            }
            else if (cmbFileType.SelectedItem.ToString() == ".rfa")
            {
                // do some other stuff
            }
            else if (cmbFileType.SelectedItem.ToString() == ".pdf")
            {
                // do some other stuff
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnHelp_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
