using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ITBD
{
    public partial class TechDir : Form
    {
        private static TechDir m_TechDir;

        public static TechDir GetChildInstance()
        {
            if (m_TechDir == null)
                m_TechDir = new TechDir();
            return m_TechDir;
        }

        public TechDir()
        {
            InitializeComponent();
        }

        private void ShowItems()
        {
            MainForm mf = new MainForm();
            string commandITDB = "SELECT  Computer.ComputerID, Motherboard.Type, Processor.Type, " +
                "Ram.Capacity, HDDrive.Type, Video.Type " +
                "FROM Computer " + 
                "LEFT OUTER JOIN Motherboard ON Computer.MbID = Motherboard.MbID " +
                "LEFT OUTER JOIN Processor ON Computer.ProcID = Processor.ProcID " +
                "LEFT OUTER JOIN Ram ON Computer.RamID = Ram.RamID " +
                "LEFT OUTER JOIN HDDrive ON Computer.DriveID = HDDRive.DriveID " +
                "LEFT OUTER JOIN Video ON Computer.VideoID = Video.VideoID";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = mf.connectionString;
            conn.Disposed += new EventHandler(conn_Disposed);
            conn.StateChange += new StateChangeEventHandler(conn_StateChange);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandITDB, mf.connectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "CompCatalog");
            dgdCompCat.DataSource = ds.Tables[0].DefaultView;
            dgdCompCat.Columns[0].HeaderText = "Имя компьютера";
            dgdCompCat.Columns[1].HeaderText = "Мат. плата";
            dgdCompCat.Columns[2].HeaderText = "Процессор";
            dgdCompCat.Columns[3].HeaderText = "RAM";
            dgdCompCat.Columns[4].HeaderText = "HDD";
            dgdCompCat.Columns[5].HeaderText = "Видеокарта";
            dgdCompCat.Visible = true;
        }

        void conn_StateChange(object sender, StateChangeEventArgs e)
        {
            throw new NotImplementedException();
        }

        void conn_Disposed(object sender, EventArgs e)
        {
        }

        private void TechDir_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iTUchetDataSet.Computer". При необходимости она может быть перемещена или удалена.
            ShowItems();
        }

        private void mnuCloseItemCat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
