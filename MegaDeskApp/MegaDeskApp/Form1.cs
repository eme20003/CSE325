namespace MegaDeskApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote addQuoteView = new AddQuote();
            addQuoteView.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotesView = new SearchQuotes();
            searchQuotesView.Show(this);
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotesView = new ViewAllQuotes();
            viewAllQuotesView.Show(this);
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
