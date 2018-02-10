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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            List<SurfaceMaterials> MaterialTypeList = Enum.GetValues(typeof(SurfaceMaterials))
                .Cast<SurfaceMaterials>().ToList();
            SearchBox.DataSource = MaterialTypeList;
        }

        private void CancelSearchBtn_Click(object sender, MouseEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void SearchMaterial(object sender, EventArgs e)
        {
            searchOutput.Items.Clear();
            SurfaceMaterials MaterialName;
            string searchInput = SearchBox.SelectedItem.ToString();
            Enum.TryParse(searchInput, out MaterialName);

            try
            {
                string QuoteFile = @"quotes.txt";
                using (StreamReader sr = new StreamReader(QuoteFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains(MaterialName.ToString()))
                        {
                            searchOutput.Items.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error, can't read the file");
            }
        }
    }
}
