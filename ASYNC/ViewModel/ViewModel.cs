using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ASYNC.Model;
namespace ASYNC.ViewModel
{
    public class ViewModel : INotifyPropertyChanged
    {
        Points FuncPoints;
        private const double Epsilon = 0.001;
        private double result;
        public double Result { get { return result; } set { result = value; OnPropertyChanged("Result"); } }

        public ViewModel()
        {
            FuncPoints = new Points(2, 4);
            Solution();
        }

        private void Solution()
        {
            double result;
            bool ver = true;
            while(ver)
            {
                result = (FuncPoints.point1 + FuncPoints.point2) / 2;
                if(Func(result) * Func(FuncPoints.point1) > 0)
                {
                    FuncPoints.point1 = result;
                }
                else if (Func(result) * Func(FuncPoints.point1) < 0)
                {
                    FuncPoints.point2 = result;
                }
                if(Epsilon * result < Epsilon)
                {
                    ver = false;
                    Result = result;
                }
            }
        }

        private double Func(double x)
        {
            double result = Math.Log10(x) + x - 2;
            return result;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
