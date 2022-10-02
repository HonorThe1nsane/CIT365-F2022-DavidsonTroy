using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk__Davidson
{
    internal class Desk
    {
        float SurfaceArea { get; set; }
        float DeskWidth { get; set; }
        float DeskDepth { get; set; }
        int NumDrawers { get; set; }
        
        int RushDays { get; set; }

       

        public Desk(float width, float depth, int drawers, int rush)
        {
            DeskWidth = width;
            DeskDepth = depth;
            NumDrawers = drawers;
            RushDays = rush;
        }



    }

    public enum SurfaceMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
}
