using FirestoreApplication.Classes;
using Google.Cloud.Firestore;
using Loginadmin.Class;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Loginadmin.Forms
{
    public partial class UpdateForm : Form
    {
        private readonly string DocumentId;
        private readonly FirestoreDb Database;

        private readonly string placeholderFname = "Enter First Name";
        private readonly string placeholderLname = "Enter Last Name";
        private readonly string placeholderAge = "Enter Age";
        private readonly string placeholderHeight = "Enter Height";
        private readonly string placeholderWeight = "Enter Weight";
        private readonly string placeholderSex = "Enter Sex";
        private readonly string placeholderCondition = "Enter Condition";
        private readonly string placeholderContact = "Enter Contact Number";
        private readonly string placeholderEmail = "Enter Email";
        private readonly string placeholderGuardian = "Enter Guardian's Name";
        private readonly string placeholderRelationship = "Enter Relationship";

        public UpdateForm(string documentId, FirestoreDb database)
        {
            InitializeComponent();

            DocumentId = documentId;
            Database = database;

            SetPlaceholders();
            LoadDocumentData();
        }

        private void SetPlaceholders()
        {
            SetPlaceholderText(Fname, placeholderFname);
            SetPlaceholderText(Lname, placeholderLname);
            SetPlaceholderText(age, placeholderAge);
            SetPlaceholderText(Height, placeholderHeight);
            SetPlaceholderText(weight, placeholderWeight);
            SetPlaceholderText(sex, placeholderSex);
            SetPlaceholderText(condition, placeholderCondition);
            SetPlaceholderText(contact, placeholderContact);
            SetPlaceholderText(email, placeholderEmail);
            SetPlaceholderText(guardian, placeholderGuardian);
            SetPlaceholderText(relationship, placeholderRelationship);
        }

        private void SetPlaceholderText(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = System.Drawing.Color.Gray;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }

        private async void LoadDocumentData()
        {
            try
            {
                DocumentReference docRef = Database.Collection("users").Document(DocumentId);
                DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

                if (snapshot.Exists)
                {
                    Fname.Text = snapshot.ContainsField("firstName") ? snapshot.GetValue<string>("firstName") : placeholderFname;
                    Lname.Text = snapshot.ContainsField("lastName") ? snapshot.GetValue<string>("lastName") : placeholderLname;
                    age.Text = snapshot.ContainsField("age") ? snapshot.GetValue<string>("age") : placeholderAge;
                    Height.Text = snapshot.ContainsField("height") ? snapshot.GetValue<string>("height") : placeholderHeight;
                    weight.Text = snapshot.ContainsField("weight") ? snapshot.GetValue<string>("weight") : placeholderWeight;
                    sex.Text = snapshot.ContainsField("sex") ? snapshot.GetValue<string>("sex") : placeholderSex;
                    condition.Text = snapshot.ContainsField("condition") ? snapshot.GetValue<string>("condition") : placeholderCondition;
                    contact.Text = snapshot.ContainsField("contact") ? snapshot.GetValue<string>("contact") : placeholderContact;
                    email.Text = snapshot.ContainsField("email") ? snapshot.GetValue<string>("email") : placeholderEmail;
                    guardian.Text = snapshot.ContainsField("guardian") ? snapshot.GetValue<string>("guardian") : placeholderGuardian;
                    relationship.Text = snapshot.ContainsField("relationship") ? snapshot.GetValue<string>("relationship") : placeholderRelationship;


                    AdjustTextBoxColor(Fname, placeholderFname);
                    AdjustTextBoxColor(Lname, placeholderLname);
                    AdjustTextBoxColor(age, placeholderAge);
                    AdjustTextBoxColor(Height, placeholderHeight);
                    AdjustTextBoxColor(weight, placeholderWeight);
                    AdjustTextBoxColor(sex, placeholderSex);
                    AdjustTextBoxColor(condition, placeholderCondition);
                    AdjustTextBoxColor(contact, placeholderContact);
                    AdjustTextBoxColor(email, placeholderEmail);
                    AdjustTextBoxColor(guardian, placeholderGuardian);
                    AdjustTextBoxColor(relationship, placeholderRelationship);
                }
                else
                {
                    MessageBox.Show("Document does not exist.");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void AdjustTextBoxColor(TextBox textBox, string placeholder)
        {
            if (textBox.Text != placeholder)
            {
                textBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private async void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(DocumentId))
                {
                    MessageBox.Show("Invalid Document ID.");
                    return;
                }

                DocumentReference docRef = Database.Collection("InfoUser").Document(DocumentId);

                var updatedData = new Dictionary<string, object>();

                // Validate first name
                if (Fname.Text != placeholderFname && !string.IsNullOrEmpty(Fname.Text.Trim()))
                    updatedData["firstName"] = Fname.Text.Trim();
                else
                {
                    MessageBox.Show("First Name cannot be empty.");
                    return;
                }

                // Validate last name
                if (Lname.Text != placeholderLname && !string.IsNullOrEmpty(Lname.Text.Trim()))
                    updatedData["lastName"] = Lname.Text.Trim();
                else
                {
                    MessageBox.Show("Last Name cannot be empty.");
                    return;
                }

                // Validate age (as a string)
                if (!string.IsNullOrEmpty(age.Text.Trim()))
                    updatedData["age"] = age.Text.Trim();
                else
                {
                    MessageBox.Show("Age cannot be empty.");
                    return;
                }

                // Validate height (as a string)
                if (Height.Text != placeholderHeight && !string.IsNullOrEmpty(Height.Text.Trim()))
                    updatedData["height"] = Height.Text.Trim();
                else
                {
                    MessageBox.Show("Height cannot be empty.");
                    return;
                }

                // Validate weight (as a string)
                if (!string.IsNullOrEmpty(weight.Text.Trim()))
                    updatedData["weight"] = weight.Text.Trim();
                else
                {
                    MessageBox.Show("Weight cannot be empty.");
                    return;
                }

                // Validate sex (as a string)
                if (sex.Text != placeholderSex && !string.IsNullOrEmpty(sex.Text.Trim()))
                    updatedData["sex"] = sex.Text.Trim();
                else
                {
                    MessageBox.Show("Sex cannot be empty.");
                    return;
                }

                // Validate condition (as a string)
                if (condition.Text != placeholderCondition && !string.IsNullOrEmpty(condition.Text.Trim()))
                    updatedData["condition"] = condition.Text.Trim();
                else
                {
                    MessageBox.Show("Condition cannot be empty.");
                    return;
                }

                // Validate contact (as a string)
                if (!string.IsNullOrEmpty(contact.Text.Trim()))
                    updatedData["contact"] = contact.Text.Trim();
                else
                {
                    MessageBox.Show("Contact cannot be empty.");
                    return;
                }

                // Validate email (as a string)
                if (email.Text != placeholderEmail && !string.IsNullOrEmpty(email.Text.Trim()))
                    updatedData["email"] = email.Text.Trim();
                else
                {
                    MessageBox.Show("Email cannot be empty.");
                    return;
                }

                // Validate guardian (as a string)
                if (guardian.Text != placeholderGuardian && !string.IsNullOrEmpty(guardian.Text.Trim()))
                    updatedData["guardian"] = guardian.Text.Trim();
                else
                {
                    MessageBox.Show("Guardian cannot be empty.");
                    return;
                }

                // Validate relationship (as a string)
                if (relationship.Text != placeholderRelationship && !string.IsNullOrEmpty(relationship.Text.Trim()))
                    updatedData["relationship"] = relationship.Text.Trim();
                else
                {
                    MessageBox.Show("Relationship cannot be empty.");
                    return;
                }

                // Update the document in Firestore
                await docRef.SetAsync(updatedData, SetOptions.MergeAll);

                MessageBox.Show("Document updated successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating document: {ex.Message}");
            }
        }

    }
}
