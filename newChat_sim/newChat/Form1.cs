using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace newChat
{
    public partial class Form1 : Form //로그인창
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = null;
        }

  

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = 192.168.0.57;Database=chat;Uid=root;Pwd=qq112233;");
                connection.Open();

                int login_status = 0;

                string loginid = textBox1.Text;
                string loginpwd = textBox2.Text;

                string selectQuery = "SELECT * FROM info WHERE id = \'" + loginid + "\' ";
                MySqlCommand Selectcommand = new MySqlCommand(selectQuery, connection);

                MySqlDataReader userAccount = Selectcommand.ExecuteReader();

                string userName = "";
                while (userAccount.Read())
                {
                    if (loginid == (string)userAccount["id"] && loginpwd == (string)userAccount["pwd"])
                    {
                        login_status = 1;
                        userName = (string)userAccount["name"];
                    }
                }
                connection.Close();

                if (login_status == 1)
                {
                    MessageBox.Show("로그인 완료");
                    Form3 showform3 = new Form3(userName);
                    showform3.ShowDialog();
                }
                else
                {
                    MessageBox.Show("회원 정보를 확인해 주세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 showform2 = new Form2();
            showform2.ShowDialog();
        }
    }
}
