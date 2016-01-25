namespace Combat_Simulator
{
    partial class TypeForm
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
            this.TypeLabel = new System.Windows.Forms.Label();
            this.AlignmentLabel = new System.Windows.Forms.Label();
            this.TypeInput = new System.Windows.Forms.TextBox();
            this.AlignmentInput = new System.Windows.Forms.TextBox();
            this.Done = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TypeLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AlignmentLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TypeInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AlignmentInput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Done, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 121);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(3, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(225, 40);
            this.TypeLabel.TabIndex = 0;
            this.TypeLabel.Text = "Monster Type";
            this.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlignmentLabel
            // 
            this.AlignmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlignmentLabel.AutoSize = true;
            this.AlignmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlignmentLabel.Location = new System.Drawing.Point(3, 40);
            this.AlignmentLabel.Name = "AlignmentLabel";
            this.AlignmentLabel.Size = new System.Drawing.Size(225, 40);
            this.AlignmentLabel.TabIndex = 1;
            this.AlignmentLabel.Text = "Alignment";
            this.AlignmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TypeInput
            // 
            this.TypeInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeInput.Location = new System.Drawing.Point(234, 3);
            this.TypeInput.Multiline = true;
            this.TypeInput.Name = "TypeInput";
            this.TypeInput.Size = new System.Drawing.Size(225, 34);
            this.TypeInput.TabIndex = 2;
            // 
            // AlignmentInput
            // 
            this.AlignmentInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlignmentInput.Location = new System.Drawing.Point(234, 43);
            this.AlignmentInput.Multiline = true;
            this.AlignmentInput.Name = "AlignmentInput";
            this.AlignmentInput.Size = new System.Drawing.Size(225, 34);
            this.AlignmentInput.TabIndex = 3;
            // 
            // Done
            // 
            this.Done.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.Done, 2);
            this.Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.Location = new System.Drawing.Point(3, 83);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(456, 35);
            this.Done.TabIndex = 4;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.DoneClick);
            // 
            // TypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 145);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TypeForm";
            this.Text = "TypeForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label AlignmentLabel;
        private System.Windows.Forms.TextBox TypeInput;
        private System.Windows.Forms.TextBox AlignmentInput;
        private System.Windows.Forms.Button Done;
    }
}