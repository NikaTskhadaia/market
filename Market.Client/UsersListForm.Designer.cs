
namespace Market.Client
{
    partial class UsersListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.empDGV = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPasswordExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.empDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // empDGV
            // 
            this.empDGV.AllowUserToAddRows = false;
            this.empDGV.AllowUserToDeleteRows = false;
            this.empDGV.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.empDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmUserName,
            this.clmPasswordExpDate,
            this.clmIsActive});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.empDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.empDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empDGV.EnableHeadersVisualStyles = false;
            this.empDGV.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.empDGV.Location = new System.Drawing.Point(0, 0);
            this.empDGV.MultiSelect = false;
            this.empDGV.Name = "empDGV";
            this.empDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.empDGV.RowHeadersWidth = 62;
            this.empDGV.RowTemplate.Height = 25;
            this.empDGV.Size = new System.Drawing.Size(516, 188);
            this.empDGV.TabIndex = 1;
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "ID";
            this.clmID.HeaderText = "ID";
            this.clmID.MinimumWidth = 8;
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Visible = false;
            this.clmID.Width = 150;
            // 
            // clmUserName
            // 
            this.clmUserName.DataPropertyName = "UserName";
            this.clmUserName.HeaderText = "UserName";
            this.clmUserName.MinimumWidth = 8;
            this.clmUserName.Name = "clmUserName";
            this.clmUserName.ReadOnly = true;
            this.clmUserName.Width = 150;
            // 
            // clmPasswordExpDate
            // 
            this.clmPasswordExpDate.DataPropertyName = "PasswordExpDate";
            this.clmPasswordExpDate.HeaderText = "PasswordExpDate";
            this.clmPasswordExpDate.MinimumWidth = 8;
            this.clmPasswordExpDate.Name = "clmPasswordExpDate";
            this.clmPasswordExpDate.ReadOnly = true;
            this.clmPasswordExpDate.Width = 150;
            // 
            // clmIsActive
            // 
            this.clmIsActive.DataPropertyName = "IsActive";
            this.clmIsActive.HeaderText = "IsActive";
            this.clmIsActive.MinimumWidth = 8;
            this.clmIsActive.Name = "clmIsActive";
            this.clmIsActive.ReadOnly = true;
            this.clmIsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmIsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmIsActive.Width = 150;
            // 
            // UsersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 188);
            this.Controls.Add(this.empDGV);
            this.Name = "UsersListForm";
            this.Text = "UsersListForm";
            this.Load += new System.EventHandler(this.UsersListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView empDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPasswordExpDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmIsActive;
    }
}