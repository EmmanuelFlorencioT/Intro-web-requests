namespace WebRequestBibUASLP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbSearchQ = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbBookResults = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbContributors = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbContribBooks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbSearchQ
            // 
            this.tbSearchQ.Location = new System.Drawing.Point(33, 52);
            this.tbSearchQ.Name = "tbSearchQ";
            this.tbSearchQ.Size = new System.Drawing.Size(115, 20);
            this.tbSearchQ.TabIndex = 0;
            this.tbSearchQ.TextChanged += new System.EventHandler(this.tbSearchQ_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(154, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbBookResults
            // 
            this.lbBookResults.FormattingEnabled = true;
            this.lbBookResults.Location = new System.Drawing.Point(33, 115);
            this.lbBookResults.Name = "lbBookResults";
            this.lbBookResults.Size = new System.Drawing.Size(196, 212);
            this.lbBookResults.TabIndex = 2;
            this.lbBookResults.SelectedIndexChanged += new System.EventHandler(this.lbBookResults_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resultados de la Búsqueda:";
            // 
            // lbContributors
            // 
            this.lbContributors.FormattingEnabled = true;
            this.lbContributors.Location = new System.Drawing.Point(323, 50);
            this.lbContributors.Name = "lbContributors";
            this.lbContributors.Size = new System.Drawing.Size(120, 95);
            this.lbContributors.TabIndex = 4;
            this.lbContributors.SelectedIndexChanged += new System.EventHandler(this.lbContributors_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contribuidores:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Libros de Contribuidores:";
            // 
            // lbContribBooks
            // 
            this.lbContribBooks.FormattingEnabled = true;
            this.lbContribBooks.Location = new System.Drawing.Point(549, 51);
            this.lbContribBooks.Name = "lbContribBooks";
            this.lbContribBooks.Size = new System.Drawing.Size(120, 95);
            this.lbContribBooks.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbContribBooks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbContributors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBookResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearchQ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearchQ;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbBookResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbContributors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbContribBooks;
    }
}

