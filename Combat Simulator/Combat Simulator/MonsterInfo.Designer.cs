namespace Combat_Simulator
{
    partial class MonsterInfo
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
        private void InitializeComponent(Monster Input)
        {
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";

            this.tableLayoutPanel3.RowCount = Input.AmountRows();
            for (int x = 0; x < Input.AmountRows();x++ )
            {
                if (Input.Ability.IsNull() == true && Input.Action.Contains == true && x == Input.AmountRows() - 2)
                {
                    this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
                    this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
                    break;
                }
                else if ((Input.Ability.IsNull() == true || Input.Action.Contains == true) && x == Input.AmountRows() - 1)
                {
                    this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
                }
                else
                {
                    this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
                }
            }
            this.tableLayoutPanel3.Size = new System.Drawing.Size(690, 481);
            this.tableLayoutPanel3.TabIndex = 0;

            //
            // NameLabel
            //


            // 
            // MonsterInfo
            // 
            this.ClientSize = new System.Drawing.Size(714, 505);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "MonsterInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label Immunity;
        private System.Windows.Forms.Label Resistance;
        private System.Windows.Forms.Label Sense;
        private System.Windows.Forms.Label Skills;
        private System.Windows.Forms.Label Ability;
        private System.Windows.Forms.Label Actions;
        private System.Windows.Forms.DataGridView Stats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Str;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Con;
        private System.Windows.Forms.DataGridViewTextBoxColumn Int;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Char;


    }
}