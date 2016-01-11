namespace Combat_Simulator
{
    partial class AbilityForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.DesLabel = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.DescriptionInput = new System.Windows.Forms.TextBox();
            this.AddAnother = new System.Windows.Forms.Button();
            this.Done = new System.Windows.Forms.Button();
            this.StatsInput = new System.Windows.Forms.DataGridView();
            this.Str = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Con = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Char = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatsInput)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.NameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DesLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.NameInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DescriptionInput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddAnother, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Done, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.StatsInput, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(614, 327);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(3, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(198, 40);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DesLabel
            // 
            this.DesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DesLabel.AutoSize = true;
            this.DesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesLabel.Location = new System.Drawing.Point(3, 40);
            this.DesLabel.Name = "DesLabel";
            this.DesLabel.Size = new System.Drawing.Size(198, 167);
            this.DesLabel.TabIndex = 1;
            this.DesLabel.Text = "Description";
            this.DesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameInput
            // 
            this.NameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.NameInput, 2);
            this.NameInput.Location = new System.Drawing.Point(207, 3);
            this.NameInput.Multiline = true;
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(404, 34);
            this.NameInput.TabIndex = 2;
            // 
            // DescriptionInput
            // 
            this.DescriptionInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.DescriptionInput, 2);
            this.DescriptionInput.Location = new System.Drawing.Point(207, 43);
            this.DescriptionInput.Multiline = true;
            this.DescriptionInput.Name = "DescriptionInput";
            this.DescriptionInput.Size = new System.Drawing.Size(404, 161);
            this.DescriptionInput.TabIndex = 3;
            // 
            // AddAnother
            // 
            this.AddAnother.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddAnother.Location = new System.Drawing.Point(207, 290);
            this.AddAnother.Name = "AddAnother";
            this.AddAnother.Size = new System.Drawing.Size(198, 34);
            this.AddAnother.TabIndex = 4;
            this.AddAnother.Text = "Add Another";
            this.AddAnother.UseVisualStyleBackColor = true;
            this.AddAnother.Click += new System.EventHandler(this.AddClick);
            // 
            // Done
            // 
            this.Done.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Done.Location = new System.Drawing.Point(411, 290);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(200, 34);
            this.Done.TabIndex = 5;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.DoneClick);
            // 
            // StatsInput
            // 
            this.StatsInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatsInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StatsInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatsInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Str,
            this.Dex,
            this.Con,
            this.Int,
            this.Wis,
            this.Char});
            this.tableLayoutPanel1.SetColumnSpan(this.StatsInput, 3);
            this.StatsInput.Location = new System.Drawing.Point(3, 210);
            this.StatsInput.Name = "StatsInput";
            this.StatsInput.Size = new System.Drawing.Size(608, 74);
            this.StatsInput.TabIndex = 6;
            // 
            // Str
            // 
            this.Str.HeaderText = "Strength";
            this.Str.Name = "Str";
            // 
            // Dex
            // 
            this.Dex.HeaderText = "Dexterity";
            this.Dex.Name = "Dex";
            // 
            // Con
            // 
            this.Con.HeaderText = "Constitution";
            this.Con.Name = "Con";
            // 
            // Int
            // 
            this.Int.HeaderText = "Intelligence";
            this.Int.Name = "Int";
            // 
            // Wis
            // 
            this.Wis.HeaderText = "Wisdom";
            this.Wis.Name = "Wis";
            // 
            // Char
            // 
            this.Char.HeaderText = "Charisma";
            this.Char.Name = "Char";
            // 
            // AbilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 351);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AbilityForm";
            this.Text = "Ability";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatsInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DesLabel;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox DescriptionInput;
        private System.Windows.Forms.Button AddAnother;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.DataGridView StatsInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Str;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Con;
        private System.Windows.Forms.DataGridViewTextBoxColumn Int;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Char;
    }
}