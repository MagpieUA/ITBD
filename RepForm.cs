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
    public partial class RepForm : Form
    {
        private static RepForm m_RepForm;

        public static RepForm GetChildInstance()
        {
            if (m_RepForm == null)
                m_RepForm = new RepForm();
            return m_RepForm;
        }

        public RepForm()
        {
            InitializeComponent();
        }

        private void mnuCloseRepForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Text = "Генератор отчетов";
            dgdRepResult.Visible = false;
        }

        private void mnuReserve_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();

            string commandITDB = "SELECT  Computer.ComputerID, Motherboard.Type, Processor.Type, " +
                  "Ram.Capacity, HDDrive.Type, Video.Type, CatPlace.Description " +
                  "FROM Computer " +
                  "LEFT OUTER JOIN Motherboard ON Computer.MbID = Motherboard.MbID " +
                  "LEFT OUTER JOIN Processor ON Computer.ProcID = Processor.ProcID " +
                  "LEFT OUTER JOIN Ram ON Computer.RamID = Ram.RamID " +
                  "LEFT OUTER JOIN HDDrive ON Computer.DriveID = HDDRive.DriveID " +
                  "LEFT OUTER JOIN Video ON Computer.VideoID = Video.VideoID " + 
                  "LEFT OUTER JOIN CatPlace ON Computer.CatPlaceID = CatPlace.CatPlaceID " +
                  "WHERE Computer.CatPlaceId = 1";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = mf.connectionString;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandITDB, mf.connectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "RepMonth");
            dgdRepResult.DataSource = ds.Tables[0].DefaultView;
            dgdRepResult.DataSource = ds.Tables[0].DefaultView;
            dgdRepResult.Columns[0].HeaderText = "Имя компьютера";
            dgdRepResult.Columns[1].HeaderText = "Мат. плата";
            dgdRepResult.Columns[2].HeaderText = "Процессор";
            dgdRepResult.Columns[3].HeaderText = "RAM";
            dgdRepResult.Columns[4].HeaderText = "HDD";
            dgdRepResult.Columns[5].HeaderText = "Видеокарта";
            dgdRepResult.Columns[6].HeaderText = "Место установки";
            dgdRepResult.Visible = true;
            this.Text = "Генератор отчетов" + " --- Отчет о технике, находящейся в резерве";
        }

        private void mnuUnoper_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();

            string commandITDB = "SELECT  Computer.ComputerID, Motherboard.Type, Processor.Type, " +
                  "Ram.Capacity, HDDrive.Type, Video.Type, CatPlace.Description " +
                  "FROM Computer " +
                  "LEFT OUTER JOIN Motherboard ON Computer.MbID = Motherboard.MbID " +
                  "LEFT OUTER JOIN Processor ON Computer.ProcID = Processor.ProcID " +
                  "LEFT OUTER JOIN Ram ON Computer.RamID = Ram.RamID " +
                  "LEFT OUTER JOIN HDDrive ON Computer.DriveID = HDDRive.DriveID " +
                  "LEFT OUTER JOIN Video ON Computer.VideoID = Video.VideoID " +
                  "LEFT OUTER JOIN CatPlace ON Computer.CatPlaceID = CatPlace.CatPlaceID " +
                  "WHERE (Computer.MbId IS NULL) OR (Computer.ProcID IS NULL) OR " +
                  "(Computer.RamId IS NULL) OR (Computer.DriveID IS NULL) OR " +
                  "(Computer.VideoID IS NULL)";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = mf.connectionString;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandITDB, mf.connectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "RepMonth");
            dgdRepResult.DataSource = ds.Tables[0].DefaultView;
            dgdRepResult.DataSource = ds.Tables[0].DefaultView;
            dgdRepResult.Columns[0].HeaderText = "Имя компьютера";
            dgdRepResult.Columns[1].HeaderText = "Мат. плата";
            dgdRepResult.Columns[2].HeaderText = "Процессор";
            dgdRepResult.Columns[3].HeaderText = "RAM";
            dgdRepResult.Columns[4].HeaderText = "HDD";
            dgdRepResult.Columns[5].HeaderText = "Видеокарта";
            dgdRepResult.Columns[6].HeaderText = "Место установки";
            dgdRepResult.Visible = true;
            this.Text = "Генератор отчетов" + " --- Отчет о некомплектной технике";
        }

        private void mnuOperable_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();

            string commandITDB = "SELECT  Computer.ComputerID, Motherboard.Type, Processor.Type, " +
                  "Ram.Capacity, HDDrive.Type, Video.Type, CatPlace.Description " +
                  "FROM Computer " +
                  "LEFT OUTER JOIN Motherboard ON Computer.MbID = Motherboard.MbID " +
                  "LEFT OUTER JOIN Processor ON Computer.ProcID = Processor.ProcID " +
                  "LEFT OUTER JOIN Ram ON Computer.RamID = Ram.RamID " +
                  "LEFT OUTER JOIN HDDrive ON Computer.DriveID = HDDRive.DriveID " +
                  "LEFT OUTER JOIN Video ON Computer.VideoID = Video.VideoID " +
                  "LEFT OUTER JOIN CatPlace ON Computer.CatPlaceID = CatPlace.CatPlaceID " +
                  "WHERE (Computer.MbId IS NOT NULL) AND (Computer.ProcID IS NOT NULL) AND " +
                  "(Computer.RamId IS NOT NULL) AND (Computer.DriveID IS NOT NULL) AND " +
                  "(Computer.VideoID IS NOT NULL)";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = mf.connectionString;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandITDB, mf.connectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "RepMonth");
            dgdRepResult.DataSource = ds.Tables[0].DefaultView;
            dgdRepResult.DataSource = ds.Tables[0].DefaultView;
            dgdRepResult.Columns[0].HeaderText = "Имя компьютера";
            dgdRepResult.Columns[1].HeaderText = "Мат. плата";
            dgdRepResult.Columns[2].HeaderText = "Процессор";
            dgdRepResult.Columns[3].HeaderText = "RAM";
            dgdRepResult.Columns[4].HeaderText = "HDD";
            dgdRepResult.Columns[5].HeaderText = "Видеокарта";
            dgdRepResult.Columns[6].HeaderText = "Место установки";
            dgdRepResult.Visible = true;
            this.Text = "Генератор отчетов" + " --- Отчет о работоспособной технике";
        }
    }
}
