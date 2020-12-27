namespace WinFormsData
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.eticaretFilmDataSet = new WinFormsData.EticaretFilmDataSet();
            this.tblFilmlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_FilmlerTableAdapter = new WinFormsData.EticaretFilmDataSetTableAdapters.tbl_FilmlerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eticaretFilmDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFilmlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eticaretFilmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilmlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eticaretFilmDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilmlerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblFilmlerBindingSource, "Id", true));
            this.comboBox1.DataSource = this.tblFilmlerBindingSource;
            this.comboBox1.DisplayMember = "FilmAdi";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(290, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // eticaretFilmDataSet
            // 
            this.eticaretFilmDataSet.DataSetName = "EticaretFilmDataSet";
            this.eticaretFilmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFilmlerBindingSource
            // 
            this.tblFilmlerBindingSource.DataMember = "tbl_Filmler";
            this.tblFilmlerBindingSource.DataSource = this.eticaretFilmDataSet;
            // 
            // tbl_FilmlerTableAdapter
            // 
            this.tbl_FilmlerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.filmAdiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblFilmlerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 328);
            this.dataGridView1.TabIndex = 1;
            // 
            // eticaretFilmDataSetBindingSource
            // 
            this.eticaretFilmDataSetBindingSource.DataSource = this.eticaretFilmDataSet;
            this.eticaretFilmDataSetBindingSource.Position = 0;
            // 
            // tblFilmlerBindingSource1
            // 
            this.tblFilmlerBindingSource1.DataMember = "tbl_Filmler";
            this.tblFilmlerBindingSource1.DataSource = this.eticaretFilmDataSet;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmAdiDataGridViewTextBoxColumn
            // 
            this.filmAdiDataGridViewTextBoxColumn.DataPropertyName = "FilmAdi";
            this.filmAdiDataGridViewTextBoxColumn.HeaderText = "FilmAdi";
            this.filmAdiDataGridViewTextBoxColumn.Name = "filmAdiDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eticaretFilmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilmlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eticaretFilmDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilmlerBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private EticaretFilmDataSet eticaretFilmDataSet;
        private System.Windows.Forms.BindingSource tblFilmlerBindingSource;
        private EticaretFilmDataSetTableAdapters.tbl_FilmlerTableAdapter tbl_FilmlerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblFilmlerBindingSource1;
        private System.Windows.Forms.BindingSource eticaretFilmDataSetBindingSource;
    }
}

