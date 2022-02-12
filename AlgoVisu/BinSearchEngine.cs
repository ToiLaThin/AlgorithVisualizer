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
                Mark(yellowBrush, left); Mark(yellowBrush, right);
                mid = (left + right) / 2;
                if (valToSearch == theArray[mid])
                {
                    markFound(mid);
                    //tra lai hai moc left right ve binh thuong
                    Mark(whiteBrush, left); 
                    Mark(whiteBrush, right);
                    MessageBox.Show("Found!!!");
                    return;
                }
                else if (valToSearch < theArray[mid])
                {
                    markNotFound(mid);
                    //tra lai hai moc left right ve binh thuong
                    Mark(whiteBrush, left);
                    Mark(whiteBrush, right);
                    right = mid - 1;
                }
                else if (valToSearch > theArray[mid])
                {
                    markNotFound(mid);
                    //tra lai hai moc left right ve binh thuong
                    Mark(whiteBrush, left);
                    Mark(whiteBrush, right);
                    left = mid + 1;
                }
            }
            MessageBox.Show("Not Found!!!");
        }

        //TODO neu mang nho thi ko can sleep
        private void markFound(int i)
        {
            for (int times = 1; times <= 3; times++)
            {
                Mark(greenBrush, i);
                delayByCase(300);
                Del(i);
                delayByCase(300);
            }
            Mark(whiteBrush, i);
        }

        private void markNotFound(int i)
        {
            for (int times = 1; times <= 3; times++)
            {
                Mark(redBrush, i);
                delayByCase(300);
                Del(i);
                delayByCase(300);
            }
            Mark(whiteBrush, i);
        }

        private void delayByCase(int time)
        {
            /*Large case and medium case*/
            if (eleWidth < 60)
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
