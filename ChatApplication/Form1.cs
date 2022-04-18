using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();

        public Form1()
        {
            InitializeComponent();
        }

        public List<User> createUser(String username, String password) {
           
            users.Add(new User {username = username, password = password });
            showMessage("User created successfully, Please login again");
            return users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = this.username_textbox.Text;
            String password = this.password_textbox.Text;

            if(username.Trim().Length <= 0 || password.Trim().Length <= 0)
            {
                showMessage("Please enter your credentials");
                return;
            }

            User foundUser =  users.Find(user => user.username == username);

            if(foundUser == null)
            {
                DialogResult dialogResult = showPrompt("User not found, do you want to create one?");
                if(dialogResult == DialogResult.Yes)
                {
                    createUser(username, password);
                }
               
                return;
            }

            if(foundUser.password != password)
            {
                showMessage("Incorrect password");
                return;
            }


            Form2 f2 = new Form2();
            f2.loggedInUser = foundUser;
            f2.Show();
            this.Hide();
        }

        private static void showMessage(String message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OKCancel);
        }

        private static DialogResult showPrompt(String message)
        {
            return MessageBox.Show(message, "", MessageBoxButtons.YesNo);
        }
    }
}
