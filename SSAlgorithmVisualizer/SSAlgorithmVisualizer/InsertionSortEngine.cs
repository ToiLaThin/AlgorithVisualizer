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

            for(int pos=1;pos<theArray.Count();pos++)
            {
                int x = theArray[pos];
                grapher.FillRectangle(yellowBrush, pos * eleWidth, maxVal - x, eleWidth, x);
                if (eleWidth >= 60)
                    Thread.Sleep(400);
                int j = pos - 1;
                while (j >= 0 && x < theArray[j]) 
                {
                    theArray[j + 1] = theArray[j];
                    grapher.FillRectangle(blackBrush, (j + 1) * eleWidth, 0, eleWidth, maxVal);
                    grapher.FillRectangle(whiteBrush, (j + 1) * eleWidth, maxVal - theArray[j + 1], eleWidth, theArray[j + 1]);
                    j--;
                }
                theArray[j + 1] = x;
                grapher.FillRectangle(blackBrush, (j + 1) * eleWidth, 0, eleWidth, maxVal);
                grapher.FillRectangle(greenBrush, (j + 1) * eleWidth, maxVal - x, eleWidth, x);
                if (eleWidth >= 60)
                    Thread.Sleep(400);
                grapher.FillRectangle(whiteBrush, (j + 1) * eleWidth, maxVal - x, eleWidth, x);

            }
        }

        private void Swap(int i, int j)
        {
            grapher.FillRectangle(redBrush, i * eleWidth, maxVal - theArray[i], eleWidth, maxVal);
            grapher.FillRectangle(redBrush, j * eleWidth, maxVal - theArray[j], eleWidth, maxVal);
            if (eleWidth >= 60)
                Thread.Sleep(400);

            int temp = theArray[i];
            theArray[i] = theArray[j];
            theArray[j] = temp;
            grapher.FillRectangle(blackBrush, i * eleWidth, 0, eleWidth, maxVal);
            grapher.FillRectangle(blackBrush, j * eleWidth, 0, eleWidth, maxVal);


            grapher.FillRectangle(greenBrush, i * eleWidth, maxVal - theArray[i], eleWidth, maxVal);
            grapher.FillRectangle(greenBrush, j * eleWidth, maxVal - theArray[j], eleWidth, maxVal);
            if (eleWidth >= 60)
                Thread.Sleep(150);

            grapher.FillRectangle(whiteBrush, i * eleWidth, maxVal - theArray[i], eleWidth, maxVal);
            grapher.FillRectangle(whiteBrush, j * eleWidth, maxVal - theArray[j], eleWidth, maxVal);


        }
    }
}
