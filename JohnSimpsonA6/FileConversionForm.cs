namespace JohnSimpsonA6;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.Text = @"John Simpson Assignment 6";
    }

    public sealed override string Text
    {
        get => base.Text;
        set => base.Text = value;
    }
}