using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_Makram_Ibrahim
{
    public partial class ViewQuotes : Form
    {
        public ViewQuotes()
        {
            InitializeComponent();

            string line;
            try
            {
                string QuoteFile = @"quotes.txt";
                using (StreamReader sr = new StreamReader(QuoteFile))
                {
                    
                    while ((line = sr.ReadLine()) != null)
                    {
                        ViewQuotesBox.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error wirting to the file");
            }
        }

        private void CancelViewQuotesBtn_Click(object sender, MouseEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
