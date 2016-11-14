namespace StockLoader {
    partial class formList {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelSearchFor = new System.Windows.Forms.Label();
            this.textSearchBox = new System.Windows.Forms.TextBox();
            this.formListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelSearchFor
            // 
            this.labelSearchFor.AutoSize = true;
            this.labelSearchFor.Location = new System.Drawing.Point(13, 13);
            this.labelSearchFor.Name = "labelSearchFor";
            this.labelSearchFor.Size = new System.Drawing.Size(62, 13);
            this.labelSearchFor.TabIndex = 0;
            this.labelSearchFor.Text = "Search For:";
            // 
            // textSearchBox
            // 
            this.textSearchBox.Location = new System.Drawing.Point(81, 13);
            this.textSearchBox.Name = "textSearchBox";
            this.textSearchBox.Size = new System.Drawing.Size(337, 20);
            this.textSearchBox.TabIndex = 1;
            this.textSearchBox.TextChanged += new System.EventHandler(this.textSearchBox_TextChanged);
            // 
            // formListBox
            // 
            this.formListBox.FormattingEnabled = true;
            this.formListBox.Location = new System.Drawing.Point(16, 50);
            this.formListBox.Name = "formListBox";
            this.formListBox.Size = new System.Drawing.Size(402, 381);
            this.formListBox.TabIndex = 2;
            this.formListBox.DoubleClick += new System.EventHandler(this.formListBox_DoubleClick);
            // 
            // formList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 451);
            this.Controls.Add(this.formListBox);
            this.Controls.Add(this.textSearchBox);
            this.Controls.Add(this.labelSearchFor);
            this.Name = "formList";
            this.Text = "CSV Files Available";
            this.Load += new System.EventHandler(this.formList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearchFor;
        private System.Windows.Forms.TextBox textSearchBox;
        private System.Windows.Forms.ListBox formListBox;
    }
}