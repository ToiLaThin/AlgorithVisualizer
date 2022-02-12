using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SSAlgorithmVisualizer
{
    public class BubleSortEngine : ISortEngine
    {
        //bool sorted = false;
        private int[] theArray;
        Graphics grapher;
        int maxVal; int eleWidth;
        Brush whiteBrush = new SolidBrush(Color.WhiteSmoke);
        Brush blackBrush = new SolidBrush(Color.Black);
        Brush redBrush = new SolidBrush(Color.DarkRed);
        Brush yellowBrush = new SolidBrush(Color.Yellow);
        Brush greenBrush = new SolidBrush(Color.Green);

        public void Sort(int[] Arr, System.Drawing.Graphics g, int maxVal, int eleWidth)
        {
            this.theArray = Arr;
            this.grapher = g;
            this.maxVal = maxVal;
            this.eleWidth = eleWidth;

            for (int time = 1; time <= theArray.Count() - 1; time++)
                for (int i = 0; i < theArray.Count() - time; i++)
                {
                    Mark(yellowBrush, i); Mark(yellowBrush, i + 1);
                    delayByCase(400);

                    if (theArray[i] > theArray[i + 1])
                        Swap(i, i+1);
                    else
                    {
                        Mark(whiteBrush, i); 
                        Mark(whiteBrush, i + 1);
                    }
                }
        }

        private void Swap(int i, int j)
        {
            Mark(redBrush, i); Mark(redBrush, j);
            delayByCase(400);

            int temp = theArray[i];
            theArray[i] = theArray[j];
            theArray[j] = temp;
            Del(i); Del(j);


            Mark(greenBrush, i); Mark(greenBrush, j);
            delayByCase(150);
            Mark(whiteBrush, i); Mark(whiteBrush, j);
        }

        private void delayByCase(int time)
        {
            /*Small case*/
            if (eleWidth >= 60)
                Thread.Sleep(time);
        }

        private void Mark(Brush br,int idx)
        {
            grapher.FillRectangle(br, idx * eleWidth, maxVal - theArray[idx], eleWidth, theArray[idx]);
        }

        private void Del(int idx)
        {
            grapher.FillRectangle(blackBrush, idx * eleWidth, 0, eleWidth, maxVal);
        }
    }
}
