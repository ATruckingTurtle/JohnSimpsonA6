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
        if (_books == null || _books.Count == 0)
        {
            MessageBox.Show(@"Please add usable data before using this." ,@"Data Warning");
            return;
        }
    }

    private void CsvSaveButton_Click(object sender, EventArgs e)
    {
        if (_books == null || _books.Count == 0)
        {
            MessageBox.Show(@"Please add usable data before using this.",@"Data Warning");
            return;
        }

        var saveFileDialog = new SaveFileDialog();
        var result = saveFileDialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            string filePath = saveFileDialog.FileName;
            try
            {
                SaveBookCsv(filePath);
                MessageBox.Show(@"File saved", @"Great success");
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Issue occured while saving: {ex.Message}", @"err");
            }
        }
    }

    public void SaveBookCsv(string filePath)
    {
        var csvFile = new List<string> { "Title,Author,Page,Genre,Year, Price" };

        if (_books != null)
        {
            csvFile.AddRange(_books.Select(book => ($"{book.Title},{book.Author},{book.Pages},{book.Genre},{book.Year},{book.Price}")));
        }
        File.WriteAllLines(filePath, csvFile);
       
    }
}