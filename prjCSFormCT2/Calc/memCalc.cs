using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace prjCSFormCT2.Calc
{
    internal class memCalc
    {
        double num1;
        double num2;
        double result;
        string opType;

        public memCalc(){}

        public double Num1
        {
            get { return num1; }
            set { num1=value; }
        }

        public double Num2
        {
            get { return num2; }
            set { num2=value; }
        }

        public double Result
        {
            get { return result; }
            set { result=value; }
        }

        public string OpType
        {
            get { return opType; }
            set { opType=value; }
        }

        public bool moreNum
        {
            get
            {
                bool calcCheck = false;

                if (opType!=null)
                {
                    calcCheck=true;
                }

                return calcCheck;
            }
        }
    }
}
