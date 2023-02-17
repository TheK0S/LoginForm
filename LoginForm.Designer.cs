namespace WinFormsApp1
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.linkConditions = new System.Windows.Forms.LinkLabel();
            this.AcceptConditions = new System.Windows.Forms.CheckBox();
            this.CreateAccount = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.FooterLabel = new System.Windows.Forms.Label();
            this.LoginLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(70, 124);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(59, 25);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // NameField
            // 
            this.NameField.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.NameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(228)))));
            this.NameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameField.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NameField.Location = new System.Drawing.Point(70, 156);
            this.NameField.Name = "NameField";
            this.NameField.PlaceholderText = "   Name";
            this.NameField.Size = new System.Drawing.Size(380, 28);
            this.NameField.TabIndex = 1;
            this.NameField.TextChanged += new System.EventHandler(this.NameField_TextChanged);
            // 
            // EmailField
            // 
            this.EmailField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(228)))));
            this.EmailField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailField.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmailField.Location = new System.Drawing.Point(70, 252);
            this.EmailField.Name = "EmailField";
            this.EmailField.PlaceholderText = "   Enter email";
            this.EmailField.Size = new System.Drawing.Size(380, 28);
            this.EmailField.TabIndex = 3;
            this.EmailField.TextChanged += new System.EventHandler(this.EmailField_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(70, 224);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(124, 25);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email Address";
            this.EmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswordField
            // 
            this.PasswordField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(228)))));
            this.PasswordField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordField.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordField.Location = new System.Drawing.Point(70, 344);
            this.PasswordField.Margin = new System.Windows.Forms.Padding(10);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PlaceholderText = "   Password";
            this.PasswordField.Size = new System.Drawing.Size(380, 28);
            this.PasswordField.TabIndex = 5;
            this.PasswordField.TextChanged += new System.EventHandler(this.PasswordField_TextChanged);
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassLabel.Location = new System.Drawing.Point(70, 309);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(88, 25);
            this.PassLabel.TabIndex = 4;
            this.PassLabel.Text = "Password";
            this.PassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkConditions
            // 
            this.linkConditions.AutoSize = true;
            this.linkConditions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkConditions.Location = new System.Drawing.Point(167, 416);
            this.linkConditions.Name = "linkConditions";
            this.linkConditions.Size = new System.Drawing.Size(160, 21);
            this.linkConditions.TabIndex = 6;
            this.linkConditions.TabStop = true;
            this.linkConditions.Text = "Terms and Conditions";
            this.linkConditions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkConditions_LinkClicked);
            // 
            // AcceptConditions
            // 
            this.AcceptConditions.AutoSize = true;
            this.AcceptConditions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AcceptConditions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AcceptConditions.Location = new System.Drawing.Point(70, 414);
            this.AcceptConditions.Name = "AcceptConditions";
            this.AcceptConditions.Size = new System.Drawing.Size(101, 25);
            this.AcceptConditions.TabIndex = 7;
            this.AcceptConditions.Text = "Accept our";
            this.AcceptConditions.UseVisualStyleBackColor = true;
            this.AcceptConditions.CheckedChanged += new System.EventHandler(this.AcceptConditions_CheckedChanged);
            // 
            // CreateAccount
            // 
            this.CreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateAccount.ForeColor = System.Drawing.SystemColors.Window;
            this.CreateAccount.Location = new System.Drawing.Point(70, 481);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(380, 35);
            this.CreateAccount.TabIndex = 8;
            this.CreateAccount.Text = "Create Free Account";
            this.CreateAccount.UseVisualStyleBackColor = false;
            this.CreateAccount.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.Location = new System.Drawing.Point(130, 33);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(264, 37);
            this.HeaderLabel.TabIndex = 9;
            this.HeaderLabel.Text = "Create your account";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HeaderLabel.UseMnemonic = false;
            // 
            // FooterLabel
            // 
            this.FooterLabel.AutoSize = true;
            this.FooterLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FooterLabel.Location = new System.Drawing.Point(110, 592);
            this.FooterLabel.Name = "FooterLabel";
            this.FooterLabel.Size = new System.Drawing.Size(186, 21);
            this.FooterLabel.TabIndex = 10;
            this.FooterLabel.Text = "Already have an account?";
            this.FooterLabel.Click += new System.EventHandler(this.FooterLabel_Click);
            // 
            // LoginLink
            // 
            this.LoginLink.AutoSize = true;
            this.LoginLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginLink.Location = new System.Drawing.Point(307, 592);
            this.LoginLink.Name = "LoginLink";
            this.LoginLink.Size = new System.Drawing.Size(88, 21);
            this.LoginLink.TabIndex = 11;
            this.LoginLink.TabStop = true;
            this.LoginLink.Text = "Log in here";
            this.LoginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLink_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(514, 649);
            this.Controls.Add(this.LoginLink);
            this.Controls.Add(this.FooterLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.CreateAccount);
            this.Controls.Add(this.AcceptConditions);
            this.Controls.Add(this.linkConditions);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.NameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameLabel;
        private TextBox NameField;
        private TextBox EmailField;
        private Label EmailLabel;
        private TextBox PasswordField;
        private Label PassLabel;
        private LinkLabel linkConditions;
        private CheckBox AcceptConditions;
        private Button CreateAccount;
        private Label HeaderLabel;
        private Label FooterLabel;
        private LinkLabel LoginLink;
    }
}