
namespace OptionPricingModel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.trackBarV = new System.Windows.Forms.TrackBar();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarS = new System.Windows.Forms.TrackBar();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarK = new System.Windows.Forms.TrackBar();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarT = new System.Windows.Forms.TrackBar();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.textBoxBS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBarTS = new System.Windows.Forms.TrackBar();
            this.textBoxTS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarSim = new System.Windows.Forms.TrackBar();
            this.textBoxSim = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDelta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Volatility";
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(126, 17);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(125, 27);
            this.textBoxV.TabIndex = 1;
            this.textBoxV.Text = "0.03";
            this.textBoxV.TextChanged += new System.EventHandler(this.textBoxV_TextChanged);
            // 
            // trackBarV
            // 
            this.trackBarV.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBarV.Location = new System.Drawing.Point(258, 15);
            this.trackBarV.Maximum = 100;
            this.trackBarV.Name = "trackBarV";
            this.trackBarV.Size = new System.Drawing.Size(130, 56);
            this.trackBarV.TabIndex = 2;
            this.trackBarV.Value = 3;
            this.trackBarV.Scroll += new System.EventHandler(this.trackBarV_Scroll);
            // 
            // trackBarR
            // 
            this.trackBarR.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBarR.Location = new System.Drawing.Point(258, 49);
            this.trackBarR.Maximum = 100;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Size = new System.Drawing.Size(130, 56);
            this.trackBarR.TabIndex = 5;
            this.trackBarR.Value = 1;
            this.trackBarR.Scroll += new System.EventHandler(this.trackBarR_Scroll);
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(126, 50);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(125, 27);
            this.textBoxR.TabIndex = 4;
            this.textBoxR.Text = "0.01";
            this.textBoxR.TextChanged += new System.EventHandler(this.textBoxR_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rates";
            // 
            // trackBarS
            // 
            this.trackBarS.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBarS.Location = new System.Drawing.Point(258, 83);
            this.trackBarS.Maximum = 100;
            this.trackBarS.Name = "trackBarS";
            this.trackBarS.Size = new System.Drawing.Size(130, 56);
            this.trackBarS.TabIndex = 8;
            this.trackBarS.Value = 10;
            this.trackBarS.Scroll += new System.EventHandler(this.trackBarS_Scroll);
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(126, 83);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(125, 27);
            this.textBoxS.TabIndex = 7;
            this.textBoxS.Text = "100";
            this.textBoxS.TextChanged += new System.EventHandler(this.textBoxS_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Spot";
            // 
            // trackBarK
            // 
            this.trackBarK.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBarK.Location = new System.Drawing.Point(258, 117);
            this.trackBarK.Maximum = 100;
            this.trackBarK.Name = "trackBarK";
            this.trackBarK.Size = new System.Drawing.Size(130, 56);
            this.trackBarK.TabIndex = 11;
            this.trackBarK.Value = 10;
            this.trackBarK.Scroll += new System.EventHandler(this.trackBarK_Scroll);
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(126, 116);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(125, 27);
            this.textBoxK.TabIndex = 10;
            this.textBoxK.Text = "100";
            this.textBoxK.TextChanged += new System.EventHandler(this.textBoxK_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Strike";
            // 
            // trackBarT
            // 
            this.trackBarT.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBarT.Location = new System.Drawing.Point(259, 149);
            this.trackBarT.Minimum = 1;
            this.trackBarT.Name = "trackBarT";
            this.trackBarT.Size = new System.Drawing.Size(130, 56);
            this.trackBarT.TabIndex = 14;
            this.trackBarT.Value = 1;
            this.trackBarT.Scroll += new System.EventHandler(this.trackBarT_Scroll);
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(126, 149);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(125, 27);
            this.textBoxT.TabIndex = 13;
            this.textBoxT.Text = "1";
            this.textBoxT.TextChanged += new System.EventHandler(this.textBoxT_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Years to Expiry";
            // 
            // plotView1
            // 
            this.plotView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotView1.Location = new System.Drawing.Point(418, 19);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(646, 406);
            this.plotView1.TabIndex = 15;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // textBoxBS
            // 
            this.textBoxBS.Location = new System.Drawing.Point(126, 260);
            this.textBoxBS.Name = "textBoxBS";
            this.textBoxBS.ReadOnly = true;
            this.textBoxBS.Size = new System.Drawing.Size(125, 27);
            this.textBoxBS.TabIndex = 18;
            this.textBoxBS.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Location = new System.Drawing.Point(16, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Black Scholes";
            // 
            // textBoxMC
            // 
            this.textBoxMC.Location = new System.Drawing.Point(126, 293);
            this.textBoxMC.Name = "textBoxMC";
            this.textBoxMC.ReadOnly = true;
            this.textBoxMC.Size = new System.Drawing.Size(125, 27);
            this.textBoxMC.TabIndex = 20;
            this.textBoxMC.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Monte Carlo";
            // 
            // trackBarTS
            // 
            this.trackBarTS.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBarTS.Location = new System.Drawing.Point(258, 181);
            this.trackBarTS.Maximum = 1000;
            this.trackBarTS.Minimum = 1;
            this.trackBarTS.Name = "trackBarTS";
            this.trackBarTS.Size = new System.Drawing.Size(130, 56);
            this.trackBarTS.TabIndex = 23;
            this.trackBarTS.Value = 1;
            this.trackBarTS.Scroll += new System.EventHandler(this.trackBarTS_Scroll);
            // 
            // textBoxTS
            // 
            this.textBoxTS.Location = new System.Drawing.Point(126, 182);
            this.textBoxTS.Name = "textBoxTS";
            this.textBoxTS.Size = new System.Drawing.Size(125, 27);
            this.textBoxTS.TabIndex = 22;
            this.textBoxTS.Text = "0.001";
            this.textBoxTS.TextChanged += new System.EventHandler(this.textBoxTS_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Time Step";
            // 
            // trackBarSim
            // 
            this.trackBarSim.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBarSim.Location = new System.Drawing.Point(258, 214);
            this.trackBarSim.Maximum = 20;
            this.trackBarSim.Name = "trackBarSim";
            this.trackBarSim.Size = new System.Drawing.Size(130, 56);
            this.trackBarSim.TabIndex = 26;
            this.trackBarSim.Value = 4;
            this.trackBarSim.Scroll += new System.EventHandler(this.trackBarSim_Scroll);
            // 
            // textBoxSim
            // 
            this.textBoxSim.Location = new System.Drawing.Point(126, 215);
            this.textBoxSim.Name = "textBoxSim";
            this.textBoxSim.Size = new System.Drawing.Size(125, 27);
            this.textBoxSim.TabIndex = 25;
            this.textBoxSim.Text = "16";
            this.textBoxSim.TextChanged += new System.EventHandler(this.textBoxSim_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Simulations";
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.Location = new System.Drawing.Point(126, 326);
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.ReadOnly = true;
            this.textBoxDelta.Size = new System.Drawing.Size(125, 27);
            this.textBoxDelta.TabIndex = 28;
            this.textBoxDelta.Text = "10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Delta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 537);
            this.Controls.Add(this.textBoxDelta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.trackBarSim);
            this.Controls.Add(this.textBoxSim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trackBarTS);
            this.Controls.Add(this.textBoxTS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxMC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxBS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.trackBarT);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBarK);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBarS);
            this.Controls.Add(this.textBoxS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarR);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarV);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1113, 584);
            this.Name = "Form1";
            this.Text = "Option Pricing Model";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.TrackBar trackBarV;
        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarS;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarK;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarT;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.Label label5;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.TextBox textBoxBS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBarTS;
        private System.Windows.Forms.TextBox textBoxTS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBarSim;
        private System.Windows.Forms.TextBox textBoxSim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDelta;
        private System.Windows.Forms.Label label10;
    }
}

