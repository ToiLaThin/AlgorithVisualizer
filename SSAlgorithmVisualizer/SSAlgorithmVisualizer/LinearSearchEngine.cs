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
                grapher.FillRectangle(yellowBrush, i * eleWidth, maxVal - theArray[i], eleWidth, theArray[i]);
                if (eleWidth >= 60)
                    Thread.Sleep(200);
                if (theArray[i] == valToSearch)
                {

                    markFound(i);
                    MessageBox.Show("Found!!!");
                    return;
                }
                grapher.FillRectangle(redBrush, i * eleWidth, maxVal - theArray[i], eleWidth, theArray[i]);
                if (eleWidth >= 60)
                    Thread.Sleep(200);
                grapher.FillRectangle(whiteBrush, i * eleWidth, maxVal - theArray[i], eleWidth, theArray[i]);
            }
            MessageBox.Show("Not Found!!!");
        }

        private void markFound(int i)
        {
            for (int times = 1; times <= 3; times++)
            {
                grapher.FillRectangle(greenBrush, i * eleWidth, maxVal - theArray[i], eleWidth, theArray[i]);
                Thread.Sleep(300);
                grapher.FillRectangle(blackBrush, i * eleWidth, 0, eleWidth, maxVal);
                Thread.Sleep(300);
            }
            grapher.FillRectangle(greenBrush, i * eleWidth, maxVal - theArray[i], eleWidth, theArray[i]);
        }
    }
}
