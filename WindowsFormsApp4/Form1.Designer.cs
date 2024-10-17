namespace WindowsFormsApp4
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
            this.btnDrawPoints = new System.Windows.Forms.Button();
            this.txtPointCount = new System.Windows.Forms.TextBox();
            this.lblBR = new System.Windows.Forms.Label();
            this.lblTotalArea = new System.Windows.Forms.Label();
            this.lblBL = new System.Windows.Forms.Label();
            this.lblTR = new System.Windows.Forms.Label();
            this.lblTL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDrawPoints
            // 
            this.btnDrawPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawPoints.Location = new System.Drawing.Point(544, 819);
            this.btnDrawPoints.Name = "btnDrawPoints";
            this.btnDrawPoints.Size = new System.Drawing.Size(135, 31);
            this.btnDrawPoints.TabIndex = 0;
            this.btnDrawPoints.Text = "Draw Points";
            this.btnDrawPoints.UseVisualStyleBackColor = true;
            this.btnDrawPoints.Click += new System.EventHandler(this.btnDrawPoints_Click);
            // 
            // txtPointCount
            // 
            this.txtPointCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPointCount.Location = new System.Drawing.Point(386, 819);
            this.txtPointCount.Name = "txtPointCount";
            this.txtPointCount.Size = new System.Drawing.Size(130, 31);
            this.txtPointCount.TabIndex = 1;
            // 
            // lblBR
            // 
            this.lblBR.AutoSize = true;
            this.lblBR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBR.Location = new System.Drawing.Point(850, 850);
            this.lblBR.Name = "lblBR";
            this.lblBR.Size = new System.Drawing.Size(0, 25);
            this.lblBR.TabIndex = 2;
            // 
            // lblTotalArea
            // 
            this.lblTotalArea.AutoSize = true;
            this.lblTotalArea.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalArea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalArea.Location = new System.Drawing.Point(500, 700);
            this.lblTotalArea.Name = "lblTotalArea";
            this.lblTotalArea.Size = new System.Drawing.Size(0, 25);
            this.lblTotalArea.TabIndex = 3;
            // 
            // lblBL
            // 
            this.lblBL.AutoSize = true;
            this.lblBL.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBL.Location = new System.Drawing.Point(150, 850);
            this.lblBL.Name = "lblBL";
            this.lblBL.Size = new System.Drawing.Size(0, 25);
            this.lblBL.TabIndex = 4;
            // 
            // lblTR
            // 
            this.lblTR.AutoSize = true;
            this.lblTR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTR.Location = new System.Drawing.Point(850, 350);
            this.lblTR.Name = "lblTR";
            this.lblTR.Size = new System.Drawing.Size(0, 25);
            this.lblTR.TabIndex = 5;
            // 
            // lblTL
            // 
            this.lblTL.AutoSize = true;
            this.lblTL.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTL.Location = new System.Drawing.Point(150, 350);
            this.lblTL.Name = "lblTL";
            this.lblTL.Size = new System.Drawing.Size(0, 25);
            this.lblTL.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1084, 961);
            this.Controls.Add(this.lblTL);
            this.Controls.Add(this.lblTR);
            this.Controls.Add(this.lblBL);
            this.Controls.Add(this.lblTotalArea);
            this.Controls.Add(this.lblBR);
            this.Controls.Add(this.txtPointCount);
            this.Controls.Add(this.btnDrawPoints);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDrawPoints;
        private System.Windows.Forms.TextBox txtPointCount;
        private System.Windows.Forms.Label lblBR;
        private System.Windows.Forms.Label lblTotalArea;
        private System.Windows.Forms.Label lblBL;
        private System.Windows.Forms.Label lblTR;
        private System.Windows.Forms.Label lblTL;
    }
}

