using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SSAlgorithmVisualizer
{
    public class LinearSearchEngine : ISearchEngine
    {
        private int[] theArray;
        Graphics grapher;
        int maxVal; int eleWidth;
        Brush whiteBrush = new SolidBrush(Color.WhiteSmoke);
        Brush blackBrush = new SolidBrush(Color.Black);
        Brush redBrush = new SolidBrush(Color.DarkRed);
        Brush yellowBrush = new SolidBrush(Color.Yellow);
        Brush greenBrush = new SolidBrush(Color.Green);

        public void Search(int[] Arr, System.Drawing.Graphics g, int maxVal, int eleWidth,int valToSearch)
        {
            this.theArray = Arr;
            this.grapher = g;
            this.maxVal = maxVal;
            this.eleWidth = eleWidth;


            for (int i = 0; i < theArray.Count(); i++)
            {
                Mark(yellowBrush, i);
                delayByCase(200);
                if (theArray[i] == valToSearch)
                {
                    markFound(i);
                    MessageBox.Show("Found!!!");
                    return;
                }
                //still not found
                Mark(redBrush, i);
                delayByCase(200);
                Mark(whiteBrush, i);
            }
            //end of arr but not found the val
            MessageBox.Show("Not Found!!!");
        }

        private void markFound(int i)
        {
            for (int times = 1; times <= 3; times++)
            {
                Mark(greenBrush, i);
                Thread.Sleep(300);
                Del(i);
                Thread.Sleep(300);
            }
            Mark(greenBrush, i);
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
