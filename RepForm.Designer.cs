namespace ITBD
{
    partial class RepForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseRepForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnoperable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepPeriod = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOperable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReserve = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnoper = new System.Windows.Forms.ToolStripMenuItem();
            this.dgdRepResult = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdRepResult)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.mnuUnoperable});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCloseRepForm});
            this.файлToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // mnuCloseRepForm
            // 
            this.mnuCloseRepForm.Name = "mnuCloseRepForm";
            this.mnuCloseRepForm.Size = new System.Drawing.Size(170, 22);
            this.mnuCloseRepForm.Text = "Закрыть отчеты";
            this.mnuCloseRepForm.Click += new System.EventHandler(this.mnuCloseRepForm_Click);
            // 
            // mnuUnoperable
            // 
            this.mnuUnoperable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRepPeriod,
            this.mnuOperable,
            this.mnuReserve,
            this.mnuUnoper});
            this.mnuUnoperable.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuUnoperable.Name = "mnuUnoperable";
            this.mnuUnoperable.Size = new System.Drawing.Size(130, 20);
            this.mnuUnoperable.Text = "Стандартные отчеты";
            // 
            // mnuRepPeriod
            // 
            this.mnuRepPeriod.Name = "mnuRepPeriod";
            this.mnuRepPeriod.Size = new System.Drawing.Size(191, 22);
            this.mnuRepPeriod.Text = "Движение за период";
            // 
            // mnuOperable
            // 
            this.mnuOperable.Name = "mnuOperable";
            this.mnuOperable.Size = new System.Drawing.Size(191, 22);
            this.mnuOperable.Text = "Рабочая техника";
            this.mnuOperable.Click += new System.EventHandler(this.mnuOperable_Click);
            // 
            // mnuReserve
            // 
            this.mnuReserve.Name = "mnuReserve";
            this.mnuReserve.Size = new System.Drawing.Size(191, 22);
            this.mnuReserve.Text = "Резерв";
            this.mnuReserve.Click += new System.EventHandler(this.mnuReserve_Click);
            // 
            // mnuUnoper
            // 
            this.mnuUnoper.Name = "mnuUnoper";
            this.mnuUnoper.Size = new System.Drawing.Size(191, 22);
            this.mnuUnoper.Text = "Нерабочая техника";
            this.mnuUnoper.Click += new System.EventHandler(this.mnuUnoper_Click);
            // 
            // dgdRepResult
            // 
            this.dgdRepResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdRepResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgdRepResult.Location = new System.Drawing.Point(0, 24);
            this.dgdRepResult.Name = "dgdRepResult";
            this.dgdRepResult.Size = new System.Drawing.Size(673, 441);
            this.dgdRepResult.TabIndex = 2;
            // 
            // RepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 465);
            this.Controls.Add(this.dgdRepResult);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RepForm";
            this.Text = "Генератор отчетов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdRepResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseRepForm;
        private System.Windows.Forms.DataGridView dgdRepResult;
        private System.Windows.Forms.ToolStripMenuItem mnuUnoperable;
        private System.Windows.Forms.ToolStripMenuItem mnuRepPeriod;
        private System.Windows.Forms.ToolStripMenuItem mnuOperable;
        private System.Windows.Forms.ToolStripMenuItem mnuReserve;
        private System.Windows.Forms.ToolStripMenuItem mnuUnoper;
    }
}