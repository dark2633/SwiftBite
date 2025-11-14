namespace SwiftBite
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblCartNotificationText = new System.Windows.Forms.Label();
            this.picCartNotificationDot = new System.Windows.Forms.PictureBox();
            this.picCartIcon = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.picSearchIcon = new System.Windows.Forms.PictureBox();
            this.picSearchBar = new System.Windows.Forms.PictureBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.btnPassShowHide = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.picUsername = new System.Windows.Forms.PictureBox();
            this.lblLoginHeader = new System.Windows.Forms.Label();
            this.picTopDivider = new System.Windows.Forms.PictureBox();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCartNotificationDot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCartIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopDivider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTopBar.Controls.Add(this.lblCartNotificationText);
            this.pnlTopBar.Controls.Add(this.picCartNotificationDot);
            this.pnlTopBar.Controls.Add(this.picCartIcon);
            this.pnlTopBar.Controls.Add(this.txtSearch);
            this.pnlTopBar.Controls.Add(this.picSearchIcon);
            this.pnlTopBar.Controls.Add(this.picSearchBar);
            this.pnlTopBar.Controls.Add(this.btnSignUp);
            this.pnlTopBar.Controls.Add(this.lblLogIn);
            this.pnlTopBar.Controls.Add(this.picLogo);
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1366, 126);
            this.pnlTopBar.TabIndex = 5;
            // 
            // lblCartNotificationText
            // 
            this.lblCartNotificationText.AutoSize = true;
            this.lblCartNotificationText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.lblCartNotificationText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCartNotificationText.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartNotificationText.ForeColor = System.Drawing.Color.White;
            this.lblCartNotificationText.Location = new System.Drawing.Point(1035, 40);
            this.lblCartNotificationText.Name = "lblCartNotificationText";
            this.lblCartNotificationText.Size = new System.Drawing.Size(30, 36);
            this.lblCartNotificationText.TabIndex = 20;
            this.lblCartNotificationText.Text = "0";
            this.lblCartNotificationText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCartNotificationText.Click += new System.EventHandler(this.picCartIcon_Click);
            // 
            // picCartNotificationDot
            // 
            this.picCartNotificationDot.BackColor = System.Drawing.Color.Transparent;
            this.picCartNotificationDot.BackgroundImage = global::SwiftBite.Properties.Resources.Ellipse_1;
            this.picCartNotificationDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picCartNotificationDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCartNotificationDot.Location = new System.Drawing.Point(1033, 39);
            this.picCartNotificationDot.Name = "picCartNotificationDot";
            this.picCartNotificationDot.Size = new System.Drawing.Size(22, 22);
            this.picCartNotificationDot.TabIndex = 21;
            this.picCartNotificationDot.TabStop = false;
            this.picCartNotificationDot.Click += new System.EventHandler(this.picCartIcon_Click);
            // 
            // picCartIcon
            // 
            this.picCartIcon.BackColor = System.Drawing.Color.Transparent;
            this.picCartIcon.BackgroundImage = global::SwiftBite.Properties.Resources.Shopping_Cart;
            this.picCartIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCartIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCartIcon.Location = new System.Drawing.Point(1014, 45);
            this.picCartIcon.Name = "picCartIcon";
            this.picCartIcon.Size = new System.Drawing.Size(32, 32);
            this.picCartIcon.TabIndex = 20;
            this.picCartIcon.TabStop = false;
            this.picCartIcon.Click += new System.EventHandler(this.picCartIcon_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "McDonald\'s",
            "Subway"});
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(74)))));
            this.txtSearch.Location = new System.Drawing.Point(352, 46);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(536, 43);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.Text = "Search restaurants";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // picSearchIcon
            // 
            this.picSearchIcon.BackColor = System.Drawing.Color.White;
            this.picSearchIcon.BackgroundImage = global::SwiftBite.Properties.Resources.search;
            this.picSearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSearchIcon.Location = new System.Drawing.Point(307, 46);
            this.picSearchIcon.Name = "picSearchIcon";
            this.picSearchIcon.Size = new System.Drawing.Size(33, 30);
            this.picSearchIcon.TabIndex = 17;
            this.picSearchIcon.TabStop = false;
            // 
            // picSearchBar
            // 
            this.picSearchBar.BackColor = System.Drawing.Color.Transparent;
            this.picSearchBar.BackgroundImage = global::SwiftBite.Properties.Resources.Home_Search_Bar;
            this.picSearchBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSearchBar.Location = new System.Drawing.Point(297, 35);
            this.picSearchBar.Name = "picSearchBar";
            this.picSearchBar.Size = new System.Drawing.Size(611, 52);
            this.picSearchBar.TabIndex = 16;
            this.picSearchBar.TabStop = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BackgroundImage = global::SwiftBite.Properties.Resources.Sign_Up;
            this.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.btnSignUp.Location = new System.Drawing.Point(1187, 34);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(158, 58);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogIn.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(7)))));
            this.lblLogIn.Location = new System.Drawing.Point(1094, 45);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(160, 66);
            this.lblLogIn.TabIndex = 3;
            this.lblLogIn.Text = "Log In";
            this.lblLogIn.Click += new System.EventHandler(this.lblLogIn_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = global::SwiftBite.Properties.Resources.SB_Icon;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Location = new System.Drawing.Point(16, 17);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(146, 88);
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.BackgroundImage = global::SwiftBite.Properties.Resources.Login_Panel;
            this.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogin.Controls.Add(this.lblSignUp);
            this.pnlLogin.Controls.Add(this.lblNoAccount);
            this.pnlLogin.Controls.Add(this.btnPassShowHide);
            this.pnlLogin.Controls.Add(this.btnSubmit);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.picPassword);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.picUsername);
            this.pnlLogin.Controls.Add(this.lblLoginHeader);
            this.pnlLogin.Location = new System.Drawing.Point(482, 226);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(402, 444);
            this.pnlLogin.TabIndex = 7;
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignUp.Font = new System.Drawing.Font("Montserrat Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.lblSignUp.Location = new System.Drawing.Point(260, 405);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(131, 44);
            this.lblSignUp.TabIndex = 16;
            this.lblSignUp.Text = "Sign Up";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAccount.Location = new System.Drawing.Point(67, 405);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(346, 44);
            this.lblNoAccount.TabIndex = 15;
            this.lblNoAccount.Text = "Don\'t have an account?";
            // 
            // btnPassShowHide
            // 
            this.btnPassShowHide.BackgroundImage = global::SwiftBite.Properties.Resources.Password_Show_Hide;
            this.btnPassShowHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPassShowHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPassShowHide.FlatAppearance.BorderSize = 0;
            this.btnPassShowHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPassShowHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPassShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassShowHide.Location = new System.Drawing.Point(329, 240);
            this.btnPassShowHide.Name = "btnPassShowHide";
            this.btnPassShowHide.Size = new System.Drawing.Size(40, 40);
            this.btnPassShowHide.TabIndex = 14;
            this.btnPassShowHide.UseVisualStyleBackColor = true;
            this.btnPassShowHide.Click += new System.EventHandler(this.btnPassShowHide_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackgroundImage = global::SwiftBite.Properties.Resources.Submit_Button;
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.btnSubmit.Location = new System.Drawing.Point(96, 316);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(210, 73);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(7)))));
            this.txtPassword.Location = new System.Drawing.Point(39, 239);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(287, 58);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Montserrat Light", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(22, 198);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(221, 64);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // picPassword
            // 
            this.picPassword.BackgroundImage = global::SwiftBite.Properties.Resources.Input_Field;
            this.picPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPassword.Location = new System.Drawing.Point(28, 237);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(346, 46);
            this.picPassword.TabIndex = 10;
            this.picPassword.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(7)))));
            this.txtUsername.Location = new System.Drawing.Point(39, 127);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(324, 58);
            this.txtUsername.TabIndex = 9;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Montserrat Light", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(22, 86);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(240, 64);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Username";
            // 
            // picUsername
            // 
            this.picUsername.BackgroundImage = global::SwiftBite.Properties.Resources.Input_Field;
            this.picUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUsername.Location = new System.Drawing.Point(28, 125);
            this.picUsername.Name = "picUsername";
            this.picUsername.Size = new System.Drawing.Size(346, 46);
            this.picUsername.TabIndex = 1;
            this.picUsername.TabStop = false;
            // 
            // lblLoginHeader
            // 
            this.lblLoginHeader.AutoSize = true;
            this.lblLoginHeader.Font = new System.Drawing.Font("Montserrat SemiBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.lblLoginHeader.Location = new System.Drawing.Point(123, 3);
            this.lblLoginHeader.Name = "lblLoginHeader";
            this.lblLoginHeader.Size = new System.Drawing.Size(271, 110);
            this.lblLoginHeader.TabIndex = 0;
            this.lblLoginHeader.Text = "Log In";
            // 
            // picTopDivider
            // 
            this.picTopDivider.BackColor = System.Drawing.Color.Transparent;
            this.picTopDivider.BackgroundImage = global::SwiftBite.Properties.Resources.Top_Divider;
            this.picTopDivider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picTopDivider.Location = new System.Drawing.Point(0, 126);
            this.picTopDivider.Margin = new System.Windows.Forms.Padding(2);
            this.picTopDivider.Name = "picTopDivider";
            this.picTopDivider.Size = new System.Drawing.Size(1366, 5);
            this.picTopDivider.TabIndex = 6;
            this.picTopDivider.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.picTopDivider);
            this.Controls.Add(this.pnlTopBar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(7)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SwiftBite - Login";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCartNotificationDot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCartIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopDivider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTopDivider;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblCartNotificationText;
        private System.Windows.Forms.PictureBox picCartNotificationDot;
        private System.Windows.Forms.PictureBox picCartIcon;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox picSearchIcon;
        private System.Windows.Forms.PictureBox picSearchBar;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblLoginHeader;
        private System.Windows.Forms.PictureBox picUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnPassShowHide;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.Label lblSignUp;
    }
}