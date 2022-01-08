using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydra_FEA_Library.Materials
{
    public class Material
    {
        public string Name;
        public Material(string name)
        {
            Name = name;
        }
    }
    
    public class Isotropic_Material : Material
        {
        public double Youngs_Modulus;
        public double Poisson_Ratio;
        public double Yield_Stress;
        public Isotropic_Material(string name, double yield_stress, double youngs_modulus, double poisson_ratio) : base(name)
        {
            Youngs_Modulus = youngs_modulus;
            Poisson_Ratio = poisson_ratio;
            Yield_Stress = yield_stress;
            
        }
    }
    /*
    public class Orthotropic_Material
    {

        public Orthotropic_Material()
        {



        }
    }

    public class Anisotropic_Material
    {

        public Anisotropic_Material()
        {



        }
    }
    */
}
