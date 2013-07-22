using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ITBD
{
    public partial class MainForm : Form
    {
        static string serverAddress = @"BDC\BDC_SQLEXPRESS";
        public string connectionString = @"Data Source=" + serverAddress + ";Initial Catalog=ITUchet;Integrated Security=SSPI; MultipleActiveResultSets=True";
        string connectionEverest = @"Data Source=" + serverAddress + ";Initial Catalog=everest;Integrated Security=True";

        public MainForm()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Запуск справочника техники
        private void mnuTechDir_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            TechDir objfrmTechDir = TechDir.GetChildInstance();
            objfrmTechDir.MdiParent = this;
            objfrmTechDir.Show();
            objfrmTechDir.WindowState = FormWindowState.Minimized;
            objfrmTechDir.WindowState = FormWindowState.Maximized;
            objfrmTechDir.BringToFront();
        }

        //Запуск генератора отчетов
        private void mnuRepStandart_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            RepForm objfrmRepForm = RepForm.GetChildInstance();
            objfrmRepForm.MdiParent = this;
            objfrmRepForm.WindowState = FormWindowState.Maximized;
            objfrmRepForm.Show();
        }


        //Импорт списка материнских плат
        private void ImportMB()
        {
            string commandEverest = "SELECT DISTINCT IValue FROM Item " + 
                "WHERE IField = 'Системная плата'";
            ArrayList compare = new ArrayList();
            bool state = true;
            int count = 0;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionEverest;
            conn.Disposed += new EventHandler(conn_Disposed);
            conn.StateChange += new StateChangeEventHandler(conn_StateChange);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandEverest, connectionEverest);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Motherboard");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            dataGridView1.Visible = true;
            conn.Dispose();
            SqlConnection connIT = new SqlConnection(connectionString);
            connIT.Open();
            SqlCommand myCommand = connIT.CreateCommand();
            myCommand.CommandText = "SELECT Type FROM Motherboard";
            SqlDataReader dataReader = myCommand.ExecuteReader();
            while (dataReader.Read())
            {
                compare.Add(dataReader[0].ToString());
            }
            dataReader.Close();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach(string compRow in compare)
                {
                    if (compRow.Trim() == row.Cells[0].FormattedValue.ToString()) state = false;
                }
     
                if (state == true)
                {
                    myCommand.CommandText = "INSERT INTO Motherboard (Type) VALUES('" +
                        row.Cells[0].FormattedValue.ToString() + "')";
                    myCommand.ExecuteNonQuery();
                    count++;
                }
                state = true;
            }
            connIT.Close();
            string addResult = "Добавлено " + count.ToString() + " записей";
            MessageBox.Show(addResult);
            
        }

        //Импорт списка процессоров
        private void ImportPC()
        {
            string commandEverest = "SELECT DISTINCT IValue FROM Item " +
                "WHERE IField = 'Тип ЦП'";
            ArrayList compare = new ArrayList();
            bool state = true;
            int count = 0;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionEverest;
            conn.Disposed += new EventHandler(conn_Disposed);
            conn.StateChange += new StateChangeEventHandler(conn_StateChange);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandEverest, connectionEverest);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "ЦП");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            dataGridView1.Visible = true;
            conn.Dispose();
            SqlConnection connIT = new SqlConnection(connectionString);
            connIT.Open();
            SqlCommand myCommand = connIT.CreateCommand();
            myCommand.CommandText = "SELECT Type FROM Processor";
            SqlDataReader dataReader = myCommand.ExecuteReader();
            while (dataReader.Read())
            {
                compare.Add(dataReader[0].ToString());
            }
            dataReader.Close();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (string compRow in compare)
                {
                    if (compRow.Trim() == row.Cells[0].FormattedValue.ToString()) state = false;
                }

                if (state == true)
                {
                    myCommand.CommandText = "INSERT INTO Processor (Type) VALUES('" +
                    row.Cells[0].FormattedValue.ToString() + "')";
                    myCommand.ExecuteNonQuery();
                    count++;
                }
                state = true;
            }
            connIT.Close();
            string addResult = "Добавлено " + count.ToString() + " записей";
            MessageBox.Show(addResult);
        }

        //Импорт списка оперативной памяти
        private void ImportRam()
        {
            string commandEverest = "SELECT DISTINCT IValue FROM Item " +
                "WHERE IField = 'Системная память'";
            ArrayList compare = new ArrayList();
            bool state = true;
            int count = 0;
            string temp;
            char[] seps = { ' ' };
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionEverest;
            conn.Disposed += new EventHandler(conn_Disposed);
            conn.StateChange += new StateChangeEventHandler(conn_StateChange);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandEverest, connectionEverest);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "RAM");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            dataGridView1.Visible = true;
            conn.Dispose();
            SqlConnection connIT = new SqlConnection(connectionString);
            connIT.Open();
            SqlCommand myCommand = connIT.CreateCommand();
            myCommand.CommandText = "SELECT Capacity FROM Ram";
            SqlDataReader dataReader = myCommand.ExecuteReader();
            while (dataReader.Read())
            {
                compare.Add(dataReader[0].ToString());
            }
            dataReader.Close();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (string compRow in compare)
                {
                    temp = row.Cells[0].FormattedValue.ToString();
                    string[] parts = temp.Split(seps);
                    if (compRow.Trim() == parts[0]) state = false;
                }

                if (state == true)
                {
                    temp = row.Cells[0].FormattedValue.ToString();
                    string[] parts = temp.Split(seps);
                    int tint = Convert.ToInt32(parts[0]);
                    myCommand.CommandText = "INSERT INTO Ram (Capacity) VALUES(" +
                    tint + ")";
                    myCommand.ExecuteNonQuery();
                    count++;
                }
                state = true;
            }
            connIT.Close();
            string addResult = "Добавлено " + count.ToString() + " записей";
            MessageBox.Show(addResult);
        }

        //Импорт списка жестких дисков
        private void ImportHDD()
        {
            string commandEverest = "SELECT DISTINCT IValue FROM Item " +
                "WHERE IField = 'Дисковый накопитель'";
            ArrayList compare = new ArrayList();
            bool state = true;
            int count = 0;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionEverest;
            conn.Disposed += new EventHandler(conn_Disposed);
            conn.StateChange += new StateChangeEventHandler(conn_StateChange);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandEverest, connectionEverest);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "HDD");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            dataGridView1.Visible = true;
            conn.Dispose();
            SqlConnection connIT = new SqlConnection(connectionString);
            connIT.Open();
            SqlCommand myCommand = connIT.CreateCommand();
            myCommand.CommandText = "SELECT Type FROM HDDrive";
            SqlDataReader dataReader = myCommand.ExecuteReader();
            while (dataReader.Read())
            {
                compare.Add(dataReader[0].ToString());
            }
            dataReader.Close();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (string compRow in compare)
                {
                    if (compRow.Trim() == row.Cells[0].FormattedValue.ToString()) state = false;
                }

                if (state == true)
                {
                    myCommand.CommandText = "INSERT INTO HDDrive (Type) VALUES('" +
                    row.Cells[0].FormattedValue.ToString() + "')";
                    myCommand.ExecuteNonQuery();
                    count++;
                }
                state = true;
            }
            connIT.Close();
            string addResult = "Добавлено " + count.ToString() + " записей";
            MessageBox.Show(addResult);
        }

        //Импорт списка видеокарт
        private void ImportVideo()
        {
            string commandEverest = "SELECT DISTINCT IValue FROM Item " +
                "WHERE IField = '3D-акселератор'";
            ArrayList compare = new ArrayList();
            bool state = true;
            int count = 0;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionEverest;
            conn.Disposed += new EventHandler(conn_Disposed);
            conn.StateChange += new StateChangeEventHandler(conn_StateChange);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandEverest, connectionEverest);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Video");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            dataGridView1.Visible = true;
            conn.Dispose();
            SqlConnection connIT = new SqlConnection(connectionString);
            connIT.Open();
            SqlCommand myCommand = connIT.CreateCommand();
            myCommand.CommandText = "SELECT Type FROM Video";
            SqlDataReader dataReader = myCommand.ExecuteReader();
            while (dataReader.Read())
            {
                compare.Add(dataReader[0].ToString());
            }
            dataReader.Close();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (string compRow in compare)
                {
                    if (compRow.Trim() == row.Cells[0].FormattedValue.ToString()) state = false;
                }

                if (state == true)
                {
                    myCommand.CommandText = "INSERT INTO Video (Type) VALUES('" +
                    row.Cells[0].FormattedValue.ToString() + "')";
                    myCommand.ExecuteNonQuery();
                    count++;
                }
                state = true;
            }
            connIT.Close();
            string addResult = "Добавлено " + count.ToString() + " записей";
            MessageBox.Show(addResult);
        }

        //Импорт списка компьютеров в сборе в справочник техники
        private void ImportObject()
        {
            string commandEverest = "select IField, IValue, ReportID from Item where IField in" +
                    "('Имя компьютера','Системная плата', 'Тип ЦП', 'Системная память', '3D-акселератор', 'Дисковый накопитель')";
            ArrayList compare = new ArrayList();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionEverest;
            conn.Disposed += new EventHandler(conn_Disposed);
            conn.StateChange += new StateChangeEventHandler(conn_StateChange);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandEverest, connectionEverest);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Object");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            dataGridView1.Visible = true;
            conn.Dispose();

            //Заполнение таблицы соответствий имени компьютера и ID отчета
            SqlConnection connIT = new SqlConnection(connectionString);
            connIT.Open();
            SqlCommand myCommand = connIT.CreateCommand();
            SqlCommand myInsert = connIT.CreateCommand();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].FormattedValue.ToString().Equals("Имя компьютера"))
                {
                   // MessageBox.Show(row.Cells[0].FormattedValue.ToString());
                    myCommand.CommandText = "SELECT * FROM CompRepID WHERE RepID = " + 
                        row.Cells[2].FormattedValue;
                    SqlDataReader dataReader = myCommand.ExecuteReader();
                    if (dataReader.Read() == false)
                    {
                        myInsert.CommandText = "INSERT INTO CompRepID (CompName, RepID) " +
                            "VALUES('" + row.Cells[1].FormattedValue.ToString() + "', '" +
                            row.Cells[2].FormattedValue.ToString() + "')";
                        dataReader.Close();
                        myInsert.ExecuteNonQuery();
                    }
                    dataReader.Close();
                } 
            }
            MessageBox.Show("Этап сопоставления отчета и объекта закончен");

            //Импорт объектов в основную БД

            SqlConnection connCR = new SqlConnection(connectionEverest);
            connCR.Open();
            SqlConnection connComp = new SqlConnection(connectionString);
            connComp.Open();
            SqlCommand myIt = connIT.CreateCommand();
            myIt.CommandText = "SELECT count(*) FROM CompRepID";
            string countAll = myIt.ExecuteScalar().ToString();
            myIt.CommandText = "SELECT * FROM CompRepID";
            SqlDataReader dataRead1 = myIt.ExecuteReader();
            char[] seps = { ' ' };
            int counter = 0;
            
            SqlDataReader dataRead3;
            while (dataRead1.Read())
            {
                Computer comp = new Computer();
                comp.ID = dataRead1[0].ToString();
                comp.RepID = Convert.ToInt32(dataRead1[1].ToString());
                SqlCommand myCr = connCR.CreateCommand();
                myCr.CommandText = "SELECT IField, IValue, ReportID FROM Item " +
                    "WHERE (ReportID = '" + dataRead1[1].ToString() + "')  AND (IField in" +
                    "('Системная плата', 'Тип ЦП', 'Системная память', '3D-акселератор', 'Дисковый накопитель'))";
                SqlDataReader dataRead2 = myCr.ExecuteReader();
                while (dataRead2.Read())
                {
                    SqlCommand myComp = connComp.CreateCommand();
                    switch (dataRead2[0].ToString())
                    {
                        case "Системная плата":
                            myComp.CommandText = "SELECT MbID FROM Motherboard WHERE Type = '" +
                                dataRead2[1].ToString().Trim() + "'";
                            dataRead3 = myComp.ExecuteReader();
                            dataRead3.Read();
                            comp.MB = dataRead3[0].ToString();
                            dataRead3.Close();
                            break;
                        case "Тип ЦП":
                            myComp.CommandText = "SELECT ProcID FROM Processor WHERE Type = '" +
                                dataRead2[1].ToString().Trim() + "'";
                            dataRead3 = myComp.ExecuteReader();
                            dataRead3.Read();
                            comp.Proc = dataRead3[0].ToString();
                            dataRead3.Close();
                            break;
                        case "Системная память":
                            string cut = dataRead2[1].ToString();
                            string[] parts = cut.Split(seps);                          
                            myComp.CommandText = "SELECT RamID FROM Ram WHERE Capacity = '" +
                                parts[0] + "'";
                            dataRead3 = myComp.ExecuteReader();
                            dataRead3.Read();
                            comp.Ram = dataRead3[0].ToString();
                            dataRead3.Close();
                            break;
                        case "3D-акселератор":
                            myComp.CommandText = "SELECT VideoID FROM Video WHERE Type = '" +
                                dataRead2[1].ToString().Trim() + "'";
                            dataRead3 = myComp.ExecuteReader();
                            dataRead3.Read();
                            comp.Video = dataRead3[0].ToString();
                            dataRead3.Close();
                            break;
                        case "Дисковый накопитель":
                            myComp.CommandText = "SELECT DriveID FROM HDDrive WHERE Type = '" +
                                dataRead2[1].ToString().Trim() + "'";
                            dataRead3 = myComp.ExecuteReader();
                            dataRead3.Read();
                            comp.Drive = dataRead3[0].ToString();
                            dataRead3.Close();
                            break;
                        default:
                            MessageBox.Show("Неверная выборка");
                            break;
                    }
                }
                SqlCommand myCompIns = connComp.CreateCommand();
                dataRead2.Close();
                myCompIns.CommandText = "SELECT count(*) FROM Computer WHERE ComputerID = '" +
                comp.ID.Trim() + "'";
                dataRead3 = myCompIns.ExecuteReader();
                dataRead3.Read();
                if (dataRead3[0].ToString() == "0")
                {
                    dataRead3.Close();
                    myCompIns.CommandText = "INSERT INTO Computer (ComputerID, MbID, ProcID, " +
                        "RamID, DriveID, VideoID) VALUES ('" + comp.ID.Trim() +
                        "', '" + Convert.ToInt32(comp.MB) + "', '" + Convert.ToInt32(comp.Proc) + "', '" +
                        Convert.ToInt32(comp.Ram) + "', '" + Convert.ToInt32(comp.Drive) + "', '" +
                        Convert.ToInt32(comp.Video) + "')";
                    myCompIns.ExecuteNonQuery();
                }
                counter++;
                this.Refresh();
                MainForm.ActiveForm.Text = "Обработано " + counter.ToString() + "/" + countAll + " отчетов";
                
            }
            dataRead1.Close();
            myIt.CommandText = "DELETE FROM CompRepID";
            myIt.ExecuteNonQuery();
            connCR.Close();
            conn.Close();
            connComp.Close();
        }
 


        void conn_StateChange(object sender, StateChangeEventArgs e)
        {
            throw new NotImplementedException();
        }

        void conn_Disposed(object sender, EventArgs e)
        {            
        }

        private void mnuMBEverestImp_Click(object sender, EventArgs e)
        {
            ImportMB();
        }

        private void mnuCPEverestImp_Click(object sender, EventArgs e)
        {
            ImportPC();
        }

        private void mnuRamEverestImp_Click(object sender, EventArgs e)
        {
            ImportRam();
        }

        private void mnuHDDEverestImp_Click(object sender, EventArgs e)
        {
            ImportHDD();
        }

        private void mnuVideoEverestImp_Click(object sender, EventArgs e)
        {
            ImportVideo();
        }

        private void mnuObjEverestImp_Click(object sender, EventArgs e)
        {
            ImportObject();
        }

 /*       private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }*/

        private void mnuConnectDB_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            Logon objfrmLogon = new Logon();
            objfrmLogon.ShowDialog(this);
            objfrmLogon.BringToFront();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mnuToolStrip.Enabled = false;
            mnuDirMain.Enabled = false;
            mnuRepMain.Enabled = false;
        }

        private void mnuHardEverestImp_Click(object sender, EventArgs e)
        {

        }

        public void ToolsMenuEnable(bool lvl)
        {
                mnuToolStrip.Enabled = lvl;
        }

        private void mnuOperDir_Click(object sender, EventArgs e)
        {

        }



    }
}
