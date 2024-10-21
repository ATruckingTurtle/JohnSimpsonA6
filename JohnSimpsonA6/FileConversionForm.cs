using System.Text.Json;

namespace JohnSimpsonA6;

public partial class FileConversionForm : Form
{
    private List<Books>? _books = [];
    public FileConversionForm()
    {
        InitializeComponent();
        if (_books != null) listedBookBox.Items.Add($"There are {_books.Count} Books in the list.");
        this.Text = @"John Simpson Assignment 6";
    }

    public sealed override string Text
    {
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(@"Value cannot be null or whitespace.", nameof(value));
            base.Text = value;
        }
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

        if (_books != null)
        {
            listedBookBox.Items.Add($"There are {_books.Count} books in the list.");
            listedBookBox.Items.Add("");

            foreach (var b in _books!)
            {
                listedBookBox.Items.Add($"{b.Title}, Released in {b.Year}");
            }
        }
        else
        {
            listedBookBox.Items.Add("Currently no books.");
        }
    }

    private void DirectoryOpenButton_Click(object sender, EventArgs e)
    {
        var folder = new OpenFileDialog();
        var result = folder.ShowDialog();
        if (result != DialogResult.OK) return;
        DirectoryDisplay.Text = folder.FileName;
        LoadBooksFromFile(folder.FileName);
    }

    private void JsonSaveButton_Click(object sender, EventArgs e)
    {
        if (_books == null || _books.Count == 0)
        {
            MessageBox.Show(@"Please add usable data before using this." ,@"Data Warning");
            return;
        }
        
        var saveFileDialog = new SaveFileDialog();
        saveFileDialog.DefaultExt = "json";
        saveFileDialog.AddExtension = true;
        var result = saveFileDialog.ShowDialog();
        if (result != DialogResult.OK) return;
        try
        {
            var filePath = saveFileDialog.FileName;
            if (!filePath.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
            {
                filePath += ".json";
            }
            SaveBookJson(filePath);
            MessageBox.Show(@"File saved", @"Great success");
        }
        catch (Exception ea)
        {
            MessageBox.Show($@"Error while saving data: {ea.Message}");
        }
    }

    private void SaveBookJson(string filePath)
    {
        var json = JsonSerializer.Serialize(_books, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }

    private void CsvSaveButton_Click(object sender, EventArgs e)
    {
        if (_books == null || _books.Count == 0)
        {
            MessageBox.Show(@"Please add usable data before using this.",@"Data Warning");
            return;
        }

        var saveFileDialog = new SaveFileDialog();
        saveFileDialog.DefaultExt = "csv";
        saveFileDialog.AddExtension = true;
        var result = saveFileDialog.ShowDialog();
        
        if (result != DialogResult.OK) return;
        var filePath = saveFileDialog.FileName;
        try
        {
            if (!filePath.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
            {
                filePath += ".csv";
            }
            SaveBookCsv(filePath);
            MessageBox.Show(@"File saved", @"Great success");
        }
        catch (Exception ex)
        {
            MessageBox.Show($@"Issue occured while saving: {ex.Message}", @"err");
        }
    }

    private void SaveBookCsv(string filePath)
    {
        var csvFile = new List<string> { "Title,Author,Page,Genre,Year, Price" };

        if (_books != null)
        {
            csvFile.AddRange(_books.Select(book => ($"{book.Title},{book.Author},{book.Pages},{book.Genre},{book.Year},{book.Price}")));
        }
        File.WriteAllLines(filePath, csvFile);
    }
}