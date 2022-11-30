namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Label();
            this.btn_Open = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(641, 25);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(128, 37);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(93, 32);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(514, 22);
            this.SearchText.TabIndex = 1;
            this.SearchText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchText_KeyPress);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 102);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(763, 273);
            this.dataGridView2.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(43, 35);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(44, 16);
            this.Search.TabIndex = 3;
            this.Search.Text = "label2";
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(624, 397);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(128, 37);
            this.btn_Open.TabIndex = 4;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.Location = new System.Drawing.Point(46, 410);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(75, 23);
            this.lbltotal.TabIndex = 5;
            this.lbltotal.Text = "Total";
            this.lbltotal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(826, 486);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.btn_Search);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button Total;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button lbltotal;
    }
}

