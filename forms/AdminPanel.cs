using Firebase.Database;
using FirestoreApplication.Classes;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using Firebase.Database.Query;
using Loginadmin.Class;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Loginadmin.Forms
{
    public partial class AdminPanel : Form
    {
        FirestoreDb Database;
        private string username;
        private IFirebaseClient client;



        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "DNc1CJQB2OOSRdTQmVDaYZXop2WnV1RKYQbJZxBk",  // Replace with your Firebase AuthSecret
            BasePath = "https://signup-login-e989d-default-rtdb.firebaseio.com/"  // Replace with your Firebase Database URL
        };



        private void adminpanel_load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
                if (client != null)
                {
                    MessageBox.Show("Connection is Established");
                }
                else
                {
                    MessageBox.Show("Failed to establish connection. Please check your configuration.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }




        public AdminPanel(string username)

        {
            client = new FireSharp.FirebaseClient(config);

            InitializeComponent();
            this.username = username;
            AdminName.Text = username;
            DisplayDateTime();

            client = new FireSharp.FirebaseClient(config);




            // Path to Firebase service account JSON file
            string path = AppDomain.CurrentDomain.BaseDirectory + @"signup-login-e989d-firebase-adminsdk-jdplu-12013ba460.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            Database = FirestoreDb.Create("signup-login-e989d");
            LoadFeedbackDataGrid(); // Now this is called after Database has been initialized
            InitializeDataGridView();



            // Set up DataGridView
            dataGridUser.ColumnCount = 12; // Set to 12 for all columns defined
            dataGridUser.Columns[0].Name = "Document ID";
            dataGridUser.Columns[1].Name = "First Name";
            dataGridUser.Columns[2].Name = "Last Name";
            dataGridUser.Columns[3].Name = "Age";
            dataGridUser.Columns[4].Name = "Height";
            dataGridUser.Columns[5].Name = "Weight lb";
            dataGridUser.Columns[6].Name = "Sex";
            dataGridUser.Columns[7].Name = "Condition";
            dataGridUser.Columns[8].Name = "Contact";
            dataGridUser.Columns[9].Name = "Email";
            dataGridUser.Columns[10].Name = "Guardian";
            dataGridUser.Columns[11].Name = "Relationship";


            // DataGridView styles
            dataGridUser.BackgroundColor = Color.FromArgb(50, 50, 50);
            dataGridUser.BorderStyle = BorderStyle.None;

            dataGridUser.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(70, 130, 180);
            dataGridUser.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridUser.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            dataGridUser.RowsDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
            dataGridUser.RowsDefaultCellStyle.ForeColor = Color.White;
            dataGridUser.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridUser.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 149, 237);
            dataGridUser.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridUser.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(80, 80, 80);
            dataGridUser.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            LoadDataGrid(); // Load data into the DataGridView

            dataGridUser.CellMouseClick += dataGridUser_CellMouseClick; // Event handler for cell clicks

            // Set placeholders for input fields
            SetPlaceholder(FnameAdd, "Enter First Name");
            SetPlaceholder(LnameAdd, "Enter Last Name");
            SetPlaceholder(Addage, "Enter Age");
            SetPlaceholder(HeightAdd, "Enter Height");
            SetPlaceholder(weightAdd, "Enter Weight");
            SetPlaceholder(sexAdd, "Enter Sex");
            SetPlaceholder(conditionAdd, "Enter Condition");
            SetPlaceholder(contactAdd, "Enter Contact");
            SetPlaceholder(emailAdd, "Enter Email");
            SetPlaceholder(guardianAdd, "Enter Guardian");
            SetPlaceholder(relationshipAdd, "Enter Relationship");

        }


     






































        private async void LoadFeedbackDataGrid()
        {
            // Set up the paths to the star images in the Downloads folder
            string starFilledPath = @"C:\Users\Nimrod Sulit\Downloads\star.png";
            string starEmptyPath = @"C:\Users\Nimrod Sulit\Downloads\star (1).png";

            try
            {
                Query feedbackQuery = Database.Collection("feedback");
                QuerySnapshot snapshot = await feedbackQuery.GetSnapshotAsync();

                dataGridViewfeedback.Rows.Clear();

                foreach (DocumentSnapshot document in snapshot.Documents)
                {
                    if (document.Exists)
                    {
                        string email = document.ContainsField("email") ? document.GetValue<string>("email") : "";
                        string feedback = document.ContainsField("feedback") ? document.GetValue<string>("feedback") : "";
                        int rating = document.ContainsField("rating") ? document.GetValue<int>("rating") : 0;

                        // Load star images based on the rating
                        Image[] stars = new Image[5];
                        for (int i = 0; i < 5; i++)
                        {
                            stars[i] = (i < rating) ? Image.FromFile(starFilledPath) : Image.FromFile(starEmptyPath);
                        }

                        Bitmap bitmap = new Bitmap(100, 20);
                        using (Graphics g = Graphics.FromImage(bitmap))
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                g.DrawImage(stars[i], i * 20, 0, 18, 18);
                            }
                        }

                        Timestamp timestamp = document.GetValue<Timestamp>("timestamp");
                        string formattedTimestamp = timestamp.ToDateTime().ToString("g");

                        // Add data to the DataGridView
                        dataGridViewfeedback.Rows.Add(
                            email,
                            feedback,
                            bitmap,
                            formattedTimestamp
                        );
                    }
                }

                // Update label3 with the row count, similar to the approach in your other example
                label3.Text = $"{dataGridViewfeedback.Rows.Count - 1}"; // Update label3 with the row count
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedback: " + ex.Message);
            }
        }





        // Method to initialize DataGridView columns
        private void InitializeDataGridView()
        {
            dataGridViewfeedback.Columns.Clear(); // Clear any existing columns

            // Add columns for email, feedback, and timestamp
            dataGridViewfeedback.Columns.Add("email", "Email");
            dataGridViewfeedback.Columns.Add("feedback", "Feedback");

            // Add a DataGridViewImageColumn for rating
            DataGridViewImageColumn ratingColumn = new DataGridViewImageColumn();
            ratingColumn.Name = "rating";
            ratingColumn.HeaderText = "Rating";
            ratingColumn.Width = 100;
            ratingColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Adjust the layout as needed
            dataGridViewfeedback.Columns.Add(ratingColumn);


            // Optionally, adjust column widths and properties
            dataGridViewfeedback.Columns["email"].Width = 150;
            dataGridViewfeedback.Columns["feedback"].Width = 300;

            // Update label3 with the number of rows in the DataGridView (excluding the new row if it exists)
            int rowCount = dataGridViewfeedback.Rows.Cast<DataGridViewRow>()
                .Count(row => !row.IsNewRow);  // Exclude the new row placeholder, if it exists

            label3.Text = "" + rowCount.ToString();  // Update label3 with row count
        }













        // Event handler for the Refresh button
        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        // Method to load data into the DataGrid
        private async void LoadDataGrid()
        {
            try
            {
                Query userQuery = Database.Collection("users");
                QuerySnapshot snapshot = await userQuery.GetSnapshotAsync();

                dataGridUser.Rows.Clear();

                foreach (DocumentSnapshot document in snapshot.Documents)
                {
                    if (document.Exists)
                    {
                        // Retrieve all fields as strings, with a default empty string for missing fields
                        string documentId = document.Id;
                        string firstName = document.ContainsField("firstName") ? document.GetValue<string>("firstName") : "";
                        string lastName = document.ContainsField("lastName") ? document.GetValue<string>("lastName") : "";
                        string age = document.ContainsField("age") ? document.GetValue<string>("age") : "";
                        string height = document.ContainsField("height") ? document.GetValue<string>("height") : "";
                        string weight = document.ContainsField("weight") ? document.GetValue<string>("weight") : "";
                        string sex = document.ContainsField("sex") ? document.GetValue<string>("sex") : "";
                        string condition = document.ContainsField("condition") ? document.GetValue<string>("condition") : "";
                        string contact = document.ContainsField("contact") ? document.GetValue<string>("contact") : "";
                        string email = document.ContainsField("email") ? document.GetValue<string>("email") : "";
                        string guardian = document.ContainsField("guardian") ? document.GetValue<string>("guardian") : "";
                        string relationship = document.ContainsField("relationship") ? document.GetValue<string>("relationship") : "";
                        string securityQuestion = document.ContainsField("securityQuestion") ? document.GetValue<string>("securityQuestion") : "";
                        string securityAnswer = document.ContainsField("securityAnswer") ? document.GetValue<string>("securityAnswer") : "";
                        string pulseRate = document.ContainsField("pulseRate") ? document.GetValue<string>("pulseRate") : "";
                        string spo2 = document.ContainsField("spo2") ? document.GetValue<string>("spo2") : "";

                        // Add the data to the DataGridView
                        dataGridUser.Rows.Add(
                            documentId,         // Document ID
                            firstName,          // First Name
                            lastName,           // Last Name
                            age,                // Age
                            height,             // Height
                            weight,             // Weight
                            sex,                // Sex
                            condition,          // Condition
                            contact,            // Contact
                            email,              // Email
                            guardian,           // Guardian
                            relationship,       // Relationship
                            securityQuestion,   // Security Question
                            securityAnswer,     // Security Answer
                            pulseRate,          // Pulse Rate
                            spo2                // SpO2
                        );
                    }
                }

                // Update the label with the row count
                label7.Text = $"{dataGridUser.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving data: {ex.Message}");
            }
        }
    


        private void dataGridUser_CellMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dataGridUser.Rows[e.RowIndex].Selected = true;

                string? documentId = dataGridUser.Rows[e.RowIndex].Cells[0].Value?.ToString();

                if (documentId != null)
                {
                    UpdateDeleteForm updateDeleteForm = new UpdateDeleteForm(documentId, Database);
                    var result = updateDeleteForm.ShowDialog();

                    if (updateDeleteForm.DialogResult == DialogResult.OK)
                    {
                        LoadDataGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Document ID is null or empty.");
                }
            }
        }

        private void DeleteDocument(string documentId)
        {
            Database.Collection("users").Document(documentId).DeleteAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate that all fields are filled
                if (
                    string.IsNullOrWhiteSpace(FnameAdd.Text) ||
                    string.IsNullOrWhiteSpace(LnameAdd.Text) ||
                    string.IsNullOrWhiteSpace(Addage.Text) ||
                    string.IsNullOrWhiteSpace(HeightAdd.Text) ||
                    string.IsNullOrWhiteSpace(weightAdd.Text) ||
                    string.IsNullOrWhiteSpace(sexAdd.Text) ||
                    string.IsNullOrWhiteSpace(conditionAdd.Text) ||
                    string.IsNullOrWhiteSpace(contactAdd.Text) ||
                    string.IsNullOrWhiteSpace(emailAdd.Text) ||
                    string.IsNullOrWhiteSpace(guardianAdd.Text) ||
                    string.IsNullOrWhiteSpace(relationshipAdd.Text)
                )
                {
                    MessageBox.Show("All fields must be filled.");
                    return;
                }

                // Validate individual fields
                if (!int.TryParse(Addage.Text.Trim(), out _))
                {
                    MessageBox.Show("Age must be a valid integer.");
                    return;
                }

                if (!double.TryParse(weightAdd.Text.Trim(), out _))
                {
                    MessageBox.Show("Weight must be a valid number.");
                    return;
                }

                if (!long.TryParse(contactAdd.Text.Trim(), out _))
                {
                    MessageBox.Show("Contact must be a valid number.");
                    return;
                }

                // Ensure the sex field has valid entries
                string validSex = sexAdd.Text.Trim().ToLower();
                if (validSex != "male" && validSex != "female")
                {
                    MessageBox.Show("Sex must be 'male' or 'female'.");
                    return;
                }

                // Prepare data for Firestore
                var newData = new
                {
                    firstName = FnameAdd.Text.Trim(),
                    lastName = LnameAdd.Text.Trim(),
                    age = Addage.Text.Trim(),  // Stored as string
                    height = HeightAdd.Text.Trim(),
                    weight = weightAdd.Text.Trim(),  // Stored as string
                    sex = sexAdd.Text.Trim(),
                    condition = conditionAdd.Text.Trim(),
                    contact = contactAdd.Text.Trim(),  // Stored as string
                    email = emailAdd.Text.Trim(),
                    guardian = guardianAdd.Text.Trim(),
                    relationship = relationshipAdd.Text.Trim()
                };

                // Add to Firestore
                CollectionReference usersCollection = Database.Collection("users");
                await usersCollection.AddAsync(newData);

                MessageBox.Show("Data added successfully!");

                // Reset fields with placeholders
                ResetFields();
                LoadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Method to reset fields
        private void ResetFields()
        {
            FnameAdd.Text = "Enter First Name";
            LnameAdd.Text = "Enter Last Name";
            Addage.Text = "Enter Age";
            HeightAdd.Text = "Enter Height";
            weightAdd.Text = "Enter Weight";
            sexAdd.Text = "Enter Sex";
            conditionAdd.Text = "Enter Condition";
            contactAdd.Text = "Enter Contact";
            emailAdd.Text = "Enter Email";
            guardianAdd.Text = "Enter Guardian's Name";
            relationshipAdd.Text = "Enter Relationship";

            FnameAdd.ForeColor = System.Drawing.Color.Gray;
            LnameAdd.ForeColor = System.Drawing.Color.Gray;
            Addage.ForeColor = System.Drawing.Color.Gray;
            HeightAdd.ForeColor = System.Drawing.Color.Gray;
            weightAdd.ForeColor = System.Drawing.Color.Gray;
            sexAdd.ForeColor = System.Drawing.Color.Gray;
            conditionAdd.ForeColor = System.Drawing.Color.Gray;
            contactAdd.ForeColor = System.Drawing.Color.Gray;
            emailAdd.ForeColor = System.Drawing.Color.Gray;
            guardianAdd.ForeColor = System.Drawing.Color.Gray;
            relationshipAdd.ForeColor = System.Drawing.Color.Gray;
        }


        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = System.Drawing.Color.Gray;

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void homeBtn_Click(object sender, EventArgs e)
        {
            UserNo.Visible = true;


        }
        private void userBtn_Click(object sender, EventArgs e)
        {
            UserNo.Visible = false;


        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            UserNo.Visible = false;

        }

        private void Logoutlbl_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                           "Are you sure you want to log out?",
                           "Confirm Logout",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question
                       );

            if (result == DialogResult.Yes)

            {
                this.Hide(); // Hide the AdminPanel
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog(); // Show LoginForm as a modal dialog
                this.Show(); // Show the AdminPanel again if LoginForm is closed without exiting the application
            }

        }




        private async void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(SearchBar.Text) || SearchBy.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a search category and enter a search term.");
                    return;
                }

                string searchCategory = SearchBy.SelectedItem.ToString();
                string searchValue = SearchBar.Text.Trim().ToLower();

                Query userQuery = Database.Collection("users");
                QuerySnapshot snapshot = await userQuery.GetSnapshotAsync();

                dataGridUser.Rows.Clear();

                foreach (DocumentSnapshot document in snapshot.Documents)
                {
                    if (document.Exists)
                    {
                        // Retrieve all fields as strings
                        string documentId = document.Id;
                        string firstName = document.ContainsField("firstName") ? document.GetValue<string>("firstName").ToLower() : "";
                        string lastName = document.ContainsField("lastName") ? document.GetValue<string>("lastName").ToLower() : "";
                        string age = document.ContainsField("age") ? document.GetValue<string>("age").ToLower() : "";
                        string height = document.ContainsField("height") ? document.GetValue<string>("height") : "";
                        string weight = document.ContainsField("weight") ? document.GetValue<string>("weight") : "";
                        string sex = document.ContainsField("sex") ? document.GetValue<string>("sex").ToLower() : "";
                        string condition = document.ContainsField("condition") ? document.GetValue<string>("condition").ToLower() : "";
                        string contact = document.ContainsField("contact") ? document.GetValue<string>("contact") : "";
                        string email = document.ContainsField("email") ? document.GetValue<string>("email") : "";
                        string guardian = document.ContainsField("guardian") ? document.GetValue<string>("guardian") : "";
                        string relationship = document.ContainsField("relationship") ? document.GetValue<string>("relationship") : "";

                        // Check if the document matches the search criteria
                        bool isMatch = false;
                        switch (searchCategory)
                        {
                            case "First Name":
                                if (firstName.Contains(searchValue))
                                    isMatch = true;
                                break;
                            case "Last Name":
                                if (lastName.Contains(searchValue))
                                    isMatch = true;
                                break;
                            case "Age":
                                if (age.Contains(searchValue))
                                    isMatch = true;
                                break;
                            case "Sex":
                                if (sex == searchValue) // Use exact match for 'Sex'
                                    isMatch = true;
                                break;
                            case "Condition":
                                if (condition.Contains(searchValue))
                                    isMatch = true;
                                break;
                        }

                        if (isMatch)
                        {
                            // Add the matching data to the DataGridView
                            dataGridUser.Rows.Add(
                                documentId,
                                firstName,
                                lastName,
                                age,
                                height,
                                weight,
                                sex,
                                condition,
                                contact,
                                email,
                                guardian,
                                relationship
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}");
            }
        }



        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void fback_Click(object sender, EventArgs e)
        {
            UserNo.Visible = false;
        }

        private void dataGridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void fbacklistView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void DisplayDateTime()
        {
            // Get the current date and time
            DateTime now = DateTime.Now;

            // Display the date and time in the labels
            Date.Text = now.ToString("MMMM dd, yyyy"); // Example: October 25, 2024
            Time.Text = now.ToString("hh:mm:ss tt"); // Example: 08:30:45 PM
        }

        private void dataGridViewfeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

    }
}