namespace JohnSimpsonA6
{
    partial class FileConversionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            directoryOpenButton = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            DirectoryDisplay = new TextBox();
            JsonSaveButton = new Button();
            CsvSaveButton = new Button();
            listedBookBox = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 49);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "File Path";
            // 
            // directoryOpenButton
            // 
            directoryOpenButton.Location = new Point(464, 67);
            directoryOpenButton.Name = "directoryOpenButton";
            directoryOpenButton.Size = new Size(86, 23);
            directoryOpenButton.TabIndex = 1;
            directoryOpenButton.Text = "Browse Files";
            directoryOpenButton.UseVisualStyleBackColor = true;
            directoryOpenButton.Click += DirectoryOpenButton_Click;
            // 
            // DirectoryDisplay
            // 
            DirectoryDisplay.Location = new Point(52, 67);
            DirectoryDisplay.Name = "DirectoryDisplay";
            DirectoryDisplay.Size = new Size(406, 23);
            DirectoryDisplay.TabIndex = 2;
            // 
            // JsonSaveButton
            // 
            JsonSaveButton.Location = new Point(112, 237);
            JsonSaveButton.Name = "JsonSaveButton";
            JsonSaveButton.Size = new Size(87, 66);
            JsonSaveButton.TabIndex = 3;
            JsonSaveButton.Text = "Save \r\nas\r\nJSON";
            JsonSaveButton.UseVisualStyleBackColor = true;
            JsonSaveButton.Click += JsonSaveButton_Click;
            // 
            // CsvSaveButton
            // 
            CsvSaveButton.Location = new Point(226, 237);
            CsvSaveButton.Name = "CsvSaveButton";
            CsvSaveButton.Size = new Size(87, 66);
            CsvSaveButton.TabIndex = 4;
            CsvSaveButton.Text = "Save \r\nas\r\nCSV";
            CsvSaveButton.UseVisualStyleBackColor = true;
            CsvSaveButton.Click += CsvSaveButton_Click;
            // 
            // listedBookBox
            // 
            listedBookBox.FormattingEnabled = true;
            listedBookBox.ItemHeight = 15;
            listedBookBox.Location = new Point(411, 145);
            listedBookBox.Name = "listedBookBox";
            listedBookBox.Size = new Size(354, 259);
            listedBookBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 127);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 6;
            label2.Text = "Contents preview";
            // 
            // FileConversionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(listedBookBox);
            Controls.Add(CsvSaveButton);
            Controls.Add(JsonSaveButton);
            Controls.Add(DirectoryDisplay);
            Controls.Add(directoryOpenButton);
            Controls.Add(label1);
            Name = "FileConversionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "John Simpson Assignment 6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button directoryOpenButton;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox DirectoryDisplay;
        private Button JsonSaveButton;
        private Button CsvSaveButton;
        private ListBox listedBookBox;
        private Label label2;
    }
}
