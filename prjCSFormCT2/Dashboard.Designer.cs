namespace prjCSFormCT2
{
    partial class Dashboard
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
            this.menuTabBox = new System.Windows.Forms.TabControl();
            this.genTab = new System.Windows.Forms.TabPage();
            this.gboxLotto = new System.Windows.Forms.GroupBox();
            this.labelLotto649 = new System.Windows.Forms.Label();
            this.labelLottoMax = new System.Windows.Forms.Label();
            this.btnLotto649 = new System.Windows.Forms.Button();
            this.btnLottoMax = new System.Windows.Forms.Button();
            this.convTab = new System.Windows.Forms.TabPage();
            this.gBoxConversion = new System.Windows.Forms.GroupBox();
            this.labelTempConv = new System.Windows.Forms.Label();
            this.labelMExchange = new System.Windows.Forms.Label();
            this.btnTempConv = new System.Windows.Forms.Button();
            this.btnMExhange = new System.Windows.Forms.Button();
            this.calcTab = new System.Windows.Forms.TabPage();
            this.btnCalc = new System.Windows.Forms.Button();
            this.ipValTab = new System.Windows.Forms.TabPage();
            this.ipValidbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.menuTabBox.SuspendLayout();
            this.genTab.SuspendLayout();
            this.gboxLotto.SuspendLayout();
            this.convTab.SuspendLayout();
            this.gBoxConversion.SuspendLayout();
            this.calcTab.SuspendLayout();
            this.ipValTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTabBox
            // 
            this.menuTabBox.Controls.Add(this.genTab);
            this.menuTabBox.Controls.Add(this.convTab);
            this.menuTabBox.Controls.Add(this.calcTab);
            this.menuTabBox.Controls.Add(this.ipValTab);
            this.menuTabBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTabBox.Location = new System.Drawing.Point(43, 30);
            this.menuTabBox.Name = "menuTabBox";
            this.menuTabBox.SelectedIndex = 0;
            this.menuTabBox.Size = new System.Drawing.Size(680, 410);
            this.menuTabBox.TabIndex = 2;
            // 
            // genTab
            // 
            this.genTab.Controls.Add(this.gboxLotto);
            this.genTab.Location = new System.Drawing.Point(4, 27);
            this.genTab.Name = "genTab";
            this.genTab.Padding = new System.Windows.Forms.Padding(3);
            this.genTab.Size = new System.Drawing.Size(672, 379);
            this.genTab.TabIndex = 0;
            this.genTab.Text = "Generated Numbers";
            this.genTab.UseVisualStyleBackColor = true;
            // 
            // gboxLotto
            // 
            this.gboxLotto.Controls.Add(this.labelLotto649);
            this.gboxLotto.Controls.Add(this.labelLottoMax);
            this.gboxLotto.Controls.Add(this.btnLotto649);
            this.gboxLotto.Controls.Add(this.btnLottoMax);
            this.gboxLotto.Location = new System.Drawing.Point(58, 30);
            this.gboxLotto.Name = "gboxLotto";
            this.gboxLotto.Size = new System.Drawing.Size(550, 301);
            this.gboxLotto.TabIndex = 0;
            this.gboxLotto.TabStop = false;
            this.gboxLotto.Text = "Lotto";
            // 
            // labelLotto649
            // 
            this.labelLotto649.AutoSize = true;
            this.labelLotto649.Location = new System.Drawing.Point(344, 240);
            this.labelLotto649.Name = "labelLotto649";
            this.labelLotto649.Size = new System.Drawing.Size(66, 18);
            this.labelLotto649.TabIndex = 3;
            this.labelLotto649.Text = "Lotto649";
            // 
            // labelLottoMax
            // 
            this.labelLottoMax.AutoSize = true;
            this.labelLottoMax.Location = new System.Drawing.Point(118, 240);
            this.labelLottoMax.Name = "labelLottoMax";
            this.labelLottoMax.Size = new System.Drawing.Size(74, 18);
            this.labelLottoMax.TabIndex = 2;
            this.labelLottoMax.Text = "Lotto Max";
            // 
            // btnLotto649
            // 
            this.btnLotto649.BackgroundImage = global::prjCSFormCT2.Properties.Resources.Lotto649;
            this.btnLotto649.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLotto649.Location = new System.Drawing.Point(297, 61);
            this.btnLotto649.Name = "btnLotto649";
            this.btnLotto649.Size = new System.Drawing.Size(173, 167);
            this.btnLotto649.TabIndex = 1;
            this.btnLotto649.UseVisualStyleBackColor = true;
            this.btnLotto649.Click += new System.EventHandler(this.btnLotto649_Click);
            // 
            // btnLottoMax
            // 
            this.btnLottoMax.BackgroundImage = global::prjCSFormCT2.Properties.Resources.LottoMax;
            this.btnLottoMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLottoMax.Location = new System.Drawing.Point(75, 61);
            this.btnLottoMax.Name = "btnLottoMax";
            this.btnLottoMax.Size = new System.Drawing.Size(173, 167);
            this.btnLottoMax.TabIndex = 0;
            this.btnLottoMax.UseVisualStyleBackColor = true;
            this.btnLottoMax.Click += new System.EventHandler(this.btnLottoMax_Click);
            // 
            // convTab
            // 
            this.convTab.Controls.Add(this.gBoxConversion);
            this.convTab.Location = new System.Drawing.Point(4, 27);
            this.convTab.Name = "convTab";
            this.convTab.Padding = new System.Windows.Forms.Padding(3);
            this.convTab.Size = new System.Drawing.Size(672, 379);
            this.convTab.TabIndex = 1;
            this.convTab.Text = "Conversions";
            this.convTab.UseVisualStyleBackColor = true;
            // 
            // gBoxConversion
            // 
            this.gBoxConversion.Controls.Add(this.labelTempConv);
            this.gBoxConversion.Controls.Add(this.labelMExchange);
            this.gBoxConversion.Controls.Add(this.btnTempConv);
            this.gBoxConversion.Controls.Add(this.btnMExhange);
            this.gBoxConversion.Location = new System.Drawing.Point(58, 30);
            this.gBoxConversion.Name = "gBoxConversion";
            this.gBoxConversion.Size = new System.Drawing.Size(550, 301);
            this.gBoxConversion.TabIndex = 1;
            this.gBoxConversion.TabStop = false;
            this.gBoxConversion.Text = "Conversion";
            // 
            // labelTempConv
            // 
            this.labelTempConv.AutoSize = true;
            this.labelTempConv.Location = new System.Drawing.Point(311, 240);
            this.labelTempConv.Name = "labelTempConv";
            this.labelTempConv.Size = new System.Drawing.Size(148, 18);
            this.labelTempConv.TabIndex = 3;
            this.labelTempConv.Text = "Temperature Convert";
            // 
            // labelMExchange
            // 
            this.labelMExchange.AutoSize = true;
            this.labelMExchange.Location = new System.Drawing.Point(102, 240);
            this.labelMExchange.Name = "labelMExchange";
            this.labelMExchange.Size = new System.Drawing.Size(122, 18);
            this.labelMExchange.TabIndex = 2;
            this.labelMExchange.Text = "Money Exchange";
            // 
            // btnTempConv
            // 
            this.btnTempConv.BackgroundImage = global::prjCSFormCT2.Properties.Resources.tempConvert;
            this.btnTempConv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTempConv.Location = new System.Drawing.Point(297, 61);
            this.btnTempConv.Name = "btnTempConv";
            this.btnTempConv.Size = new System.Drawing.Size(173, 167);
            this.btnTempConv.TabIndex = 1;
            this.btnTempConv.UseVisualStyleBackColor = true;
            this.btnTempConv.Click += new System.EventHandler(this.btnTempConv_Click);
            // 
            // btnMExhange
            // 
            this.btnMExhange.BackgroundImage = global::prjCSFormCT2.Properties.Resources.moneyConvert;
            this.btnMExhange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMExhange.Location = new System.Drawing.Point(75, 61);
            this.btnMExhange.Name = "btnMExhange";
            this.btnMExhange.Size = new System.Drawing.Size(173, 167);
            this.btnMExhange.TabIndex = 0;
            this.btnMExhange.UseVisualStyleBackColor = true;
            this.btnMExhange.Click += new System.EventHandler(this.btnMExhange_Click);
            // 
            // calcTab
            // 
            this.calcTab.Controls.Add(this.btnCalc);
            this.calcTab.Location = new System.Drawing.Point(4, 27);
            this.calcTab.Name = "calcTab";
            this.calcTab.Padding = new System.Windows.Forms.Padding(3);
            this.calcTab.Size = new System.Drawing.Size(672, 379);
            this.calcTab.TabIndex = 2;
            this.calcTab.Text = "Simple Calculator";
            this.calcTab.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.BackgroundImage = global::prjCSFormCT2.Properties.Resources.Calculator;
            this.btnCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalc.Location = new System.Drawing.Point(201, 63);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(246, 232);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // ipValTab
            // 
            this.ipValTab.Controls.Add(this.ipValidbtn);
            this.ipValTab.Location = new System.Drawing.Point(4, 27);
            this.ipValTab.Name = "ipValTab";
            this.ipValTab.Size = new System.Drawing.Size(672, 379);
            this.ipValTab.TabIndex = 3;
            this.ipValTab.Text = "IP v4 validator";
            this.ipValTab.UseVisualStyleBackColor = true;
            // 
            // ipValidbtn
            // 
            this.ipValidbtn.BackgroundImage = global::prjCSFormCT2.Properties.Resources.ip4;
            this.ipValidbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ipValidbtn.Location = new System.Drawing.Point(201, 63);
            this.ipValidbtn.Name = "ipValidbtn";
            this.ipValidbtn.Size = new System.Drawing.Size(246, 232);
            this.ipValidbtn.TabIndex = 1;
            this.ipValidbtn.UseVisualStyleBackColor = true;
            this.ipValidbtn.Click += new System.EventHandler(this.ipValidbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(605, 467);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(114, 31);
            this.exitbtn.TabIndex = 3;
            this.exitbtn.Text = "E&xit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(762, 533);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.menuTabBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard - Mickael Lavigueur-Leduc";
            this.menuTabBox.ResumeLayout(false);
            this.genTab.ResumeLayout(false);
            this.gboxLotto.ResumeLayout(false);
            this.gboxLotto.PerformLayout();
            this.convTab.ResumeLayout(false);
            this.gBoxConversion.ResumeLayout(false);
            this.gBoxConversion.PerformLayout();
            this.calcTab.ResumeLayout(false);
            this.ipValTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menuTabBox;
        private System.Windows.Forms.TabPage genTab;
        private System.Windows.Forms.TabPage convTab;
        private System.Windows.Forms.TabPage calcTab;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.GroupBox gboxLotto;
        private System.Windows.Forms.Label labelLotto649;
        private System.Windows.Forms.Label labelLottoMax;
        private System.Windows.Forms.Button btnLotto649;
        private System.Windows.Forms.Button btnLottoMax;
        private System.Windows.Forms.GroupBox gBoxConversion;
        private System.Windows.Forms.Label labelTempConv;
        private System.Windows.Forms.Label labelMExchange;
        private System.Windows.Forms.Button btnTempConv;
        private System.Windows.Forms.Button btnMExhange;
        private System.Windows.Forms.TabPage ipValTab;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button ipValidbtn;
    }
}

