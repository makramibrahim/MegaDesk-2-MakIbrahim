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
    public partial class AddNewQuote : Form
    {


        string ClientName = String.Empty;
        decimal DeskWidth = 0;
        decimal DeskDepth = 0;
        int Drawers = 0;
        SurfaceMaterials surfMaterials;
        string RushOrderInput = String.Empty;
        int RushOrderDays = 0;
        decimal DeskQuotePrice = 0;
        DeskQuote deskQuote = new DeskQuote();

        //Priced items with fiexed values
        private const int RUSH_DAYS1 = 3;
        private const int RUSH_DAYS2 = 5;
        private const int RUSH_DAYS3 = 7;
        private const int RUSH_HOLD = 2000;


        public AddNewQuote()
        {
            InitializeComponent();

            List<SurfaceMaterials> MaterialTypeList = Enum.GetValues(typeof(SurfaceMaterials))
                .Cast<SurfaceMaterials>().ToList();
            materialsOutput.DataSource = MaterialTypeList;
            materialsOutput.Text = "";
        }

        private void AddQuote_FormClosed(Object sender, FormClosedEventArgs e)
        {
            var ReturnMainMenu = (MainMenu)Tag;
            ReturnMainMenu.Show();
            this.Close();
        }

        private void CancelBtn_Click(object sender, MouseEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }


        private void Width_Validating(object sender, CancelEventArgs e)
        {
            string Message;
            if (!ValidWidth(width.Text, out Message))
            {

                e.Cancel = true;
                width.Select(0, width.Text.Length);


                this.widthErrorProvider.SetError(width, Message);
                width.BackColor = Color.LightCoral;
            }
        }

        private void Width_Validated(object sender, EventArgs e)
        {

            widthErrorProvider.SetError(width, "");
            width.BackColor = default(Color);
        }

        private void Depth_Validating(object sender, CancelEventArgs e)
        {
            string Message;
            if (!ValidDepth(depth.Text, out Message))
            {

                e.Cancel = true;
                depth.Select(0, depth.Text.Length);


                this.ErrorProvider.SetError(depth, Message);
                depth.BackColor = Color.LightCoral;
            }
        }

        private void Depth_Validated(object sender, EventArgs e)
        {

            ErrorProvider.SetError(depth, "");
            depth.BackColor = default(Color);
        }

        public bool ValidWidth(string width, out string Message)
        {

            if (width.Length == 0)
            {
                Message = "Width is required.";
                return false;
            }


            if (Convert.ToDecimal(width) >= Desk.MIN_WIDTH &&
                Convert.ToDecimal(width) <= Desk.MAX_WIDTH)
            {
                Message = "";
                return true;

            }

            Message = "Width must be" + Desk.MIN_WIDTH +
                 " inches and " + Desk.MAX_WIDTH + " inches.";
            return false;
        }

        public bool ValidDepth(string depth, out string Message)
        {

            if (depth.Length == 0)
            {
                Message = "Error, Please enter depth";
                return false;
            }


            if (Convert.ToDecimal(depth) >= Desk.MIN_DEPTH &&
                Convert.ToDecimal(depth) <= Desk.MAX_DEPTH)
            {
                Message = "";
                return true;

            }

            Message = "Depth Must be" + Desk.MIN_DEPTH +
                " inches and " + Desk.MAX_DEPTH + " inches.";
            return false;
        }

        private void CharValidation(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) && (e.KeyChar != '.'))
            {

                e.Handled = true;
            }
        }

        private void DeskQuoteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ClientName = clientName.Text;
                DeskWidth = decimal.Parse(width.Text);
                DeskDepth = decimal.Parse(depth.Text);
                Drawers = int.Parse(numOfDrawers.Text);

                string Material = materialsOutput.Text;
                Enum.TryParse(Material, out surfMaterials);


                RushOrderInput = rushOptions.Text;

                switch (RushOrderInput)
                {
                    case "3 Days":
                        RushOrderDays = RUSH_DAYS1;
                        break;
                    case "5 Days":
                        RushOrderDays = RUSH_DAYS2;
                        break;
                    case "7 Days":
                        RushOrderDays = RUSH_DAYS3;
                        break;
                    default:
                        RushOrderDays = RUSH_DAYS3;
                        break;
                }

                DeskQuote NewOrder = new DeskQuote(ClientName, DateTime.Now, DeskWidth,
                    DeskDepth, Drawers, surfMaterials, RushOrderDays);
                DeskQuotePrice = NewOrder.CalQuoteTotal();
                DeskQuotePrice = Math.Round(DeskQuotePrice, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }

            string QuoteDate = DateTime.Now.ToString("dd MMMMM yyyy");

            try
            {
                var DeskFile = ClientName + ", Date: " + QuoteDate + ", Width: " + DeskWidth + ", Depth: " + DeskDepth
                    + ", Drawers: " + Drawers + ", Materials: " + surfMaterials + ", Rush: " + RushOrderDays + ", $" + DeskQuotePrice;
                string QuoteFile = @"quotes.txt";
                if (!File.Exists(QuoteFile))
                {
                    using (StreamWriter sw = File.CreateText(QuoteFile))
                    {
                    }
                }
                using (StreamWriter sw = File.AppendText(QuoteFile))
                {
                    sw.WriteLine(DeskFile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error, writing to the file");
            }

            var MainMenu = (MainMenu)Tag;
            DisplayQuote newOrderView = new DisplayQuote(ClientName, QuoteDate, DeskWidth,
                DeskDepth, Drawers, surfMaterials, RushOrderDays, DeskQuotePrice)
            {
                Tag = MainMenu
            };
            newOrderView.Show();
            this.Close();
        }

    }
}
