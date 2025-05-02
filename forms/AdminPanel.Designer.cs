namespace Loginadmin.Forms
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            dataGridUser = new DataGridView();
            panel1 = new Panel();
            Time = new Label();
            Date = new Label();
            AdminName = new Label();
            SearchBar = new TextBox();
            SearchBy = new ComboBox();
            SearchBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel9 = new Panel();
            Logoutlbl = new Label();
            button1 = new Button();
            userBtn = new Button();
            homeBtn = new Button();
            groupBox3 = new GroupBox();
            dataGridViewfeedback = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            AddBtn = new Button();
            groupBox = new GroupBox();
            panel4 = new Panel();
            panel7 = new Panel();
            conditionAdd = new TextBox();
            contactAdd = new TextBox();
            relationshipAdd = new TextBox();
            sexAdd = new TextBox();
            guardianAdd = new TextBox();
            emailAdd = new TextBox();
            weightAdd = new TextBox();
            FnameAdd = new TextBox();
            HeightAdd = new TextBox();
            LnameAdd = new TextBox();
            Addage = new TextBox();
            Refresh = new Button();
            UserNo = new GroupBox();
            panel6 = new Panel();
            panel8 = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label12 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewfeedback).BeginInit();
            groupBox.SuspendLayout();
            panel7.SuspendLayout();
            UserNo.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridUser
            // 
            dataGridUser.AllowUserToAddRows = false;
            dataGridUser.AllowUserToDeleteRows = false;
            dataGridUser.AllowUserToOrderColumns = true;
            dataGridUser.BackgroundColor = SystemColors.Control;
            dataGridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUser.Cursor = Cursors.Hand;
            dataGridUser.Location = new Point(30, 0);
            dataGridUser.Name = "dataGridUser";
            dataGridUser.ReadOnly = true;
            dataGridUser.RowHeadersWidth = 51;
            dataGridUser.Size = new Size(1567, 458);
            dataGridUser.TabIndex = 1;
            dataGridUser.CellContentClick += dataGridUser_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(Time);
            panel1.Controls.Add(Date);
            panel1.Controls.Add(AdminName);
            panel1.Controls.Add(SearchBar);
            panel1.Controls.Add(SearchBy);
            panel1.Controls.Add(SearchBtn);
            panel1.Location = new Point(222, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1702, 72);
            panel1.TabIndex = 3;
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Time.Location = new Point(1272, 26);
            Time.Name = "Time";
            Time.Size = new Size(92, 31);
            Time.TabIndex = 19;
            Time.Text = "label12";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Date.Location = new Point(924, 25);
            Date.Name = "Date";
            Date.Size = new Size(92, 31);
            Date.TabIndex = 18;
            Date.Text = "label12";
            // 
            // AdminName
            // 
            AdminName.AutoSize = true;
            AdminName.FlatStyle = FlatStyle.System;
            AdminName.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminName.Location = new Point(1516, 19);
            AdminName.Name = "AdminName";
            AdminName.Size = new Size(101, 35);
            AdminName.TabIndex = 5;
            AdminName.Text = "Name ";
            // 
            // SearchBar
            // 
            SearchBar.BorderStyle = BorderStyle.FixedSingle;
            SearchBar.Location = new Point(36, 20);
            SearchBar.Multiline = true;
            SearchBar.Name = "SearchBar";
            SearchBar.Size = new Size(238, 29);
            SearchBar.TabIndex = 15;
            // 
            // SearchBy
            // 
            SearchBy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBy.FormattingEnabled = true;
            SearchBy.Items.AddRange(new object[] { "First Name", "Last Name", "Sex", "Condition" });
            SearchBy.Location = new Point(281, 20);
            SearchBy.Name = "SearchBy";
            SearchBy.Size = new Size(151, 28);
            SearchBy.TabIndex = 17;
            SearchBy.Text = "Searh by";
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.DodgerBlue;
            SearchBtn.FlatStyle = FlatStyle.Popup;
            SearchBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.Location = new Point(442, 18);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(94, 29);
            SearchBtn.TabIndex = 16;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(33, 23);
            label1.Name = "label1";
            label1.Size = new Size(161, 62);
            label1.TabIndex = 0;
            label1.Text = "Elderly health\r\n Monitoring";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(480, 62);
            label2.Name = "label2";
            label2.Size = new Size(248, 46);
            label2.TabIndex = 13;
            label2.Text = "Add New User";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(Logoutlbl);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(userBtn);
            panel2.Controls.Add(homeBtn);
            panel2.Location = new Point(-3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(226, 972);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Black;
            panel9.Location = new Point(225, 935);
            panel9.Name = "panel9";
            panel9.Size = new Size(552, 35);
            panel9.TabIndex = 2;
            // 
            // Logoutlbl
            // 
            Logoutlbl.AutoSize = true;
            Logoutlbl.BackColor = SystemColors.ButtonHighlight;
            Logoutlbl.Cursor = Cursors.Hand;
            Logoutlbl.FlatStyle = FlatStyle.Popup;
            Logoutlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logoutlbl.ForeColor = Color.Red;
            Logoutlbl.Location = new Point(88, 234);
            Logoutlbl.Name = "Logoutlbl";
            Logoutlbl.Size = new Size(78, 28);
            Logoutlbl.TabIndex = 1;
            Logoutlbl.Text = "Logout";
            Logoutlbl.UseWaitCursor = true;
            Logoutlbl.Click += Logoutlbl_Click_1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources._switch;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(32, 226);
            button1.Name = "button1";
            button1.Size = new Size(189, 46);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // userBtn
            // 
            userBtn.BackColor = SystemColors.ButtonHighlight;
            userBtn.BackgroundImageLayout = ImageLayout.None;
            userBtn.FlatStyle = FlatStyle.Popup;
            userBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userBtn.ForeColor = SystemColors.ActiveCaptionText;
            userBtn.Image = Properties.Resources.user;
            userBtn.ImageAlign = ContentAlignment.MiddleLeft;
            userBtn.Location = new Point(31, 176);
            userBtn.Name = "userBtn";
            userBtn.Size = new Size(191, 42);
            userBtn.TabIndex = 7;
            userBtn.Text = "Users";
            userBtn.UseVisualStyleBackColor = false;
            userBtn.Click += userBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.BackColor = SystemColors.ButtonHighlight;
            homeBtn.BackgroundImageLayout = ImageLayout.None;
            homeBtn.FlatStyle = FlatStyle.Popup;
            homeBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeBtn.Image = Properties.Resources.home;
            homeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            homeBtn.Location = new Point(30, 124);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(192, 42);
            homeBtn.TabIndex = 6;
            homeBtn.Text = "Home";
            homeBtn.UseVisualStyleBackColor = false;
            homeBtn.Click += homeBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.DarkGray;
            groupBox3.Controls.Add(dataGridViewfeedback);
            groupBox3.Location = new Point(167, 208);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(655, 555);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // dataGridViewfeedback
            // 
            dataGridViewfeedback.BackgroundColor = Color.White;
            dataGridViewfeedback.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewfeedback.Location = new Point(18, 15);
            dataGridViewfeedback.Name = "dataGridViewfeedback";
            dataGridViewfeedback.RowHeadersWidth = 51;
            dataGridViewfeedback.Size = new Size(621, 527);
            dataGridViewfeedback.TabIndex = 0;
            dataGridViewfeedback.CellContentClick += dataGridViewfeedback_CellContentClick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Black;
            flowLayoutPanel1.Location = new Point(225, 938);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1699, 32);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.HotTrack;
            AddBtn.Cursor = Cursors.Hand;
            AddBtn.FlatStyle = FlatStyle.Popup;
            AddBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(811, 221);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(170, 31);
            AddBtn.TabIndex = 5;
            AddBtn.Text = "Add User";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // groupBox
            // 
            groupBox.BackColor = Color.White;
            groupBox.Controls.Add(panel4);
            groupBox.Controls.Add(panel7);
            groupBox.Controls.Add(Refresh);
            groupBox.Controls.Add(dataGridUser);
            groupBox.Location = new Point(224, 75);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(1697, 857);
            groupBox.TabIndex = 20;
            groupBox.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Turquoise;
            panel4.Location = new Point(0, 478);
            panel4.Name = "panel4";
            panel4.Size = new Size(1697, 26);
            panel4.TabIndex = 31;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(255, 255, 192);
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(conditionAdd);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(contactAdd);
            panel7.Controls.Add(AddBtn);
            panel7.Controls.Add(relationshipAdd);
            panel7.Controls.Add(sexAdd);
            panel7.Controls.Add(guardianAdd);
            panel7.Controls.Add(emailAdd);
            panel7.Controls.Add(weightAdd);
            panel7.Controls.Add(FnameAdd);
            panel7.Controls.Add(HeightAdd);
            panel7.Controls.Add(LnameAdd);
            panel7.Controls.Add(Addage);
            panel7.Location = new Point(206, 522);
            panel7.Name = "panel7";
            panel7.Size = new Size(1267, 317);
            panel7.TabIndex = 30;
            // 
            // conditionAdd
            // 
            conditionAdd.Cursor = Cursors.Hand;
            conditionAdd.Font = new Font("Segoe UI", 10.8F);
            conditionAdd.Location = new Point(429, 181);
            conditionAdd.Name = "conditionAdd";
            conditionAdd.Size = new Size(170, 31);
            conditionAdd.TabIndex = 11;
            // 
            // contactAdd
            // 
            contactAdd.Cursor = Cursors.Hand;
            contactAdd.Font = new Font("Segoe UI", 10.8F);
            contactAdd.Location = new Point(621, 140);
            contactAdd.Name = "contactAdd";
            contactAdd.Size = new Size(170, 31);
            contactAdd.TabIndex = 23;
            // 
            // relationshipAdd
            // 
            relationshipAdd.Cursor = Cursors.Hand;
            relationshipAdd.Font = new Font("Segoe UI", 10.8F);
            relationshipAdd.Location = new Point(811, 179);
            relationshipAdd.Name = "relationshipAdd";
            relationshipAdd.Size = new Size(170, 31);
            relationshipAdd.TabIndex = 13;
            // 
            // sexAdd
            // 
            sexAdd.Cursor = Cursors.Hand;
            sexAdd.Font = new Font("Segoe UI", 10.8F);
            sexAdd.Location = new Point(429, 140);
            sexAdd.Name = "sexAdd";
            sexAdd.Size = new Size(170, 31);
            sexAdd.TabIndex = 22;
            // 
            // guardianAdd
            // 
            guardianAdd.Cursor = Cursors.Hand;
            guardianAdd.Font = new Font("Segoe UI", 10.8F);
            guardianAdd.Location = new Point(811, 138);
            guardianAdd.Name = "guardianAdd";
            guardianAdd.Size = new Size(170, 31);
            guardianAdd.TabIndex = 12;
            // 
            // emailAdd
            // 
            emailAdd.Cursor = Cursors.Hand;
            emailAdd.Font = new Font("Segoe UI", 10.8F);
            emailAdd.Location = new Point(620, 180);
            emailAdd.Name = "emailAdd";
            emailAdd.Size = new Size(170, 31);
            emailAdd.TabIndex = 14;
            // 
            // weightAdd
            // 
            weightAdd.Cursor = Cursors.Hand;
            weightAdd.Font = new Font("Segoe UI", 10.8F);
            weightAdd.Location = new Point(617, 221);
            weightAdd.Name = "weightAdd";
            weightAdd.Size = new Size(170, 31);
            weightAdd.TabIndex = 24;
            // 
            // FnameAdd
            // 
            FnameAdd.Cursor = Cursors.Hand;
            FnameAdd.Font = new Font("Segoe UI", 10.8F);
            FnameAdd.Location = new Point(242, 142);
            FnameAdd.Name = "FnameAdd";
            FnameAdd.Size = new Size(170, 31);
            FnameAdd.TabIndex = 27;
            // 
            // HeightAdd
            // 
            HeightAdd.Cursor = Cursors.Hand;
            HeightAdd.Font = new Font("Segoe UI", 10.8F);
            HeightAdd.Location = new Point(429, 221);
            HeightAdd.Name = "HeightAdd";
            HeightAdd.Size = new Size(170, 31);
            HeightAdd.TabIndex = 25;
            // 
            // LnameAdd
            // 
            LnameAdd.Cursor = Cursors.Hand;
            LnameAdd.Font = new Font("Segoe UI", 10.8F);
            LnameAdd.Location = new Point(242, 182);
            LnameAdd.Name = "LnameAdd";
            LnameAdd.Size = new Size(170, 31);
            LnameAdd.TabIndex = 26;
            // 
            // Addage
            // 
            Addage.Cursor = Cursors.Hand;
            Addage.Font = new Font("Segoe UI", 10.8F);
            Addage.Location = new Point(243, 221);
            Addage.Name = "Addage";
            Addage.Size = new Size(170, 31);
            Addage.TabIndex = 28;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(34, 6);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(28, 29);
            Refresh.TabIndex = 29;
            Refresh.Text = "R";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // UserNo
            // 
            UserNo.BackColor = Color.White;
            UserNo.Controls.Add(groupBox3);
            UserNo.Controls.Add(panel6);
            UserNo.Controls.Add(label4);
            UserNo.Location = new Point(225, 3);
            UserNo.Name = "UserNo";
            UserNo.Size = new Size(1696, 929);
            UserNo.TabIndex = 20;
            UserNo.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlLightLight;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel3);
            panel6.Location = new Point(931, 204);
            panel6.Name = "panel6";
            panel6.Size = new Size(326, 573);
            panel6.TabIndex = 5;
            // 
            // panel8
            // 
            panel8.BackColor = Color.PaleGreen;
            panel8.Controls.Add(pictureBox3);
            panel8.Controls.Add(label3);
            panel8.Controls.Add(label12);
            panel8.Location = new Point(32, 288);
            panel8.Name = "panel8";
            panel8.Size = new Size(253, 236);
            panel8.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(25, 17);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(207, 168);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(113, 194);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(20, 195);
            label12.Name = "label12";
            label12.Size = new Size(93, 23);
            label12.TabIndex = 2;
            label12.Text = "Feedbacks";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(32, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(253, 236);
            panel3.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(174, 194);
            label7.Name = "label7";
            label7.Size = new Size(59, 23);
            label7.TabIndex = 3;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 194);
            label6.Name = "label6";
            label6.Size = new Size(148, 23);
            label6.TabIndex = 2;
            label6.Text = "Number of users:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.picon;
            pictureBox1.Location = new Point(32, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(512, 90);
            label4.Name = "label4";
            label4.Size = new Size(598, 52);
            label4.TabIndex = 0;
            label4.Text = "WELCOME TO ADMIN DATABASE";
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1924, 974);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(UserNo);
            Controls.Add(groupBox);
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPanel";
            Load += AdminPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridUser).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewfeedback).EndInit();
            groupBox.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            UserNo.ResumeLayout(false);
            UserNo.PerformLayout();
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridUser;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label AdminName;
        private Button AddBtn;
        private Label label2;
        private TextBox SearchBar;
        private Button SearchBtn;
        private ComboBox SearchBy;
        private Button homeBtn;
        private Button userBtn;
        private GroupBox groupBox;
        private Label Logoutlbl;
        private TextBox emailAdd;
        private TextBox Addage;
        private TextBox relationshipAdd;
        private TextBox FnameAdd;
        private TextBox conditionAdd;
        private TextBox HeightAdd;
        private TextBox guardianAdd;
        private TextBox LnameAdd;
        private TextBox weightAdd;
        private GroupBox UserNo;
        private Label label4;
        private TextBox contactAdd;
        private TextBox sexAdd;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label6;
        private Panel panel6;
        private Button Refresh;
        private Button button1;
        private GroupBox groupBox3;
        private Label Time;
        private Label Date;
        private DataGridView dataGridViewfeedback;
        private Panel panel7;
        private Panel panel9;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel8;
        private Label label3;
        private Label label12;
        private PictureBox pictureBox3;
        private Panel panel4;
    }
}