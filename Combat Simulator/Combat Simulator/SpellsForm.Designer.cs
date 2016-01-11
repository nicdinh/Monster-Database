namespace Combat_Simulator
{
    partial class SpellsForm
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
            this.LevelLabel = new System.Windows.Forms.Label();
            this.LevelInput = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.LevelList = new System.Windows.Forms.ComboBox();
            this.Done = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.SlotsLabel = new System.Windows.Forms.Label();
            this.SlotsInput = new System.Windows.Forms.TextBox();
            this.DCLabel = new System.Windows.Forms.Label();
            this.DCInput = new System.Windows.Forms.TextBox();
            this.ModLabel = new System.Windows.Forms.Label();
            this.ModInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.LevelLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LevelInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.NameLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.NameInput, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.LevelList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SlotsLabel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.SlotsInput, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.Add, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.Done, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.DCLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DCInput, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ModLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ModInput, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(557, 152);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LevelLabel
            // 
            this.LevelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(3, 0);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(86, 50);
            this.LevelLabel.TabIndex = 0;
            this.LevelLabel.Text = "Spell Level";
            this.LevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LevelInput
            // 
            this.LevelInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LevelInput.Location = new System.Drawing.Point(95, 3);
            this.LevelInput.Multiline = true;
            this.LevelInput.Name = "LevelInput";
            this.LevelInput.Size = new System.Drawing.Size(86, 44);
            this.LevelInput.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(187, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(86, 50);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Spell Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameInput
            // 
            this.NameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameInput.Location = new System.Drawing.Point(279, 3);
            this.NameInput.Multiline = true;
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(86, 44);
            this.NameInput.TabIndex = 4;
            // 
            // LevelList
            // 
            this.LevelList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LevelList.FormattingEnabled = true;
            this.LevelList.Items.AddRange(new object[] {
            "Cantrip",
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4",
            "Level 5",
            "Level 6",
            "Level 7",
            "Level 8",
            "Level 9"});
            this.LevelList.Location = new System.Drawing.Point(3, 53);
            this.LevelList.Name = "LevelList";
            this.LevelList.Size = new System.Drawing.Size(86, 21);
            this.LevelList.TabIndex = 2;
            this.LevelList.TextChanged += new System.EventHandler(this.LevelChange);
            // 
            // Done
            // 
            this.Done.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Done.Location = new System.Drawing.Point(463, 103);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(91, 46);
            this.Done.TabIndex = 12;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.DoneClick);
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.Location = new System.Drawing.Point(371, 103);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(86, 46);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add Another";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.AddClick);
            // 
            // SlotsLabel
            // 
            this.SlotsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SlotsLabel.AutoSize = true;
            this.SlotsLabel.Location = new System.Drawing.Point(371, 0);
            this.SlotsLabel.Name = "SlotsLabel";
            this.SlotsLabel.Size = new System.Drawing.Size(86, 50);
            this.SlotsLabel.TabIndex = 5;
            this.SlotsLabel.Text = "Spell Slots";
            this.SlotsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SlotsInput
            // 
            this.SlotsInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SlotsInput.Location = new System.Drawing.Point(463, 3);
            this.SlotsInput.Multiline = true;
            this.SlotsInput.Name = "SlotsInput";
            this.SlotsInput.Size = new System.Drawing.Size(91, 44);
            this.SlotsInput.TabIndex = 6;
            this.SlotsInput.LostFocus += new System.EventHandler(this.SlotsChange);
            // 
            // DCLabel
            // 
            this.DCLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DCLabel.AutoSize = true;
            this.DCLabel.Location = new System.Drawing.Point(3, 100);
            this.DCLabel.Name = "DCLabel";
            this.DCLabel.Size = new System.Drawing.Size(86, 52);
            this.DCLabel.TabIndex = 7;
            this.DCLabel.Text = "Spell DC";
            this.DCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DCInput
            // 
            this.DCInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DCInput.Location = new System.Drawing.Point(95, 103);
            this.DCInput.Multiline = true;
            this.DCInput.Name = "DCInput";
            this.DCInput.Size = new System.Drawing.Size(86, 46);
            this.DCInput.TabIndex = 8;
            // 
            // ModLabel
            // 
            this.ModLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModLabel.AutoSize = true;
            this.ModLabel.Location = new System.Drawing.Point(187, 100);
            this.ModLabel.Name = "ModLabel";
            this.ModLabel.Size = new System.Drawing.Size(86, 52);
            this.ModLabel.TabIndex = 9;
            this.ModLabel.Text = "Spell Mod";
            this.ModLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModInput
            // 
            this.ModInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModInput.Location = new System.Drawing.Point(279, 103);
            this.ModInput.Multiline = true;
            this.ModInput.Name = "ModInput";
            this.ModInput.Size = new System.Drawing.Size(86, 46);
            this.ModInput.TabIndex = 10;
            // 
            // SpellsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 176);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SpellsForm";
            this.Text = "SpellsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.TextBox LevelInput;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.ComboBox LevelList;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label SlotsLabel;
        private System.Windows.Forms.TextBox SlotsInput;
        private System.Windows.Forms.Label DCLabel;
        private System.Windows.Forms.TextBox DCInput;
        private System.Windows.Forms.Label ModLabel;
        private System.Windows.Forms.TextBox ModInput;
    }
}