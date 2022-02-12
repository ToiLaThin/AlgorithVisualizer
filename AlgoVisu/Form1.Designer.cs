namespace SSAlgorithmVisualizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlScreen = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSearch = new System.Windows.Forms.Label();
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.clbTestSize = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbbSelectAlgo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlScreen
            // 
            this.pnlScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlScreen.BackColor = System.Drawing.Color.Black;
            this.pnlScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlScreen.Location = new System.Drawing.Point(14, 80);
            this.pnlScreen.Name = "pnlScreen";
            this.pnlScreen.Size = new System.Drawing.Size(372, 275);
            this.pnlScreen.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbSearch);
            this.panel1.Controls.Add(this.txtbSearch);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.clbTestSize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.cbbSelectAlgo);
            this.panel1.Controls.Add(this.pnlScreen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 358);
            this.panel1.TabIndex = 0;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(12, 57);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(44, 13);
            this.lbSearch.TabIndex = 16;
            this.lbSearch.Text = "Search:";
            // 
            // txtbSearch
            // 
            this.txtbSearch.Location = new System.Drawing.Point(62, 54);
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(35, 20);
            this.txtbSearch.TabIndex = 15;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(250, 34);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(136, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Visualize!!!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // clbTestSize
            // 
            this.clbTestSize.BackColor = System.Drawing.SystemColors.Control;
            this.clbTestSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbTestSize.CheckOnClick = true;
            this.clbTestSize.FormattingEnabled = true;
            this.clbTestSize.Items.AddRange(new object[] {
            "Large",
            "Medium",
            "Small"});
            this.clbTestSize.Location = new System.Drawing.Point(164, 19);
            this.clbTestSize.Name = "clbTestSize";
            this.clbTestSize.Size = new System.Drawing.Size(80, 45);
            this.clbTestSize.TabIndex = 13;
            this.clbTestSize.ThreeDCheckBoxes = true;
            this.clbTestSize.SelectedIndexChanged += new System.EventHandler(this.clbTestSize_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Array Size :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Algorithm:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(250, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbbSelectAlgo
            // 
            this.cbbSelectAlgo.FormattingEnabled = true;
            this.cbbSelectAlgo.Items.AddRange(new object[] {
            "LinearSearch",
            "BinarySearch",
            "BubleSort",
            "SelectionSort",
            "InsertionSort",
            "QuickSort",
            "MergeSort"});
            this.cbbSelectAlgo.Location = new System.Drawing.Point(14, 26);
            this.cbbSelectAlgo.Name = "cbbSelectAlgo";
            this.cbbSelectAlgo.Size = new System.Drawing.Size(121, 21);
            this.cbbSelectAlgo.TabIndex = 9;
            this.cbbSelectAlgo.SelectedIndexChanged += new System.EventHandler(this.cbbSelectAlgo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(399, 358);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "SSAlgorithmVisualizer";
            this.Resize += new System.EventHandler(this.btnReset_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlScreen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckedListBox clbTestSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbbSelectAlgo;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtbSearch;
    }
}

