using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_Makram_Ibrahim
{
    class DeskQuote
    {
        /*************************
        * Declare some variables 
        *************************/
        public String ClientName { get; set; }
        public DateTime QuoteDate { get; set; }
        public int RushDays { get; set; }
        public Desk Desk = new Desk();
        public decimal QuotePrice { get; set; }
        public List<Desk> Ldisk { get; set; }


        private decimal Surface = 0;


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
        public DeskQuote(string name, DateTime quoteDate, decimal width, decimal depth,
            int drawers, SurfaceMaterials material, int rushDays)
        {
            ClientName = name;
            QuoteDate = quoteDate;
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.surfMaterials = material;
            Desk.NumOfDrawers = drawers;
            RushDays = rushDays;

            Surface = Desk.Width * Desk.Depth;
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
            decimal extraSurfaceCost = 0;
            if (Surface > BASE_SIZE)
            {
                extraSurfaceCost = (Surface - BASE_SIZE) * PRICE_PER_INCH;

            }
            return extraSurfaceCost;
        }

        private decimal DrawerCost()
        {
            return Desk.NumOfDrawers * DRAWER_PRICE;
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
                    rushDays = 60;
                }
                else if (RushDays == RUSH_DAYS2)
                {
                    rushDays = 40;
                }
                else if (RushDays == RUSH_DAYS3)
                {
                    rushDays = 30;
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
                    rushDays = 70;
                }
                else if (RushDays == RUSH_DAYS2)
                {
                    rushDays = 50;
                }
                else if (RushDays == RUSH_DAYS3)
                {
                    rushDays = 35;
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
                    rushDays = 80;
                }
                else if (RushDays == RUSH_DAYS2)
                {
                    rushDays = 60;
                }
                else if (RushDays == RUSH_DAYS3)
                {
                    rushDays = 40;
                }
                else
                {
                    rushDays = 0;
                }
            }

            return rushDays;

        }
    }

}
