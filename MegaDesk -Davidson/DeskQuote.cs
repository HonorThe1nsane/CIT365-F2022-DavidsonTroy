using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk__Davidson
{
    public class DeskQuote
    {
        string CustomerName;
        float DeskWidth;
        float DeskDepth;
        int NumDrawers;
        string SurfaceMaterial;
        int RushDays;
        float QuotePrice;

        public void calcShipping()
        {
            {
                if (RushDays == 3)
                {
                    if (DeskWidth * DeskDepth < 1000)
                    {
                        QuotePrice += 60;
                    }
                    else if (DeskWidth * DeskDepth >= 1000 && DeskWidth * DeskDepth <= 2000)
                    {
                        QuotePrice += 70;
                    }
                    else if (DeskWidth * DeskDepth > 2000)
                    {
                        QuotePrice += 80;
                    }
                }
                else if (RushDays == 5)
                {
                    if (DeskWidth * DeskDepth < 1000)
                    {
                        QuotePrice += 40;
                    }
                    else if (DeskWidth * DeskDepth >= 1000 && DeskWidth * DeskDepth <= 2000)
                    {
                        QuotePrice += 50;
                    }
                    else if (DeskWidth * DeskDepth > 2000)
                    {
                        QuotePrice += 60;
                    }
                }
                else if (RushDays == 7)
                {
                    if (DeskWidth * DeskDepth < 1000)
                    {
                        QuotePrice += 30;
                    }
                    else if (DeskWidth * DeskDepth >= 1000 && DeskWidth * DeskDepth <= 2000)
                    {
                        QuotePrice += 35;
                    }
                    else if (DeskWidth * DeskDepth > 2000)
                    {
                        QuotePrice += 40;
                    }
                }
            }
        }

        public void calcSurfaceMaterial()
        {
            if (SurfaceMaterial == "Oak")
            {
                QuotePrice += 200;
            }
            else if (SurfaceMaterial == "Laminate")
            {
                QuotePrice += 100;
            }
            else if (SurfaceMaterial == "Pine")
            {
                QuotePrice += 50;
            }
            else if (SurfaceMaterial == "Rosewood")
            {
                QuotePrice += 300;
            }
            else if (SurfaceMaterial == "Veneer")
            {
                QuotePrice += 125;
            }
        }

        public void calcDrawers()
        {
            QuotePrice += NumDrawers * 50;
        }

        public void calcSize()
        {
            if (DeskWidth < 24 || DeskWidth > 96 || DeskDepth < 12 || DeskDepth > 48)
            {
                QuotePrice = 0;
            }
            else
            {
                QuotePrice += DeskWidth * DeskDepth;
            }
        }


    }
}
