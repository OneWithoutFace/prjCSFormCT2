using prjCSFormCT2.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace prjCSFormCT2
{
    internal class Calculation
    {

       

       public static void Add(memCalc activeMem ,double userNum)
        {
            if (activeMem.moreNum==true)
            {
               activeMem.Num1= Equal(activeMem, userNum);
                activeMem.OpType = "+";

            }
            else
            {
                activeMem.Num1 = userNum;
                activeMem.OpType = "+";
            }
            
        }

        public static void Sub(memCalc activeMem, double userNum)
        {
            if (activeMem.moreNum == true)
            {
                activeMem.Num1 = Equal(activeMem, userNum);
                activeMem.OpType = "-";

            }
            else
            {
                activeMem.Num1 = userNum;
                activeMem.OpType = "-";
            }
        }

        public static void Multi(memCalc activeMem, double userNum)
        {
            if (activeMem.moreNum == true)
            {
                activeMem.Num1 = Equal(activeMem, userNum);
                activeMem.OpType = "*";

            }
            else
            {
                activeMem.Num1 = userNum;
                activeMem.OpType = "*";
            }
        }

        public static void Div(memCalc activeMem, double userNum)
        {
            if (activeMem.moreNum == true)
            {
                activeMem.Num1 = Equal(activeMem, userNum);
                activeMem.OpType = "/";

            }
            else
            {
                activeMem.Num1 = userNum;
                activeMem.OpType = "/";
            }
        }

        public static double Equal(memCalc activeMem, double userNum)
        {
            activeMem.Num2=userNum;

            if (activeMem.OpType=="+")
            {
                activeMem.Result=activeMem.Num1+activeMem.Num2;
                activeMem.OpType = null;

            }

            else if (activeMem.OpType=="-")
            {
                activeMem.Result=activeMem.Num1-activeMem.Num2;
                activeMem.OpType = null;
            }

            else if (activeMem.OpType=="*")
            {
                activeMem.Result=activeMem.Num1*activeMem.Num2;
                activeMem.OpType = null;
            }

            else if (activeMem.OpType=="/")
            {
                activeMem.Result=activeMem.Num1/activeMem.Num2;
                activeMem.OpType = null;
            }

            return activeMem.Result;
        }

        public static void Clear(memCalc activeMem)
        {
            activeMem.Num1 = 0;
            activeMem.Num2 = 0;
            activeMem.Result = 0;
            activeMem.OpType = null;
            
        }
    }
}
