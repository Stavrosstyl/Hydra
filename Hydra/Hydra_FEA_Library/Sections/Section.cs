using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hydra_FEA_Library.Materials;

namespace Hydra_FEA_Library.Sections
{
    public class Section
    {
        public Material Material;
        public double Area;
        public double First_Moment_Of_Inertia;
        public double Second_Moment_Of_Inertia;
        public double Wel;
        public double Wpl;
        public string Name;
            public Section(string name, Material material, double area, double second_moment_of_inertia)
            {
                Name = name;
                Material = material;
                Area = area;
                Second_Moment_Of_Inertia = second_moment_of_inertia;
            }

    }
}