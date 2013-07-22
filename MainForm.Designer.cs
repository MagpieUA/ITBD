namespace ITBD
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConnectDB = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDirMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTechDir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOperDir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.импортДанныхИзEverestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHardEverestImp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMBEverestImp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCPEverestImp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRamEverestImp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHDDEverestImp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVideoEverestImp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuObjEverestImp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepMain = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAccLvl = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuRepStandart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuDirMain,
            this.mnuToolStrip,
            this.mnuRepMain,
            this.помощьToolStripMenuItem,
            this.mnuWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(566, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConnectDB,
            this.выходToolStripMenuItem});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(45, 20);
            this.mnuFile.Text = "Файл";
            // 
            // mnuConnectDB
            // 
            this.mnuConnectDB.Name = "mnuConnectDB";
            this.mnuConnectDB.Size = new System.Drawing.Size(196, 22);
            this.mnuConnectDB.Text = "Подключиться к базе";
            this.mnuConnectDB.Click += new System.EventHandler(this.mnuConnectDB_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // mnuDirMain
            // 
            this.mnuDirMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTechDir,
            this.mnuOperDir});
            this.mnuDirMain.Name = "mnuDirMain";
            this.mnuDirMain.Size = new System.Drawing.Size(86, 20);
            this.mnuDirMain.Text = "Справочники";
            // 
            // mnuTechDir
            // 
            this.mnuTechDir.Name = "mnuTechDir";
            this.mnuTechDir.Size = new System.Drawing.Size(197, 22);
            this.mnuTechDir.Text = "Справочник техники";
            this.mnuTechDir.Click += new System.EventHandler(this.mnuTechDir_Click);
            // 
            // mnuOperDir
            // 
            this.mnuOperDir.Name = "mnuOperDir";
            this.mnuOperDir.Size = new System.Drawing.Size(197, 22);
            this.mnuOperDir.Text = "Справочник операций";
            this.mnuOperDir.Click += new System.EventHandler(this.mnuOperDir_Click);
            // 
            // mnuToolStrip
            // 
            this.mnuToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.импортДанныхИзEverestToolStripMenuItem});
            this.mnuToolStrip.Name = "mnuToolStrip";
            this.mnuToolStrip.Size = new System.Drawing.Size(68, 20);
            this.mnuToolStrip.Text = "Средства";
            // 
            // импортДанныхИзEverestToolStripMenuItem
            // 
            this.импортДанныхИзEverestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHardEverestImp,
            this.mnuObjEverestImp});
            this.импортДанныхИзEverestToolStripMenuItem.Name = "импортДанныхИзEverestToolStripMenuItem";
            this.импортДанныхИзEverestToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.импортДанныхИзEverestToolStripMenuItem.Text = "Импорт данных из Everest...";
            // 
            // mnuHardEverestImp
            // 
            this.mnuHardEverestImp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMBEverestImp,
            this.mnuCPEverestImp,
            this.mnuRamEverestImp,
            this.mnuHDDEverestImp,
            this.mnuVideoEverestImp});
            this.mnuHardEverestImp.Name = "mnuHardEverestImp";
            this.mnuHardEverestImp.Size = new System.Drawing.Size(170, 22);
            this.mnuHardEverestImp.Text = "Комплектующие";
            this.mnuHardEverestImp.Click += new System.EventHandler(this.mnuHardEverestImp_Click);
            // 
            // mnuMBEverestImp
            // 
            this.mnuMBEverestImp.Name = "mnuMBEverestImp";
            this.mnuMBEverestImp.Size = new System.Drawing.Size(192, 22);
            this.mnuMBEverestImp.Text = "Материнские платы";
            this.mnuMBEverestImp.Click += new System.EventHandler(this.mnuMBEverestImp_Click);
            // 
            // mnuCPEverestImp
            // 
            this.mnuCPEverestImp.Name = "mnuCPEverestImp";
            this.mnuCPEverestImp.Size = new System.Drawing.Size(192, 22);
            this.mnuCPEverestImp.Text = "Процессоры";
            this.mnuCPEverestImp.Click += new System.EventHandler(this.mnuCPEverestImp_Click);
            // 
            // mnuRamEverestImp
            // 
            this.mnuRamEverestImp.Name = "mnuRamEverestImp";
            this.mnuRamEverestImp.Size = new System.Drawing.Size(192, 22);
            this.mnuRamEverestImp.Text = "Оперативная память";
            this.mnuRamEverestImp.Click += new System.EventHandler(this.mnuRamEverestImp_Click);
            // 
            // mnuHDDEverestImp
            // 
            this.mnuHDDEverestImp.Name = "mnuHDDEverestImp";
            this.mnuHDDEverestImp.Size = new System.Drawing.Size(192, 22);
            this.mnuHDDEverestImp.Text = "Жесткие диски";
            this.mnuHDDEverestImp.Click += new System.EventHandler(this.mnuHDDEverestImp_Click);
            // 
            // mnuVideoEverestImp
            // 
            this.mnuVideoEverestImp.Name = "mnuVideoEverestImp";
            this.mnuVideoEverestImp.Size = new System.Drawing.Size(192, 22);
            this.mnuVideoEverestImp.Text = "Видеоадаптер";
            this.mnuVideoEverestImp.Click += new System.EventHandler(this.mnuVideoEverestImp_Click);
            // 
            // mnuObjEverestImp
            // 
            this.mnuObjEverestImp.Name = "mnuObjEverestImp";
            this.mnuObjEverestImp.Size = new System.Drawing.Size(170, 22);
            this.mnuObjEverestImp.Text = "Объекты";
            this.mnuObjEverestImp.Click += new System.EventHandler(this.mnuObjEverestImp_Click);
            // 
            // mnuRepMain
            // 
            this.mnuRepMain.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.mnuRepMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRepStandart});
            this.mnuRepMain.Name = "mnuRepMain";
            this.mnuRepMain.Size = new System.Drawing.Size(59, 20);
            this.mnuRepMain.Text = "Отчеты";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // mnuWindow
            // 
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(45, 20);
            this.mnuWindow.Text = "Окна";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 372);
            this.dataGridView1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusUser,
            this.statusAccLvl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 374);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(566, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusUser
            // 
            this.statusUser.Name = "statusUser";
            this.statusUser.Size = new System.Drawing.Size(35, 17);
            this.statusUser.Text = "NONE";
            // 
            // statusAccLvl
            // 
            this.statusAccLvl.Name = "statusAccLvl";
            this.statusAccLvl.Size = new System.Drawing.Size(35, 17);
            this.statusAccLvl.Text = "NONE";
            // 
            // mnuRepStandart
            // 
            this.mnuRepStandart.Name = "mnuRepStandart";
            this.mnuRepStandart.Size = new System.Drawing.Size(196, 22);
            this.mnuRepStandart.Text = "Стандартные отчеты";
            this.mnuRepStandart.Click += new System.EventHandler(this.mnuRepStandart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 396);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Учет техники";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem mnuFile;
        public System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mnuDirMain;
        public System.Windows.Forms.ToolStripMenuItem mnuTechDir;
        public System.Windows.Forms.ToolStripMenuItem mnuOperDir;
        public System.Windows.Forms.ToolStripMenuItem mnuToolStrip;
        public System.Windows.Forms.ToolStripMenuItem импортДанныхИзEverestToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mnuRepMain;
        public System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mnuHardEverestImp;
        public System.Windows.Forms.ToolStripMenuItem mnuObjEverestImp;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ToolStripMenuItem mnuMBEverestImp;
        public System.Windows.Forms.ToolStripMenuItem mnuCPEverestImp;
        public System.Windows.Forms.ToolStripMenuItem mnuRamEverestImp;
        public System.Windows.Forms.ToolStripMenuItem mnuHDDEverestImp;
        public System.Windows.Forms.ToolStripMenuItem mnuVideoEverestImp;
        public System.Windows.Forms.ToolStripMenuItem mnuWindow;
        public System.Windows.Forms.ToolStripMenuItem mnuConnectDB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel statusUser;
        internal System.Windows.Forms.ToolStripStatusLabel statusAccLvl;
        private System.Windows.Forms.ToolStripMenuItem mnuRepStandart;
    }
}

