using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk__Davidson
{
    internal class Desk
    {
        float SurfaceArea;
        float DeskWidth;
        float DeskDepth;
        int NumDrawers;
        string SurfaceMaterial;
        int RushDays;


        public Desk(float width, float depth, int drawers, string material, int rush)
        {
            DeskWidth = width;
            DeskDepth = depth;
            NumDrawers = drawers;
            SurfaceMaterial = material;
            RushDays = rush;
        }

        public float getSurfaceArea()
        {
            SurfaceArea = DeskWidth * DeskDepth;
            return SurfaceArea;
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
        
        
    }
}
