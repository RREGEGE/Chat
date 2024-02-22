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
    public partial class Form2 : Form //회원가입
    {
        public Form2()
        {
            InitializeComponent();
        }


       

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = 192.168.0.57;Database=chat;Uid=root;Pwd=qq112233;");
                connection.Open();

                string password = pwd_txtbox.Text;
                string reenteredPassword = repwd_txtbox.Text; // 재입력한 비밀번호

                if (password != reenteredPassword)
                {
                    MessageBox.Show("비밀번호가 일치하지 않습니다. 다시 입력해주세요.");
                    return; // 비밀번호가 일치하지 않으면 회원가입을 중단하고 메서드를 종료합니다.
                }

                string id = id_txtbox.Text;

                // ID 중복 검사
                string checkQuery = "SELECT COUNT(*) FROM info WHERE id = '" + id + "'";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("이미 존재하는 ID입니다. 다른 ID를 입력해주세요.");
                    return; // 중복된 ID가 있으면 회원가입을 중단하고 메서드를 종료합니다.
                }

                string insertQuery = "INSERT INTO info (name, id, pwd, birth) VALUES ('" + name_txtbox.Text + "', '" + id + "', '" + password + "', '" + birth_txtbox.Text + "');";
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(name_txtbox.Text + "님 회원가입 완료, 사용할 아이디는 " + id + "입니다.");
                    connection.Close();
                    Close();
                }
                else
                {
                    MessageBox.Show("비정상 입력 정보, 재확인 요망");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
