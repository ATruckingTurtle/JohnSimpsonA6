using System.Text.Json;

namespace JohnSimpsonA6;

public partial class FileConversionForm : Form
{
    private List<Books>? _books = new List<Books>();
    public FileConversionForm()
    {
        InitializeComponent();
        this.Text = @"John Simpson Assignment 6";
    }

    public sealed override string Text
    {
        set => base.Text = value;
        get => base.Text;
    }

    private void LoadBooksFromFile(string filePath)
    {
        try
        {
            var data = File.ReadAllText(filePath);
            _books = JsonSerializer.Deserialize<List<Books>>(data);
            DisplayBooks();
        }
        catch (Exception ex)
        {
            MessageBox.Show($@"Error loading file: {ex.Message}");
        }
    }

    private void DisplayBooks()
    {
        listedBookBox.Items.Clear();

        foreach (var b in _books)
        {
            listedBookBox.Items.Add($"{b.Title}");
        }
    }

    private void DirectoryOpenButton_Click(object sender, EventArgs e)
    {
        var folder = new OpenFileDialog();
        var result = folder.ShowDialog();
        if (result == DialogResult.OK)
        {
            DirectoryDisplay.Text = folder.FileName;
            LoadBooksFromFile(folder.FileName);
        }
    }

    private void JsonSaveButton_Click(object sender, EventArgs e)
    {

    }
}