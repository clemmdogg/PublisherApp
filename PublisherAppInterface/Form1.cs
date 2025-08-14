using Microsoft.EntityFrameworkCore;
using PublisherData;
using PublisherDomain;
using PublisherConsole;

namespace PublisherAppInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = FirstName.Text;
            string lastName = LastName.Text;
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                { return; }
            PublisherHelper publisherHelper = new PublisherHelper();
            publisherHelper.AddAuthor(firstName, lastName);
            FirstName.Text = "";
            LastName.Text = "";
            RefreshGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }
        private void RefreshGrid()
        {
           AuthorGridView.DataSource = null;
           PublisherHelper publisherHelper = new PublisherHelper();
           AuthorGridView.DataSource = publisherHelper.GetAuthors();
        }
    }
}
