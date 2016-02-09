namespace Combat_Simulator
{
    partial class SenseForm
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
            this.SenseLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NameLabel1 = new System.Windows.Forms.Label();
            this.SenseRangeLabel = new System.Windows.Forms.Label();
            this.NameLabel2 = new System.Windows.Forms.Label();
            this.SenseRangeLabel2 = new System.Windows.Forms.Label();
            this.BlindSight = new System.Windows.Forms.CheckBox();
            this.BlindRange = new System.Windows.Forms.TextBox();
            this.DarkVision = new System.Windows.Forms.CheckBox();
            this.DarkRange = new System.Windows.Forms.TextBox();
            this.Tremorsense = new System.Windows.Forms.CheckBox();
            this.TremorsenseRange = new System.Windows.Forms.TextBox();
            this.TrueSight = new System.Windows.Forms.CheckBox();
            this.TrueRange = new System.Windows.Forms.TextBox();
            this.Done = new System.Windows.Forms.Button();
            this.Passive = new System.Windows.Forms.Label();
            this.PassiveInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SenseLabel
            // 
            this.SenseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SenseLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.SenseLabel, 4);
            this.SenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenseLabel.Location = new System.Drawing.Point(3, 0);
            this.SenseLabel.Name = "SenseLabel";
            this.SenseLabel.Size = new System.Drawing.Size(596, 46);
            this.SenseLabel.TabIndex = 0;
            this.SenseLabel.Text = "Sense";
            this.SenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel1.Controls.Add(this.SenseLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.NameLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SenseRangeLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.NameLabel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.SenseRangeLabel2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.BlindSight, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BlindRange, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.DarkVision, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.DarkRange, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Tremorsense, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TremorsenseRange, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TrueSight, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.TrueRange, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Done, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.Passive, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.PassiveInput, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(602, 213);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NameLabel1
            // 
            this.NameLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel1.AutoSize = true;
            this.NameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel1.Location = new System.Drawing.Point(3, 46);
            this.NameLabel1.Name = "NameLabel1";
            this.NameLabel1.Size = new System.Drawing.Size(144, 40);
            this.NameLabel1.TabIndex = 1;
            this.NameLabel1.Text = "Sense Names";
            this.NameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SenseRangeLabel
            // 
            this.SenseRangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SenseRangeLabel.AutoSize = true;
            this.SenseRangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenseRangeLabel.Location = new System.Drawing.Point(153, 46);
            this.SenseRangeLabel.Name = "SenseRangeLabel";
            this.SenseRangeLabel.Size = new System.Drawing.Size(144, 40);
            this.SenseRangeLabel.TabIndex = 2;
            this.SenseRangeLabel.Text = "Sense Range";
            this.SenseRangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SenseRangeLabel.Visible = false;
            // 
            // NameLabel2
            // 
            this.NameLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel2.AutoSize = true;
            this.NameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel2.Location = new System.Drawing.Point(303, 46);
            this.NameLabel2.Name = "NameLabel2";
            this.NameLabel2.Size = new System.Drawing.Size(144, 40);
            this.NameLabel2.TabIndex = 3;
            this.NameLabel2.Text = "Sense Names";
            this.NameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SenseRangeLabel2
            // 
            this.SenseRangeLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SenseRangeLabel2.AutoSize = true;
            this.SenseRangeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenseRangeLabel2.Location = new System.Drawing.Point(453, 46);
            this.SenseRangeLabel2.Name = "SenseRangeLabel2";
            this.SenseRangeLabel2.Size = new System.Drawing.Size(146, 40);
            this.SenseRangeLabel2.TabIndex = 4;
            this.SenseRangeLabel2.Text = "Sense Range";
            this.SenseRangeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SenseRangeLabel2.Visible = false;
            // 
            // BlindSight
            // 
            this.BlindSight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlindSight.AutoSize = true;
            this.BlindSight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlindSight.Location = new System.Drawing.Point(3, 89);
            this.BlindSight.Name = "BlindSight";
            this.BlindSight.Size = new System.Drawing.Size(144, 34);
            this.BlindSight.TabIndex = 5;
            this.BlindSight.Text = "Blind Sight";
            this.BlindSight.UseVisualStyleBackColor = true;
            this.BlindSight.CheckedChanged += new System.EventHandler(this.BlindChecked);
            // 
            // BlindRange
            // 
            this.BlindRange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlindRange.Location = new System.Drawing.Point(153, 89);
            this.BlindRange.Multiline = true;
            this.BlindRange.Name = "BlindRange";
            this.BlindRange.Size = new System.Drawing.Size(144, 34);
            this.BlindRange.TabIndex = 6;
            this.BlindRange.Visible = false;
            // 
            // DarkVision
            // 
            this.DarkVision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DarkVision.AutoSize = true;
            this.DarkVision.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DarkVision.Location = new System.Drawing.Point(303, 89);
            this.DarkVision.Name = "DarkVision";
            this.DarkVision.Size = new System.Drawing.Size(144, 34);
            this.DarkVision.TabIndex = 7;
            this.DarkVision.Text = "Dark Vision";
            this.DarkVision.UseVisualStyleBackColor = true;
            this.DarkVision.CheckedChanged += new System.EventHandler(this.DarkChecked);
            // 
            // DarkRange
            // 
            this.DarkRange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DarkRange.Location = new System.Drawing.Point(453, 89);
            this.DarkRange.Multiline = true;
            this.DarkRange.Name = "DarkRange";
            this.DarkRange.Size = new System.Drawing.Size(146, 34);
            this.DarkRange.TabIndex = 8;
            this.DarkRange.Visible = false;
            // 
            // Tremorsense
            // 
            this.Tremorsense.AutoSize = true;
            this.Tremorsense.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tremorsense.Location = new System.Drawing.Point(3, 129);
            this.Tremorsense.Name = "Tremorsense";
            this.Tremorsense.Size = new System.Drawing.Size(142, 28);
            this.Tremorsense.TabIndex = 9;
            this.Tremorsense.Text = "Tremorsense";
            this.Tremorsense.UseVisualStyleBackColor = true;
            this.Tremorsense.CheckedChanged += new System.EventHandler(this.TremorsenseChecked);
            // 
            // TremorsenseRange
            // 
            this.TremorsenseRange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TremorsenseRange.Location = new System.Drawing.Point(153, 129);
            this.TremorsenseRange.Multiline = true;
            this.TremorsenseRange.Name = "TremorsenseRange";
            this.TremorsenseRange.Size = new System.Drawing.Size(144, 34);
            this.TremorsenseRange.TabIndex = 10;
            this.TremorsenseRange.Visible = false;
            // 
            // TrueSight
            // 
            this.TrueSight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrueSight.AutoSize = true;
            this.TrueSight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrueSight.Location = new System.Drawing.Point(303, 129);
            this.TrueSight.Name = "TrueSight";
            this.TrueSight.Size = new System.Drawing.Size(144, 34);
            this.TrueSight.TabIndex = 11;
            this.TrueSight.Text = "True Sight";
            this.TrueSight.UseVisualStyleBackColor = true;
            this.TrueSight.CheckedChanged += new System.EventHandler(this.TrueChecked);
            // 
            // TrueRange
            // 
            this.TrueRange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrueRange.Location = new System.Drawing.Point(453, 129);
            this.TrueRange.Multiline = true;
            this.TrueRange.Name = "TrueRange";
            this.TrueRange.Size = new System.Drawing.Size(146, 34);
            this.TrueRange.TabIndex = 12;
            this.TrueRange.Visible = false;
            // 
            // Done
            // 
            this.Done.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.Done, 2);
            this.Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.Location = new System.Drawing.Point(303, 169);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(296, 41);
            this.Done.TabIndex = 13;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.DoneClick);
            // 
            // Passive
            // 
            this.Passive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Passive.AutoSize = true;
            this.Passive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passive.Location = new System.Drawing.Point(3, 166);
            this.Passive.Name = "Passive";
            this.Passive.Size = new System.Drawing.Size(144, 47);
            this.Passive.TabIndex = 14;
            this.Passive.Text = "Passive Perception";
            this.Passive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PassiveInput
            // 
            this.PassiveInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassiveInput.Location = new System.Drawing.Point(153, 169);
            this.PassiveInput.Multiline = true;
            this.PassiveInput.Name = "PassiveInput";
            this.PassiveInput.Size = new System.Drawing.Size(144, 41);
            this.PassiveInput.TabIndex = 15;
            // 
            // SenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 237);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Add Senses";
            this.Text = "SenseForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SenseLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label NameLabel1;
        private System.Windows.Forms.Label SenseRangeLabel;
        private System.Windows.Forms.Label NameLabel2;
        private System.Windows.Forms.Label SenseRangeLabel2;
        private System.Windows.Forms.CheckBox BlindSight;
        private System.Windows.Forms.TextBox BlindRange;
        private System.Windows.Forms.CheckBox DarkVision;
        private System.Windows.Forms.TextBox DarkRange;
        private System.Windows.Forms.CheckBox Tremorsense;
        private System.Windows.Forms.TextBox TremorsenseRange;
        private System.Windows.Forms.CheckBox TrueSight;
        private System.Windows.Forms.TextBox TrueRange;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Label Passive;
        private System.Windows.Forms.TextBox PassiveInput;
    }
}