namespace ITBD
{
    partial class TechDir
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFileTechDir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseItemCat = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgdCompCat = new System.Windows.Forms.DataGridView();
            this.iTUchetDataSet = new ITBD.ITUchetDataSet();
            this.computerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerTableAdapter = new ITBD.ITUchetDataSetTableAdapters.ComputerTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdCompCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTUchetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileTechDir,
            this.правкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFileTechDir
            // 
            this.mnuFileTechDir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCloseItemCat});
            this.mnuFileTechDir.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuFileTechDir.Name = "mnuFileTechDir";
            this.mnuFileTechDir.Size = new System.Drawing.Size(45, 20);
            this.mnuFileTechDir.Text = "Файл";
            // 
            // mnuCloseItemCat
            // 
            this.mnuCloseItemCat.Name = "mnuCloseItemCat";
            this.mnuCloseItemCat.Size = new System.Drawing.Size(191, 22);
            this.mnuCloseItemCat.Text = "Закрыть справочник";
            this.mnuCloseItemCat.Click += new System.EventHandler(this.mnuCloseItemCat_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // dgdCompCat
            // 
            this.dgdCompCat.AllowUserToAddRows = false;
            this.dgdCompCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdCompCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdCompCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgdCompCat.Location = new System.Drawing.Point(0, 24);
            this.dgdCompCat.Name = "dgdCompCat";
            this.dgdCompCat.Size = new System.Drawing.Size(792, 749);
            this.dgdCompCat.TabIndex = 1;
            // 
            // iTUchetDataSet
            // 
            this.iTUchetDataSet.DataSetName = "ITUchetDataSet";
            this.iTUchetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // computerBindingSource
            // 
            this.computerBindingSource.DataMember = "Computer";
            this.computerBindingSource.DataSource = this.iTUchetDataSet;
            // 
            // computerTableAdapter
            // 
            this.computerTableAdapter.ClearBeforeFill = true;
            // 
            // TechDir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 773);
            this.Controls.Add(this.dgdCompCat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TechDir";
            this.Text = "Справочник техники";
            this.Load += new System.EventHandler(this.TechDir_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdCompCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTUchetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileTechDir;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseItemCat;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgdCompCat;
        private ITUchetDataSet iTUchetDataSet;
        private System.Windows.Forms.BindingSource computerBindingSource;
        private ITBD.ITUchetDataSetTableAdapters.ComputerTableAdapter computerTableAdapter;
    }
}