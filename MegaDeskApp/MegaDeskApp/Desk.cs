using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskApp
{
    internal class Desk
    {
        int depth;
        const int Max_Depth = 48;
        int width;
        const int Max_Width = 96;
        int numberOfDrawers;
        bool wantKeyboardTray;
        bool integratedWirelessCharger;
        enum deskMaterial
        { 
            laminate,
            oak, 
            rosewood,
            veneer,
            pine
        }

        enum deskSize
        { 
            small,
            medium,
            large
        }

        static int CalculateArea(int width, int depth)
        {
            int totalArea = 0;

            if ((width >= 0 && width <= Max_Width) && (depth >= 0 && depth <= Max_Depth))
            {
                 totalArea = width * depth;
            }

            return totalArea;
     
        }


    }
}
