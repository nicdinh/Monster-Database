namespace Combat_Simulator
{
    partial class CRForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CRLabel = new System.Windows.Forms.Label();
            this.CRInput = new System.Windows.Forms.TextBox();
            this.EXPLabel = new System.Windows.Forms.Label();
            this.EXPInput = new System.Windows.Forms.TextBox();
            this.CRList = new System.Windows.Forms.ComboBox();
            this.EXPList = new System.Windows.Forms.ComboBox();
            this.Done = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.CRLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CRInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.EXPLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.EXPInput, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.CRList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.EXPList, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Done, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 122);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CRLabel
            // 
            this.CRLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CRLabel.AutoSize = true;
            this.CRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRLabel.Location = new System.Drawing.Point(3, 0);
            this.CRLabel.Name = "CRLabel";
            this.CRLabel.Size = new System.Drawing.Size(108, 61);
            this.CRLabel.TabIndex = 0;
            this.CRLabel.Text = "Challenge Rating";
            this.CRLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CRInput
            // 
            this.CRInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CRInput.Location = new System.Drawing.Point(117, 3);
            this.CRInput.Multiline = true;
            this.CRInput.Name = "CRInput";
            this.CRInput.Size = new System.Drawing.Size(108, 55);
            this.CRInput.TabIndex = 1;
            // 
            // EXPLabel
            // 
            this.EXPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EXPLabel.AutoSize = true;
            this.EXPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXPLabel.Location = new System.Drawing.Point(231, 0);
            this.EXPLabel.Name = "EXPLabel";
            this.EXPLabel.Size = new System.Drawing.Size(108, 61);
            this.EXPLabel.TabIndex = 2;
            this.EXPLabel.Text = "Experience";
            this.EXPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EXPInput
            // 
            this.EXPInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EXPInput.Location = new System.Drawing.Point(345, 3);
            this.EXPInput.Multiline = true;
            this.EXPInput.Name = "EXPInput";
            this.EXPInput.Size = new System.Drawing.Size(109, 55);
            this.EXPInput.TabIndex = 3;
            // 
            // CRList
            // 
            this.CRList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CRList.FormattingEnabled = true;
            this.CRList.Items.AddRange(new object[] {
            "Challenge 0",
            "Challenge 1/8",
            "Challenge 1/4",
            "Challenge 1/2",
            "Challenge 1",
            "Challenge 2",
            "Challenge 3",
            "Challenge 4",
            "Challenge 5",
            "Challenge 6",
            "Challenge 7",
            "Challenge 8",
            "Challenge 9",
            "Challenge 10",
            "Challenge 11",
            "Challenge 12",
            "Challenge 13",
            "Challenge 14",
            "Challenge 15",
            "Challenge 16",
            "Challenge 17",
            "Challenge 18",
            "Challenge 19",
            "Challenge 20",
            "Challenge 21",
            "Challenge 22",
            "Challenge 23",
            "Challenge 24",
            "Challenge 30"});
            this.CRList.Location = new System.Drawing.Point(3, 64);
            this.CRList.Name = "CRList";
            this.CRList.Size = new System.Drawing.Size(108, 21);
            this.CRList.TabIndex = 4;
            this.CRList.TextChanged += new System.EventHandler(this.ChallengeChange);
            // 
            // EXPList
            // 
            this.EXPList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EXPList.FormattingEnabled = true;
            this.EXPList.Items.AddRange(new object[] {
            "10 XP",
            "25 XP",
            "50 XP",
            "100 XP",
            "200 XP",
            "450 XP",
            "700 XP",
            "1 100 XP",
            "1 800  XP",
            "2 300  XP",
            "2 900 XP",
            "3 900 XP",
            "5 000 XP",
            "5 900 XP",
            "7 200 XP",
            "8 400 XP",
            "10 000 XP",
            "11 500 XP",
            "13 000 XP",
            "15 000  XP",
            "18 000 XP",
            "20 000 XP",
            "22 000 XP",
            "25 000 XP",
            "33 000 XP",
            "41 000 XP",
            "50 000 XP",
            "62 000 XP",
            "155 000 XP"});
            this.EXPList.Location = new System.Drawing.Point(231, 64);
            this.EXPList.Name = "EXPList";
            this.EXPList.Size = new System.Drawing.Size(108, 21);
            this.EXPList.TabIndex = 5;
            this.EXPList.TextChanged += new System.EventHandler(this.ExperienceChange);
            // 
            // Done
            // 
            this.Done.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Done.Location = new System.Drawing.Point(345, 64);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(109, 55);
            this.Done.TabIndex = 6;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.DoneClick);
            // 
            // CRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 146);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CRForm";
            this.Text = "Challenge Rating";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label CRLabel;
        private System.Windows.Forms.TextBox CRInput;
        private System.Windows.Forms.Label EXPLabel;
        private System.Windows.Forms.TextBox EXPInput;
        private System.Windows.Forms.ComboBox CRList;
        private System.Windows.Forms.ComboBox EXPList;
        private System.Windows.Forms.Button Done;

    }
}