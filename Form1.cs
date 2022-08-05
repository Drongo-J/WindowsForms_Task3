using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsForms_Task3
{
    public partial class Questionnaire : Form
    {
        List<User> users = new List<User>();

        public Questionnaire()
        {
            InitializeComponent();

            User user1 = new User("John", "Johnlu", "john@gmail.com", "(111) 546-1321", new DateTime(1999, 4, 23).ToLongDateString());
            User user2 = new User("Tural", "Turalli", "tural@gmail.com", "(111) 243-6256", new DateTime(1999, 9, 12).ToLongDateString());
            User user3 = new User("Leyla", "Leylali", "leyla@gmail.com", "(111) 452-1683", new DateTime(1978, 3, 30).ToLongDateString());
            User user4 = new User("Memmed", "Memmed", "memmed@gmail.com", "(111) 519-8351", new DateTime(2000, 1, 1).ToLongDateString());

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);

            usersListBx.Items.AddRange(users.ToArray());
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            bool canCreate = true;
            if (nameTxtb.Text == String.Empty)
            {
                nameWarningLbl.Text = "Name must be filled";
                canCreate = false;
            }
            else
            {
                nameWarningLbl.Text = String.Empty;
            }

            if (surnameTxtb.Text == String.Empty)
            {
                surnameWarningLbl.Text = "Surname must be filled";
                canCreate = false;
            }
            else
            {
                surnameWarningLbl.Text = String.Empty;
            }

            if (emailTxtb.Text == String.Empty)
            {
                emailWarningLbl.Text = "Email must be filled";
                canCreate = false;
            }
            else
            {
                emailWarningLbl.Text = String.Empty;
            }

            if (!phoneNumberMTxtb.MaskCompleted)
            {
                phoneNumberWarningLbl.Text = "Phone number must be filled";
                canCreate = false;
            }
            else
            {
                phoneNumberWarningLbl.Text = String.Empty;
            }

            if (canCreate)
            {
                User user = new User(nameTxtb.Text, surnameTxtb.Text, emailTxtb.Text, phoneNumberMTxtb.Text, guna2DateTimePicker2.Text);
                users.Add(user);
                usersListBx.Items.Add(user);
            }


        }

        private void nameTxtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            User selectedUser = usersListBx.SelectedItem as User;
            if (selectedUser != null)
            {
                usersListBx.Items.Remove(usersListBx.SelectedItem as User);
                users.Remove(usersListBx.SelectedItem as User);

                selectedUser.Name = nameTxtb.Text;
                selectedUser.Surname = surnameTxtb.Text;
                selectedUser.Email = emailTxtb.Text;
                selectedUser.PhoneNumber = phoneNumberMTxtb.Text;
                selectedUser.BirthDate = guna2DateTimePicker2.Value.ToString();

                usersListBx.Items.Add(selectedUser);
                users.Add(selectedUser);

                File.Delete(selectedUser.Email);
                Helper.JsonSerialization.SerializeUser(selectedUser);

                warningLbl.ForeColor = Color.LightGreen;
                warningLbl.Text = "User Updated";
            }
        }


        private void usersListBx_SelectedValueChanged(object sender, EventArgs e)
        {
            if (usersListBx.SelectedItem != null)
                filenameLbl.Text = (usersListBx.SelectedItem as User).Email + ".json";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Helper.JsonSerialization.SerializeUser(usersListBx.SelectedItem as User);
            warningLbl.ForeColor = Color.LightGreen;
            warningLbl.Text = "User saved to JSON files.";
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(filenameLbl.Text))
            {
                warningLbl.Text = String.Empty;
                User user = Helper.JsonSerialization.DeserializeUser(filenameLbl.Text);

                nameTxtb.Text = user.Name;
                surnameTxtb.Text = user.Surname;
                emailTxtb.Text = user.Email;
                phoneNumberMTxtb.Text = user.PhoneNumber;
                guna2DateTimePicker2.Value = DateTime.Parse(user.BirthDate);
            }
            else
            {
                warningLbl.ForeColor = Color.Red;
                warningLbl.Text = $"File does not exist.";
            }
        }
    }
}

