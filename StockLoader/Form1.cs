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

        public Form1() {
            InitializeComponent();
            folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            textSaveBox.Text = folder;
            folderBrowserDialog.SelectedPath = folder;
            setDate();
        }

        private void setDate() {
            // For this project, we are going to just strong arm this all
            DateTime currentDate = DateTime.Today;
            comboBoxToMonth.SelectedIndex = currentDate.Month - 1;
            numericUpDownToDay.Value = currentDate.Day;
            numericUpDownToYear.Value = currentDate.Year;
            numericUpDownFromYear.Value = currentDate.Year;
        }

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

        private void buttonChooseSavePath_Click(object sender, EventArgs e) {
            DialogResult results = folderBrowserDialog.ShowDialog();

            if (results == DialogResult.OK) {
                folder = folderBrowserDialog.SelectedPath;
                textSaveBox.Text = folder;
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e) {
            if (!Directory.Exists(textSaveBox.Text)) {
                MessageBox.Show("Please enter a valid save location");
                return;
            }
            if (textTicker.Text == "") {
                MessageBox.Show("Please enter a stock ticker symbol");
                return; 
            }
            if (datesAreValid()) {
                string tickers = textTicker.Text;
                bool isValidTicker = tickers.All(c => char.IsLetter(c) || c == ',' || c == ' ');
                if (!isValidTicker) {
                    MessageBox.Show("Please only enter valid tickers seperated by a comma");
                    return;
                }
                setInterval();
                string[] symbols = Helpers.SplitTickers(tickers);
                // Otherwise let's process this thing.

                foreach (string symbol in symbols) {
                    string path = Path.Combine(folder, symbol + ".csv");
                    string url = "http://real-chart.finance.yahoo.com/table.csv?s=" + symbol + "&a=" + comboBoxFromMonth.SelectedIndex + "&b=" + numericUpDownFromDay.Value + "&c=" + numericUpDownFromYear.Value + "&d=" + comboBoxToMonth + "&e=" + numericUpDownToDay.Value + "&f=" + numericUpDownToYear.Value + "&g=" + interval + "&ignore=.csv";

                    //try {
                    //    Helpers.DownloadSymbolsToCSV(url, path, folder, symbol);
                    //} catch {
                    //    MessageBox.Show("Could not locate" + symbol);
                    //}
                }
                formList fileList = new formList(folder);
                fileList.Show();
            }


        }

        private void setInterval() {
            if (radioButtonDaily.Checked) {
                interval = "d";
            } else if (radioButtonWeekly.Checked) {
                interval = "w";
            } else {
                interval = "m";
            }
        }

        private void dow30ToolStripMenuItem_Click(object sender, EventArgs e) {
            textTicker.Text = GetIndices.GetStockList("industrials");
        }


        private void nazdaq100ToolStripMenuItem_Click(object sender, EventArgs e) {
            textTicker.Text = GetIndices.GetStockList("nasdaq100");
        }

        private void spToolStripMenuItem_Click(object sender, EventArgs e) {
            textTicker.Text = GetIndices.GetStockList("sp100");
        }
    }
}
