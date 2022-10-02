using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk__Davidson
{
    public class DeskQuote
    {
        string FirstName;
        string LastName;
        float DeskWidth;
        float DeskDepth;
        int NumDrawers;
        string SurfaceMaterial;
        int RushDays;
        float QuotePrice;


        public DeskQuote(string firstName, string lastName, float width, float depth, int drawers, string material, int rush)
        {
            FirstName = firstName;
            LastName = lastName;
            DeskWidth = width;
            DeskDepth = depth;
            NumDrawers = drawers;
            SurfaceMaterial = material;
            RushDays = rush;
        }

        public string getFirstName()
        {
            return FirstName;
        }

        public string getLastName()
        {
            return LastName;
        }

        public float getDeskWidth()
        {
            return DeskWidth;
        }

        public float getDeskDepth()
        {
            return DeskDepth;
        }

        public int getNumDrawers()
        {
            return NumDrawers;
        }

        public string getSurfaceMaterial()
        {
            return SurfaceMaterial;
        }

        public int getRushDays()
        {
            return RushDays;
        }

        public float getQuotePrice()
        {
            return QuotePrice;
        }

        public void setQuotePrice(float price)
        {
            QuotePrice = price;
        }
        
        

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
                else if (RushDays == 14)
                {
                    QuotePrice += 0;
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

      
    }


    
}
