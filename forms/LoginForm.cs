using FirestoreApplication.Classes;
using Google.Cloud.Firestore;
using Loginadmin.Class;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginadmin.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UserBox.Text.Trim();
            string password = PassBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Fields cannot be empty.");
                return;
            }

            try
            {
                var db = FirestoreHelper.Database;
                DocumentReference docRef = db.Collection("AdminUser").Document(username);
                DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

                if (snapshot.Exists)
                {
                    AdminUser data = snapshot.ConvertTo<AdminUser>();
                    if (Security.Encrypt(password) == data.password)
                    {
                        MessageBox.Show("Login Successful!");
                        Hide();
                        AdminPanel adminPanel = new AdminPanel(username);
                        adminPanel.ShowDialog();
                        Close();
                    }
                    else
                    {
                        ShowInvalidLoginMessage();
                    }
                }
                else
                {
                    ShowInvalidLoginMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Reglnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            PassBox.UseSystemPasswordChar = true;
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            PassBox.UseSystemPasswordChar = ShowPassword.Checked;
        }

        private void ShowInvalidLoginMessage()
        {
            MessageBox.Show("Invalid username or password.");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
