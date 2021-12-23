/* Original idea: https://www.youtube.com/watch?v=n5zUCyLe9ks */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSAlgorithmVisualizer
{
    public partial class Form1 : Form
    {
        Random rander = default(Random);
        Graphics grapher;
        int[] theArray;
        int eleWidth;
        bool isSorted;
        public Form1()
        {
            InitializeComponent();
            clbTestSize.SelectedIndex = 0;
            cbbSelectAlgo.SelectedIndex = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pnlScreen.Refresh();
            grapher = pnlScreen.CreateGraphics();
            rander=new Random();
            switch (clbTestSize.SelectedItem.ToString())
            {
                case "Large":
                    eleWidth = 2;
                    break;
                case "Medium":
                    eleWidth = pnlScreen.Width / 50;
                    break;
                case "Small":
                    eleWidth = pnlScreen.Width / 6;
                    break;
                default:
                    eleWidth = pnlScreen.Width / 20;
                    break;
            }
            int maxVal = pnlScreen.Height;
            int numEle = pnlScreen.Width / eleWidth;
            theArray = new int[numEle];
            for(int i=0;i<numEle;i++)
            {
                theArray[i] = rander.Next(0, maxVal);
                grapher.FillRectangle(new SolidBrush(Color.WhiteSmoke), i * eleWidth, maxVal - theArray[i], eleWidth, maxVal);
            }
            //cho biet mang da sort hay chua
            //true: sau khi thuc hien algo sort
            //false reset event handler
            isSorted = false;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            switch (cbbSelectAlgo.SelectedItem.ToString())
            {
                case "LinearSearch":
                    LinearSearchEngine lse = new LinearSearchEngine();
                    try
                    {
                        lse.Search(theArray,grapher,pnlScreen.Height,eleWidth,Convert.ToInt32(txtbSearch.Text));
                    }
                    catch (Exception err) { MessageBox.Show(err.Message); }
                    break;
                case "BinarySearch":
                    if (isSorted)//chi thuc hien sau khi mang da sap xep
                    {
                        BinSearchEngine bse = new BinSearchEngine();
                        try
                        {
                            bse.Search(theArray, grapher, pnlScreen.Height, eleWidth, Convert.ToInt32(txtbSearch.Text));
                        }
                        catch (Exception err) { MessageBox.Show(err.Message); }
                    }
                    else
                        MessageBox.Show("Sort First!!!");
                    break;
                case "SelectionSort":
                    SelectionSortEngine se = new SelectionSortEngine();
                    se.Sort(theArray, grapher, pnlScreen.Height, eleWidth);
                    isSorted = true;
                    break;
                case "BubleSort":
                    BubleSortEngine be = new BubleSortEngine();
                    be.Sort(theArray, grapher, pnlScreen.Height, eleWidth);
                    isSorted = true;
                    break;
                case "InsertionSort":
                    InsertionSortEngine ie = new InsertionSortEngine();
                    ie.Sort(theArray, grapher, pnlScreen.Height, eleWidth);
                    isSorted = true;
                    break;
                case "QuickSort":
                    QuickSortEngine qe = new QuickSortEngine();
                    qe.Sort(theArray, grapher, pnlScreen.Height, eleWidth);
                    isSorted = true;
                    break;
            }
        }

        //chi cho phep 1 check 
        private void clbTestSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idxToCheck=clbTestSize.SelectedIndex;
            for (int idx = 0; idx < clbTestSize.Items.Count; idx++)
                clbTestSize.SetItemChecked(idx, false);
            clbTestSize.SetItemChecked(idxToCheck, true);

            btnReset_Click(sender, e);
        }

        //neu chon thuat toan tim kiem thi se co o de nhap gia tri can tim
        private void cbbSelectAlgo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSelectAlgo.SelectedItem.ToString().Contains("Search"))
            {
                this.lbSearch.Visible = true;
                this.txtbSearch.Visible = true;
                this.txtbSearch.Text = "2";
            }
            else
            {
                this.lbSearch.Visible = false;
                this.txtbSearch.Visible = false;
            }
        }

    }
}
