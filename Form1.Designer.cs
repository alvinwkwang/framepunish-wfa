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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.appInfoLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubRepositoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutFramePunishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mainTextBox = new System.Windows.Forms.RichTextBox();
            this.userPortrait = new System.Windows.Forms.PictureBox();
            this.opponentPortrait = new System.Windows.Forms.PictureBox();
            this.vsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPortrait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponentPortrait)).BeginInit();
            this.SuspendLayout();
            // 
            // fdButton
            // 
            this.fdButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdButton.Location = new System.Drawing.Point(54, 163);
            this.fdButton.Name = "fdButton";
            this.fdButton.Size = new System.Drawing.Size(122, 43);
            this.fdButton.TabIndex = 2;
            this.fdButton.Text = "Get Frame Data";
            this.fdButton.UseVisualStyleBackColor = true;
            this.fdButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fdButton_MouseClick);
            // 
            // fdComboBox
            // 
            this.fdComboBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdComboBox.FormattingEnabled = true;
            this.fdComboBox.Location = new System.Drawing.Point(55, 130);
            this.fdComboBox.Name = "fdComboBox";
            this.fdComboBox.Size = new System.Drawing.Size(121, 27);
            this.fdComboBox.TabIndex = 3;
            // 
            // fdLabel
            // 
            this.fdLabel.AutoSize = true;
            this.fdLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdLabel.Location = new System.Drawing.Point(49, 103);
            this.fdLabel.Name = "fdLabel";
            this.fdLabel.Size = new System.Drawing.Size(153, 19);
            this.fdLabel.TabIndex = 5;
            this.fdLabel.Text = "View Frame Data:";
            // 
            // mpLabel
            // 
            this.mpLabel.AutoSize = true;
            this.mpLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpLabel.Location = new System.Drawing.Point(308, 24);
            this.mpLabel.Name = "mpLabel";
            this.mpLabel.Size = new System.Drawing.Size(144, 19);
            this.mpLabel.TabIndex = 6;
            this.mpLabel.Text = "Move Punishing:";
            // 
            // mpUserComboBox
            // 
            this.mpUserComboBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpUserComboBox.FormattingEnabled = true;
            this.mpUserComboBox.Location = new System.Drawing.Point(308, 226);
            this.mpUserComboBox.Name = "mpUserComboBox";
            this.mpUserComboBox.Size = new System.Drawing.Size(165, 27);
            this.mpUserComboBox.TabIndex = 7;
            this.mpUserComboBox.SelectionChangeCommitted += new System.EventHandler(this.mpUserComboBox_SelectionChangeCommitted);
            // 
            // mpOpponentComboBox
            // 
            this.mpOpponentComboBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpOpponentComboBox.FormattingEnabled = true;
            this.mpOpponentComboBox.Location = new System.Drawing.Point(606, 226);
            this.mpOpponentComboBox.Name = "mpOpponentComboBox";
            this.mpOpponentComboBox.Size = new System.Drawing.Size(165, 27);
            this.mpOpponentComboBox.TabIndex = 8;
            this.mpOpponentComboBox.SelectionChangeCommitted += new System.EventHandler(this.mpOpponentComboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "You";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(655, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Opponent";
            // 
            // mpButton
            // 
            this.mpButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpButton.Location = new System.Drawing.Point(478, 255);
            this.mpButton.Name = "mpButton";
            this.mpButton.Size = new System.Drawing.Size(122, 43);
            this.mpButton.TabIndex = 11;
            this.mpButton.Text = "Get Punishes";
            this.mpButton.UseVisualStyleBackColor = true;
            this.mpButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mpButton_MouseClick);
            // 
            // mpBlockedComboBox
            // 
            this.mpBlockedComboBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpBlockedComboBox.FormattingEnabled = true;
            this.mpBlockedComboBox.Location = new System.Drawing.Point(606, 271);
            this.mpBlockedComboBox.Name = "mpBlockedComboBox";
            this.mpBlockedComboBox.Size = new System.Drawing.Size(165, 27);
            this.mpBlockedComboBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(644, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Blocked Move";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FramePunishV2.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // appInfoLabel
            // 
            this.appInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.appInfoLabel.AutoSize = true;
            this.appInfoLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appInfoLabel.Location = new System.Drawing.Point(2, 512);
            this.appInfoLabel.Name = "appInfoLabel";
            this.appInfoLabel.Size = new System.Drawing.Size(73, 13);
            this.appInfoLabel.TabIndex = 15;
            this.appInfoLabel.Text = "app version";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubRepositoryToolStripMenuItem,
            this.aboutFramePunishToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // gitHubRepositoryToolStripMenuItem
            // 
            this.gitHubRepositoryToolStripMenuItem.Name = "gitHubRepositoryToolStripMenuItem";
            this.gitHubRepositoryToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.gitHubRepositoryToolStripMenuItem.Text = "GitHub Repository";
            this.gitHubRepositoryToolStripMenuItem.Click += new System.EventHandler(this.gitHubRepositoryToolStripMenuItem_Click);
            // 
            // aboutFramePunishToolStripMenuItem
            // 
            this.aboutFramePunishToolStripMenuItem.Name = "aboutFramePunishToolStripMenuItem";
            this.aboutFramePunishToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.aboutFramePunishToolStripMenuItem.Text = "About Frame Punish";
            this.aboutFramePunishToolStripMenuItem.Click += new System.EventHandler(this.aboutFramePunishToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mainTextBox
            // 
            this.mainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTextBox.Location = new System.Drawing.Point(12, 304);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(760, 205);
            this.mainTextBox.TabIndex = 0;
            this.mainTextBox.Text = "";
            // 
            // userPortrait
            // 
            this.userPortrait.Location = new System.Drawing.Point(308, 42);
            this.userPortrait.Name = "userPortrait";
            this.userPortrait.Size = new System.Drawing.Size(165, 165);
            this.userPortrait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPortrait.TabIndex = 17;
            this.userPortrait.TabStop = false;
            // 
            // opponentPortrait
            // 
            this.opponentPortrait.Location = new System.Drawing.Point(606, 42);
            this.opponentPortrait.Name = "opponentPortrait";
            this.opponentPortrait.Size = new System.Drawing.Size(165, 165);
            this.opponentPortrait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opponentPortrait.TabIndex = 18;
            this.opponentPortrait.TabStop = false;
            // 
            // vsLabel
            // 
            this.vsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vsLabel.AutoSize = true;
            this.vsLabel.Font = new System.Drawing.Font("Consolas", 57F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsLabel.Location = new System.Drawing.Point(479, 82);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(122, 89);
            this.vsLabel.TabIndex = 19;
            this.vsLabel.Text = "VS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 527);
            this.Controls.Add(this.vsLabel);
            this.Controls.Add(this.opponentPortrait);
            this.Controls.Add(this.userPortrait);
            this.Controls.Add(this.appInfoLabel);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Frame Punish";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPortrait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponentPortrait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label appInfoLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubRepositoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutFramePunishToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox mainTextBox;
        private System.Windows.Forms.PictureBox userPortrait;
        private System.Windows.Forms.PictureBox opponentPortrait;
        private System.Windows.Forms.Label vsLabel;
    }
}

