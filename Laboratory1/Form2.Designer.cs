namespace Laboratory1
{
    partial class frmHistoria
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.historiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbo_HistoriaDataSet = new Laboratory1.dbo_HistoriaDataSet();
            this.dboHistoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.historiaTableAdapter = new Laboratory1.dbo_HistoriaDataSetTableAdapters.HistoriaTableAdapter();
            this.dboHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zwycięzcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakładDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscPrzedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscPoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_HistoriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboHistoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.zwycięzcaDataGridViewTextBoxColumn,
            this.piesDataGridViewTextBoxColumn,
            this.zakładDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.iloscPrzedDataGridViewTextBoxColumn,
            this.iloscPoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dboHistoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 376);
            this.dataGridView1.TabIndex = 0;
            // 
            // historiaBindingSource
            // 
            this.historiaBindingSource.DataMember = "Historia";
            this.historiaBindingSource.DataSource = this.dbo_HistoriaDataSet;
            // 
            // dbo_HistoriaDataSet
            // 
            this.dbo_HistoriaDataSet.DataSetName = "dbo_HistoriaDataSet";
            this.dbo_HistoriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dboHistoriaBindingSource
            // 
            this.dboHistoriaBindingSource.DataSource = typeof(Laboratory1.dbo_History);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wyjdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // historiaTableAdapter
            // 
            this.historiaTableAdapter.ClearBeforeFill = true;
            // 
            // dboHistoryBindingSource
            // 
            this.dboHistoryBindingSource.DataSource = typeof(Laboratory1.dbo_History);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // zwycięzcaDataGridViewTextBoxColumn
            // 
            this.zwycięzcaDataGridViewTextBoxColumn.DataPropertyName = "Zwycięzca";
            this.zwycięzcaDataGridViewTextBoxColumn.HeaderText = "Zwycięzca";
            this.zwycięzcaDataGridViewTextBoxColumn.Name = "zwycięzcaDataGridViewTextBoxColumn";
            // 
            // piesDataGridViewTextBoxColumn
            // 
            this.piesDataGridViewTextBoxColumn.DataPropertyName = "Pies";
            this.piesDataGridViewTextBoxColumn.HeaderText = "Pies";
            this.piesDataGridViewTextBoxColumn.Name = "piesDataGridViewTextBoxColumn";
            // 
            // zakładDataGridViewTextBoxColumn
            // 
            this.zakładDataGridViewTextBoxColumn.DataPropertyName = "Zakład";
            this.zakładDataGridViewTextBoxColumn.HeaderText = "Zakład";
            this.zakładDataGridViewTextBoxColumn.Name = "zakładDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // iloscPrzedDataGridViewTextBoxColumn
            // 
            this.iloscPrzedDataGridViewTextBoxColumn.DataPropertyName = "IloscPrzed";
            this.iloscPrzedDataGridViewTextBoxColumn.HeaderText = "IloscPrzed";
            this.iloscPrzedDataGridViewTextBoxColumn.Name = "iloscPrzedDataGridViewTextBoxColumn";
            // 
            // iloscPoDataGridViewTextBoxColumn
            // 
            this.iloscPoDataGridViewTextBoxColumn.DataPropertyName = "IloscPo";
            this.iloscPoDataGridViewTextBoxColumn.HeaderText = "IloscPo";
            this.iloscPoDataGridViewTextBoxColumn.Name = "iloscPoDataGridViewTextBoxColumn";
            // 
            // frmHistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHistoria";
            this.Text = "Historia";
            this.Load += new System.EventHandler(this.frmHistoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_HistoriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboHistoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dboHistoriaBindingSource;
        private dbo_HistoriaDataSet dbo_HistoriaDataSet;
        private System.Windows.Forms.BindingSource historiaBindingSource;
        private dbo_HistoriaDataSetTableAdapters.HistoriaTableAdapter historiaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zwycięzcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn piesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakładDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscPrzedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscPoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dboHistoryBindingSource;
    }
}