namespace comp2129Assignment3
{
    partial class FormAddCustomer
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
            this.lblTextOne = new System.Windows.Forms.Label();
            this.lblTextTwo = new System.Windows.Forms.Label();
            this.lblTextThree = new System.Windows.Forms.Label();
            this.lblTextFour = new System.Windows.Forms.Label();
            this.lablTextFive = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblFirstNameError = new System.Windows.Forms.Label();
            this.lblLastNameError = new System.Windows.Forms.Label();
            this.lblPhoneNUmberError = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblEmptyFieldError = new System.Windows.Forms.Label();
            this.lblAddingError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTextOne
            // 
            this.lblTextOne.AutoSize = true;
            this.lblTextOne.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextOne.Location = new System.Drawing.Point(297, 9);
            this.lblTextOne.Name = "lblTextOne";
            this.lblTextOne.Size = new System.Drawing.Size(205, 29);
            this.lblTextOne.TabIndex = 8;
            this.lblTextOne.Text = "Add a Customer";
            // 
            // lblTextTwo
            // 
            this.lblTextTwo.AutoSize = true;
            this.lblTextTwo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextTwo.Location = new System.Drawing.Point(62, 38);
            this.lblTextTwo.Name = "lblTextTwo";
            this.lblTextTwo.Size = new System.Drawing.Size(664, 23);
            this.lblTextTwo.TabIndex = 13;
            this.lblTextTwo.Text = "Enter the corresponsing information into all of the text boxes below";
            this.lblTextTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextThree
            // 
            this.lblTextThree.AutoSize = true;
            this.lblTextThree.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextThree.Location = new System.Drawing.Point(325, 124);
            this.lblTextThree.Name = "lblTextThree";
            this.lblTextThree.Size = new System.Drawing.Size(122, 23);
            this.lblTextThree.TabIndex = 14;
            this.lblTextThree.Text = "First Name:";
            this.lblTextThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextFour
            // 
            this.lblTextFour.AutoSize = true;
            this.lblTextFour.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextFour.Location = new System.Drawing.Point(325, 244);
            this.lblTextFour.Name = "lblTextFour";
            this.lblTextFour.Size = new System.Drawing.Size(119, 23);
            this.lblTextFour.TabIndex = 15;
            this.lblTextFour.Text = "Last Name:";
            this.lblTextFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lablTextFive
            // 
            this.lablTextFive.AutoSize = true;
            this.lablTextFive.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablTextFive.Location = new System.Drawing.Point(307, 358);
            this.lablTextFive.Name = "lablTextFive";
            this.lablTextFive.Size = new System.Drawing.Size(159, 23);
            this.lablTextFive.TabIndex = 16;
            this.lablTextFive.Text = "Phone Number:";
            this.lablTextFive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(279, 150);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(210, 31);
            this.txtFirstName.TabIndex = 17;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(279, 270);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(210, 31);
            this.txtLastName.TabIndex = 18;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(279, 384);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(210, 31);
            this.txtPhoneNumber.TabIndex = 19;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhoneNumber.Leave += new System.EventHandler(this.txtPhoneNumber_Leave);
            // 
            // lblFirstNameError
            // 
            this.lblFirstNameError.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameError.ForeColor = System.Drawing.Color.Red;
            this.lblFirstNameError.Location = new System.Drawing.Point(217, 184);
            this.lblFirstNameError.Name = "lblFirstNameError";
            this.lblFirstNameError.Size = new System.Drawing.Size(340, 41);
            this.lblFirstNameError.TabIndex = 20;
            this.lblFirstNameError.Text = "The customer\'s first name can not contain numbers or special characters";
            this.lblFirstNameError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFirstNameError.Visible = false;
            // 
            // lblLastNameError
            // 
            this.lblLastNameError.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameError.ForeColor = System.Drawing.Color.Red;
            this.lblLastNameError.Location = new System.Drawing.Point(217, 304);
            this.lblLastNameError.Name = "lblLastNameError";
            this.lblLastNameError.Size = new System.Drawing.Size(340, 41);
            this.lblLastNameError.TabIndex = 21;
            this.lblLastNameError.Text = "The customer\'s last name can not contain numbers or special characters";
            this.lblLastNameError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLastNameError.Visible = false;
            // 
            // lblPhoneNUmberError
            // 
            this.lblPhoneNUmberError.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNUmberError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneNUmberError.Location = new System.Drawing.Point(217, 418);
            this.lblPhoneNUmberError.Name = "lblPhoneNUmberError";
            this.lblPhoneNUmberError.Size = new System.Drawing.Size(340, 41);
            this.lblPhoneNUmberError.TabIndex = 22;
            this.lblPhoneNUmberError.Text = "The customer\'s phone number can only contain numbers and \'-\'";
            this.lblPhoneNUmberError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPhoneNUmberError.Visible = false;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(306, 486);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(155, 33);
            this.btnAddCustomer.TabIndex = 23;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            this.btnAddCustomer.MouseLeave += new System.EventHandler(this.btnAddCustomer_MouseLeave);
            this.btnAddCustomer.MouseHover += new System.EventHandler(this.btnAddCustomer_MouseHover);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(689, 446);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 33);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(605, 486);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(167, 33);
            this.btnMenu.TabIndex = 25;
            this.btnMenu.Text = "Return to Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblEmptyFieldError
            // 
            this.lblEmptyFieldError.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyFieldError.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyFieldError.Location = new System.Drawing.Point(253, 522);
            this.lblEmptyFieldError.Name = "lblEmptyFieldError";
            this.lblEmptyFieldError.Size = new System.Drawing.Size(260, 19);
            this.lblEmptyFieldError.TabIndex = 26;
            this.lblEmptyFieldError.Text = "Not all fields have been filled";
            this.lblEmptyFieldError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmptyFieldError.Visible = false;
            // 
            // lblAddingError
            // 
            this.lblAddingError.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddingError.ForeColor = System.Drawing.Color.Red;
            this.lblAddingError.Location = new System.Drawing.Point(74, 61);
            this.lblAddingError.Name = "lblAddingError";
            this.lblAddingError.Size = new System.Drawing.Size(628, 47);
            this.lblAddingError.TabIndex = 27;
            this.lblAddingError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblAddingError);
            this.Controls.Add(this.lblEmptyFieldError);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblPhoneNUmberError);
            this.Controls.Add(this.lblLastNameError);
            this.Controls.Add(this.lblFirstNameError);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lablTextFive);
            this.Controls.Add(this.lblTextFour);
            this.Controls.Add(this.lblTextThree);
            this.Controls.Add(this.lblTextTwo);
            this.Controls.Add(this.lblTextOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "George Brown Airlines Services";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextOne;
        private System.Windows.Forms.Label lblTextTwo;
        private System.Windows.Forms.Label lblTextThree;
        private System.Windows.Forms.Label lblTextFour;
        private System.Windows.Forms.Label lablTextFive;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblFirstNameError;
        private System.Windows.Forms.Label lblLastNameError;
        private System.Windows.Forms.Label lblPhoneNUmberError;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblEmptyFieldError;
        private System.Windows.Forms.Label lblAddingError;
    }
}