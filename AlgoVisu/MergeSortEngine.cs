using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SSAlgorithmVisualizer
{
    class MergeSortEngine : ISortEngine
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
            mergeSort(theArray, grapher, maxVal, eleWidth, 0, theArray.Length - 1);
        }

        private void mergeSort(int[] Arr, System.Drawing.Graphics g, int maxVal, int eleWidth,int start,int end)
        {
            if (start == end)
                return;
            else
            {
                /*Mark the region of processing and return it to white color after 0.2s*/
                Mark(yellowBrush, start);
                Mark(yellowBrush, end);
                Thread.Sleep(500);
                Mark(whiteBrush, start);
                Mark(whiteBrush, end);


                int mid = (start + end) / 2;
                mergeSort(theArray,grapher,maxVal,eleWidth,start,mid);
                mergeSort(theArray, grapher, maxVal, eleWidth, mid + 1, end);
                merge(theArray, grapher, maxVal, eleWidth, start, mid, end);

                /*Mark the region of processing green,which means it sorted*/
                MarkFrom(greenBrush, start, end);
                Thread.Sleep(600);
                MarkFrom(whiteBrush, start, end);
            }
        }

        private void merge(int[] Arr, System.Drawing.Graphics g, int maxVal, int eleWidth,int start,int mid,int end)
        {
            int i = start; int j = mid + 1; int k = start;
            int[] tempArr = new int[Arr.Length];

            while (k <= end)
            {
                if (i == mid + 1){
                    for (int tempIdx = j; tempIdx <= end; tempIdx++)
                    {
                        tempArr[k] = Arr[tempIdx];
                        k++;
                    }
                    break;
                }
                else if (j == end + 1){
                    for (int tempIdx = i; tempIdx <= mid; tempIdx++)
                    {
                        tempArr[k] = Arr[tempIdx];
                        k++;
                    }
                    break;
                }

                if (Arr[i] <= Arr[j]) { tempArr[k] = Arr[i]; i++; }
                else if (Arr[j] < Arr[i]) { tempArr[k] = Arr[j]; j++; }
                k++;
            }

            for (int tempIdx = start; tempIdx < end + 1; tempIdx++)
            {
                Del(tempIdx);
                Arr[tempIdx] = tempArr[tempIdx];
                Mark(whiteBrush, tempIdx);
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

        private void MarkFrom(Brush br,int fr,int to)
        {
            for (int idx = fr; idx <= to; idx++)
                Mark(br, idx);
        }

        private void Del(int idx)
        {
            grapher.FillRectangle(blackBrush, idx * eleWidth, 0, eleWidth, maxVal);
        }
    }
}
