namespace Combat_Simulator
{
    partial class AttackForm
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
            this.MeleeButton = new System.Windows.Forms.RadioButton();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.DamageLabel = new System.Windows.Forms.Label();
            this.AttackModLabel = new System.Windows.Forms.Label();
            this.RangeButton = new System.Windows.Forms.RadioButton();
            this.AttackModInput = new System.Windows.Forms.TextBox();
            this.DamageInput = new System.Windows.Forms.TextBox();
            this.NormalLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.NormalInput = new System.Windows.Forms.TextBox();
            this.MaxInput = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.MeleeButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.NameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.NameInput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DamageLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.AttackModLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.RangeButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.AttackModInput, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.DamageInput, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.NormalLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MaxLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.NormalInput, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.MaxInput, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Add, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Done, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 185);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MeleeButton
            // 
            this.MeleeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MeleeButton.AutoSize = true;
            this.MeleeButton.Location = new System.Drawing.Point(3, 3);
            this.MeleeButton.Name = "MeleeButton";
            this.MeleeButton.Size = new System.Drawing.Size(98, 24);
            this.MeleeButton.TabIndex = 0;
            this.MeleeButton.TabStop = true;
            this.MeleeButton.Text = "Melee";
            this.MeleeButton.UseVisualStyleBackColor = true;
            this.MeleeButton.CheckedChanged += new System.EventHandler(this.MeleeButtonChange);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(3, 30);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(98, 51);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameInput
            // 
            this.NameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameInput.Location = new System.Drawing.Point(107, 33);
            this.NameInput.Multiline = true;
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(98, 45);
            this.NameInput.TabIndex = 3;
            // 
            // DamageLabel
            // 
            this.DamageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DamageLabel.AutoSize = true;
            this.DamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DamageLabel.Location = new System.Drawing.Point(3, 132);
            this.DamageLabel.Name = "DamageLabel";
            this.DamageLabel.Size = new System.Drawing.Size(98, 53);
            this.DamageLabel.TabIndex = 4;
            this.DamageLabel.Text = "Damage";
            this.DamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AttackModLabel
            // 
            this.AttackModLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AttackModLabel.AutoSize = true;
            this.AttackModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttackModLabel.Location = new System.Drawing.Point(3, 81);
            this.AttackModLabel.Name = "AttackModLabel";
            this.AttackModLabel.Size = new System.Drawing.Size(98, 51);
            this.AttackModLabel.TabIndex = 7;
            this.AttackModLabel.Text = "Attack Modifier";
            this.AttackModLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RangeButton
            // 
            this.RangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RangeButton.AutoSize = true;
            this.RangeButton.Location = new System.Drawing.Point(211, 3);
            this.RangeButton.Name = "RangeButton";
            this.RangeButton.Size = new System.Drawing.Size(98, 24);
            this.RangeButton.TabIndex = 1;
            this.RangeButton.TabStop = true;
            this.RangeButton.Text = "Range";
            this.RangeButton.UseVisualStyleBackColor = true;
            // 
            // AttackModInput
            // 
            this.AttackModInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AttackModInput.Location = new System.Drawing.Point(107, 84);
            this.AttackModInput.Multiline = true;
            this.AttackModInput.Name = "AttackModInput";
            this.AttackModInput.Size = new System.Drawing.Size(98, 45);
            this.AttackModInput.TabIndex = 8;
            // 
            // DamageInput
            // 
            this.DamageInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DamageInput.Location = new System.Drawing.Point(107, 135);
            this.DamageInput.Multiline = true;
            this.DamageInput.Name = "DamageInput";
            this.DamageInput.Size = new System.Drawing.Size(98, 47);
            this.DamageInput.TabIndex = 9;
            // 
            // NormalLabel
            // 
            this.NormalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NormalLabel.AutoSize = true;
            this.NormalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalLabel.Location = new System.Drawing.Point(211, 30);
            this.NormalLabel.Name = "NormalLabel";
            this.NormalLabel.Size = new System.Drawing.Size(98, 51);
            this.NormalLabel.TabIndex = 10;
            this.NormalLabel.Text = "Normal Range";
            this.NormalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaxLabel
            // 
            this.MaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxLabel.Location = new System.Drawing.Point(211, 81);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(98, 51);
            this.MaxLabel.TabIndex = 11;
            this.MaxLabel.Text = "Max Range";
            this.MaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MaxLabel.Visible = false;
            // 
            // NormalInput
            // 
            this.NormalInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NormalInput.Location = new System.Drawing.Point(315, 33);
            this.NormalInput.Multiline = true;
            this.NormalInput.Name = "NormalInput";
            this.NormalInput.Size = new System.Drawing.Size(99, 45);
            this.NormalInput.TabIndex = 12;
            // 
            // MaxInput
            // 
            this.MaxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxInput.Location = new System.Drawing.Point(315, 84);
            this.MaxInput.Multiline = true;
            this.MaxInput.Name = "MaxInput";
            this.MaxInput.Size = new System.Drawing.Size(99, 45);
            this.MaxInput.TabIndex = 13;
            this.MaxInput.Visible = false;
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.Location = new System.Drawing.Point(211, 135);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(98, 47);
            this.Add.TabIndex = 14;
            this.Add.Text = "Add Another";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.AddClick);
            // 
            // Done
            // 
            this.Done.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Done.Location = new System.Drawing.Point(315, 135);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(99, 47);
            this.Done.TabIndex = 15;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.DoneClick);
            // 
            // AttackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 209);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AttackForm";
            this.Text = "Action Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton MeleeButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label DamageLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AttackModLabel;
        private System.Windows.Forms.RadioButton RangeButton;
        private System.Windows.Forms.TextBox AttackModInput;
        private System.Windows.Forms.TextBox DamageInput;
        private System.Windows.Forms.Label NormalLabel;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.TextBox NormalInput;
        private System.Windows.Forms.TextBox MaxInput;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Done;

    }
}