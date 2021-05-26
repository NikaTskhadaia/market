
namespace Market.Client
{
    partial class EmployeeEdit
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
            this.lblPhoto = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhoto.Location = new System.Drawing.Point(346, 31);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(58, 21);
            this.lblPhoto.TabIndex = 24;
            this.lblPhoto.Text = "Photo:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email.Location = new System.Drawing.Point(14, 143);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(52, 21);
            this.Email.TabIndex = 23;
            this.Email.Text = "Email:";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumber.Location = new System.Drawing.Point(12, 114);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(126, 21);
            this.PhoneNumber.TabIndex = 22;
            this.PhoneNumber.Text = "Phone Number:";
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Position.Location = new System.Drawing.Point(12, 85);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(73, 21);
            this.Position.TabIndex = 21;
            this.Position.Text = "Position:";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName.Location = new System.Drawing.Point(14, 56);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(92, 21);
            this.LastName.TabIndex = 20;
            this.LastName.Text = "Last Name:";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstName.Location = new System.Drawing.Point(12, 27);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(94, 21);
            this.FirstName.TabIndex = 19;
            this.FirstName.Text = "First Name:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(144, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(152, 23);
            this.txtEmail.TabIndex = 18;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(144, 116);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(152, 23);
            this.txtPhoneNumber.TabIndex = 17;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(144, 87);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(152, 23);
            this.txtPosition.TabIndex = 16;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(144, 58);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(152, 23);
            this.txtLastName.TabIndex = 15;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(144, 29);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(152, 23);
            this.txtFirstName.TabIndex = 14;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(462, 229);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 37);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(410, 174);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(114, 23);
            this.btnUpload.TabIndex = 46;
            this.btnUpload.Text = "Change Photo";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(410, 32);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(148, 136);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 45;
            this.pictureBox.TabStop = false;
            // 
            // EmployeeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 278);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "EmployeeEdit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.EmployeeEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}