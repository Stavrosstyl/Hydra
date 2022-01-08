using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydra_FEA_Library.CAD.Shapes
{
    public class Point // POINTS (SIMEIA MONTELOU) have coordinates X, Y, Z and their main use is
                       // as reference points to create nodes, draw lines, etc.
    {
        public double X;
        public double Y;
        public double Z;
        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public (double, double, double) Get_Coordinates()
        {
            return (X, Y, Z);
        }
    }
    public class Straight_Line // STRAIGHT LINES are made by connecting two points. They are used to draw shapes,
                               // to help with the drawing of the model, etc.
    {
        public Point Start_Point;
        public Point End_Point;
        public double Length;
        //orientation vector

        public Straight_Line(Point start_Point, Point end_Point)
        { 
            Start_Point= start_Point;
            End_Point = end_Point;
            Point i = Start_Point;
            Point j = End_Point;
            Length = Math.Sqrt(Math.Pow(i.X - j.X, 2) + Math.Pow(i.Y - j.Y, 2) + Math.Pow(i.Z - j.Z, 2));
        }
    }
    public class Circle
    {
        public Point Center;
        public double Radius;
        public double Diameter;

        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
            Diameter = 2 * radius;
        }
    }
}     //   public double [,,] vctr_Dir = (v)
