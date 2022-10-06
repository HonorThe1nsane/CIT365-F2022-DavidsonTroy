using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk__Davidson
{
    public class DeskQuote
    {
        public string CustomerName { get; set; }
        public DateTime QuoteDate;
        public float RushDays { get; set; }

        private Desk newDesk = new Desk();

        public float DrawerCost { get; set; }

        float QuotePrice { get; set; }
        public float RushCost { get; set; }



        public float MaterialCost;
        public float SurfaceArea;
        public float SizeCost;

        private const int BASE_PRICE = 200;
        private const int SIZE_TRESHHOLD = 1000;
        private const int PRICE_PER_DRAWER = 50;



        private float CalcMaterialCost(string material)
        {
            newDesk.DeskMaterial = material;

            switch (newDesk.DeskMaterial)
            {
                case "Oak":
                    MaterialCost = 200;
                    break;

                case "Laminate":
                    MaterialCost = 100;
                    break;

                case "Pine":
                    MaterialCost = 50;
                    break;

                case "Rosewood":
                    MaterialCost = 300;
                    break;

                case "Veneer":
                    MaterialCost = 125;
                    break;
            }
            return MaterialCost;
        }


        private float CalcSurfaceArea(float width, float depth)
        {
            newDesk.DeskWidth = width;
            newDesk.DeskDepth = depth;
            SurfaceArea = newDesk.DeskWidth * newDesk.DeskDepth;
            return SurfaceArea;
        }




        private float calSurfaceAreaCost(float SurfaceArea)
        {
            if (SurfaceArea <= 1000)
            {
                SizeCost = SIZE_TRESHHOLD;
            }
            else
            {
                SizeCost = SIZE_TRESHHOLD + (SurfaceArea - SIZE_TRESHHOLD);
            }

            return SizeCost;
        }


        private float CalcRushORderCost(float RushDays, float SurfaceArea)
        {
            if (SurfaceArea<1000)
            {
                switch (RushDays)
                {
                    case 3:
                        RushCost = 60;
                        break;
                    case 5:
                        RushCost = 40;
                        break;
                    case 7:
                        RushCost = 30;
                        break;
                }
            }
            else if (SurfaceArea < 2000)
            {
                switch (RushDays)
                {
                    case 3:
                        RushCost = 70;
                        break;
                    case 5:
                        RushCost = 50;
                        break;
                    case 7:
                        RushCost = 35;
                        break;
                }
            }
            else if (SurfaceArea > 2000)
            {
                switch (RushDays)
                {
                    case 3:
                        RushCost = 80;
                        break;
                    case 5:
                        RushCost = 60;
                        break;
                    case 7:
                        RushCost = 40;
                        break;
                }
            }
            return RushCost;
        }

        public DeskQuote()
        {

            DrawerCost = newDesk.NumDrawers * PRICE_PER_DRAWER;

            QuotePrice = BASE_PRICE + SizeCost + DrawerCost + MaterialCost + RushCost;

        }




    }



}
