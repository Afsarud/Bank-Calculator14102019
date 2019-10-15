using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    class Calculator
    {
        public double FirstNam;
        public double SecondNam;
        public double Add()
        {
            double Result = FirstNam + SecondNam;
            return Result;
        }
        public double Sub()
        {
            double Result = FirstNam - SecondNam;
            return Result;
        }
        public double Mult()
        {
            double Result = FirstNam * SecondNam;
            return Result;
        }
        public double Div()
        {
            double Result = FirstNam / SecondNam;
            return Result;
        }
    }

}
