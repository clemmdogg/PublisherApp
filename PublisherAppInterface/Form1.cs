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
            if (dataBaseNameText.Text == "") { return; }
            using var context = new PubContext(dataBaseNameText.Text);
            PublisherHelper publisherHelper = new PublisherHelper(dataBaseNameText.Text);
            try
            {
                publisherHelper.AddAuthor(firstName, lastName, context);
            }
            catch
            {
                return;
            }
            FirstName.Text = "";
            LastName.Text = "";
            RefreshGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void RefreshGrid()
        {
            AuthorGridView.DataSource = null;
            if (dataBaseNameText.Text == "") { return; }
            PublisherHelper publisherHelper = new PublisherHelper(dataBaseNameText.Text);
            AuthorGridView.DataSource = publisherHelper.GetAuthors();
        }

        private void SetUPDataBaseButton_Click(object sender, EventArgs e)
        {
            if (dataBaseNameText.Text == "") { return; }
            PublisherHelper publisherHelper = new PublisherHelper(dataBaseNameText.Text);
            publisherHelper.MakeDataBase();
            RefreshGrid();
        }
    }
}
