using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SSAlgorithmVisualizer
{
    class SelectionSortEngine : ISortEngine
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
            for (int i = 0; i < theArray.Length - 1; i++)
                for (int j = i + 1; j < theArray.Length; j++)
                {
                    Mark(yellowBrush, j);
                    delayByCase(400);
                    Mark(whiteBrush, j);
                    if (theArray[i] > theArray[j])
                        Swap(i, j);
                }
        }
        private void Swap(int i,int j)
        {
            Mark(redBrush, j);
            delayByCase(400);
            /*Delete to be redrawn*/
            Del(i); Del(j);

            int temp = theArray[i];
            theArray[i] = theArray[j];
            theArray[j] = temp;


            Mark(whiteBrush, j);

            //Redraw the array[i] and mark them with green color and then return to white 
            Mark(greenBrush, i);
            delayByCase(400);
            Mark(whiteBrush, i);

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
