using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ITBD
{
    public partial class Logon : Form
    {
        MainForm mf = new MainForm();
        private static Logon m_Logon;

        public static Logon GetChildInstance()
        {
            if (m_Logon == null)
                m_Logon = new Logon();
            return m_Logon;
        }

        public Logon()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int access;
            string logonITDB = "SELECT AccessLvl,Logon FROM Login WHERE Logon = '" +
                txtLogon.Text + "' AND Password = '" + txtPsw.Text + "'";
            SqlConnection connLog = new SqlConnection(mf.connectionString);
            using (SqlCommand sqlCommand = new SqlCommand(logonITDB, connLog))
            {
                connLog.Open();

                sqlCommand.ExecuteNonQuery();
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                {
                    DataSet logon = new DataSet();
                    sqlDataAdapter.Fill(logon);
                    if (logon.Tables[0].Rows.Count == 0)
                        MessageBox.Show("Неверный логин или пароль!!!");
                    else
                    {
                        access = Convert.ToInt32(logon.Tables[0].Rows[0][0].ToString());
                        switch (access)
                        {
                            case 1:
                                MessageBox.Show("Добро пожаловать. Вы получили права администратора");
                                (Owner as MainForm).statusUser.Text = logon.Tables[0].Rows[0][1].ToString();
                                (Owner as MainForm).statusAccLvl.Text = "Администратор";
                                AccessActivate(access);
                                break;
                            case 2:
                                MessageBox.Show("Добро пожаловать. Вы получили права пользователя");
                                (Owner as MainForm).statusUser.Text = logon.Tables[0].Rows[0][1].ToString();
                                (Owner as MainForm).statusAccLvl.Text = "Пользователь";
                                AccessActivate(access);
                                break;                                
                            default:
                                MessageBox.Show("Упс, для вас группу еще не придумали :)");
                                break;
                        }
                    }
                }
            }
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Logon_Load(object sender, EventArgs e)
        {
            txtLogon.Select();
            (Owner as MainForm).mnuToolStrip.Enabled = false;
            (Owner as MainForm).mnuDirMain.Enabled = false;
            (Owner as MainForm).mnuRepMain.Enabled = false;
        }

        private void txtPsw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOk_Click(sender, new EventArgs());
        }

        private void AccessActivate(int access)
        {
            switch (access)
            {
                case 1:
                    (Owner as MainForm).mnuToolStrip.Enabled = true;
                    (Owner as MainForm).mnuDirMain.Enabled = true;
                    (Owner as MainForm).mnuRepMain.Enabled = true;
                    break;
                case 2:
                    (Owner as MainForm).mnuDirMain.Enabled = true;
                    (Owner as MainForm).mnuRepMain.Enabled = true;
                    break;
                default:
                    break;
            }
        }
    }
}
