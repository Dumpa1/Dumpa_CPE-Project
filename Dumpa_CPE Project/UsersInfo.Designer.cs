namespace Dumpa_CPE_Project
{
    partial class UsersInfo
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCalorieTarget = new System.Windows.Forms.TextBox();
            this.txtCurrentDiet = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblCalorieTarget = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCurrentDiet = new System.Windows.Forms.Label();
            this.txtBodyFat = new System.Windows.Forms.TextBox();
            this.lblBodyFat = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtActivityLevel = new System.Windows.Forms.TextBox();
            this.lblActivityLevel = new System.Windows.Forms.Label();
            this.txtGoalWeight = new System.Windows.Forms.TextBox();
            this.lblGoalWeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(29, 570);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(114, 43);
            this.btnInsert.TabIndex = 63;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(502, 570);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(114, 43);
            this.btnLoad.TabIndex = 62;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(614, 225);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 37);
            this.btnSearch.TabIndex = 61;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(559, 192);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 27);
            this.txtSearch.TabIndex = 60;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(479, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "Search:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(344, 570);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 43);
            this.btnUpdate.TabIndex = 58;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(187, 570);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 43);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(833, 277);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtCalorieTarget
            // 
            this.txtCalorieTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalorieTarget.Location = new System.Drawing.Point(163, 111);
            this.txtCalorieTarget.Name = "txtCalorieTarget";
            this.txtCalorieTarget.Size = new System.Drawing.Size(154, 27);
            this.txtCalorieTarget.TabIndex = 55;
            this.txtCalorieTarget.TextChanged += new System.EventHandler(this.txtCalorieTarget_TextChanged);
            // 
            // txtCurrentDiet
            // 
            this.txtCurrentDiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentDiet.Location = new System.Drawing.Point(163, 78);
            this.txtCurrentDiet.Name = "txtCurrentDiet";
            this.txtCurrentDiet.Size = new System.Drawing.Size(154, 27);
            this.txtCurrentDiet.TabIndex = 54;
            this.txtCurrentDiet.TextChanged += new System.EventHandler(this.txtCurrentDiet_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(163, 45);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(154, 27);
            this.txtUsername.TabIndex = 53;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(163, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(154, 27);
            this.txtID.TabIndex = 52;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblCalorieTarget
            // 
            this.lblCalorieTarget.AutoSize = true;
            this.lblCalorieTarget.BackColor = System.Drawing.Color.Transparent;
            this.lblCalorieTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalorieTarget.ForeColor = System.Drawing.Color.Transparent;
            this.lblCalorieTarget.Location = new System.Drawing.Point(6, 114);
            this.lblCalorieTarget.Name = "lblCalorieTarget";
            this.lblCalorieTarget.Size = new System.Drawing.Size(135, 20);
            this.lblCalorieTarget.TabIndex = 51;
            this.lblCalorieTarget.Text = "Calorie Target:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Transparent;
            this.lblUsername.Location = new System.Drawing.Point(41, 48);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 20);
            this.lblUsername.TabIndex = 49;
            this.lblUsername.Text = "Username:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Transparent;
            this.lblID.Location = new System.Drawing.Point(107, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(34, 20);
            this.lblID.TabIndex = 48;
            this.lblID.Text = "ID:";
            // 
            // lblCurrentDiet
            // 
            this.lblCurrentDiet.AutoSize = true;
            this.lblCurrentDiet.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentDiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDiet.ForeColor = System.Drawing.Color.Transparent;
            this.lblCurrentDiet.Location = new System.Drawing.Point(22, 81);
            this.lblCurrentDiet.Name = "lblCurrentDiet";
            this.lblCurrentDiet.Size = new System.Drawing.Size(119, 20);
            this.lblCurrentDiet.TabIndex = 64;
            this.lblCurrentDiet.Text = "Current Diet:\r\n";
            // 
            // txtBodyFat
            // 
            this.txtBodyFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodyFat.Location = new System.Drawing.Point(163, 144);
            this.txtBodyFat.Name = "txtBodyFat";
            this.txtBodyFat.Size = new System.Drawing.Size(154, 27);
            this.txtBodyFat.TabIndex = 66;
            this.txtBodyFat.TextChanged += new System.EventHandler(this.txtBodyFat_TextChanged);
            // 
            // lblBodyFat
            // 
            this.lblBodyFat.AutoSize = true;
            this.lblBodyFat.BackColor = System.Drawing.Color.Transparent;
            this.lblBodyFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodyFat.ForeColor = System.Drawing.Color.Transparent;
            this.lblBodyFat.Location = new System.Drawing.Point(51, 147);
            this.lblBodyFat.Name = "lblBodyFat";
            this.lblBodyFat.Size = new System.Drawing.Size(90, 20);
            this.lblBodyFat.TabIndex = 65;
            this.lblBodyFat.Text = "Body Fat:";
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(163, 177);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(154, 27);
            this.txtGender.TabIndex = 68;
            this.txtGender.TextChanged += new System.EventHandler(this.txtGender_TextChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Transparent;
            this.lblGender.Location = new System.Drawing.Point(65, 180);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(76, 20);
            this.lblGender.TabIndex = 67;
            this.lblGender.Text = "Gender:";
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(515, 12);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(154, 27);
            this.txtHeight.TabIndex = 70;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.Transparent;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.ForeColor = System.Drawing.Color.Transparent;
            this.lblHeight.Location = new System.Drawing.Point(426, 15);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(70, 20);
            this.lblHeight.TabIndex = 69;
            this.lblHeight.Text = "Height:";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(515, 45);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(154, 27);
            this.txtWeight.TabIndex = 72;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.Color.Transparent;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.Transparent;
            this.lblWeight.Location = new System.Drawing.Point(423, 48);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(73, 20);
            this.lblWeight.TabIndex = 71;
            this.lblWeight.Text = "Weight:";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(515, 78);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(154, 27);
            this.txtAge.TabIndex = 74;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(449, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "Age:";
            // 
            // txtActivityLevel
            // 
            this.txtActivityLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivityLevel.Location = new System.Drawing.Point(515, 111);
            this.txtActivityLevel.Name = "txtActivityLevel";
            this.txtActivityLevel.Size = new System.Drawing.Size(154, 27);
            this.txtActivityLevel.TabIndex = 76;
            this.txtActivityLevel.TextChanged += new System.EventHandler(this.txtActivityLevel_TextChanged);
            // 
            // lblActivityLevel
            // 
            this.lblActivityLevel.AutoSize = true;
            this.lblActivityLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblActivityLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityLevel.ForeColor = System.Drawing.Color.Transparent;
            this.lblActivityLevel.Location = new System.Drawing.Point(368, 114);
            this.lblActivityLevel.Name = "lblActivityLevel";
            this.lblActivityLevel.Size = new System.Drawing.Size(128, 20);
            this.lblActivityLevel.TabIndex = 75;
            this.lblActivityLevel.Text = "Activity Level:\r\n";
            // 
            // txtGoalWeight
            // 
            this.txtGoalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoalWeight.Location = new System.Drawing.Point(515, 144);
            this.txtGoalWeight.Name = "txtGoalWeight";
            this.txtGoalWeight.Size = new System.Drawing.Size(154, 27);
            this.txtGoalWeight.TabIndex = 78;
            this.txtGoalWeight.TextChanged += new System.EventHandler(this.txtGoalWeight_TextChanged);
            // 
            // lblGoalWeight
            // 
            this.lblGoalWeight.AutoSize = true;
            this.lblGoalWeight.BackColor = System.Drawing.Color.Transparent;
            this.lblGoalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalWeight.ForeColor = System.Drawing.Color.Transparent;
            this.lblGoalWeight.Location = new System.Drawing.Point(378, 147);
            this.lblGoalWeight.Name = "lblGoalWeight";
            this.lblGoalWeight.Size = new System.Drawing.Size(118, 20);
            this.lblGoalWeight.TabIndex = 77;
            this.lblGoalWeight.Text = "Goal Weight:";
            // 
            // UsersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dumpa_CPE_Project.Properties.Resources.Brown_Yellow_Simple_Kitchen_and_Restaurant_Logo__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 630);
            this.Controls.Add(this.txtGoalWeight);
            this.Controls.Add(this.lblGoalWeight);
            this.Controls.Add(this.txtActivityLevel);
            this.Controls.Add(this.lblActivityLevel);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtBodyFat);
            this.Controls.Add(this.lblBodyFat);
            this.Controls.Add(this.lblCurrentDiet);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCalorieTarget);
            this.Controls.Add(this.txtCurrentDiet);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblCalorieTarget);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblID);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersInfo";
            this.Text = "UsersInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCalorieTarget;
        private System.Windows.Forms.TextBox txtCurrentDiet;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblCalorieTarget;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCurrentDiet;
        private System.Windows.Forms.TextBox txtBodyFat;
        private System.Windows.Forms.Label lblBodyFat;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtActivityLevel;
        private System.Windows.Forms.Label lblActivityLevel;
        private System.Windows.Forms.TextBox txtGoalWeight;
        private System.Windows.Forms.Label lblGoalWeight;
    }
}