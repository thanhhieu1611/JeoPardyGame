namespace TheGameOfJeopardy
{
    partial class ResultFr
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.highestScoreTxtBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resultsLstBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(30, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(457, 51);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(282, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Highest Score:";
            // 
            // highestScoreTxtBox
            // 
            this.highestScoreTxtBox.BackColor = System.Drawing.Color.Black;
            this.highestScoreTxtBox.ForeColor = System.Drawing.Color.White;
            this.highestScoreTxtBox.Location = new System.Drawing.Point(365, 268);
            this.highestScoreTxtBox.Name = "highestScoreTxtBox";
            this.highestScoreTxtBox.Size = new System.Drawing.Size(102, 20);
            this.highestScoreTxtBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::TheGameOfJeopardy.Properties.Resources.closeBtn1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(482, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // resultsLstBox
            // 
            this.resultsLstBox.BackColor = System.Drawing.Color.Black;
            this.resultsLstBox.ForeColor = System.Drawing.Color.White;
            this.resultsLstBox.FormattingEnabled = true;
            this.resultsLstBox.Location = new System.Drawing.Point(30, 27);
            this.resultsLstBox.Name = "resultsLstBox";
            this.resultsLstBox.Size = new System.Drawing.Size(457, 225);
            this.resultsLstBox.TabIndex = 5;
            // 
            // ResultFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheGameOfJeopardy.Properties.Resources.mainBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 324);
            this.Controls.Add(this.resultsLstBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.highestScoreTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultFr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ResultFr";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox highestScoreTxtBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox resultsLstBox;
    }
}