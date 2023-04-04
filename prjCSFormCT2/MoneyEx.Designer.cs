namespace prjCSFormCT2
{
    partial class MoneyEx
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imgCNY = new System.Windows.Forms.PictureBox();
            this.imgGBP = new System.Windows.Forms.PictureBox();
            this.imgEUR = new System.Windows.Forms.PictureBox();
            this.imgUSD = new System.Windows.Forms.PictureBox();
            this.imgCAD = new System.Windows.Forms.PictureBox();
            this.rbtnIN = new System.Windows.Forms.RadioButton();
            this.rbtnGBPIN = new System.Windows.Forms.RadioButton();
            this.rbtnEURIN = new System.Windows.Forms.RadioButton();
            this.rbtnUSDIN = new System.Windows.Forms.RadioButton();
            this.rbtnCADIN = new System.Windows.Forms.RadioButton();
            this.tBoxUser = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbtnOUT = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rbtnGBPOUT = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.rbtnEUROUT = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.rbtnUSDOUT = new System.Windows.Forms.RadioButton();
            this.rbtnCADOut = new System.Windows.Forms.RadioButton();
            this.tBoxConvert = new System.Windows.Forms.TextBox();
            this.TimerDurrWindow = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCNY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGBP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEUR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCAD)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imgCNY);
            this.groupBox1.Controls.Add(this.imgGBP);
            this.groupBox1.Controls.Add(this.imgEUR);
            this.groupBox1.Controls.Add(this.imgUSD);
            this.groupBox1.Controls.Add(this.imgCAD);
            this.groupBox1.Controls.Add(this.rbtnIN);
            this.groupBox1.Controls.Add(this.rbtnGBPIN);
            this.groupBox1.Controls.Add(this.rbtnEURIN);
            this.groupBox1.Controls.Add(this.rbtnUSDIN);
            this.groupBox1.Controls.Add(this.rbtnCADIN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // imgCNY
            // 
            this.imgCNY.BackgroundImage = global::prjCSFormCT2.Properties.Resources.ChinaFlag;
            this.imgCNY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCNY.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgCNY.Location = new System.Drawing.Point(73, 137);
            this.imgCNY.Name = "imgCNY";
            this.imgCNY.Size = new System.Drawing.Size(27, 24);
            this.imgCNY.TabIndex = 10;
            this.imgCNY.TabStop = false;
            // 
            // imgGBP
            // 
            this.imgGBP.BackgroundImage = global::prjCSFormCT2.Properties.Resources.gpd;
            this.imgGBP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgGBP.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgGBP.Location = new System.Drawing.Point(73, 110);
            this.imgGBP.Name = "imgGBP";
            this.imgGBP.Size = new System.Drawing.Size(27, 24);
            this.imgGBP.TabIndex = 9;
            this.imgGBP.TabStop = false;
            // 
            // imgEUR
            // 
            this.imgEUR.BackgroundImage = global::prjCSFormCT2.Properties.Resources.euro;
            this.imgEUR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgEUR.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgEUR.Location = new System.Drawing.Point(73, 82);
            this.imgEUR.Name = "imgEUR";
            this.imgEUR.Size = new System.Drawing.Size(27, 24);
            this.imgEUR.TabIndex = 8;
            this.imgEUR.TabStop = false;
            // 
            // imgUSD
            // 
            this.imgUSD.BackgroundImage = global::prjCSFormCT2.Properties.Resources.usa;
            this.imgUSD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgUSD.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgUSD.Location = new System.Drawing.Point(73, 54);
            this.imgUSD.Name = "imgUSD";
            this.imgUSD.Size = new System.Drawing.Size(27, 24);
            this.imgUSD.TabIndex = 7;
            this.imgUSD.TabStop = false;
            // 
            // imgCAD
            // 
            this.imgCAD.BackgroundImage = global::prjCSFormCT2.Properties.Resources.cad;
            this.imgCAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCAD.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgCAD.Location = new System.Drawing.Point(73, 25);
            this.imgCAD.Name = "imgCAD";
            this.imgCAD.Size = new System.Drawing.Size(27, 24);
            this.imgCAD.TabIndex = 6;
            this.imgCAD.TabStop = false;
            // 
            // rbtnIN
            // 
            this.rbtnIN.AutoSize = true;
            this.rbtnIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnIN.Location = new System.Drawing.Point(6, 137);
            this.rbtnIN.Name = "rbtnIN";
            this.rbtnIN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnIN.Size = new System.Drawing.Size(60, 22);
            this.rbtnIN.TabIndex = 5;
            this.rbtnIN.TabStop = true;
            this.rbtnIN.Text = "CNY";
            this.rbtnIN.UseVisualStyleBackColor = true;
            // 
            // rbtnGBPIN
            // 
            this.rbtnGBPIN.AutoSize = true;
            this.rbtnGBPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGBPIN.Location = new System.Drawing.Point(6, 112);
            this.rbtnGBPIN.Name = "rbtnGBPIN";
            this.rbtnGBPIN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnGBPIN.Size = new System.Drawing.Size(61, 22);
            this.rbtnGBPIN.TabIndex = 4;
            this.rbtnGBPIN.TabStop = true;
            this.rbtnGBPIN.Text = "GBP";
            this.rbtnGBPIN.UseVisualStyleBackColor = true;
            // 
            // rbtnEURIN
            // 
            this.rbtnEURIN.AutoSize = true;
            this.rbtnEURIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEURIN.Location = new System.Drawing.Point(6, 84);
            this.rbtnEURIN.Name = "rbtnEURIN";
            this.rbtnEURIN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnEURIN.Size = new System.Drawing.Size(61, 22);
            this.rbtnEURIN.TabIndex = 3;
            this.rbtnEURIN.TabStop = true;
            this.rbtnEURIN.Text = "EUR";
            this.rbtnEURIN.UseVisualStyleBackColor = true;
            // 
            // rbtnUSDIN
            // 
            this.rbtnUSDIN.AutoSize = true;
            this.rbtnUSDIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnUSDIN.Location = new System.Drawing.Point(6, 56);
            this.rbtnUSDIN.Name = "rbtnUSDIN";
            this.rbtnUSDIN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnUSDIN.Size = new System.Drawing.Size(61, 22);
            this.rbtnUSDIN.TabIndex = 2;
            this.rbtnUSDIN.TabStop = true;
            this.rbtnUSDIN.Text = "USD";
            this.rbtnUSDIN.UseVisualStyleBackColor = true;
            // 
            // rbtnCADIN
            // 
            this.rbtnCADIN.AllowDrop = true;
            this.rbtnCADIN.AutoSize = true;
            this.rbtnCADIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCADIN.Location = new System.Drawing.Point(6, 28);
            this.rbtnCADIN.Name = "rbtnCADIN";
            this.rbtnCADIN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnCADIN.Size = new System.Drawing.Size(60, 22);
            this.rbtnCADIN.TabIndex = 1;
            this.rbtnCADIN.TabStop = true;
            this.rbtnCADIN.Text = "CAD";
            this.rbtnCADIN.UseVisualStyleBackColor = true;
            // 
            // tBoxUser
            // 
            this.tBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxUser.Location = new System.Drawing.Point(23, 234);
            this.tBoxUser.Name = "tBoxUser";
            this.tBoxUser.Size = new System.Drawing.Size(176, 24);
            this.tBoxUser.TabIndex = 0;
            this.tBoxUser.Text = "0";
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(23, 295);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(114, 31);
            this.btnConvert.TabIndex = 11;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(212, 295);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(114, 31);
            this.btnRead.TabIndex = 12;
            this.btnRead.Text = "&Read File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(405, 295);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(114, 31);
            this.exitbtn.TabIndex = 13;
            this.exitbtn.Text = "&Back";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.rbtnOUT);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.rbtnGBPOUT);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.rbtnEUROUT);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.rbtnUSDOUT);
            this.groupBox2.Controls.Add(this.rbtnCADOut);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(283, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(236, 178);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::prjCSFormCT2.Properties.Resources.ChinaFlag;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(136, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 24);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // rbtnOUT
            // 
            this.rbtnOUT.AutoSize = true;
            this.rbtnOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOUT.Location = new System.Drawing.Point(169, 140);
            this.rbtnOUT.Name = "rbtnOUT";
            this.rbtnOUT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbtnOUT.Size = new System.Drawing.Size(60, 22);
            this.rbtnOUT.TabIndex = 10;
            this.rbtnOUT.TabStop = true;
            this.rbtnOUT.Text = "CNY";
            this.rbtnOUT.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::prjCSFormCT2.Properties.Resources.gpd;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Location = new System.Drawing.Point(136, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 24);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // rbtnGBPOUT
            // 
            this.rbtnGBPOUT.AutoSize = true;
            this.rbtnGBPOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGBPOUT.Location = new System.Drawing.Point(169, 112);
            this.rbtnGBPOUT.Name = "rbtnGBPOUT";
            this.rbtnGBPOUT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbtnGBPOUT.Size = new System.Drawing.Size(61, 22);
            this.rbtnGBPOUT.TabIndex = 9;
            this.rbtnGBPOUT.TabStop = true;
            this.rbtnGBPOUT.Text = "GBP";
            this.rbtnGBPOUT.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::prjCSFormCT2.Properties.Resources.euro;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox3.Location = new System.Drawing.Point(136, 84);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 24);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // rbtnEUROUT
            // 
            this.rbtnEUROUT.AutoSize = true;
            this.rbtnEUROUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEUROUT.Location = new System.Drawing.Point(169, 84);
            this.rbtnEUROUT.Name = "rbtnEUROUT";
            this.rbtnEUROUT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbtnEUROUT.Size = new System.Drawing.Size(61, 22);
            this.rbtnEUROUT.TabIndex = 8;
            this.rbtnEUROUT.TabStop = true;
            this.rbtnEUROUT.Text = "EUR";
            this.rbtnEUROUT.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::prjCSFormCT2.Properties.Resources.usa;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox4.Location = new System.Drawing.Point(136, 56);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 24);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::prjCSFormCT2.Properties.Resources.cad;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox5.Location = new System.Drawing.Point(136, 27);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 24);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // rbtnUSDOUT
            // 
            this.rbtnUSDOUT.AutoSize = true;
            this.rbtnUSDOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnUSDOUT.Location = new System.Drawing.Point(169, 56);
            this.rbtnUSDOUT.Name = "rbtnUSDOUT";
            this.rbtnUSDOUT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbtnUSDOUT.Size = new System.Drawing.Size(61, 22);
            this.rbtnUSDOUT.TabIndex = 7;
            this.rbtnUSDOUT.TabStop = true;
            this.rbtnUSDOUT.Text = "USD";
            this.rbtnUSDOUT.UseVisualStyleBackColor = true;
            // 
            // rbtnCADOut
            // 
            this.rbtnCADOut.AutoSize = true;
            this.rbtnCADOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCADOut.Location = new System.Drawing.Point(169, 28);
            this.rbtnCADOut.Name = "rbtnCADOut";
            this.rbtnCADOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbtnCADOut.Size = new System.Drawing.Size(60, 22);
            this.rbtnCADOut.TabIndex = 6;
            this.rbtnCADOut.TabStop = true;
            this.rbtnCADOut.Text = "CAD";
            this.rbtnCADOut.UseVisualStyleBackColor = true;
            // 
            // tBoxConvert
            // 
            this.tBoxConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxConvert.Location = new System.Drawing.Point(343, 234);
            this.tBoxConvert.Name = "tBoxConvert";
            this.tBoxConvert.ReadOnly = true;
            this.tBoxConvert.Size = new System.Drawing.Size(176, 24);
            this.tBoxConvert.TabIndex = 14;
            this.tBoxConvert.TabStop = false;
            this.tBoxConvert.Text = "0";
            this.tBoxConvert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TimerDurrWindow
            // 
            this.TimerDurrWindow.Enabled = true;
            this.TimerDurrWindow.Interval = 1000;
            this.TimerDurrWindow.Tick += new System.EventHandler(this.TimerDurrWindow_Tick);
            // 
            // MoneyEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 362);
            this.Controls.Add(this.tBoxConvert);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.tBoxUser);
            this.Controls.Add(this.groupBox1);
            this.Name = "MoneyEx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyEx - Mickael";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCNY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGBP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEUR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCAD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnIN;
        private System.Windows.Forms.RadioButton rbtnGBPIN;
        private System.Windows.Forms.RadioButton rbtnEURIN;
        private System.Windows.Forms.RadioButton rbtnUSDIN;
        private System.Windows.Forms.RadioButton rbtnCADIN;
        private System.Windows.Forms.TextBox tBoxUser;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tBoxConvert;
        private System.Windows.Forms.RadioButton rbtnOUT;
        private System.Windows.Forms.RadioButton rbtnGBPOUT;
        private System.Windows.Forms.RadioButton rbtnEUROUT;
        private System.Windows.Forms.RadioButton rbtnUSDOUT;
        private System.Windows.Forms.RadioButton rbtnCADOut;
        private System.Windows.Forms.Timer TimerDurrWindow;
        private System.Windows.Forms.PictureBox imgCAD;
        private System.Windows.Forms.PictureBox imgCNY;
        private System.Windows.Forms.PictureBox imgGBP;
        private System.Windows.Forms.PictureBox imgEUR;
        private System.Windows.Forms.PictureBox imgUSD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}