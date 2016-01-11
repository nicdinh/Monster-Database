namespace Combat_Simulator
{
    partial class MainMenu
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
            this.Allies = new System.Windows.Forms.GroupBox();
            this.DataAllies = new System.Windows.Forms.DataGridView();
            this.AllyCreature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllyAc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllyMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllyHealth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllyFigure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enemies = new System.Windows.Forms.GroupBox();
            this.DataEnemies = new System.Windows.Forms.DataGridView();
            this.EnemyCreature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnemyAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnemyMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnemyHealth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnemyFigure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsertAlly = new System.Windows.Forms.Button();
            this.InsertEnemy = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.AllySpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnemySpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.Allies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataAllies)).BeginInit();
            this.Enemies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataEnemies)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.Allies, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Enemies, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.InsertAlly, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.InsertEnemy, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Start, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(909, 585);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Allies
            // 
            this.Allies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.Allies, 3);
            this.Allies.Controls.Add(this.DataAllies);
            this.Allies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Allies.Location = new System.Drawing.Point(3, 3);
            this.Allies.Name = "Allies";
            this.Allies.Size = new System.Drawing.Size(903, 257);
            this.Allies.TabIndex = 0;
            this.Allies.TabStop = false;
            this.Allies.Text = "Allies";
            // 
            // DataAllies
            // 
            this.DataAllies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataAllies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataAllies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataAllies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AllyCreature,
            this.AllyAc,
            this.AllyMax,
            this.AllyHealth,
            this.AllyFigure,
            this.AllySpeed});
            this.DataAllies.Location = new System.Drawing.Point(3, 25);
            this.DataAllies.Name = "DataAllies";
            this.DataAllies.Size = new System.Drawing.Size(894, 226);
            this.DataAllies.TabIndex = 0;
            // 
            // AllyCreature
            // 
            this.AllyCreature.HeaderText = "Creature";
            this.AllyCreature.Name = "AllyCreature";
            // 
            // AllyAc
            // 
            this.AllyAc.HeaderText = "Ac";
            this.AllyAc.Name = "AllyAc";
            // 
            // AllyMax
            // 
            this.AllyMax.HeaderText = "Max Health";
            this.AllyMax.Name = "AllyMax";
            // 
            // AllyHealth
            // 
            this.AllyHealth.HeaderText = "Health";
            this.AllyHealth.Name = "AllyHealth";
            // 
            // AllyFigure
            // 
            this.AllyFigure.HeaderText = "Figure";
            this.AllyFigure.Name = "AllyFigure";
            // 
            // Enemies
            // 
            this.Enemies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.Enemies, 3);
            this.Enemies.Controls.Add(this.DataEnemies);
            this.Enemies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enemies.Location = new System.Drawing.Point(3, 266);
            this.Enemies.Name = "Enemies";
            this.Enemies.Size = new System.Drawing.Size(903, 257);
            this.Enemies.TabIndex = 1;
            this.Enemies.TabStop = false;
            this.Enemies.Text = "Enemies";
            // 
            // DataEnemies
            // 
            this.DataEnemies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataEnemies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataEnemies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataEnemies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EnemyCreature,
            this.EnemyAC,
            this.EnemyMax,
            this.EnemyHealth,
            this.EnemyFigure,
            this.EnemySpeed});
            this.DataEnemies.Location = new System.Drawing.Point(3, 25);
            this.DataEnemies.Name = "DataEnemies";
            this.DataEnemies.Size = new System.Drawing.Size(894, 226);
            this.DataEnemies.TabIndex = 0;
            // 
            // EnemyCreature
            // 
            this.EnemyCreature.HeaderText = "Creature";
            this.EnemyCreature.Name = "EnemyCreature";
            // 
            // EnemyAC
            // 
            this.EnemyAC.HeaderText = "AC";
            this.EnemyAC.Name = "EnemyAC";
            // 
            // EnemyMax
            // 
            this.EnemyMax.HeaderText = "Max Health";
            this.EnemyMax.Name = "EnemyMax";
            // 
            // EnemyHealth
            // 
            this.EnemyHealth.HeaderText = "Health";
            this.EnemyHealth.Name = "EnemyHealth";
            // 
            // EnemyFigure
            // 
            this.EnemyFigure.HeaderText = "Figure";
            this.EnemyFigure.Name = "EnemyFigure";
            // 
            // InsertAlly
            // 
            this.InsertAlly.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertAlly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertAlly.Location = new System.Drawing.Point(3, 529);
            this.InsertAlly.Name = "InsertAlly";
            this.InsertAlly.Size = new System.Drawing.Size(297, 53);
            this.InsertAlly.TabIndex = 2;
            this.InsertAlly.Text = "Insert Ally";
            this.InsertAlly.UseVisualStyleBackColor = true;
            this.InsertAlly.Click += new System.EventHandler(this.InsertAllyClick);
            // 
            // InsertEnemy
            // 
            this.InsertEnemy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertEnemy.Location = new System.Drawing.Point(306, 529);
            this.InsertEnemy.Name = "InsertEnemy";
            this.InsertEnemy.Size = new System.Drawing.Size(297, 53);
            this.InsertEnemy.TabIndex = 3;
            this.InsertEnemy.Text = "Insert Enemy";
            this.InsertEnemy.UseVisualStyleBackColor = true;
            this.InsertEnemy.Click += new System.EventHandler(this.InsertEnemyClick);
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(609, 529);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(297, 53);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start Combat";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.StartClick);
            // 
            // AllySpeed
            // 
            this.AllySpeed.HeaderText = "Speed";
            this.AllySpeed.Name = "AllySpeed";
            // 
            // EnemySpeed
            // 
            this.EnemySpeed.HeaderText = "Speed";
            this.EnemySpeed.Name = "EnemySpeed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(933, 609);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Allies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataAllies)).EndInit();
            this.Enemies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataEnemies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox Allies;
        private System.Windows.Forms.DataGridView DataAllies;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllyCreature;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllyAc;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllyMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllyHealth;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllyFigure;
        private System.Windows.Forms.GroupBox Enemies;
        private System.Windows.Forms.DataGridView DataEnemies;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnemyCreature;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnemyAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnemyMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnemyHealth;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnemyFigure;
        private System.Windows.Forms.Button InsertAlly;
        private System.Windows.Forms.Button InsertEnemy;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllySpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnemySpeed;

    }
}

