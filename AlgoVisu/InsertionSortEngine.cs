using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

namespace SSAlgorithmVisualizer
{
    public class InsertionSortEngine : ISortEngine
    {
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

            for (int pos = 1; pos < theArray.Count(); pos++) 
            {
                int x = theArray[pos];
                grapher.FillRectangle(yellowBrush, pos * eleWidth, maxVal - x, eleWidth, x);
                delayByCase(400);
                int j = pos - 1;
                while (j >= 0 && x < theArray[j]) 
                {
                    theArray[j + 1] = theArray[j];
                    Del(j + 1);
                    grapher.FillRectangle(whiteBrush, (j + 1) * eleWidth, maxVal - theArray[j + 1], eleWidth, theArray[j + 1]);
                    j--;
                }
                theArray[j + 1] = x;
                Del(j + 1);
                grapher.FillRectangle(greenBrush, (j + 1) * eleWidth, maxVal - x, eleWidth, x);
                delayByCase(400);
                grapher.FillRectangle(whiteBrush, (j + 1) * eleWidth, maxVal - x, eleWidth, x);
            }
        }

        private void delayByCase(int time)
        {
            /*Small case*/
            if (eleWidth >= 60)
                Thread.Sleep(time);
        }

        private void Mark(Brush br, int idx)
        {
            grapher.FillRectangle(br, idx * eleWidth, maxVal - theArray[idx], eleWidth, theArray[idx]);
        }

        private void Del(int idx)
        {
            grapher.FillRectangle(blackBrush, idx * eleWidth, 0, eleWidth, maxVal);
        }
    }
}
