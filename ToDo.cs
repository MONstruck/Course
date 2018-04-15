using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCourse
{
   public class ToDo
    {
        //function checks whether the cube will enter
       protected static bool Check(double a1, double d1, double r1)
        {

            if (a1 < d1 || a1 < r1)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
        //function checks the input data for negative and zero values
      protected static bool IsNotNegative(double a1, double d1, double r1, double c1, double b1)
        {

            if (a1 <= 0 || d1 <= 0 || c1 <= 0 || b1 <= 0 || r1 <= 0)
            {

                return false;
            }
            else { return true; }
        }
    }
}
