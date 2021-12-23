using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SSAlgorithmVisualizer
{
    public interface ISearchEngine
    {
        void Search(int[] Arr, Graphics g, int maxVal, int eleWidth,int valToSearch);
    }
}
