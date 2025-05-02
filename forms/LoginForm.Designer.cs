namespace Loginadmin.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            UserBox = new TextBox();
            PassBox = new TextBox();
            LoginBtn = new Button();
            label1 = new Label();
            ShowPassword = new CheckBox();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // UserBox
            // 
            UserBox.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            UserBox.Location = new Point(215, 161);
            UserBox.Margin = new Padding(4);
            UserBox.Multiline = true;
            UserBox.Name = "UserBox";
            UserBox.Size = new Size(398, 44);
            UserBox.TabIndex = 0;
            // 
            // PassBox
            // 
            PassBox.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            PassBox.Location = new Point(215, 225);
            PassBox.Margin = new Padding(4);
            PassBox.Multiline = true;
            PassBox.Name = "PassBox";
            PassBox.PasswordChar = '*';
            PassBox.Size = new Size(398, 41);
            PassBox.TabIndex = 1;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.RoyalBlue;
            LoginBtn.FlatStyle = FlatStyle.Popup;
            LoginBtn.Font = new Font("Segoe UI", 12F);
            LoginBtn.Location = new Point(215, 319);
            LoginBtn.Margin = new Padding(4);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(117, 48);
            LoginBtn.TabIndex = 3;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(53, 167);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 38);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            // 
            // ShowPassword
            // 
            ShowPassword.AutoSize = true;
            ShowPassword.BackColor = Color.Transparent;
            ShowPassword.Font = new Font("Segoe UI", 12F);
            ShowPassword.Location = new Point(215, 276);
            ShowPassword.Margin = new Padding(4);
            ShowPassword.Name = "ShowPassword";
            ShowPassword.Size = new Size(168, 32);
            ShowPassword.TabIndex = 8;
            ShowPassword.Text = "Show Password";
            ShowPassword.UseVisualStyleBackColor = false;
            ShowPassword.CheckedChanged += ShowPassword_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(64, 227);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 38);
            label2.TabIndex = 9;
            label2.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(270, 52);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(226, 46);
            label4.TabIndex = 11;
            label4.Text = "Admin Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(807, 518);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(ShowPassword);
            Controls.Add(label1);
            Controls.Add(LoginBtn);
            Controls.Add(PassBox);
            Controls.Add(UserBox);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            IsMdiContainer = true;
            Margin = new Padding(4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserBox;
        private TextBox PassBox;
        private Button LoginBtn;
        private Label label1;
        private CheckBox ShowPassword;
        private Label label2;
        private Label label4;
    }
}