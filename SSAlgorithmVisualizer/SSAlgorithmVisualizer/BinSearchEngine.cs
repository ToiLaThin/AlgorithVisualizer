using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SSAlgorithmVisualizer
{
    public class BinSearchEngine : ISearchEngine
    {
        private int[] theArray;
        Graphics grapher;
        int maxVal; int eleWidth;
        Brush whiteBrush = new SolidBrush(Color.WhiteSmoke);
        Brush blackBrush = new SolidBrush(Color.Black);
        Brush redBrush = new SolidBrush(Color.DarkRed);
        Brush yellowBrush = new SolidBrush(Color.Yellow);
        Brush greenBrush = new SolidBrush(Color.Green);


        public void Search(int[] Arr, System.Drawing.Graphics g, int maxVal, int eleWidth, int valToSearch)
        {
            this.theArray = Arr;
            this.grapher = g;
            this.maxVal = maxVal;
            this.eleWidth = eleWidth;

            int left = 0; 
            int right = theArray.Count()-1;
            int mid;
            while (left<=right)
            {
                //danh dau 2 moc left right
                grapher.FillRectangle(yellowBrush, left * eleWidth, maxVal - theArray[left], eleWidth, theArray[left]);
                grapher.FillRectangle(yellowBrush, right * eleWidth, maxVal - theArray[right], eleWidth, theArray[right]);
                mid = (left + right) / 2;
                if (valToSearch == theArray[mid])
                {
                    markFound(mid);
                    //tra lai hai moc left right ve binh thuong
                    grapher.FillRectangle(whiteBrush, left * eleWidth, maxVal - theArray[left], eleWidth, theArray[left]);
                    grapher.FillRectangle(whiteBrush, right * eleWidth, maxVal - theArray[right], eleWidth, theArray[right]);
                    MessageBox.Show("Found!!!");
                    return;
                }
                else if (valToSearch < theArray[mid])
                {
                    markNotFound(mid);
                    //tra lai hai moc left right ve binh thuong
                    grapher.FillRectangle(whiteBrush, left * eleWidth, maxVal - theArray[left], eleWidth, theArray[left]);
                    grapher.FillRectangle(whiteBrush, right * eleWidth, maxVal - theArray[right], eleWidth, theArray[right]);
                    right = mid - 1;
                }
                else if (valToSearch > theArray[mid])
                {
                    markNotFound(mid);
                    //tra lai hai moc left right ve binh thuong
                    grapher.FillRectangle(whiteBrush, left * eleWidth, maxVal - theArray[left], eleWidth, theArray[left]);
                    grapher.FillRectangle(whiteBrush, right * eleWidth, maxVal - theArray[right], eleWidth, theArray[right]);
                    left = mid + 1;
                }
            }
            MessageBox.Show("Not Found!!!");
        }
        //TODO neu mang lon thi ko can sleep
        private void markFound(int i)
        {
            for (int times = 1; times <= 3; times++)
            {
                grapher.FillRectangle(greenBrush, i * eleWidth, maxVal - theArray[i], eleWidth, theArray[i]);
                if(eleWidth!=2)
                    Thread.Sleep(300);
                grapher.FillRectangle(blackBrush, i * eleWidth, 0, eleWidth, maxVal);
                if (eleWidth != 2)
                    Thread.Sleep(300);
            }
            grapher.FillRectangle(whiteBrush, i * eleWidth, maxVal - theArray[i], eleWidth, theArray[i]);
        }
        private void markNotFound(int i)
        {
            for (int times = 1; times <= 3; times++)
            {
                grapher.FillRectangle(redBrush, i * eleWidth, maxVal - theArray[i], eleWidth, theArray[i]);
                if (eleWidth != 2)
                    Thread.Sleep(300);
                grapher.FillRectangle(blackBrush, i * eleWidth, 0, eleWidth, maxVal);
                if (eleWidth != 2)
                    Thread.Sleep(300);
            }
            grapher.FillRectangle(whiteBrush, i * eleWidth, maxVal - theArray[i], eleWidth, theArray[i]);
        }
    }
}
