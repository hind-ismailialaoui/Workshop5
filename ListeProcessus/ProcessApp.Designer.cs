namespace ListeProcessus
{
    partial class ProcessApp
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessApp));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.tbRecherche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.Menu;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nom});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 124);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1117, 569);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 70;
            // 
            // Nom
            // 
            this.Nom.Text = "Name";
            this.Nom.Width = 140;
            // 
            // btnActualiser
            // 
            this.btnActualiser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualiser.BackColor = System.Drawing.Color.Plum;
            this.btnActualiser.FlatAppearance.BorderSize = 3;
            this.btnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualiser.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiser.Location = new System.Drawing.Point(3, 3);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(552, 43);
            this.btnActualiser.TabIndex = 1;
            this.btnActualiser.Text = "Refresh";
            this.btnActualiser.UseVisualStyleBackColor = false;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            this.btnActualiser.MouseEnter += new System.EventHandler(this.btnActualiser_MouseEnter);
            this.btnActualiser.MouseLeave += new System.EventHandler(this.btnActualiser_MouseLeave);
            // 
            // btnCount
            // 
            this.btnCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCount.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCount.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCount.Location = new System.Drawing.Point(561, 3);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(553, 43);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = false;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            this.btnCount.MouseEnter += new System.EventHandler(this.btnCount_MouseEnter);
            this.btnCount.MouseLeave += new System.EventHandler(this.btnCount_MouseLeave);
            // 
            // tbRecherche
            // 
            this.tbRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRecherche.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbRecherche.Location = new System.Drawing.Point(12, 57);
            this.tbRecherche.Name = "tbRecherche";
            this.tbRecherche.Size = new System.Drawing.Size(1114, 28);
            this.tbRecherche.TabIndex = 2;
            this.tbRecherche.Text = "enter a process name...";
            this.tbRecherche.TextChanged += new System.EventHandler(this.tbRecherche_TextChanged);
            this.tbRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRecherche_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter a process name in the textbox down below:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnActualiser, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 726);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1117, 49);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // ProcessApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1141, 787);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRecherche);
            this.Controls.Add(this.listView1);
            this.DoubleBuffered = true;
            this.Enabled = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcessApp";
            this.Text = "ProcessApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox tbRecherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

