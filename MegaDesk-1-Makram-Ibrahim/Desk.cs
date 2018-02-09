/***********************************************************
 * Author: Makram Ibrahim
 * Instructor: Brother Blazzard
 * CIT 365 - .NET Software Development
 * Date: Feb 9, 2018
 * Summary:
 * This is a MegaDesk window application to prompt user for input
 * and save the data in a json file format.
 * *********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_Makram_Ibrahim
{
    struct Desk
    {
        public decimal Width                  { get; set; }
        public decimal Depth                  { get; set; }
        public int NumOfDrawers               { get; set; }
        public SurfaceMaterials surfMaterials { get; set; }

        public const decimal MIN_WIDTH = 24;
        public const decimal MAX_WIDTH = 96;
        public const decimal MIN_DEPTH = 12;
        public const decimal MAX_DEPTH = 48;
    }

    /***********************
     * Set our own data type 
     **********************/
    public enum SurfaceMaterials
    {
        Laminate = 100,
        Oak = 200,
        Rosewood = 300,
        Veneer = 125,
        Pine = 50
    };
}

