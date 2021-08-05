namespace AdminPanel
{
    partial class Editor_Page
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnAddNewCustomer = new System.Windows.Forms.Button();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblSurname = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdateAndSeen = new System.Windows.Forms.Button();
            this.groupBoxUpdate = new System.Windows.Forms.GroupBox();
            this.TxtUpdateID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtUpdateEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUpdatePhone = new System.Windows.Forms.TextBox();
            this.TxtUpdateName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnMin = new System.Windows.Forms.Button();
            this.TxtMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnAddNewCustomer
            // 
            this.BtnAddNewCustomer.Location = new System.Drawing.Point(12, 219);
            this.BtnAddNewCustomer.Name = "BtnAddNewCustomer";
            this.BtnAddNewCustomer.Size = new System.Drawing.Size(119, 23);
            this.BtnAddNewCustomer.TabIndex = 5;
            this.BtnAddNewCustomer.Text = "Add New Customer";
            this.BtnAddNewCustomer.UseVisualStyleBackColor = true;
            this.BtnAddNewCustomer.Click += new System.EventHandler(this.BtnAddNewCustomer_Click);
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.btnAdd);
            this.groupBoxAdd.Controls.Add(this.TxtEmail);
            this.groupBoxAdd.Controls.Add(this.LblEmail);
            this.groupBoxAdd.Controls.Add(this.TxtPhone);
            this.groupBoxAdd.Controls.Add(this.TxtName);
            this.groupBoxAdd.Controls.Add(this.LblSurname);
            this.groupBoxAdd.Controls.Add(this.LblName);
            this.groupBoxAdd.Location = new System.Drawing.Point(295, 185);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(200, 180);
            this.groupBoxAdd.TabIndex = 2;
            this.groupBoxAdd.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(111, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(86, 64);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 20);
            this.TxtEmail.TabIndex = 16;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(38, 64);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(35, 13);
            this.LblEmail.TabIndex = 16;
            this.LblEmail.Text = "Email:";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(86, 103);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(100, 20);
            this.TxtPhone.TabIndex = 17;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(86, 25);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 15;
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Location = new System.Drawing.Point(32, 110);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(41, 13);
            this.LblSurname.TabIndex = 13;
            this.LblSurname.Text = "Phone:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(35, 28);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(38, 13);
            this.LblName.TabIndex = 12;
            this.LblName.Text = "Name:";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(12, 190);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(119, 23);
            this.BtnRefresh.TabIndex = 4;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(12, 277);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(119, 23);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdateAndSeen
            // 
            this.BtnUpdateAndSeen.Location = new System.Drawing.Point(12, 248);
            this.BtnUpdateAndSeen.Name = "BtnUpdateAndSeen";
            this.BtnUpdateAndSeen.Size = new System.Drawing.Size(119, 23);
            this.BtnUpdateAndSeen.TabIndex = 6;
            this.BtnUpdateAndSeen.Text = "Update";
            this.BtnUpdateAndSeen.UseVisualStyleBackColor = true;
            this.BtnUpdateAndSeen.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxUpdate
            // 
            this.groupBoxUpdate.Controls.Add(this.TxtUpdateID);
            this.groupBoxUpdate.Controls.Add(this.label5);
            this.groupBoxUpdate.Controls.Add(this.BtnUpdate);
            this.groupBoxUpdate.Controls.Add(this.TxtUpdateEmail);
            this.groupBoxUpdate.Controls.Add(this.label2);
            this.groupBoxUpdate.Controls.Add(this.TxtUpdatePhone);
            this.groupBoxUpdate.Controls.Add(this.TxtUpdateName);
            this.groupBoxUpdate.Controls.Add(this.label3);
            this.groupBoxUpdate.Controls.Add(this.label4);
            this.groupBoxUpdate.Location = new System.Drawing.Point(295, 185);
            this.groupBoxUpdate.Name = "groupBoxUpdate";
            this.groupBoxUpdate.Size = new System.Drawing.Size(200, 193);
            this.groupBoxUpdate.TabIndex = 7;
            this.groupBoxUpdate.TabStop = false;
            // 
            // TxtUpdateID
            // 
            this.TxtUpdateID.Location = new System.Drawing.Point(79, 17);
            this.TxtUpdateID.Name = "TxtUpdateID";
            this.TxtUpdateID.Size = new System.Drawing.Size(39, 20);
            this.TxtUpdateID.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "ID:";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(104, 164);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 25;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtUpdateEmail
            // 
            this.TxtUpdateEmail.Location = new System.Drawing.Point(79, 85);
            this.TxtUpdateEmail.Name = "TxtUpdateEmail";
            this.TxtUpdateEmail.Size = new System.Drawing.Size(100, 20);
            this.TxtUpdateEmail.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Email:";
            // 
            // TxtUpdatePhone
            // 
            this.TxtUpdatePhone.Location = new System.Drawing.Point(79, 124);
            this.TxtUpdatePhone.Name = "TxtUpdatePhone";
            this.TxtUpdatePhone.Size = new System.Drawing.Size(100, 20);
            this.TxtUpdatePhone.TabIndex = 24;
            // 
            // TxtUpdateName
            // 
            this.TxtUpdateName.Location = new System.Drawing.Point(79, 49);
            this.TxtUpdateName.Name = "TxtUpdateName";
            this.TxtUpdateName.Size = new System.Drawing.Size(100, 20);
            this.TxtUpdateName.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name:";
            // 
            // BtnMin
            // 
            this.BtnMin.Location = new System.Drawing.Point(12, 309);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(119, 23);
            this.BtnMin.TabIndex = 8;
            this.BtnMin.Text = "Minimize";
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // TxtMessage
            // 
            this.TxtMessage.AutoSize = true;
            this.TxtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMessage.Location = new System.Drawing.Point(193, 171);
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.Size = new System.Drawing.Size(0, 42);
            this.TxtMessage.TabIndex = 9;
            // 
            // Editor_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtMessage);
            this.Controls.Add(this.BtnMin);
            this.Controls.Add(this.groupBoxUpdate);
            this.Controls.Add(this.BtnUpdateAndSeen);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.BtnAddNewCustomer);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Editor_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editor Page";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.groupBoxUpdate.ResumeLayout(false);
            this.groupBoxUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button BtnAddNewCustomer;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.Label LblName;
        public System.Windows.Forms.Button BtnDelete;
        public System.Windows.Forms.Button BtnUpdateAndSeen;
        private System.Windows.Forms.GroupBox groupBoxUpdate;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox TxtUpdateEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUpdatePhone;
        private System.Windows.Forms.TextBox TxtUpdateName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtUpdateID;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label TxtMessage;
        public System.Windows.Forms.Button BtnRefresh;
        public System.Windows.Forms.Button BtnMin;
    }
}