using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjCSFormCT2
{
    public class ReadWriteFile
    {
        //Need to StreamLine processe
        public static void WriteLottoNum(string textpath, int amount , int[] numLotto,string lottoName)
        {
            DateTime currTime = DateTime.Now;
            StreamWriter textwrite = new StreamWriter(textpath,true);

            textwrite.Write(lottoName+", "+currTime+",   ");

            for (int i = 0; i < amount; i++)
            {
                if (i==amount-1)
                {
                    textwrite.WriteLine("  Bonus "+numLotto[i]);
                    
                }
                else if (i==amount-2)
                {
                    textwrite.Write(numLotto[i]+" ");
                }
                else
                {
                    textwrite.Write(numLotto[i]+",");
                }
            }
            textwrite.Close();

        }

        public static void WriteFileTemp(string textpath,double userIn,double convOut,string userTempIn,string convTempOut,string txtMsg)
        {
            DateTime currTime = DateTime.Now;
            StreamWriter textwrite = new StreamWriter(textpath, true);

            textwrite.WriteLine(userIn + " " + userTempIn + " = " + convOut + " " + convTempOut + ",     " + currTime+"     "+txtMsg);

            textwrite.Close();

        }

        public static void WriteFileTimeME(string textpath, string currIn, string currOut,double currAmountIn,double currAmountOut)
        {
            DateTime currTime = DateTime.Now;
            StreamWriter textwrite = new StreamWriter(textpath, true);

            textwrite.WriteLine(currAmountIn+" "+currIn+" = "+currAmountOut+" "+currOut+",     "+currTime);

            textwrite.Close();
        }

        public static void writeSimpleText(string textpath,string text)
        {
            StreamWriter textwrite = new StreamWriter(textpath, true);

            textwrite.WriteLine(text);
            textwrite.Close();

        }

        public static void binaryWrite(string textpath,string text)
        {
            try
            {
                FileStream binFStream = new FileStream(textpath, FileMode.Append, FileAccess.Write);
                BinaryWriter binWriter = new BinaryWriter(binFStream);
                binWriter.Write(text);

                binWriter.Close();
                binFStream.Close();
                

            }
            catch (Exception)
            {
                MessageBox.Show("error binwriter", "", MessageBoxButtons.OK);
                return;
            }
            
        }

        public static string ReadWholeFile(string textpath)
        {
            string logText;

            logText=File.ReadAllText(textpath);

            return logText;

        }



    }
}
