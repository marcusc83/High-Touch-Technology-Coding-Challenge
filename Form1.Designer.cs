
namespace HIghTouch_CodeChallenge
{
    partial class frmMain
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
            this.lblDevTag = new System.Windows.Forms.Label();
            this.btnUserInput = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txbxUserInput = new System.Windows.Forms.RichTextBox();
            this.txbxResults = new System.Windows.Forms.RichTextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblLeftoverLettersTotal = new System.Windows.Forms.Label();
            this.txbxLeftoverLetterTotal = new System.Windows.Forms.TextBox();
            this.lblTotalCharacters = new System.Windows.Forms.Label();
            this.txbxTotalCharacters = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDevTag
            // 
            this.lblDevTag.AutoSize = true;
            this.lblDevTag.Location = new System.Drawing.Point(7, 80);
            this.lblDevTag.Name = "lblDevTag";
            this.lblDevTag.Size = new System.Drawing.Size(172, 52);
            this.lblDevTag.TabIndex = 2;
            this.lblDevTag.Text = "Developed By:  Marcus Curran\r\nEmail:  marcus@curran-labs.com\r\nPhone:  316-249-366" +
    "8\r\nGitHub: marcusc83\r\n";
            // 
            // btnUserInput
            // 
            this.btnUserInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnUserInput.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUserInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUserInput.FlatAppearance.BorderSize = 0;
            this.btnUserInput.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUserInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserInput.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUserInput.Location = new System.Drawing.Point(0, 160);
            this.btnUserInput.Name = "btnUserInput";
            this.btnUserInput.Size = new System.Drawing.Size(193, 78);
            this.btnUserInput.TabIndex = 2;
            this.btnUserInput.Text = "Submit";
            this.btnUserInput.UseVisualStyleBackColor = false;
            this.btnUserInput.Click += new System.EventHandler(this.btnUserInput_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExit.Location = new System.Drawing.Point(0, 316);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(193, 78);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txbxUserInput
            // 
            this.txbxUserInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxUserInput.DetectUrls = false;
            this.txbxUserInput.Location = new System.Drawing.Point(235, 37);
            this.txbxUserInput.MaxLength = 256;
            this.txbxUserInput.Name = "txbxUserInput";
            this.txbxUserInput.Size = new System.Drawing.Size(320, 120);
            this.txbxUserInput.TabIndex = 1;
            this.txbxUserInput.Text = "Enter Your Text here ( 256 character Limit)\nClick Submit When Done\n\n";
            this.txbxUserInput.TextChanged += new System.EventHandler(this.txbxUserInput_TextChanged);
            // 
            // txbxResults
            // 
            this.txbxResults.Location = new System.Drawing.Point(235, 229);
            this.txbxResults.Name = "txbxResults";
            this.txbxResults.ReadOnly = true;
            this.txbxResults.Size = new System.Drawing.Size(320, 48);
            this.txbxResults.TabIndex = 7;
            this.txbxResults.TabStop = false;
            this.txbxResults.Text = "The Left Over Letters";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnReset.Location = new System.Drawing.Point(0, 238);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(193, 78);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblLeftoverLettersTotal
            // 
            this.lblLeftoverLettersTotal.AutoSize = true;
            this.lblLeftoverLettersTotal.Location = new System.Drawing.Point(354, 322);
            this.lblLeftoverLettersTotal.Name = "lblLeftoverLettersTotal";
            this.lblLeftoverLettersTotal.Size = new System.Drawing.Size(136, 13);
            this.lblLeftoverLettersTotal.TabIndex = 9;
            this.lblLeftoverLettersTotal.Text = "Total # of Leftover Letters";
            // 
            // txbxLeftoverLetterTotal
            // 
            this.txbxLeftoverLetterTotal.Location = new System.Drawing.Point(518, 313);
            this.txbxLeftoverLetterTotal.Name = "txbxLeftoverLetterTotal";
            this.txbxLeftoverLetterTotal.ReadOnly = true;
            this.txbxLeftoverLetterTotal.Size = new System.Drawing.Size(37, 22);
            this.txbxLeftoverLetterTotal.TabIndex = 10;
            this.txbxLeftoverLetterTotal.TabStop = false;
            // 
            // lblTotalCharacters
            // 
            this.lblTotalCharacters.AutoSize = true;
            this.lblTotalCharacters.Location = new System.Drawing.Point(354, 185);
            this.lblTotalCharacters.Name = "lblTotalCharacters";
            this.lblTotalCharacters.Size = new System.Drawing.Size(141, 13);
            this.lblTotalCharacters.TabIndex = 11;
            this.lblTotalCharacters.Text = "Total # of Characters Used";
            // 
            // txbxTotalCharacters
            // 
            this.txbxTotalCharacters.Location = new System.Drawing.Point(518, 176);
            this.txbxTotalCharacters.Name = "txbxTotalCharacters";
            this.txbxTotalCharacters.ReadOnly = true;
            this.txbxTotalCharacters.Size = new System.Drawing.Size(37, 22);
            this.txbxTotalCharacters.TabIndex = 12;
            this.txbxTotalCharacters.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblDevTag);
            this.panel1.Controls.Add(this.btnUserInput);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 394);
            this.panel1.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 42);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "High Touch Technologies\'\r\n      Coding Challenge";
            // 
            // frmMain
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(579, 394);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbxTotalCharacters);
            this.Controls.Add(this.lblLeftoverLettersTotal);
            this.Controls.Add(this.lblTotalCharacters);
            this.Controls.Add(this.txbxLeftoverLetterTotal);
            this.Controls.Add(this.txbxResults);
            this.Controls.Add(this.txbxUserInput);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "High Touch Technologies Coding Challenge";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDevTag;
        private System.Windows.Forms.Button btnUserInput;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox txbxUserInput;
        private System.Windows.Forms.RichTextBox txbxResults;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblLeftoverLettersTotal;
        private System.Windows.Forms.TextBox txbxLeftoverLetterTotal;
        private System.Windows.Forms.Label lblTotalCharacters;
        private System.Windows.Forms.TextBox txbxTotalCharacters;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
    }
}

