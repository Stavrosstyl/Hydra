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
        public object Constraint; // fixed, pinned, custom, etc. Sto custom tha to orizw meta...
        public string Constraint_Name;
        public Point point;
        public object Constraint_Fx, Constraint_Fy, Constraint_Fz;
        public object Constraint_Mx, Constraint_My, Constraint_Mz;
        public double Force_X, Force_Y, Force_Z;
        public double Moment_X, Moment_Y, Moment_Z;
        //public Node(double x, double y, double z, string constraint)//
        //{
        //   // point = null;
        //    X = x;
        //    Y = y;
        //    Z = z;
        //    Constraint = constraint;
        //}

        public Node(Point point) : base(point.X, point.Y, point.Z)
        {
            Constraint_Name = "free node";
            Constraint_Fx = 0;
            Constraint_Fy = 0;
            Constraint_Fz = 0;
            Constraint_Mx = 0;
            Constraint_My = 0;
            Constraint_Mz = 0;

            Force_X = 0;
            Force_Y = 0;
            Force_Z = 0;
            Moment_X = 0;
            Moment_Y = 0;
            Moment_Z = 0;
        }

        public Node(Point point, object constraint) : base(point.X, point.Y, point.Z)
        {
            Constraint = constraint;
            
            if (Constraint == "fixed")
            {
                Constraint_Name = "fixed node";
                Constraint_Fx = "1";
                Constraint_Fy = "1";
                Constraint_Fz = "1";
                Constraint_Mx = "1";
                Constraint_My = "1";
                Constraint_Mz = "1";
            }
            else if (Constraint == "pinned")
            {
                Constraint_Name = "pinned node";
                Constraint_Fx = "1";
                Constraint_Fy = "1";
                Constraint_Fz = "1";
                Constraint_Mx = 0;
                Constraint_My = 0;
                Constraint_Mz = 0;
            }
            else
            {
                Constraint_Name = "custom constraint";
                Constraint_Fx = 0;
                Constraint_Fy = 0;
                Constraint_Fz = 0;
                Constraint_Mx = 0;
                Constraint_My = 0;
                Constraint_Mz = 0;
            }
            Force_X = 0;
            Force_Y = 0;
            Force_Z = 0;
            Moment_X = 0;
            Moment_Y = 0;
            Moment_Z = 0;
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
