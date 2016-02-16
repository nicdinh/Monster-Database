namespace Combat_Simulator
{
    partial class SpellorAttackForm
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
            this.Attack = new System.Windows.Forms.Button();
            this.Spell = new System.Windows.Forms.Button();
            this.Legendary = new System.Windows.Forms.Button();
            this.OldSpell = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.Attack, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Spell, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Legendary, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.OldSpell, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 77);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Attack
            // 
            this.Attack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Attack.Location = new System.Drawing.Point(3, 3);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(137, 32);
            this.Attack.TabIndex = 0;
            this.Attack.Text = "Attack";
            this.Attack.UseVisualStyleBackColor = true;
            this.Attack.Click += new System.EventHandler(this.AttackClick);
            // 
            // Spell
            // 
            this.Spell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Spell.Location = new System.Drawing.Point(146, 3);
            this.Spell.Name = "Spell";
            this.Spell.Size = new System.Drawing.Size(137, 32);
            this.Spell.TabIndex = 1;
            this.Spell.Text = "Spell";
            this.Spell.UseVisualStyleBackColor = true;
            this.Spell.Click += new System.EventHandler(this.SpellClick);
            // 
            // Legendary
            // 
            this.Legendary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Legendary.Location = new System.Drawing.Point(289, 3);
            this.Legendary.Name = "Legendary";
            this.Legendary.Size = new System.Drawing.Size(138, 32);
            this.Legendary.TabIndex = 2;
            this.Legendary.Text = "Legendary";
            this.Legendary.UseVisualStyleBackColor = true;
            this.Legendary.Click += new System.EventHandler(this.LegendaryClick);
            // 
            // OldSpell
            // 
            this.OldSpell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.OldSpell, 3);
            this.OldSpell.Location = new System.Drawing.Point(3, 41);
            this.OldSpell.Name = "OldSpell";
            this.OldSpell.Size = new System.Drawing.Size(424, 33);
            this.OldSpell.TabIndex = 3;
            this.OldSpell.Text = "Exsisting Spell";
            this.OldSpell.UseVisualStyleBackColor = true;
            this.OldSpell.Click += new System.EventHandler(this.OldClick);
            // 
            // SpellorAttackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 101);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SpellorAttackForm";
            this.Text = "SpellorAttackForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Attack;
        private System.Windows.Forms.Button Spell;
        private System.Windows.Forms.Button Legendary;
        private System.Windows.Forms.Button OldSpell;
    }
}