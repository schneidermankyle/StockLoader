using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;

namespace StockLoader {
    public partial class formList : Form {
        string folderPath;

        // Class constructor
        public formList(string folder) {
            InitializeComponent();
            this.folderPath = folder;
        }

        // Let's return a list of all the .csv files in our directory
        private void formList_Load(object sender, EventArgs e) {
            string[] csvFiles = Directory.GetFiles(this.folderPath, "*.csv");
            this.formListBox.Items.AddRange(csvFiles);
        }

        // When a file is double clicked, let's open with the default application
        private void formListBox_DoubleClick(object sender, EventArgs e) {
            if (formListBox.SelectedItem != null) {
                RegistryKey key = Registry.ClassesRoot.OpenSubKey(".csv", false);
                string value = key.GetValue(null).ToString();

                key = Registry.ClassesRoot.OpenSubKey(value + "\\shell\\Open\\command", false);
                value = key.GetValue(null).ToString();

                int start = value.IndexOf("\"") + 1;
                value = value.Substring(start, value.LastIndexOf("\"") - start);

                Process.Start(value, formListBox.SelectedItem.ToString());

            }
        }

        // When the text is changed in our search box, let's update the search results
        private void textSearchBox_TextChanged(object sender, EventArgs e) {
            formListBox.Items.Clear();
            List<string> allPaths = Directory.GetFiles(folderPath, "*.csv").ToList();

            var filteredPaths = allPaths.Where(x => Path.GetFileNameWithoutExtension(x).Contains(textSearchBox.Text.ToUpper()));
            formListBox.Items.AddRange(filteredPaths.ToArray());
        }
    }
}
