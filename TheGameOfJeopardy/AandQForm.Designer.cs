namespace TheGameOfJeopardy
{
    partial class AQFr
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
            this.label1 = new System.Windows.Forms.Label();
            this.answerTxtBox = new System.Windows.Forms.TextBox();
            this.playerComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBtn = new System.Windows.Forms.Button();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.wrongRatioBtn = new System.Windows.Forms.RadioButton();
            this.rightRadioBtn = new System.Windows.Forms.RadioButton();
            this.continueBtn = new System.Windows.Forms.Button();
            this.playerRespondTxtBox = new System.Windows.Forms.TextBox();
            this.rightReponseTxtBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.questionRemaingTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.resultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Answer:";
            // 
            // answerTxtBox
            // 
            this.answerTxtBox.BackColor = System.Drawing.Color.Black;
            this.answerTxtBox.ForeColor = System.Drawing.Color.White;
            this.answerTxtBox.Location = new System.Drawing.Point(40, 92);
            this.answerTxtBox.Multiline = true;
            this.answerTxtBox.Name = "answerTxtBox";
            this.answerTxtBox.ReadOnly = true;
            this.answerTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.answerTxtBox.Size = new System.Drawing.Size(196, 66);
            this.answerTxtBox.TabIndex = 1;
            // 
            // playerComboBox
            // 
            this.playerComboBox.BackColor = System.Drawing.Color.Black;
            this.playerComboBox.ForeColor = System.Drawing.Color.White;
            this.playerComboBox.FormattingEnabled = true;
            this.playerComboBox.ItemHeight = 13;
            this.playerComboBox.Location = new System.Drawing.Point(40, 51);
            this.playerComboBox.Name = "playerComboBox";
            this.playerComboBox.Size = new System.Drawing.Size(86, 21);
            this.playerComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Player:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Respond:";
            // 
            // checkBtn
            // 
            this.checkBtn.BackColor = System.Drawing.Color.Black;
            this.checkBtn.ForeColor = System.Drawing.Color.White;
            this.checkBtn.Location = new System.Drawing.Point(258, 65);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(98, 21);
            this.checkBtn.TabIndex = 6;
            this.checkBtn.Text = "Check Respond";
            this.checkBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBtn.UseVisualStyleBackColor = false;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.BackColor = System.Drawing.Color.Black;
            this.resultGroupBox.Controls.Add(this.wrongRatioBtn);
            this.resultGroupBox.Controls.Add(this.rightRadioBtn);
            this.resultGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resultGroupBox.ForeColor = System.Drawing.Color.White;
            this.resultGroupBox.Location = new System.Drawing.Point(258, 177);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(81, 64);
            this.resultGroupBox.TabIndex = 10;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Result:";
            // 
            // wrongRatioBtn
            // 
            this.wrongRatioBtn.AutoSize = true;
            this.wrongRatioBtn.Location = new System.Drawing.Point(6, 48);
            this.wrongRatioBtn.Name = "wrongRatioBtn";
            this.wrongRatioBtn.Size = new System.Drawing.Size(57, 17);
            this.wrongRatioBtn.TabIndex = 1;
            this.wrongRatioBtn.TabStop = true;
            this.wrongRatioBtn.Text = "Wrong";
            this.wrongRatioBtn.UseVisualStyleBackColor = true;
            //this.wrongRatioBtn.CheckedChanged += new System.EventHandler(this.wrongRatioBtn_CheckedChanged);
            // 
            // rightRadioBtn
            // 
            this.rightRadioBtn.AutoSize = true;
            this.rightRadioBtn.Location = new System.Drawing.Point(6, 19);
            this.rightRadioBtn.Name = "rightRadioBtn";
            this.rightRadioBtn.Size = new System.Drawing.Size(50, 17);
            this.rightRadioBtn.TabIndex = 0;
            this.rightRadioBtn.TabStop = true;
            this.rightRadioBtn.Text = "Right";
            this.rightRadioBtn.UseVisualStyleBackColor = true;
            // 
            // continueBtn
            // 
            this.continueBtn.BackColor = System.Drawing.Color.Black;
            this.continueBtn.ForeColor = System.Drawing.Color.White;
            this.continueBtn.Location = new System.Drawing.Point(383, 212);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(83, 29);
            this.continueBtn.TabIndex = 11;
            this.continueBtn.Text = "Continue";
            this.continueBtn.UseVisualStyleBackColor = false;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // playerRespondTxtBox
            // 
            this.playerRespondTxtBox.BackColor = System.Drawing.Color.Black;
            this.playerRespondTxtBox.ForeColor = System.Drawing.Color.White;
            this.playerRespondTxtBox.Location = new System.Drawing.Point(40, 177);
            this.playerRespondTxtBox.Multiline = true;
            this.playerRespondTxtBox.Name = "playerRespondTxtBox";
            this.playerRespondTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.playerRespondTxtBox.Size = new System.Drawing.Size(196, 64);
            this.playerRespondTxtBox.TabIndex = 12;
            this.playerRespondTxtBox.TextChanged += new System.EventHandler(this.playerRespondTxtBox_TextChanged);
            // 
            // rightReponseTxtBox
            // 
            this.rightReponseTxtBox.BackColor = System.Drawing.Color.Black;
            this.rightReponseTxtBox.ForeColor = System.Drawing.Color.White;
            this.rightReponseTxtBox.Location = new System.Drawing.Point(258, 92);
            this.rightReponseTxtBox.Multiline = true;
            this.rightReponseTxtBox.Name = "rightReponseTxtBox";
            this.rightReponseTxtBox.ReadOnly = true;
            this.rightReponseTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rightReponseTxtBox.Size = new System.Drawing.Size(208, 66);
            this.rightReponseTxtBox.TabIndex = 13;
            this.rightReponseTxtBox.Text = "Click \"Check Respond button\" to see the correct Reponds";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // questionRemaingTime
            // 
            this.questionRemaingTime.AutoSize = true;
            this.questionRemaingTime.BackColor = System.Drawing.Color.Transparent;
            this.questionRemaingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionRemaingTime.ForeColor = System.Drawing.Color.White;
            this.questionRemaingTime.Location = new System.Drawing.Point(453, 9);
            this.questionRemaingTime.Name = "questionRemaingTime";
            this.questionRemaingTime.Size = new System.Drawing.Size(13, 13);
            this.questionRemaingTime.TabIndex = 49;
            this.questionRemaingTime.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(319, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Time Remainging (Second):";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(29, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(446, 228);
            this.button1.TabIndex = 50;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AQFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheGameOfJeopardy.Properties.Resources.mainBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 280);
            this.Controls.Add(this.questionRemaingTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rightReponseTxtBox);
            this.Controls.Add(this.playerRespondTxtBox);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.resultGroupBox);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerComboBox);
            this.Controls.Add(this.answerTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AQFr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AandQForm";
            this.Load += new System.EventHandler(this.AQFr_Load);
            this.resultGroupBox.ResumeLayout(false);
            this.resultGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox answerTxtBox;
        private System.Windows.Forms.ComboBox playerComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.RadioButton wrongRatioBtn;
        private System.Windows.Forms.RadioButton rightRadioBtn;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.TextBox playerRespondTxtBox;
        private System.Windows.Forms.TextBox rightReponseTxtBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label questionRemaingTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}