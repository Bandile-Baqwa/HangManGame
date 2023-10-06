namespace HangManGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            pDraw = new Panel();
            groupBox2 = new GroupBox();
            lblWordLength = new Label();
            lblMissedLetters = new Label();
            groupBox3 = new GroupBox();
            txtSubmitWord = new TextBox();
            txtSubmitLetter = new TextBox();
            btnSubmitWord = new Button();
            btnSubmitLetter = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pDraw);
            groupBox1.Location = new Point(354, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(155, 256);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "HangMan";
            // 
            // pDraw
            // 
            pDraw.Dock = DockStyle.Fill;
            pDraw.Location = new Point(3, 19);
            pDraw.Name = "pDraw";
            pDraw.Size = new Size(149, 234);
            pDraw.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblWordLength);
            groupBox2.Controls.Add(lblMissedLetters);
            groupBox2.Location = new Point(12, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(336, 173);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Word";
            // 
            // lblWordLength
            // 
            lblWordLength.AutoSize = true;
            lblWordLength.Location = new Point(248, 143);
            lblWordLength.Name = "lblWordLength";
            lblWordLength.Size = new Size(82, 15);
            lblWordLength.TabIndex = 1;
            lblWordLength.Text = "Word Length :";
            // 
            // lblMissedLetters
            // 
            lblMissedLetters.AutoSize = true;
            lblMissedLetters.Location = new Point(10, 143);
            lblMissedLetters.Name = "lblMissedLetters";
            lblMissedLetters.Size = new Size(92, 15);
            lblMissedLetters.TabIndex = 0;
            lblMissedLetters.Text = "Missing Letters :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSubmitWord);
            groupBox3.Controls.Add(txtSubmitLetter);
            groupBox3.Controls.Add(btnSubmitWord);
            groupBox3.Controls.Add(btnSubmitLetter);
            groupBox3.Location = new Point(12, 190);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(336, 77);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Submit";
            // 
            // txtSubmitWord
            // 
            txtSubmitWord.Location = new Point(239, 50);
            txtSubmitWord.Name = "txtSubmitWord";
            txtSubmitWord.Size = new Size(92, 23);
            txtSubmitWord.TabIndex = 3;
            // 
            // txtSubmitLetter
            // 
            txtSubmitLetter.Location = new Point(11, 48);
            txtSubmitLetter.Name = "txtSubmitLetter";
            txtSubmitLetter.Size = new Size(20, 23);
            txtSubmitLetter.TabIndex = 2;
            // 
            // btnSubmitWord
            // 
            btnSubmitWord.Location = new Point(238, 19);
            btnSubmitWord.Name = "btnSubmitWord";
            btnSubmitWord.Size = new Size(92, 23);
            btnSubmitWord.TabIndex = 1;
            btnSubmitWord.Text = "Submit Word";
            btnSubmitWord.UseVisualStyleBackColor = true;
            btnSubmitWord.Click += btnSubmitWord_Click_1;
            // 
            // btnSubmitLetter
            // 
            btnSubmitLetter.Location = new Point(7, 19);
            btnSubmitLetter.Name = "btnSubmitLetter";
            btnSubmitLetter.Size = new Size(92, 23);
            btnSubmitLetter.TabIndex = 0;
            btnSubmitLetter.Text = "Submit Letter";
            btnSubmitLetter.UseVisualStyleBackColor = true;
            btnSubmitLetter.Click += btnSubmitLetter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 279);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Hang Man ";
            Load += Form1_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel pDraw;
        private GroupBox groupBox3;
        private Label lblWordLength;
        private Label lblMissedLetters;
        private TextBox txtSubmitWord;
        private TextBox txtSubmitLetter;
        private Button btnSubmitWord;
        private Button btnSubmitLetter;
    }
}