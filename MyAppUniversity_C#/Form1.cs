using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAppUniversity
{
    public partial class Form1 : Form
    {
        public List<User> ListUser;

        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            bool isCorrect = false;
            foreach (var el in ListUser)
            {
                if (el._Login == login && el._Password == password)//перевірка облікових даних
                {
                    MessageBox.Show("Ви успішно зайшли. !", "Вітаємо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isCorrect = true;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    return;
                }
            }
            isCorrect = false;

            if (!isCorrect)
                MessageBox.Show("Невірно введені дані. !", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ListUser = new List<User>()
            {
                new User("User1", "Password1"),
                new User("User2", "Password2"),
                new User("User3", "Password3"),
                new User("User4", "Password4")
            };
        }
    }
    public class User
    {
        public string _Login;

        public string _Password;

        public User(string login, string password)
        {
            _Login = login;
            _Password = password;
        }

    }
}
