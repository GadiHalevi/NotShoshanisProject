
namespace NotShoshanisProject.Forms
{
    partial class LogInForm
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bateOfBirthLabel = new System.Windows.Forms.Label();
            this.emailComboBox = new System.Windows.Forms.ComboBox();
            this.DataListBox = new System.Windows.Forms.ListBox();
            this.listButton = new System.Windows.Forms.Button();
            this.label_ID = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.FilterGroupBox = new System.Windows.Forms.GroupBox();
            this.PhoneFilterTextBox = new System.Windows.Forms.TextBox();
            this.LastNameFilterTextBox = new System.Windows.Forms.TextBox();
            this.IDFilterTextBox = new System.Windows.Forms.TextBox();
            this.PhoneFilterLabel = new System.Windows.Forms.Label();
            this.LastNameFilterLabel = new System.Windows.Forms.Label();
            this.IDFilterLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.AddCityButton = new System.Windows.Forms.Button();
            this.FilterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(265, 55);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(55, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(265, 85);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last name";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(284, 113);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grade";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(244, 187);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(76, 13);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Phone number";
            // 
            // phoneComboBox
            // 
            this.phoneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.phoneComboBox.FormattingEnabled = true;
            this.phoneComboBox.Items.AddRange(new object[] {
            "050",
            "052",
            "053",
            "054",
            "055",
            "058"});
            this.phoneComboBox.Location = new System.Drawing.Point(322, 187);
            this.phoneComboBox.Name = "phoneComboBox";
            this.phoneComboBox.Size = new System.Drawing.Size(41, 21);
            this.phoneComboBox.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Lime;
            this.saveButton.Location = new System.Drawing.Point(306, 214);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 53);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(322, 55);
            this.firstNameTextBox.MaxLength = 10;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            this.firstNameTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(322, 85);
            this.lastNameTextBox.MaxLength = 10;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            this.lastNameTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(322, 110);
            this.emailTextBox.MaxLength = 15;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 3;
            this.emailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextBox_TextChanged);
            this.emailTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(369, 188);
            this.phoneTextBox.MaxLength = 7;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 7;
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTextBox_KeyPress);
            this.phoneTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // classComboBox
            // 
            this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Items.AddRange(new object[] {
            "10th grade",
            "11th grade",
            "12th grade"});
            this.classComboBox.Location = new System.Drawing.Point(322, 136);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(59, 21);
            this.classComboBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(336, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // bateOfBirthLabel
            // 
            this.bateOfBirthLabel.AutoSize = true;
            this.bateOfBirthLabel.Location = new System.Drawing.Point(265, 29);
            this.bateOfBirthLabel.Name = "bateOfBirthLabel";
            this.bateOfBirthLabel.Size = new System.Drawing.Size(65, 13);
            this.bateOfBirthLabel.TabIndex = 0;
            this.bateOfBirthLabel.Text = "Date of birth";
            // 
            // emailComboBox
            // 
            this.emailComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emailComboBox.FormattingEnabled = true;
            this.emailComboBox.Items.AddRange(new object[] {
            "@gmail.com",
            "@walla.com",
            "@outlook.com",
            "@tichonet.com"});
            this.emailComboBox.Location = new System.Drawing.Point(437, 110);
            this.emailComboBox.Name = "emailComboBox";
            this.emailComboBox.Size = new System.Drawing.Size(121, 21);
            this.emailComboBox.TabIndex = 4;
            // 
            // DataListBox
            // 
            this.DataListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DataListBox.FormattingEnabled = true;
            this.DataListBox.Location = new System.Drawing.Point(8, 113);
            this.DataListBox.Name = "DataListBox";
            this.DataListBox.Size = new System.Drawing.Size(134, 212);
            this.DataListBox.TabIndex = 9;
            this.DataListBox.Visible = false;
            this.DataListBox.DoubleClick += new System.EventHandler(this.listBox_Client_DoubleClick);
            // 
            // listButton
            // 
            this.listButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.listButton.Location = new System.Drawing.Point(306, 272);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(156, 52);
            this.listButton.TabIndex = 10;
            this.listButton.Text = "Show Data";
            this.listButton.UseVisualStyleBackColor = false;
            this.listButton.Click += new System.EventHandler(this.ListButton_Click);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(307, 5);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(13, 13);
            this.label_ID.TabIndex = 11;
            this.label_ID.Text = "0";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(265, 5);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(21, 13);
            this.ID_label.TabIndex = 12;
            this.ID_label.Text = "ID:";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Yellow;
            this.ClearButton.Location = new System.Drawing.Point(387, 214);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.Location = new System.Drawing.Point(387, 243);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FilterGroupBox.Controls.Add(this.PhoneFilterTextBox);
            this.FilterGroupBox.Controls.Add(this.LastNameFilterTextBox);
            this.FilterGroupBox.Controls.Add(this.IDFilterTextBox);
            this.FilterGroupBox.Controls.Add(this.PhoneFilterLabel);
            this.FilterGroupBox.Controls.Add(this.LastNameFilterLabel);
            this.FilterGroupBox.Controls.Add(this.IDFilterLabel);
            this.FilterGroupBox.Location = new System.Drawing.Point(8, 7);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Size = new System.Drawing.Size(200, 100);
            this.FilterGroupBox.TabIndex = 15;
            this.FilterGroupBox.TabStop = false;
            this.FilterGroupBox.Text = "Filter";
            this.FilterGroupBox.Visible = false;
            // 
            // PhoneFilterTextBox
            // 
            this.PhoneFilterTextBox.Location = new System.Drawing.Point(94, 75);
            this.PhoneFilterTextBox.MaxLength = 7;
            this.PhoneFilterTextBox.Name = "PhoneFilterTextBox";
            this.PhoneFilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneFilterTextBox.TabIndex = 16;
            this.PhoneFilterTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // LastNameFilterTextBox
            // 
            this.LastNameFilterTextBox.Location = new System.Drawing.Point(94, 48);
            this.LastNameFilterTextBox.MaxLength = 10;
            this.LastNameFilterTextBox.Name = "LastNameFilterTextBox";
            this.LastNameFilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameFilterTextBox.TabIndex = 16;
            this.LastNameFilterTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // IDFilterTextBox
            // 
            this.IDFilterTextBox.Location = new System.Drawing.Point(94, 19);
            this.IDFilterTextBox.MaxLength = 10;
            this.IDFilterTextBox.Name = "IDFilterTextBox";
            this.IDFilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDFilterTextBox.TabIndex = 16;
            this.IDFilterTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // PhoneFilterLabel
            // 
            this.PhoneFilterLabel.AutoSize = true;
            this.PhoneFilterLabel.Location = new System.Drawing.Point(6, 78);
            this.PhoneFilterLabel.Name = "PhoneFilterLabel";
            this.PhoneFilterLabel.Size = new System.Drawing.Size(76, 13);
            this.PhoneFilterLabel.TabIndex = 16;
            this.PhoneFilterLabel.Text = "Phone number";
            // 
            // LastNameFilterLabel
            // 
            this.LastNameFilterLabel.AutoSize = true;
            this.LastNameFilterLabel.Location = new System.Drawing.Point(6, 51);
            this.LastNameFilterLabel.Name = "LastNameFilterLabel";
            this.LastNameFilterLabel.Size = new System.Drawing.Size(56, 13);
            this.LastNameFilterLabel.TabIndex = 16;
            this.LastNameFilterLabel.Text = "Last name";
            // 
            // IDFilterLabel
            // 
            this.IDFilterLabel.AutoSize = true;
            this.IDFilterLabel.Location = new System.Drawing.Point(6, 22);
            this.IDFilterLabel.Name = "IDFilterLabel";
            this.IDFilterLabel.Size = new System.Drawing.Size(18, 13);
            this.IDFilterLabel.TabIndex = 16;
            this.IDFilterLabel.Text = "ID";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(292, 165);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 16;
            this.cityLabel.Text = "City";
            // 
            // cityComboBox
            // 
            this.cityComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cityComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(322, 162);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(59, 21);
            this.cityComboBox.TabIndex = 17;
            // 
            // AddCityButton
            // 
            this.AddCityButton.Location = new System.Drawing.Point(387, 162);
            this.AddCityButton.Name = "AddCityButton";
            this.AddCityButton.Size = new System.Drawing.Size(22, 23);
            this.AddCityButton.TabIndex = 18;
            this.AddCityButton.Text = "+";
            this.AddCityButton.UseVisualStyleBackColor = true;
            this.AddCityButton.Click += new System.EventHandler(this.AddCityButton_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MALearningApp.Properties.Resources.IMG_0518;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddCityButton);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.FilterGroupBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.DataListBox);
            this.Controls.Add(this.emailComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.phoneComboBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.bateOfBirthLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.FilterGroupBox.ResumeLayout(false);
            this.FilterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.ComboBox phoneComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label bateOfBirthLabel;
        private System.Windows.Forms.ComboBox emailComboBox;
        private System.Windows.Forms.ListBox DataListBox;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.GroupBox FilterGroupBox;
        private System.Windows.Forms.TextBox PhoneFilterTextBox;
        private System.Windows.Forms.TextBox LastNameFilterTextBox;
        private System.Windows.Forms.TextBox IDFilterTextBox;
        private System.Windows.Forms.Label PhoneFilterLabel;
        private System.Windows.Forms.Label LastNameFilterLabel;
        private System.Windows.Forms.Label IDFilterLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Button AddCityButton;
    }
}