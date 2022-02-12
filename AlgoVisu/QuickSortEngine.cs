using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SSAlgorithmVisualizer
{
    class QuickSortEngine : ISortEngine
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
            quickSort(theArray, grapher, maxVal, eleWidth, 0, theArray.Length - 1);
        }

        private void quickSort(int[] Arr, System.Drawing.Graphics g, int maxVal, int eleWidth,int left,int right)
        {
            int i = left, j = right, pivot = Arr[(left + right) / 2];
            /*Mark the region of processing and return it to white color after 0.2s*/
            Mark(yellowBrush, left);
            Mark(yellowBrush, right);
            Mark(redBrush, (left + right) / 2);
            Thread.Sleep(200);
            Mark(whiteBrush, left);
            Mark(whiteBrush, right);
            Mark(whiteBrush, (left + right) / 2);


	        while(i<=j)
	        {
                while (Arr[i] < pivot) i++;
                while (Arr[j] > pivot) j--;
		        if (i <= j){
                    Del(i);
                    Del(j);
			        Swap(ref Arr[i],ref Arr[j]);
                    Mark(whiteBrush, i);
                    Mark(whiteBrush, j);
			        i++; j--;
		        }
	        }
            if (i < right)
                quickSort(Arr, g, maxVal, eleWidth, i, right);
	        if (j > left)
                quickSort(Arr, g, maxVal, eleWidth, left, j);

            /*Mark the region of processing green,which means it sorted*/
            Mark(greenBrush, left);
            Mark(greenBrush, right);
            Thread.Sleep(600);
            Mark(whiteBrush, left);
            Mark(whiteBrush, right);

        }

        private void Swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
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
