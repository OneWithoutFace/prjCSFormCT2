namespace prjCSFormCT2
{
    partial class TempConv
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
            this.btnConv = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.rbtnCtoF = new System.Windows.Forms.RadioButton();
            this.rbtnFtoC = new System.Windows.Forms.RadioButton();
            this.tBoxInput = new System.Windows.Forms.TextBox();
            this.labelMid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxOutput = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.tBoxMsg = new System.Windows.Forms.TextBox();
            this.panRadioCF = new System.Windows.Forms.Panel();
            this.panRadioCF.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConv
            // 
            this.btnConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConv.Location = new System.Drawing.Point(16, 341);
            this.btnConv.Name = "btnConv";
            this.btnConv.Size = new System.Drawing.Size(114, 31);
            this.btnConv.TabIndex = 13;
            this.btnConv.Text = "&Convert";
            this.btnConv.UseVisualStyleBackColor = true;
            this.btnConv.Click += new System.EventHandler(this.btnConv_Click);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(185, 340);
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
            this.exitbtn.Location = new System.Drawing.Point(357, 341);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(114, 31);
            this.exitbtn.TabIndex = 11;
            this.exitbtn.Text = "&Back";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // rbtnCtoF
            // 
            this.rbtnCtoF.AutoSize = true;
            this.rbtnCtoF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCtoF.Location = new System.Drawing.Point(20, 3);
            this.rbtnCtoF.Name = "rbtnCtoF";
            this.rbtnCtoF.Size = new System.Drawing.Size(105, 22);
            this.rbtnCtoF.TabIndex = 14;
            this.rbtnCtoF.TabStop = true;
            this.rbtnCtoF.Text = "from C to F";
            this.rbtnCtoF.UseVisualStyleBackColor = true;
            this.rbtnCtoF.CheckedChanged += new System.EventHandler(this.rbtnCtoF_CheckedChanged);
            // 
            // rbtnFtoC
            // 
            this.rbtnFtoC.AutoSize = true;
            this.rbtnFtoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFtoC.Location = new System.Drawing.Point(20, 40);
            this.rbtnFtoC.Name = "rbtnFtoC";
            this.rbtnFtoC.Size = new System.Drawing.Size(105, 22);
            this.rbtnFtoC.TabIndex = 15;
            this.rbtnFtoC.TabStop = true;
            this.rbtnFtoC.Text = "from F to C";
            this.rbtnFtoC.UseVisualStyleBackColor = true;
            this.rbtnFtoC.CheckedChanged += new System.EventHandler(this.rbtnFtoC_CheckedChanged);
            // 
            // tBoxInput
            // 
            this.tBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxInput.Location = new System.Drawing.Point(34, 124);
            this.tBoxInput.Name = "tBoxInput";
            this.tBoxInput.Size = new System.Drawing.Size(178, 28);
            this.tBoxInput.TabIndex = 16;
            // 
            // labelMid
            // 
            this.labelMid.AutoSize = true;
            this.labelMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMid.Location = new System.Drawing.Point(237, 130);
            this.labelMid.Name = "labelMid";
            this.labelMid.Size = new System.Drawing.Size(21, 18);
            this.labelMid.TabIndex = 17;
            this.labelMid.Text = "to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "2";
            // 
            // tBoxOutput
            // 
            this.tBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxOutput.Location = new System.Drawing.Point(281, 124);
            this.tBoxOutput.Name = "tBoxOutput";
            this.tBoxOutput.ReadOnly = true;
            this.tBoxOutput.Size = new System.Drawing.Size(178, 28);
            this.tBoxOutput.TabIndex = 19;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(9, 209);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(73, 18);
            this.labelMessage.TabIndex = 21;
            this.labelMessage.Text = "Message:";
            // 
            // tBoxMsg
            // 
            this.tBoxMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxMsg.Location = new System.Drawing.Point(12, 240);
            this.tBoxMsg.Multiline = true;
            this.tBoxMsg.Name = "tBoxMsg";
            this.tBoxMsg.ReadOnly = true;
            this.tBoxMsg.Size = new System.Drawing.Size(473, 68);
            this.tBoxMsg.TabIndex = 22;
            // 
            // panRadioCF
            // 
            this.panRadioCF.Controls.Add(this.rbtnFtoC);
            this.panRadioCF.Controls.Add(this.rbtnCtoF);
            this.panRadioCF.Location = new System.Drawing.Point(174, 24);
            this.panRadioCF.Name = "panRadioCF";
            this.panRadioCF.Size = new System.Drawing.Size(143, 68);
            this.panRadioCF.TabIndex = 24;
            // 
            // TempConv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 397);
            this.Controls.Add(this.panRadioCF);
            this.Controls.Add(this.tBoxMsg);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMid);
            this.Controls.Add(this.tBoxInput);
            this.Controls.Add(this.btnConv);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.exitbtn);
            this.Name = "TempConv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temp App - Mickael";
            this.panRadioCF.ResumeLayout(false);
            this.panRadioCF.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConv;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.RadioButton rbtnCtoF;
        private System.Windows.Forms.RadioButton rbtnFtoC;
        private System.Windows.Forms.TextBox tBoxInput;
        private System.Windows.Forms.Label labelMid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxOutput;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox tBoxMsg;
        private System.Windows.Forms.Panel panRadioCF;
    }
}