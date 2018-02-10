using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_Makram_Ibrahim
{
    class DeskQuote
    {
        /*************************
        * Declare some variables 
        *************************/
        public String ClientName  { get; set; }
        public DateTime QuoteDate { get; set; }
        public int RushDays       { get; set; }
        public Desk Desk          { get; set; }
        public decimal QuotePrice { get; set; }
        public Desk desk = new Desk();
        public decimal Surface = 0;
        public int[,] array2D = new int[3,3];


        //Priced items with fiexed values
        private const int BASE_PRICE = 200;
        private const int BASE_SIZE = 1000;
        private const int DRAWER_PRICE = 50;
        private const int PRICE_PER_INCH = 1;
        private const int RUSH_DAYS1 = 3;
        private const int RUSH_DAYS2 = 5;
        private const int RUSH_DAYS3 = 7;
        private const int RUSH_HOLD = 2000;

        /******************************
        * Overloaded Constructor
        * ***************************/
        public DeskQuote( string name, DateTime quoteDate, decimal width, decimal depth,
                          int drawers, SurfaceMaterials material, int rushDays)
        {
            ClientName = name;
            QuoteDate = quoteDate;
            desk.Width = width;
            desk.Depth = depth;
            desk.surfMaterials = material;
            desk.NumOfDrawers = drawers;
            RushDays = rushDays;

            Surface = desk.Width * desk.Depth;
        }

        /*******************************
       * Defalut Constructor
       * ***************************/
        public DeskQuote() { }


        /************************************
       * Display the desk surface area
       * **********************************/
        public decimal CalQuoteTotal()
        {
            return BASE_PRICE + SurfaceArea() + DrawerCost() + (int)Desk.surfMaterials + RushOrderCost();
        }

        private decimal SurfaceArea()
        {
            decimal extraCost = 0;
            if (Surface > BASE_SIZE)
            {
                extraCost = (Surface - BASE_SIZE) * PRICE_PER_INCH;

            }
            return extraCost;
        }

        private decimal DrawerCost()
        {
            return Desk.NumOfDrawers * DRAWER_PRICE;
        }
        /************************************
        * Read File from RushDaus costs
        ***********************************/
        public int[,] ReadFileRushDays()
        {
            try
            {
                string readFile = @"C:\Users\Makram\Desktop\rushOrderPrices.txt";
                string[] array = File.ReadAllLines(readFile);

                //foreach(var i in array)
                //{
                //    Console.WriteLine(i);
                //}

                int store;
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        for (int j = 0; j < array.Length; j++)
                        {
                            if (Int32.TryParse(array[i], out store))
                            {
                                array2D[i, j] = store;
                                Console.WriteLine(array[i]);
                            }

                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "There is a problem");
            }

            return array2D;
        }

        /************************************
        * Get Rush Days cost. 
        ***********************************/
        public int RushOrderCost()
        {
            int rushDays = 0;
            if (Surface < BASE_SIZE)
            {
                if (RushDays == RUSH_DAYS1)
                {
                    rushDays = array2D[0, 0];
                }
                else if (RushDays == RUSH_DAYS2)
                {
                    rushDays = array2D[0, 1];
                }
                else if (RushDays == RUSH_DAYS3)
                {
                    rushDays = array2D[0, 2];
                }
                else
                {
                    rushDays = 0;
                }
            }
            else if (Surface > BASE_SIZE || Surface < 2000)
            {
                if (RushDays == RUSH_DAYS1)
                {
                    rushDays = array2D[1, 0];
                }
                else if (RushDays == RUSH_DAYS2)
                {
                    rushDays = array2D[1, 1];
                }
                else if (RushDays == RUSH_DAYS3)
                {
                    rushDays = array2D[1, 2];
                }
                else
                {
                    rushDays = 0;
                }
            }

            else
            {
                if (RushDays == RUSH_DAYS1)
                {
                    rushDays = array2D[2, 0];
                }
                else if (RushDays == RUSH_DAYS2)
                {
                    rushDays = array2D[2, 1];
                }
                else if (RushDays == RUSH_DAYS3)
                {
                    rushDays = array2D[2, 2];
                }
                else
                {
                    rushDays = 0;
                }
            }
            MessageBox.Show(rushDays.ToString());
            return rushDays;
            
        }
        
       
    }

}
