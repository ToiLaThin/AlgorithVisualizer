using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAlgorithmVisualizer
{
    public interface ISortEngine
    {
        void Sort(int[] Arr, Graphics g, int maxVal,int eleWidth);
    }
}
