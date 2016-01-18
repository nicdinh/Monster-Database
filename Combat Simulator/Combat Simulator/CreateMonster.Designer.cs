namespace Combat_Simulator
{
    partial class CreateMonster
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
            this.createLayout = new System.Windows.Forms.TableLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.ACLabel = new System.Windows.Forms.Label();
            this.ACInput = new System.Windows.Forms.TextBox();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.HealthInput = new System.Windows.Forms.TextBox();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.SpeedInput = new System.Windows.Forms.TextBox();
            this.AddResistances = new System.Windows.Forms.Button();
            this.AddStats = new System.Windows.Forms.Button();
            this.AddThrow = new System.Windows.Forms.Button();
            this.AddSkill = new System.Windows.Forms.Button();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.SizeList = new System.Windows.Forms.ComboBox();
            this.AddCR = new System.Windows.Forms.Button();
            this.AddAction = new System.Windows.Forms.Button();
            this.AddAbility = new System.Windows.Forms.Button();
            this.Preview = new System.Windows.Forms.Button();
            this.Done = new System.Windows.Forms.Button();
            this.createLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // createLayout
            // 
            this.createLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createLayout.AutoSize = true;
            this.createLayout.ColumnCount = 8;
            this.createLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.createLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.createLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.createLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.createLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.createLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.createLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.createLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.createLayout.Controls.Add(this.NameLabel, 0, 0);
            this.createLayout.Controls.Add(this.NameInput, 1, 0);
            this.createLayout.Controls.Add(this.ACLabel, 2, 0);
            this.createLayout.Controls.Add(this.ACInput, 3, 0);
            this.createLayout.Controls.Add(this.HealthLabel, 4, 0);
            this.createLayout.Controls.Add(this.HealthInput, 5, 0);
            this.createLayout.Controls.Add(this.SpeedLabel, 6, 0);
            this.createLayout.Controls.Add(this.SpeedInput, 7, 0);
            this.createLayout.Controls.Add(this.AddResistances, 0, 1);
            this.createLayout.Controls.Add(this.AddStats, 0, 2);
            this.createLayout.Controls.Add(this.AddThrow, 2, 2);
            this.createLayout.Controls.Add(this.AddSkill, 4, 2);
            this.createLayout.Controls.Add(this.SizeLabel, 6, 2);
            this.createLayout.Controls.Add(this.SizeList, 7, 2);
            this.createLayout.Controls.Add(this.AddCR, 0, 3);
            this.createLayout.Controls.Add(this.AddAction, 2, 3);
            this.createLayout.Controls.Add(this.AddAbility, 4, 3);
            this.createLayout.Controls.Add(this.Preview, 6, 3);
            this.createLayout.Controls.Add(this.Done, 0, 4);
            this.createLayout.Location = new System.Drawing.Point(12, 12);
            this.createLayout.Name = "createLayout";
            this.createLayout.RowCount = 5;
            this.createLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.createLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.createLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.createLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.createLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.createLayout.Size = new System.Drawing.Size(813, 201);
            this.createLayout.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(3, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(95, 40);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameInput
            // 
            this.NameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameInput.Location = new System.Drawing.Point(104, 3);
            this.NameInput.Multiline = true;
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(95, 34);
            this.NameInput.TabIndex = 1;
            // 
            // ACLabel
            // 
            this.ACLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ACLabel.AutoSize = true;
            this.ACLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACLabel.Location = new System.Drawing.Point(205, 0);
            this.ACLabel.Name = "ACLabel";
            this.ACLabel.Size = new System.Drawing.Size(95, 40);
            this.ACLabel.TabIndex = 2;
            this.ACLabel.Text = "Armor Class";
            this.ACLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ACInput
            // 
            this.ACInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ACInput.Location = new System.Drawing.Point(306, 3);
            this.ACInput.Multiline = true;
            this.ACInput.Name = "ACInput";
            this.ACInput.Size = new System.Drawing.Size(95, 34);
            this.ACInput.TabIndex = 3;
            // 
            // HealthLabel
            // 
            this.HealthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthLabel.Location = new System.Drawing.Point(407, 0);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(95, 40);
            this.HealthLabel.TabIndex = 4;
            this.HealthLabel.Text = "Health";
            this.HealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HealthInput
            // 
            this.HealthInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HealthInput.Location = new System.Drawing.Point(508, 3);
            this.HealthInput.Multiline = true;
            this.HealthInput.Name = "HealthInput";
            this.HealthInput.Size = new System.Drawing.Size(95, 34);
            this.HealthInput.TabIndex = 5;
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedLabel.Location = new System.Drawing.Point(609, 0);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(95, 40);
            this.SpeedLabel.TabIndex = 6;
            this.SpeedLabel.Text = "Speed";
            this.SpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpeedInput
            // 
            this.SpeedInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedInput.Location = new System.Drawing.Point(710, 3);
            this.SpeedInput.Multiline = true;
            this.SpeedInput.Name = "SpeedInput";
            this.SpeedInput.Size = new System.Drawing.Size(100, 34);
            this.SpeedInput.TabIndex = 7;
            // 
            // AddResistances
            // 
            this.AddResistances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createLayout.SetColumnSpan(this.AddResistances, 8);
            this.AddResistances.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddResistances.Location = new System.Drawing.Point(3, 43);
            this.AddResistances.Name = "AddResistances";
            this.AddResistances.Size = new System.Drawing.Size(807, 34);
            this.AddResistances.TabIndex = 8;
            this.AddResistances.Text = "Add Resistances/Immunites";
            this.AddResistances.UseVisualStyleBackColor = true;
            // 
            // AddStats
            // 
            this.AddStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createLayout.SetColumnSpan(this.AddStats, 2);
            this.AddStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStats.Location = new System.Drawing.Point(3, 83);
            this.AddStats.Name = "AddStats";
            this.AddStats.Size = new System.Drawing.Size(196, 34);
            this.AddStats.TabIndex = 9;
            this.AddStats.Text = "Add Stats";
            this.AddStats.UseVisualStyleBackColor = true;
            // 
            // AddThrow
            // 
            this.AddThrow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createLayout.SetColumnSpan(this.AddThrow, 2);
            this.AddThrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddThrow.Location = new System.Drawing.Point(205, 83);
            this.AddThrow.Name = "AddThrow";
            this.AddThrow.Size = new System.Drawing.Size(196, 34);
            this.AddThrow.TabIndex = 10;
            this.AddThrow.Text = "Add Saving Throws";
            this.AddThrow.UseVisualStyleBackColor = true;
            // 
            // AddSkill
            // 
            this.AddSkill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createLayout.SetColumnSpan(this.AddSkill, 2);
            this.AddSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSkill.Location = new System.Drawing.Point(407, 83);
            this.AddSkill.Name = "AddSkill";
            this.AddSkill.Size = new System.Drawing.Size(196, 34);
            this.AddSkill.TabIndex = 11;
            this.AddSkill.Text = "Add Skill";
            this.AddSkill.UseVisualStyleBackColor = true;
            // 
            // SizeLabel
            // 
            this.SizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.Location = new System.Drawing.Point(609, 80);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(95, 40);
            this.SizeLabel.TabIndex = 12;
            this.SizeLabel.Text = "Size";
            this.SizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SizeList
            // 
            this.SizeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeList.FormattingEnabled = true;
            this.SizeList.Items.AddRange(new object[] {
            "Tiny",
            "Small",
            "Medium",
            "Large",
            "Huge",
            "Gargantuan"});
            this.SizeList.Location = new System.Drawing.Point(710, 83);
            this.SizeList.Name = "SizeList";
            this.SizeList.Size = new System.Drawing.Size(100, 32);
            this.SizeList.TabIndex = 13;
            this.SizeList.Text = "Medium";
            // 
            // AddCR
            // 
            this.AddCR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createLayout.SetColumnSpan(this.AddCR, 2);
            this.AddCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCR.Location = new System.Drawing.Point(3, 123);
            this.AddCR.Name = "AddCR";
            this.AddCR.Size = new System.Drawing.Size(196, 34);
            this.AddCR.TabIndex = 14;
            this.AddCR.Text = "CR/EXP";
            this.AddCR.UseVisualStyleBackColor = true;
            // 
            // AddAction
            // 
            this.AddAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createLayout.SetColumnSpan(this.AddAction, 2);
            this.AddAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAction.Location = new System.Drawing.Point(205, 123);
            this.AddAction.Name = "AddAction";
            this.AddAction.Size = new System.Drawing.Size(196, 34);
            this.AddAction.TabIndex = 15;
            this.AddAction.Text = "Add Action";
            this.AddAction.UseVisualStyleBackColor = true;
            this.AddAction.Click += new System.EventHandler(this.AddActionClick);
            // 
            // AddAbility
            // 
            this.AddAbility.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createLayout.SetColumnSpan(this.AddAbility, 2);
            this.AddAbility.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAbility.Location = new System.Drawing.Point(407, 123);
            this.AddAbility.Name = "AddAbility";
            this.AddAbility.Size = new System.Drawing.Size(196, 34);
            this.AddAbility.TabIndex = 16;
            this.AddAbility.Text = "Add Ability";
            this.AddAbility.UseVisualStyleBackColor = true;
            // 
            // Preview
            // 
            this.Preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createLayout.SetColumnSpan(this.Preview, 2);
            this.Preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preview.Location = new System.Drawing.Point(609, 123);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(201, 34);
            this.Preview.TabIndex = 17;
            this.Preview.Text = "Preview";
            this.Preview.UseVisualStyleBackColor = true;
            // 
            // Done
            // 
            this.Done.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createLayout.SetColumnSpan(this.Done, 8);
            this.Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.Location = new System.Drawing.Point(3, 163);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(807, 35);
            this.Done.TabIndex = 18;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.DoneClick);
            // 
            // CreateMonster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 225);
            this.Controls.Add(this.createLayout);
            this.Name = "CreateMonster";
            this.Text = "CreateMonster";
            this.createLayout.ResumeLayout(false);
            this.createLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel createLayout;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label ACLabel;
        private System.Windows.Forms.TextBox ACInput;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.TextBox HealthInput;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.TextBox SpeedInput;
        private System.Windows.Forms.Button AddResistances;
        private System.Windows.Forms.Button AddStats;
        private System.Windows.Forms.Button AddThrow;
        private System.Windows.Forms.Button AddSkill;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.ComboBox SizeList;
        private System.Windows.Forms.Button AddCR;
        private System.Windows.Forms.Button AddAction;
        private System.Windows.Forms.Button AddAbility;
        private System.Windows.Forms.Button Preview;
        private System.Windows.Forms.Button Done;

    }
}