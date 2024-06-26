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
                cmbFileType.Items.Add(fileType);
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
