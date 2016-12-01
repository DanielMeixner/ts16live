using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class DevSkillComputer
    {
        public static double ComputeDeveloperCodingsSkills(
                int yearsOfExperience, 
                int githubRepos, 
                int stickersOnLaptop, 
                int shoesize){
            double factor = 1;

            if (yearsOfExperience<1)
            {
                return 1;
            }

            switch (shoesize)
            {
                case 47:
                    factor += 0.2;
                    if (yearsOfExperience >10)
                        factor += 0.3;
                        if (yearsOfExperience < 3)
                        factor += 0.2;
                    if (stickersOnLaptop > yearsOfExperience)
                            factor += 0.5;
                    break;
                case 36:
                    factor += 0.01 * stickersOnLaptop / yearsOfExperience;
                    break;
                default:
                    break;
            }

            if (stickersOnLaptop == 0)            
                factor *= -0.5;
                if (githubRepos > 10)
                    factor += 0.4;            
            
            return factor * githubRepos + shoesize / yearsOfExperience;
        }
    }
}
