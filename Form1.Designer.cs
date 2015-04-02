namespace FramePunishV2
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
            this.mainTextBox = new System.Windows.Forms.RichTextBox();
            this.fdButton = new System.Windows.Forms.Button();
            this.fdComboBox = new System.Windows.Forms.ComboBox();
            this.fdLabel = new System.Windows.Forms.Label();
            this.mpLabel = new System.Windows.Forms.Label();
            this.mpUserComboBox = new System.Windows.Forms.ComboBox();
            this.mpOpponentComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mpButton = new System.Windows.Forms.Button();
            this.mpBlockedComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTextBox.Location = new System.Drawing.Point(288, 12);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(338, 433);
            this.mainTextBox.TabIndex = 0;
            this.mainTextBox.Text = "";
            // 
            // fdButton
            // 
            this.fdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdButton.Location = new System.Drawing.Point(73, 134);
            this.fdButton.Name = "fdButton";
            this.fdButton.Size = new System.Drawing.Size(121, 43);
            this.fdButton.TabIndex = 2;
            this.fdButton.Text = "Get Frame Data";
            this.fdButton.UseVisualStyleBackColor = true;
            this.fdButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fdButton_MouseClick);
            // 
            // fdComboBox
            // 
            this.fdComboBox.FormattingEnabled = true;
            this.fdComboBox.Location = new System.Drawing.Point(73, 98);
            this.fdComboBox.Name = "fdComboBox";
            this.fdComboBox.Size = new System.Drawing.Size(121, 21);
            this.fdComboBox.TabIndex = 3;
            // 
            // fdLabel
            // 
            this.fdLabel.AutoSize = true;
            this.fdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdLabel.Location = new System.Drawing.Point(69, 64);
            this.fdLabel.Name = "fdLabel";
            this.fdLabel.Size = new System.Drawing.Size(152, 20);
            this.fdLabel.TabIndex = 5;
            this.fdLabel.Text = "View Frame Data:";
            // 
            // mpLabel
            // 
            this.mpLabel.AutoSize = true;
            this.mpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpLabel.Location = new System.Drawing.Point(69, 246);
            this.mpLabel.Name = "mpLabel";
            this.mpLabel.Size = new System.Drawing.Size(139, 20);
            this.mpLabel.TabIndex = 6;
            this.mpLabel.Text = "Move Punishing:";
            // 
            // mpUserComboBox
            // 
            this.mpUserComboBox.FormattingEnabled = true;
            this.mpUserComboBox.Location = new System.Drawing.Point(12, 293);
            this.mpUserComboBox.Name = "mpUserComboBox";
            this.mpUserComboBox.Size = new System.Drawing.Size(121, 21);
            this.mpUserComboBox.TabIndex = 7;
            // 
            // mpOpponentComboBox
            // 
            this.mpOpponentComboBox.FormattingEnabled = true;
            this.mpOpponentComboBox.Location = new System.Drawing.Point(161, 293);
            this.mpOpponentComboBox.Name = "mpOpponentComboBox";
            this.mpOpponentComboBox.Size = new System.Drawing.Size(121, 21);
            this.mpOpponentComboBox.TabIndex = 8;
            this.mpOpponentComboBox.SelectionChangeCommitted += new System.EventHandler(this.mpOpponentComboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "You";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Opponent";
            // 
            // mpButton
            // 
            this.mpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpButton.Location = new System.Drawing.Point(73, 383);
            this.mpButton.Name = "mpButton";
            this.mpButton.Size = new System.Drawing.Size(121, 43);
            this.mpButton.TabIndex = 11;
            this.mpButton.Text = "Get Punishes";
            this.mpButton.UseVisualStyleBackColor = true;
            this.mpButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mpButton_MouseClick);
            // 
            // mpBlockedComboBox
            // 
            this.mpBlockedComboBox.FormattingEnabled = true;
            this.mpBlockedComboBox.Location = new System.Drawing.Point(161, 339);
            this.mpBlockedComboBox.Name = "mpBlockedComboBox";
            this.mpBlockedComboBox.Size = new System.Drawing.Size(121, 21);
            this.mpBlockedComboBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Opponent\'s Blocked Move";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.LinkColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(29, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(229, 37);
            this.titleLabel.TabIndex = 14;
            this.titleLabel.TabStop = true;
            this.titleLabel.Text = "Frame Punish";
            this.titleLabel.VisitedLinkColor = System.Drawing.Color.Black;
            this.titleLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.titleLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 457);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mpBlockedComboBox);
            this.Controls.Add(this.mpButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mpOpponentComboBox);
            this.Controls.Add(this.mpUserComboBox);
            this.Controls.Add(this.mpLabel);
            this.Controls.Add(this.fdLabel);
            this.Controls.Add(this.fdComboBox);
            this.Controls.Add(this.fdButton);
            this.Controls.Add(this.mainTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainTextBox;
        private System.Windows.Forms.Button fdButton;
        private System.Windows.Forms.ComboBox fdComboBox;
        private System.Windows.Forms.Label fdLabel;
        private System.Windows.Forms.Label mpLabel;
        private System.Windows.Forms.ComboBox mpUserComboBox;
        private System.Windows.Forms.ComboBox mpOpponentComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mpButton;
        private System.Windows.Forms.ComboBox mpBlockedComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel titleLabel;
    }
}

