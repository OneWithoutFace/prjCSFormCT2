namespace prjCSFormCT2
{
    partial class Lotto649
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.displayL649 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.displayid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::prjCSFormCT2.Properties.Resources._649Extra;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(36, 99);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 362);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnGen
            // 
            this.btnGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGen.Location = new System.Drawing.Point(16, 532);
            this.btnGen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(157, 46);
            this.btnGen.TabIndex = 0;
            this.btnGen.Text = "&Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(194, 532);
            this.btnRead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(157, 46);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "&Read File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(371, 532);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(157, 46);
            this.exitbtn.TabIndex = 2;
            this.exitbtn.Text = "&Back";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // displayL649
            // 
            this.displayL649.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.displayL649.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayL649.Location = new System.Drawing.Point(425, 99);
            this.displayL649.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayL649.Multiline = true;
            this.displayL649.Name = "displayL649";
            this.displayL649.ReadOnly = true;
            this.displayL649.Size = new System.Drawing.Size(74, 258);
            this.displayL649.TabIndex = 7;
            this.displayL649.TabStop = false;
            this.displayL649.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "The winning numbers are:";
            // 
            // displayid
            // 
            this.displayid.AutoSize = true;
            this.displayid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayid.Location = new System.Drawing.Point(42, 489);
            this.displayid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayid.Name = "displayid";
            this.displayid.Size = new System.Drawing.Size(0, 24);
            this.displayid.TabIndex = 13;
            // 
            // Lotto649
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 612);
            this.Controls.Add(this.displayid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.displayL649);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Lotto649";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotto 649 - Mickael";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox displayL649;
        private System.Windows.Forms.Label displayid;
    }
}