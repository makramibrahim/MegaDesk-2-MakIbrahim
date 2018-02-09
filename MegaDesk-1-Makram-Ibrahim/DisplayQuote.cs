using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace MegaDesk_4_Makram_Ibrahim
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(string clientName, string quoteDate, decimal width, decimal depth,
            int drawers, SurfaceMaterials material, int rushOptions, decimal quotePrice)
        {
            string rushOrder;
            InitializeComponent();

            if (rushOptions == 0)
            {
                rushOrder = "none";
            }
            else
            {
                rushOrder = rushOptions.ToString() + " Days";
            }


            try
            {
                DisplQuote.Text = "-----------------------------------------------------------------------" + Environment.NewLine +
                                    "Customer Name:                             " + clientName + Environment.NewLine +
                                   "-----------------------------------------------------------------------" + Environment.NewLine +
                                    "Desk Width:                                      " + width + " inches" + Environment.NewLine +
                                   "-----------------------------------------------------------------------" + Environment.NewLine +
                                    "Desk Depth:                                      " + depth + " inches" + Environment.NewLine +
                                   "-----------------------------------------------------------------------" + Environment.NewLine +
                                    "Desk Drawers:                                    " + drawers + Environment.NewLine +
                                   "-----------------------------------------------------------------------" + Environment.NewLine +
                                    "Desk Material:                                   " + material + Environment.NewLine +
                                  "------------------------------------------------------------------------" + Environment.NewLine +
                                    "Rush Days:                                       " + rushOrder + Environment.NewLine +
                                   "-----------------------------------------------------------------------" + Environment.NewLine;
  
                quotePrices.Text = "$" + quotePrice.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Writing the file");
            }
        }

        private void QuoteBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
