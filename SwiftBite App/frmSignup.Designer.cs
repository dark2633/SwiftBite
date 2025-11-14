namespace SwiftBite
{
    partial class frmSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignup));
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
            this.pnlSignup = new System.Windows.Forms.Panel();
            this.lblLoginLink = new System.Windows.Forms.Label();
            this.lblAlreadyAccount = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnPassShowHide = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.picUsername = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.picEmail = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.picName = new System.Windows.Forms.PictureBox();
            this.lblSignupHeader = new System.Windows.Forms.Label();
            this.picTopDivider = new System.Windows.Forms.PictureBox();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCartNotificationDot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCartIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlSignup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picName)).BeginInit();
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
            this.pnlTopBar.TabIndex = 7;
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
            this.lblCartNotificationText.Size = new System.Drawing.Size(18, 20);
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
            this.txtSearch.Size = new System.Drawing.Size(536, 25);
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
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogIn.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(7)))));
            this.lblLogIn.Location = new System.Drawing.Point(1094, 45);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(91, 38);
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
            // pnlSignup
            // 
            this.pnlSignup.BackColor = System.Drawing.Color.Transparent;
            this.pnlSignup.BackgroundImage = global::SwiftBite.Properties.Resources.Signup_Panel;
            this.pnlSignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSignup.Controls.Add(this.lblLoginLink);
            this.pnlSignup.Controls.Add(this.lblAlreadyAccount);
            this.pnlSignup.Controls.Add(this.btnSubmit);
            this.pnlSignup.Controls.Add(this.btnPassShowHide);
            this.pnlSignup.Controls.Add(this.txtPassword);
            this.pnlSignup.Controls.Add(this.lblPassword);
            this.pnlSignup.Controls.Add(this.picPassword);
            this.pnlSignup.Controls.Add(this.txtUsername);
            this.pnlSignup.Controls.Add(this.lblUsername);
            this.pnlSignup.Controls.Add(this.picUsername);
            this.pnlSignup.Controls.Add(this.txtEmail);
            this.pnlSignup.Controls.Add(this.lblEmail);
            this.pnlSignup.Controls.Add(this.picEmail);
            this.pnlSignup.Controls.Add(this.txtName);
            this.pnlSignup.Controls.Add(this.lblName);
            this.pnlSignup.Controls.Add(this.picName);
            this.pnlSignup.Controls.Add(this.lblSignupHeader);
            this.pnlSignup.Location = new System.Drawing.Point(482, 159);
            this.pnlSignup.Name = "pnlSignup";
            this.pnlSignup.Size = new System.Drawing.Size(402, 586);
            this.pnlSignup.TabIndex = 9;
            // 
            // lblLoginLink
            // 
            this.lblLoginLink.AutoSize = true;
            this.lblLoginLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoginLink.Font = new System.Drawing.Font("Montserrat Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.lblLoginLink.Location = new System.Drawing.Point(274, 546);
            this.lblLoginLink.Name = "lblLoginLink";
            this.lblLoginLink.Size = new System.Drawing.Size(63, 25);
            this.lblLoginLink.TabIndex = 24;
            this.lblLoginLink.Text = "Log In";
            this.lblLoginLink.Click += new System.EventHandler(this.lblLogIn_Click);
            // 
            // lblAlreadyAccount
            // 
            this.lblAlreadyAccount.AutoSize = true;
            this.lblAlreadyAccount.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlreadyAccount.Location = new System.Drawing.Point(65, 546);
            this.lblAlreadyAccount.Name = "lblAlreadyAccount";
            this.lblAlreadyAccount.Size = new System.Drawing.Size(215, 25);
            this.lblAlreadyAccount.TabIndex = 23;
            this.lblAlreadyAccount.Text = "Already have an account?";
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
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.btnSubmit.Location = new System.Drawing.Point(96, 451);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(210, 73);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            this.btnPassShowHide.Location = new System.Drawing.Point(329, 394);
            this.btnPassShowHide.Name = "btnPassShowHide";
            this.btnPassShowHide.Size = new System.Drawing.Size(40, 40);
            this.btnPassShowHide.TabIndex = 22;
            this.btnPassShowHide.UseVisualStyleBackColor = true;
            this.btnPassShowHide.Click += new System.EventHandler(this.btnPassShowHide_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(7)))));
            this.txtPassword.Location = new System.Drawing.Point(39, 393);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(287, 33);
            this.txtPassword.TabIndex = 21;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Montserrat Light", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(22, 353);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(125, 36);
            this.lblPassword.TabIndex = 20;
            this.lblPassword.Text = "Password";
            // 
            // picPassword
            // 
            this.picPassword.BackgroundImage = global::SwiftBite.Properties.Resources.Input_Field;
            this.picPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPassword.Location = new System.Drawing.Point(28, 391);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(346, 46);
            this.picPassword.TabIndex = 19;
            this.picPassword.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(7)))));
            this.txtUsername.Location = new System.Drawing.Point(39, 302);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(324, 33);
            this.txtUsername.TabIndex = 18;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Montserrat Light", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(22, 262);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(133, 36);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Text = "Username";
            // 
            // picUsername
            // 
            this.picUsername.BackgroundImage = global::SwiftBite.Properties.Resources.Input_Field;
            this.picUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUsername.Location = new System.Drawing.Point(28, 300);
            this.picUsername.Name = "picUsername";
            this.picUsername.Size = new System.Drawing.Size(346, 46);
            this.picUsername.TabIndex = 16;
            this.picUsername.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(7)))));
            this.txtEmail.Location = new System.Drawing.Point(39, 211);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(324, 33);
            this.txtEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Montserrat Light", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(22, 171);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(79, 36);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // picEmail
            // 
            this.picEmail.BackgroundImage = global::SwiftBite.Properties.Resources.Input_Field;
            this.picEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEmail.Location = new System.Drawing.Point(28, 209);
            this.picEmail.Name = "picEmail";
            this.picEmail.Size = new System.Drawing.Size(346, 46);
            this.picEmail.TabIndex = 13;
            this.picEmail.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(7)))));
            this.txtName.Location = new System.Drawing.Point(39, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(324, 33);
            this.txtName.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Montserrat Light", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(22, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 36);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // picName
            // 
            this.picName.BackgroundImage = global::SwiftBite.Properties.Resources.Input_Field;
            this.picName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picName.Location = new System.Drawing.Point(28, 118);
            this.picName.Name = "picName";
            this.picName.Size = new System.Drawing.Size(346, 46);
            this.picName.TabIndex = 10;
            this.picName.TabStop = false;
            // 
            // lblSignupHeader
            // 
            this.lblSignupHeader.AutoSize = true;
            this.lblSignupHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblSignupHeader.Font = new System.Drawing.Font("Montserrat SemiBold", 30F, System.Drawing.FontStyle.Bold);
            this.lblSignupHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.lblSignupHeader.Location = new System.Drawing.Point(107, 3);
            this.lblSignupHeader.Name = "lblSignupHeader";
            this.lblSignupHeader.Size = new System.Drawing.Size(189, 62);
            this.lblSignupHeader.TabIndex = 0;
            this.lblSignupHeader.Text = "Sign Up";
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
            this.picTopDivider.TabIndex = 8;
            this.picTopDivider.TabStop = false;
            // 
            // frmSignup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pnlSignup);
            this.Controls.Add(this.picTopDivider);
            this.Controls.Add(this.pnlTopBar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(7)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SwiftBite - Signup";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCartNotificationDot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCartIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlSignup.ResumeLayout(false);
            this.pnlSignup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picName)).EndInit();
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
        private System.Windows.Forms.Panel pnlSignup;
        private System.Windows.Forms.Label lblSignupHeader;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox picEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox picUsername;
        private System.Windows.Forms.Button btnPassShowHide;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblLoginLink;
        private System.Windows.Forms.Label lblAlreadyAccount;
    }
}