namespace prjCSFormCT2
{
    partial class Textpop
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
            this.textPopName = new System.Windows.Forms.Label();
            this.displayRead = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textPopName
            // 
            this.textPopName.AutoSize = true;
            this.textPopName.Enabled = false;
            this.textPopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPopName.Location = new System.Drawing.Point(19, 12);
            this.textPopName.Name = "textPopName";
            this.textPopName.Size = new System.Drawing.Size(0, 24);
            this.textPopName.TabIndex = 0;
            // 
            // displayRead
            // 
            this.displayRead.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.displayRead.Location = new System.Drawing.Point(23, 45);
            this.displayRead.Multiline = true;
            this.displayRead.Name = "displayRead";
            this.displayRead.ReadOnly = true;
            this.displayRead.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayRead.Size = new System.Drawing.Size(395, 161);
            this.displayRead.TabIndex = 1;
            this.displayRead.TabStop = false;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(303, 226);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(114, 31);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "&Close";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Textpop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 267);
            this.ControlBox = false;
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.displayRead);
            this.Controls.Add(this.textPopName);
            this.Name = "Textpop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textPopName;
        private System.Windows.Forms.Button btnback;
        public System.Windows.Forms.TextBox displayRead;
    }
}