using Google.Cloud.Firestore;
using System;
using System.Windows.Forms;

namespace Loginadmin.Forms
{
    public partial class UpdateDeleteForm : Form
    {
        private string documentId; 
        private FirestoreDb database; 

        public UpdateDeleteForm(string documentId, FirestoreDb database)
        {
            InitializeComponent();
            this.documentId = documentId;
            this.database = database;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (UpdateForm updateForm = new UpdateForm(documentId, database))
            {
            
                updateForm.ShowDialog();
                this.DialogResult = DialogResult.OK; 
                this.Close(); 
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                $"Are you sure you want to delete the row for '{documentId}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                   
                    DeleteDocument(documentId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting document: {ex.Message}");
                }
            }
        }

        
        private async void DeleteDocument(string documentId)
        {
            try
            {
                DocumentReference docRef = database.Collection("users").Document(documentId);
                await docRef.DeleteAsync(); 

                MessageBox.Show("Record deleted successfully.");
                this.DialogResult = DialogResult.OK; 
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting record: {ex.Message}");
            }
        }
    }
}
