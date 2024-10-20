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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 49);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Pick a file";
            // 
            // directoryOpenButton
            // 
            directoryOpenButton.Location = new Point(340, 67);
            directoryOpenButton.Name = "directoryOpenButton";
            directoryOpenButton.Size = new Size(30, 23);
            directoryOpenButton.TabIndex = 1;
            directoryOpenButton.Text = "....";
            directoryOpenButton.UseVisualStyleBackColor = true;
            directoryOpenButton.Click += directoryOpenButton_Click;
            // 
            // DirectoryDisplay
            // 
            DirectoryDisplay.Location = new Point(52, 67);
            DirectoryDisplay.Name = "DirectoryDisplay";
            DirectoryDisplay.Size = new Size(282, 23);
            DirectoryDisplay.TabIndex = 2;
            // 
            // FileConversionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
