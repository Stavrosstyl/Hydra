// See https://aka.ms/new-console-template for more information

// -------------- WE USE SI HERE (meters, seconds etc etc!!!!!). Conversions are done with methods -------------- //

using Hydra_FEA_Library.CAD.Shapes;
using Hydra_FEA_Library.Materials;
using Hydra_FEA_Library.Elements;
using Hydra_FEA_Library.Sections;
//using Hydra_FEA_Library.Elements.Linear_Elements;
//using Solver

Console.WriteLine("Hello, World!");

Point Point1 = new Point(0, 0, 0);
Point Point2 = new Point(0, 5, 0);
Point Point3 = new Point(5, 0, 0);
Point Point4 = new Point(5, 5, 0);

Console.WriteLine($"\nPoint 1 = ({Point1.X}, {Point1.Y}, {Point1.Z})");
Console.WriteLine($"Point 2 = ({Point2.X}, {Point2.Y}, {Point2.Z})");
Console.WriteLine($"Point 3= ({Point3.X}, {Point3.Y}, {Point3.Z})");
Console.WriteLine($"Point 4 = ({Point4.X}, {Point4.Y}, {Point4.Z})");

//Node Node1 = new Node1(0, 0, 0, pinned);
//Node Node1 = new Node1(0, 5, 0, pinned);
//Node Node1 = new Node1(5, 0, 0, free);
//Node Node1 = new Node(5, 5, 0, "free");
Node Node1 = new Node(Point1, "pinned");
Node Node2 = new Node(Point2, "pinned");
Node Node3 = new Node(Point3, "free");
Node Node4 = new Node(Point4, "free");

Console.WriteLine($"\nNode 1 = ({Node1.X}, {Node1.Y}, {Node1.Z}, {Node1.Constraint})");
Console.WriteLine($"Node 2 = ({Node2.X}, {Node2.Y}, {Node2.Z}, {Node2.Constraint})");
Console.WriteLine($"Node 3 = ({Node3.X}, {Node3.Y}, {Node3.Z}, {Node3.Constraint})");
Console.WriteLine($"Node 4 = ({Node4.X}, {Node4.Y}, {Node4.Z}, {Node4.Constraint})");

Straight_Line line1 = new Straight_Line(Point1, Point3);
Circle C1 = new Circle(Point2, 10);

Console.WriteLine($"\nLength of line 1 = {line1.Length}");
Console.WriteLine($"Radius of circle 1 = {C1.Radius}, diameter of circle 1 = {C1.Diameter}");

Isotropic_Material S355_Steel = new Isotropic_Material("S355", 355e+6, 210e+8, 0.3);

Console.WriteLine($"\nSteel S235 properties:" +
                  $"\tYield stress = {S355_Steel.Yield_Stress / 1000000} MPa" +
                  $"\n\t\t\tYoung's modulus = {S355_Steel.Youngs_Modulus / 100000000} GPa" +
                  $"\n\t\t\tPoisson's ratio = {S355_Steel.Poisson_Ratio}");

Section rect_2cm = new Section("Rectangular 2 cm section", S355_Steel, 0.04, 0.00013333333);

Console.WriteLine($"\n{rect_2cm.Name} properties:" +
                  $"\n\t\t\t\tMaterial= {rect_2cm.Material.Name}" +
                  $"\n\t\t\t\tArea = {rect_2cm.Area} m^2" +
                  $"\n\t\t\t\tSecond Moment of Inertia= {rect_2cm.Second_Moment_Of_Inertia} m^4");

//Truss_Element trs_elem_1 = new Truss_Element(Node1, Node2, S355_Steel);
//Truss_Element trs_elem_2 = new Truss_Element(Node1, Node3, S355_Steel);
//Truss_Element trs_elem_3 = new Truss_Element(Node2, Node4, S355_Steel);
//Truss_Element trs_elem_4 = new Truss_Element(Node3, Node4, S355_Steel);
//Truss_Element trs_elem_5 = new Truss_Element(Node1, Node4, S355_Steel);
//Truss_Element trs_elem_6 = new Truss_Element(Node2, Node3, S355_Steel);














