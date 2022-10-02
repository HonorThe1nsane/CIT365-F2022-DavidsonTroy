using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk__Davidson
{
    public class DeskQuote
    {
        string FirstName{ get; set; }
        string LastName { get; set; }
        float DeskWidth { get; set; }
        float DeskDepth { get; set; }
        int NumDrawers { get; set; }
        string SurfaceMaterial { get; set; }
        int RushDays { get; set; }
        float QuotePrice { get; set; }
        public int Width { get; }
        public int Drawers { get; }
        public string Material { get; }
        public int Rush { get; }

        public DeskQuote(string firstName, string lastName, float width, float depth, int drawers, string material, int rush)
        {
            FirstName = firstName;
            LastName = lastName;
            DeskWidth = width;
            DeskDepth = depth;
            NumDrawers = drawers;
            SurfaceMaterial = material;
            Rush = rush;
        }

        public DeskQuote(string firstName, string lastName, int width, int drawers, string material, int rush)
        {
            FirstName=firstName;
            LastName=lastName;
            Width=width;
            Drawers=drawers;
            Material=material;
            Rush=rush;
        }

        public float GetQuotePrice()
        {
            float surfaceArea = DeskWidth * DeskDepth;
            float basePrice = 200;
            float surfaceAreaPrice = 0;
            float drawerPrice = 50;
            float materialPrice = 0;
            float rushPrice = 0;
            float total = 0;

            if (surfaceArea > 1000)
            {
                surfaceAreaPrice = surfaceArea - 1000;
            }

            if (SurfaceMaterial == "Oak")
            {
                materialPrice = 200;
            }
            else if (SurfaceMaterial == "Laminate")
            {
                materialPrice = 100;
            }
            else if (SurfaceMaterial == "Pine")
            {
                materialPrice = 50;
            }
            else if (SurfaceMaterial == "Rosewood")
            {
                materialPrice = 300;
            }
            else if (SurfaceMaterial == "Veneer")
            {
                materialPrice = 125;
            }

            if (RushDays == 3)
            {
                if (surfaceArea < 1000)
                {
                    rushPrice = 60;
                }
                else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                {
                    rushPrice = 70;
                }
                else if (surfaceArea > 2000)
                {
                    rushPrice = 80;
                }
            }
            else if (RushDays == 5)
            {
                if (surfaceArea < 1000)
                {
                    rushPrice = 40;
                }
                else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                {
                    rushPrice = 50;
                }
                else if (surfaceArea > 2000)
                {
                    rushPrice = 60;
                }
            }
            else if (RushDays == 7)
            {
                if (surfaceArea < 1000)
                {
                    rushPrice = 30;
                }
                else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                {
                    rushPrice = 35;
                }
                else if (surfaceArea > 2000)
                {
                    rushPrice = 40;
                }
            }

            total = basePrice + surfaceAreaPrice + (drawerPrice * NumDrawers) + materialPrice + rushPrice;

            return total;
        }





        public float calcShipping()
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
                else if (RushDays == 14)
                {
                    QuotePrice += 0;
                }
            }
            return QuotePrice;
        }
        
        public float calcSurfaceMaterial()
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
            return QuotePrice;
        }

        public float calcDrawers()
        {
            QuotePrice += NumDrawers * 50;
            return QuotePrice;
        }

      
    }


    
}
