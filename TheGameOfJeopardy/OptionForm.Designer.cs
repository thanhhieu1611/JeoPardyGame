namespace TheGameOfJeopardy
{
    partial class OptionFr
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
            this.numPlayersComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.playNameLbl = new System.Windows.Forms.Label();
            this.player1Lbl = new System.Windows.Forms.Label();
            this.player1TxtBox = new System.Windows.Forms.TextBox();
            this.player2TxtBox = new System.Windows.Forms.TextBox();
            this.player2Lbl = new System.Windows.Forms.Label();
            this.player3TxtBox = new System.Windows.Forms.TextBox();
            this.player3Lbl = new System.Windows.Forms.Label();
            this.continueBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numPlayersComboBox
            // 
            this.numPlayersComboBox.BackColor = System.Drawing.Color.Black;
            this.numPlayersComboBox.ForeColor = System.Drawing.Color.White;
            this.numPlayersComboBox.FormattingEnabled = true;
            this.numPlayersComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.numPlayersComboBox.Location = new System.Drawing.Point(32, 57);
            this.numPlayersComboBox.Name = "numPlayersComboBox";
            this.numPlayersComboBox.Size = new System.Drawing.Size(121, 21);
            this.numPlayersComboBox.TabIndex = 0;
            this.numPlayersComboBox.SelectedIndexChanged += new System.EventHandler(this.numPlayersComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Players:";
            // 
            // playNameLbl
            // 
            this.playNameLbl.AutoSize = true;
            this.playNameLbl.BackColor = System.Drawing.Color.Black;
            this.playNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playNameLbl.ForeColor = System.Drawing.Color.White;
            this.playNameLbl.Location = new System.Drawing.Point(181, 40);
            this.playNameLbl.Name = "playNameLbl";
            this.playNameLbl.Size = new System.Drawing.Size(91, 13);
            this.playNameLbl.TabIndex = 2;
            this.playNameLbl.Text = "Player\'s Name:";
            // 
            // player1Lbl
            // 
            this.player1Lbl.AutoSize = true;
            this.player1Lbl.BackColor = System.Drawing.Color.Black;
            this.player1Lbl.ForeColor = System.Drawing.Color.White;
            this.player1Lbl.Location = new System.Drawing.Point(181, 64);
            this.player1Lbl.Name = "player1Lbl";
            this.player1Lbl.Size = new System.Drawing.Size(48, 13);
            this.player1Lbl.TabIndex = 3;
            this.player1Lbl.Text = "Player 1:";
            this.player1Lbl.Visible = false;
            // 
            // player1TxtBox
            // 
            this.player1TxtBox.BackColor = System.Drawing.Color.Black;
            this.player1TxtBox.ForeColor = System.Drawing.Color.White;
            this.player1TxtBox.Location = new System.Drawing.Point(241, 61);
            this.player1TxtBox.Name = "player1TxtBox";
            this.player1TxtBox.Size = new System.Drawing.Size(143, 20);
            this.player1TxtBox.TabIndex = 4;
            this.player1TxtBox.Visible = false;
            // 
            // player2TxtBox
            // 
            this.player2TxtBox.BackColor = System.Drawing.Color.Black;
            this.player2TxtBox.ForeColor = System.Drawing.Color.White;
            this.player2TxtBox.Location = new System.Drawing.Point(241, 96);
            this.player2TxtBox.Name = "player2TxtBox";
            this.player2TxtBox.Size = new System.Drawing.Size(143, 20);
            this.player2TxtBox.TabIndex = 6;
            this.player2TxtBox.Visible = false;
            // 
            // player2Lbl
            // 
            this.player2Lbl.AutoSize = true;
            this.player2Lbl.BackColor = System.Drawing.Color.Black;
            this.player2Lbl.ForeColor = System.Drawing.Color.White;
            this.player2Lbl.Location = new System.Drawing.Point(181, 99);
            this.player2Lbl.Name = "player2Lbl";
            this.player2Lbl.Size = new System.Drawing.Size(48, 13);
            this.player2Lbl.TabIndex = 5;
            this.player2Lbl.Text = "Player 2:";
            this.player2Lbl.Visible = false;
            // 
            // player3TxtBox
            // 
            this.player3TxtBox.BackColor = System.Drawing.Color.Black;
            this.player3TxtBox.ForeColor = System.Drawing.Color.White;
            this.player3TxtBox.Location = new System.Drawing.Point(241, 131);
            this.player3TxtBox.Name = "player3TxtBox";
            this.player3TxtBox.Size = new System.Drawing.Size(143, 20);
            this.player3TxtBox.TabIndex = 8;
            this.player3TxtBox.Visible = false;
            // 
            // player3Lbl
            // 
            this.player3Lbl.AutoSize = true;
            this.player3Lbl.BackColor = System.Drawing.Color.Black;
            this.player3Lbl.ForeColor = System.Drawing.Color.White;
            this.player3Lbl.Location = new System.Drawing.Point(181, 134);
            this.player3Lbl.Name = "player3Lbl";
            this.player3Lbl.Size = new System.Drawing.Size(48, 13);
            this.player3Lbl.TabIndex = 7;
            this.player3Lbl.Text = "Player 3:";
            this.player3Lbl.Visible = false;
            // 
            // continueBtn
            // 
            this.continueBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.continueBtn.BackColor = System.Drawing.Color.Black;
            this.continueBtn.ForeColor = System.Drawing.Color.White;
            this.continueBtn.Location = new System.Drawing.Point(32, 91);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(57, 21);
            this.continueBtn.TabIndex = 9;
            this.continueBtn.Text = "Continue";
            this.continueBtn.UseVisualStyleBackColor = false;
            this.continueBtn.Visible = false;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelBtn.BackColor = System.Drawing.Color.Black;
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(96, 91);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(57, 21);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Visible = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::TheGameOfJeopardy.Properties.Resources.closeBtn1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(392, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(23, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 152);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "NUMBER OF PLAYER";
            // 
            // OptionFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::TheGameOfJeopardy.Properties.Resources.mainBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(419, 189);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.player3TxtBox);
            this.Controls.Add(this.player3Lbl);
            this.Controls.Add(this.player2TxtBox);
            this.Controls.Add(this.player2Lbl);
            this.Controls.Add(this.player1TxtBox);
            this.Controls.Add(this.player1Lbl);
            this.Controls.Add(this.playNameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPlayersComboBox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OptionFr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Option Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox numPlayersComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playNameLbl;
        private System.Windows.Forms.Label player1Lbl;
        private System.Windows.Forms.TextBox player1TxtBox;
        private System.Windows.Forms.TextBox player2TxtBox;
        private System.Windows.Forms.Label player2Lbl;
        private System.Windows.Forms.TextBox player3TxtBox;
        private System.Windows.Forms.Label player3Lbl;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}