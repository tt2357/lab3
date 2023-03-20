namespace lab4
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBN1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.form2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.form2BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorlDataGridViewTextBoxColumn,
            this.title1DataGridViewTextBoxColumn,
            this.genre1DataGridViewTextBoxColumn,
            this.iSBN1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(100, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 256);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "REMOVE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(410, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 53);
            this.button3.TabIndex = 3;
            this.button3.Text = "SAVE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(567, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 53);
            this.button4.TabIndex = 4;
            this.button4.Text = "LOAD";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(lab4.Form2.Book);
            // 
            // authorlDataGridViewTextBoxColumn
            // 
            this.authorlDataGridViewTextBoxColumn.DataPropertyName = "Authorl";
            this.authorlDataGridViewTextBoxColumn.HeaderText = "Authorl";
            this.authorlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorlDataGridViewTextBoxColumn.Name = "authorlDataGridViewTextBoxColumn";
            this.authorlDataGridViewTextBoxColumn.Width = 125;
            // 
            // title1DataGridViewTextBoxColumn
            // 
            this.title1DataGridViewTextBoxColumn.DataPropertyName = "Title1";
            this.title1DataGridViewTextBoxColumn.HeaderText = "Title1";
            this.title1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.title1DataGridViewTextBoxColumn.Name = "title1DataGridViewTextBoxColumn";
            this.title1DataGridViewTextBoxColumn.Width = 125;
            // 
            // genre1DataGridViewTextBoxColumn
            // 
            this.genre1DataGridViewTextBoxColumn.DataPropertyName = "Genre1";
            this.genre1DataGridViewTextBoxColumn.HeaderText = "Genre1";
            this.genre1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genre1DataGridViewTextBoxColumn.Name = "genre1DataGridViewTextBoxColumn";
            this.genre1DataGridViewTextBoxColumn.Width = 125;
            // 
            // iSBN1DataGridViewTextBoxColumn
            // 
            this.iSBN1DataGridViewTextBoxColumn.DataPropertyName = "ISBN1";
            this.iSBN1DataGridViewTextBoxColumn.HeaderText = "ISBN1";
            this.iSBN1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBN1DataGridViewTextBoxColumn.Name = "iSBN1DataGridViewTextBoxColumn";
            this.iSBN1DataGridViewTextBoxColumn.Width = 125;
            // 
            // form2BindingSource
            // 
            this.form2BindingSource.DataSource = typeof(lab4.Form2);
            // 
            // form2BindingSource1
            // 
            this.form2BindingSource1.DataSource = typeof(lab4.Form2);
            // 
            // form2BindingSource2
            // 
            this.form2BindingSource2.DataSource = typeof(lab4.Form2);
            // 
            // form2BindingSource3
            // 
            this.form2BindingSource3.DataSource = typeof(lab4.Form2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource form2BindingSource;
        private System.Windows.Forms.BindingSource form2BindingSource1;
        private System.Windows.Forms.BindingSource form2BindingSource2;
        private System.Windows.Forms.BindingSource form2BindingSource3;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn title1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBN1DataGridViewTextBoxColumn;
    }
}

