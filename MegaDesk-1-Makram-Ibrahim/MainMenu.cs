using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_Makram_Ibrahim
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddNewQuoteBtn_Click(object sender, EventArgs e)
        {
            AddNewQuote addNewQuote = new AddNewQuote();

            addNewQuote.Tag = this;

            addNewQuote.Show(this);

            Hide();
        }

        private void ViewQuotesBtn_Click(object sender, EventArgs e)
        {
            ViewQuotes viewQuotes = new ViewQuotes();

            viewQuotes.Tag = this;

            viewQuotes.Show(this);

            Hide();

        }

        private void SearchQuotesBtn_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes();

            searchQuotes.Tag = this;

            searchQuotes.Show(this);

            Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
