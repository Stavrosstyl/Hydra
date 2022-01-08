using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hydra_FEA_Library.CAD.Shapes;


namespace Hydra_FEA_Library.Elements
{
    public class Node : Point
    {
        public string Constraint; // fixed, pinned, custom, etc. Sto custom tha to orizw meta...
        public Point point;
        //public Node(double x, double y, double z, string constraint)//
        //{
        //   // point = null;
        //    X = x;
        //    Y = y;
        //    Z = z;
        //    Constraint = constraint;
        //}

        public Node(Point point, string constraint) : base(point.X, point.Y, point.Z) // String constructor
        //public Node(double x, double y, double z, string restraint)
        {
            Constraint = constraint;
        }

        /*
            public Node(double x, double y, double z, ??? [] restraint); // List constructor
                {
                    X = x;
                    Y = y;
                    Z = z;
                    Restraint = restraint;
                }

            public Node(Point Po, ??? [] restraint); // List constructor
                {
                    X = Po.X;
                    Y = Po.Y;
                    Z = Po.Z;
                    Restraint = restraint;
                }
    */
    }
}
