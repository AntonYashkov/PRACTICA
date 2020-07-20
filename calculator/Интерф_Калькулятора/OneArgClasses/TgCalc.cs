using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Интерф_Калькулятора.OneArgClasses
{
    public class TgCalc : IOneArgCalculator
    {
        public double Calculate(double FirstNumber)
        {
            return (Math.Tan(FirstNumber * Math.PI / 180));
        }
    }
}
