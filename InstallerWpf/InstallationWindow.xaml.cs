using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InstallerWpf
{
    /// <summary>
    /// Логика взаимодействия для InstallationWindow.xaml
    /// </summary>
    public partial class InstallationWindow : Window
    {
        public InstallationWindow()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FilenameTextbox.Text = fbd.SelectedPath;
            }
        }

        private void InstallButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Directory.Exists(FilenameTextbox.Text))
            {
                Directory.CreateDirectory(FilenameTextbox.Text);
            }
            new ProgressWindow(FilenameTextbox.Text).Show();
            Close();
        }
    }
}
