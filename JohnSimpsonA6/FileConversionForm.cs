namespace JohnSimpsonA6;

public partial class FileConversionForm : Form
{
    public FileConversionForm()
    {
        InitializeComponent();
        this.Text = @"John Simpson Assignment 6";
    }

    public sealed override string Text
    {
        get => base.Text;
        set => base.Text = value;
    }

    private void DirectoryOpenButton_Click(object sender, EventArgs e)
    {
        var folder = new OpenFileDialog();
        var result = folder.ShowDialog();
        if (result == DialogResult.OK)
        {
            DirectoryDisplay.Text = folder.FileName;
        }
    }
}