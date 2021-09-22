using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ASYNC.Model
{
    public class FuncModel
    {
        Points point;
        internal Points SetPoints { get { return point; } set { point = value; } }
        public FuncModel() { }
    }

    public struct Points
    {
        public double point1, point2;

        public Points(double point1, double point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }
    }
}
