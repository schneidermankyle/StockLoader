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

namespace StockLoader {
    public partial class Form1 : Form {
        private string folder = "";
        private string interval = "";

        // Our class constructor
        public Form1() {
            InitializeComponent();
            folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            textSaveBox.Text = folder;
            folderBrowserDialog.SelectedPath = folder;
            setDate();
        }

        // We will set the upper boundery of our date search to todays date
        private void setDate() {
            DateTime currentDate = DateTime.Today;
            comboBoxToMonth.SelectedIndex = currentDate.Month - 1;
            numericUpDownToDay.Value = currentDate.Day;
            numericUpDownToYear.Value = currentDate.Year;
            numericUpDownFromYear.Value = currentDate.Year;
        }

        // When someone is calling a file, we need to ensure that dates are valid
        private bool datesAreValid() {

            try {
                DateTime startDate = new DateTime((int)numericUpDownFromYear.Value, comboBoxFromMonth.SelectedIndex + 1, (int)numericUpDownFromDay.Value);
                DateTime endDate = new DateTime((int)numericUpDownToYear.Value, comboBoxToMonth.SelectedIndex + 1, (int)numericUpDownToDay.Value);
                if (startDate > endDate) {
                    MessageBox.Show("Error, start date or end date is out of order");
                    return false;
                }
                else if (endDate > DateTime.Now) {
                    MessageBox.Show("Error, cannot select future dates");
                    return false;
                }
                return true;
            }
            catch {
                MessageBox.Show("Please enter a valid date");
                return false;
            }
            
        }

        private void indexComponeToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void labelFolderPath_Click(object sender, EventArgs e) {

        }

        private void comboBoxFromMonth_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void radioButtonDaily_CheckedChanged(object sender, EventArgs e) {

        }

        private void numericUpDownToYear_ValueChanged(object sender, EventArgs e) {

        }

        private void numericUpDownFromYear_ValueChanged(object sender, EventArgs e) {

        }

        // Event listener for choosing our save path
        private void buttonChooseSavePath_Click(object sender, EventArgs e) {
            DialogResult results = folderBrowserDialog.ShowDialog();

            // If path looks good, set it to memory
            if (results == DialogResult.OK) {
                folder = folderBrowserDialog.SelectedPath;
                textSaveBox.Text = folder;
            }
        }

        // Event listener for clicking download
        private void buttonDownload_Click(object sender, EventArgs e) {
            // Check to ensure directory is valid
            if (!Directory.Exists(textSaveBox.Text)) {
                MessageBox.Show("Please enter a valid save location");
                return;
            }
            // check to ensure stock ticker text has been entered 
            if (textTicker.Text == "") {
                MessageBox.Show("Please enter a stock ticker symbol");
                return; 
            }
            // Are our dates valid?
            if (datesAreValid()) {
                // If so mak our call Async
                backgroundWorker1.RunWorkerAsync();
            }


        }

        // Based off user selection, what is our stock reporting interval
        private void setInterval() {
            if (radioButtonDaily.Checked) {
                interval = "d";
            } else if (radioButtonWeekly.Checked) {
                interval = "w";
            } else {
                interval = "m";
            }
        }

        // Downloads data for all of our data.
        private void Download()
        {
            CheckForIllegalCrossThreadCalls = false;
            string tickers = textTicker.Text;
            bool isValidTicker = tickers.All(c => char.IsLetter(c) || c == ',' || c == ' ');
            if (!isValidTicker)
            {
                MessageBox.Show("Please only enter valid tickers seperated by a comma");
                return;
            }
            setInterval();
            string[] symbols = Helpers.SplitTickers(tickers);

            // Otherwise let's process this thing.
            // Loop through each stock in list to begin downloading.
            foreach (string symbol in symbols)
            {
                string path = Path.Combine(folder, symbol + ".csv");
                string url = "http://real-chart.finance.yahoo.com/table.csv?s=" + symbol + "&a=" + comboBoxFromMonth.SelectedIndex + "&b=" + numericUpDownFromDay.Value + "&c=" + numericUpDownFromYear.Value + "&d=" + comboBoxToMonth + "&e=" + numericUpDownToDay.Value + "&f=" + numericUpDownToYear.Value + "&g=" + interval + "&ignore=.csv";

                try
                {
                    Helpers.DownloadSymbolsToCSV(url, path, folder, symbol);
                }
                catch
                {
                    MessageBox.Show("Could not locate" + symbol);
                }
            }
        }

        // Event listeners for our indicy list request
        // Returns a list of DOW 30
        private void dow30ToolStripMenuItem_Click(object sender, EventArgs e) {
            textTicker.Text = GetIndices.GetStockList("industrials");
        }

        // Returns a list for Nasdaq100
        private void nazdaq100ToolStripMenuItem_Click(object sender, EventArgs e) {
            textTicker.Text = GetIndices.GetStockList("nasdaq100");
        }

        // Returns a list for SP100
        private void spToolStripMenuItem_Click(object sender, EventArgs e) {
            textTicker.Text = GetIndices.GetStockList("sp100");
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Download();
        }

        // Upon download completion, run the file list
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            formList fileList = new formList(folder);
            fileList.Show();
        }
    }
}
