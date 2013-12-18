namespace CountdownClock
{
    partial class Control
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
            this.lblCurTm = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCntDwn = new System.Windows.Forms.Label();
            this.bMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurTm
            // 
            this.lblCurTm.AutoSize = true;
            this.lblCurTm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurTm.Location = new System.Drawing.Point(12, 9);
            this.lblCurTm.Name = "lblCurTm";
            this.lblCurTm.Size = new System.Drawing.Size(172, 31);
            this.lblCurTm.TabIndex = 0;
            this.lblCurTm.Text = "Current Time";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCntDwn
            // 
            this.lblCntDwn.AutoSize = true;
            this.lblCntDwn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCntDwn.Location = new System.Drawing.Point(13, 74);
            this.lblCntDwn.Name = "lblCntDwn";
            this.lblCntDwn.Size = new System.Drawing.Size(136, 31);
            this.lblCntDwn.TabIndex = 2;
            this.lblCntDwn.Text = "Time Until";
            // 
            // bMax
            // 
            this.bMax.Location = new System.Drawing.Point(19, 153);
            this.bMax.Name = "bMax";
            this.bMax.Size = new System.Drawing.Size(108, 47);
            this.bMax.TabIndex = 4;
            this.bMax.Text = "Maximize (F11)";
            this.bMax.UseVisualStyleBackColor = true;
            this.bMax.Click += new System.EventHandler(this.bMax_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 212);
            this.Controls.Add(this.bMax);
            this.Controls.Add(this.lblCntDwn);
            this.Controls.Add(this.lblCurTm);
            this.KeyPreview = true;
            this.Name = "Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurTm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCntDwn;
        private System.Windows.Forms.Button bMax;
    }
}

