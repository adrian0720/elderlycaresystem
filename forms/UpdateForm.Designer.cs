namespace Loginadmin.Forms
{
    partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UpdateBtn = new Button();
            weight = new TextBox();
            relationship = new TextBox();
            guardian = new TextBox();
            email = new TextBox();
            contact = new TextBox();
            condition = new TextBox();
            sex = new TextBox();
            label2 = new Label();
            Lname = new TextBox();
            age = new TextBox();
            Height = new TextBox();
            Fname = new TextBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.RoyalBlue;
            UpdateBtn.FlatStyle = FlatStyle.Popup;
            UpdateBtn.Location = new Point(166, 620);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(94, 29);
            UpdateBtn.TabIndex = 4;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // weight
            // 
            weight.BackColor = Color.Gainsboro;
            weight.Location = new Point(150, 286);
            weight.Name = "weight";
            weight.Size = new Size(125, 27);
            weight.TabIndex = 6;
            // 
            // relationship
            // 
            relationship.BackColor = Color.Gainsboro;
            relationship.Location = new Point(150, 567);
            relationship.Name = "relationship";
            relationship.Size = new Size(125, 27);
            relationship.TabIndex = 7;
            // 
            // guardian
            // 
            guardian.BackColor = Color.Gainsboro;
            guardian.Location = new Point(150, 520);
            guardian.Name = "guardian";
            guardian.Size = new Size(125, 27);
            guardian.TabIndex = 8;
            // 
            // email
            // 
            email.BackColor = Color.Gainsboro;
            email.Location = new Point(150, 475);
            email.Name = "email";
            email.Size = new Size(125, 27);
            email.TabIndex = 9;
            // 
            // contact
            // 
            contact.BackColor = Color.Gainsboro;
            contact.Location = new Point(150, 426);
            contact.Name = "contact";
            contact.Size = new Size(125, 27);
            contact.TabIndex = 10;
            // 
            // condition
            // 
            condition.BackColor = Color.Gainsboro;
            condition.Location = new Point(150, 379);
            condition.Name = "condition";
            condition.Size = new Size(125, 27);
            condition.TabIndex = 11;
            // 
            // sex
            // 
            sex.BackColor = Color.Gainsboro;
            sex.Location = new Point(150, 334);
            sex.Name = "sex";
            sex.Size = new Size(125, 27);
            sex.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(107, 50);
            label2.Name = "label2";
            label2.Size = new Size(228, 31);
            label2.TabIndex = 13;
            label2.Text = "Update Information";
            // 
            // Lname
            // 
            Lname.BackColor = Color.Gainsboro;
            Lname.Location = new Point(150, 146);
            Lname.Name = "Lname";
            Lname.Size = new Size(125, 27);
            Lname.TabIndex = 17;
            // 
            // age
            // 
            age.BackColor = Color.Gainsboro;
            age.Location = new Point(150, 193);
            age.Name = "age";
            age.Size = new Size(125, 27);
            age.TabIndex = 16;
            // 
            // Height
            // 
            Height.BackColor = Color.Gainsboro;
            Height.Location = new Point(150, 240);
            Height.Name = "Height";
            Height.Size = new Size(125, 27);
            Height.TabIndex = 15;
            // 
            // Fname
            // 
            Fname.BackColor = Color.Gainsboro;
            Fname.Location = new Point(150, 103);
            Fname.Name = "Fname";
            Fname.Size = new Size(125, 27);
            Fname.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(80, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 676);
            panel1.TabIndex = 18;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(456, 806);
            Controls.Add(Lname);
            Controls.Add(age);
            Controls.Add(Height);
            Controls.Add(Fname);
            Controls.Add(label2);
            Controls.Add(sex);
            Controls.Add(condition);
            Controls.Add(contact);
            Controls.Add(email);
            Controls.Add(guardian);
            Controls.Add(relationship);
            Controls.Add(weight);
            Controls.Add(UpdateBtn);
            Controls.Add(panel1);
            Name = "UpdateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button UpdateBtn;
        private TextBox weight;
        private TextBox relationship;
        private TextBox guardian;
        private TextBox email;
        private TextBox contact;
        private TextBox condition;
        private TextBox sex;
        private Label label2;
        private TextBox Lname;
        private TextBox age;
        private TextBox Height;
        private TextBox Fname;
        private Panel panel1;
    }
}