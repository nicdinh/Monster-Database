namespace Combat_Simulator
{
    partial class SpellDisplayForm
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
            this.SpellName = new System.Windows.Forms.Label();
            this.School = new System.Windows.Forms.Label();
            this.Cast = new System.Windows.Forms.Label();
            this.Range = new System.Windows.Forms.Label();
            this.Component = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.RichTextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.SpellName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.School, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Cast, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Range, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Component, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Duration, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Info, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(599, 513);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SpellName
            // 
            this.SpellName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpellName.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.SpellName, 4);
            this.SpellName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpellName.Location = new System.Drawing.Point(3, 0);
            this.SpellName.Name = "SpellName";
            this.SpellName.Size = new System.Drawing.Size(593, 40);
            this.SpellName.TabIndex = 0;
            this.SpellName.Text = "Name";
            this.SpellName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // School
            // 
            this.School.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.School.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.School, 4);
            this.School.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.School.Location = new System.Drawing.Point(3, 40);
            this.School.Name = "School";
            this.School.Size = new System.Drawing.Size(593, 40);
            this.School.TabIndex = 1;
            this.School.Text = "School";
            this.School.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cast
            // 
            this.Cast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cast.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Cast, 4);
            this.Cast.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cast.Location = new System.Drawing.Point(3, 80);
            this.Cast.Name = "Cast";
            this.Cast.Size = new System.Drawing.Size(593, 40);
            this.Cast.TabIndex = 2;
            this.Cast.Text = "Cast Time";
            this.Cast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Range
            // 
            this.Range.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Range.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Range, 4);
            this.Range.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Range.Location = new System.Drawing.Point(3, 120);
            this.Range.Name = "Range";
            this.Range.Size = new System.Drawing.Size(593, 40);
            this.Range.TabIndex = 3;
            this.Range.Text = "Range";
            this.Range.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Component
            // 
            this.Component.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Component.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Component, 4);
            this.Component.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Component.Location = new System.Drawing.Point(3, 160);
            this.Component.Name = "Component";
            this.Component.Size = new System.Drawing.Size(593, 40);
            this.Component.TabIndex = 4;
            this.Component.Text = "Components";
            this.Component.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Duration
            // 
            this.Duration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Duration.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Duration, 4);
            this.Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration.Location = new System.Drawing.Point(3, 200);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(593, 40);
            this.Duration.TabIndex = 5;
            this.Duration.Text = "Duration";
            this.Duration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Info
            // 
            this.Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.Info, 4);
            this.Info.Location = new System.Drawing.Point(3, 243);
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.Size = new System.Drawing.Size(593, 267);
            this.Info.TabIndex = 6;
            this.Info.Text = "";
            // 
            // SpellDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 537);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SpellDisplayForm";
            this.Text = "SpellDisplayForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label SpellName;
        private System.Windows.Forms.Label School;
        private System.Windows.Forms.Label Cast;
        private System.Windows.Forms.Label Range;
        private System.Windows.Forms.Label Component;
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.RichTextBox Info;
    }
}