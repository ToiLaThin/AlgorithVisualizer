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
                    grapher.FillRectangle(yellowBrush, i * eleWidth, maxVal - theArray[i], eleWidth, theArray[i]);
                    grapher.FillRectangle(yellowBrush, (i + 1) * eleWidth, maxVal - theArray[i + 1], eleWidth, theArray[i + 1]);
                    if (eleWidth >= 60)
                        Thread.Sleep(400);

                    if (theArray[i] > theArray[i + 1])
                        Swap(i, i+1);
                    else
                    {
                        grapher.FillRectangle(whiteBrush, i * eleWidth, maxVal - theArray[i], eleWidth, theArray[i]);
                        grapher.FillRectangle(whiteBrush, (i + 1) * eleWidth, maxVal - theArray[i + 1], eleWidth, theArray[i + 1]);
                    }

                }
        }

        private void Swap(int i, int j)
        {
            grapher.FillRectangle(redBrush, i * eleWidth, maxVal - theArray[i], eleWidth, theArray[i]);
            grapher.FillRectangle(redBrush, j * eleWidth, maxVal - theArray[j], eleWidth, theArray[j]);
            if (eleWidth >= 60)
                Thread.Sleep(400);

            int temp = theArray[i];
            theArray[i] = theArray[j];
            theArray[j] = temp;
            grapher.FillRectangle(blackBrush, i * eleWidth, 0, eleWidth, maxVal);
            grapher.FillRectangle(blackBrush, j * eleWidth, 0, eleWidth, maxVal);


            grapher.FillRectangle(greenBrush, i * eleWidth, maxVal - theArray[i], eleWidth, theArray[i]);
            grapher.FillRectangle(greenBrush, j * eleWidth, maxVal - theArray[j], eleWidth, theArray[j]);
            if (eleWidth >= 60)
                Thread.Sleep(150);

            grapher.FillRectangle(whiteBrush, i * eleWidth, maxVal - theArray[i], eleWidth, theArray[i]);
            grapher.FillRectangle(whiteBrush, j * eleWidth, maxVal - theArray[j], eleWidth, theArray[j]);


        }
    }
}
