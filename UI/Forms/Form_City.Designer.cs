
namespace NotShoshanisProject.UI.Forms
{
    partial class Form_City
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
            this.ID_label = new System.Windows.Forms.Label();
            this.Label_ID = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ListButton = new System.Windows.Forms.Button();
            this.FilterGroupBox = new System.Windows.Forms.GroupBox();
            this.NameFilterTextBox = new System.Windows.Forms.TextBox();
            this.NameFilterLabel = new System.Windows.Forms.Label();
            this.IDFilterTextBox = new System.Windows.Forms.TextBox();
            this.IDFilterLabel = new System.Windows.Forms.Label();
            this.DataListBox = new System.Windows.Forms.ListBox();
            this.FilterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(406, 25);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(24, 13);
            this.ID_label.TabIndex = 0;
            this.ID_label.Text = "ID: ";
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.Location = new System.Drawing.Point(490, 25);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(13, 13);
            this.Label_ID.TabIndex = 1;
            this.Label_ID.Text = "0";
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(406, 58);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(38, 13);
            this.Name_Label.TabIndex = 2;
            this.Name_Label.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(484, 55);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 3;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Lime;
            this.SaveButton.Location = new System.Drawing.Point(400, 96);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(84, 54);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Yellow;
            this.ClearButton.Location = new System.Drawing.Point(500, 96);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(84, 22);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.Location = new System.Drawing.Point(500, 125);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(84, 25);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ListButton
            // 
            this.ListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ListButton.Location = new System.Drawing.Point(400, 156);
            this.ListButton.Name = "ListButton";
            this.ListButton.Size = new System.Drawing.Size(184, 54);
            this.ListButton.TabIndex = 7;
            this.ListButton.Text = "Show Data";
            this.ListButton.UseVisualStyleBackColor = false;
            this.ListButton.Click += new System.EventHandler(this.ListButton_Click);
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FilterGroupBox.Controls.Add(this.NameFilterTextBox);
            this.FilterGroupBox.Controls.Add(this.NameFilterLabel);
            this.FilterGroupBox.Controls.Add(this.IDFilterTextBox);
            this.FilterGroupBox.Controls.Add(this.IDFilterLabel);
            this.FilterGroupBox.Location = new System.Drawing.Point(12, 12);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Size = new System.Drawing.Size(200, 100);
            this.FilterGroupBox.TabIndex = 8;
            this.FilterGroupBox.TabStop = false;
            this.FilterGroupBox.Text = "Filter";
            this.FilterGroupBox.Visible = false;
            // 
            // NameFilterTextBox
            // 
            this.NameFilterTextBox.Location = new System.Drawing.Point(94, 61);
            this.NameFilterTextBox.Name = "NameFilterTextBox";
            this.NameFilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameFilterTextBox.TabIndex = 10;
            this.NameFilterTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // NameFilterLabel
            // 
            this.NameFilterLabel.AutoSize = true;
            this.NameFilterLabel.Location = new System.Drawing.Point(6, 64);
            this.NameFilterLabel.Name = "NameFilterLabel";
            this.NameFilterLabel.Size = new System.Drawing.Size(35, 13);
            this.NameFilterLabel.TabIndex = 9;
            this.NameFilterLabel.Text = "Name";
            // 
            // IDFilterTextBox
            // 
            this.IDFilterTextBox.Location = new System.Drawing.Point(94, 22);
            this.IDFilterTextBox.Name = "IDFilterTextBox";
            this.IDFilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDFilterTextBox.TabIndex = 9;
            this.IDFilterTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // IDFilterLabel
            // 
            this.IDFilterLabel.AutoSize = true;
            this.IDFilterLabel.Location = new System.Drawing.Point(6, 25);
            this.IDFilterLabel.Name = "IDFilterLabel";
            this.IDFilterLabel.Size = new System.Drawing.Size(18, 13);
            this.IDFilterLabel.TabIndex = 9;
            this.IDFilterLabel.Text = "ID";
            // 
            // DataListBox
            // 
            this.DataListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DataListBox.FormattingEnabled = true;
            this.DataListBox.Location = new System.Drawing.Point(12, 125);
            this.DataListBox.Name = "DataListBox";
            this.DataListBox.Size = new System.Drawing.Size(130, 186);
            this.DataListBox.TabIndex = 9;
            this.DataListBox.Visible = false;
            this.DataListBox.DoubleClick += new System.EventHandler(this.listBox_Client_DoubleClick);
            // 
            // Form_City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MALearningApp.Properties.Resources.WhatsApp_Image_2020_11_16_at_11_02_53;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataListBox);
            this.Controls.Add(this.FilterGroupBox);
            this.Controls.Add(this.ListButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Label_ID);
            this.Controls.Add(this.ID_label);
            this.Name = "Form_City";
            this.Text = "Form_City";
            this.Load += new System.EventHandler(this.Form_City_Load);
            this.FilterGroupBox.ResumeLayout(false);
            this.FilterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label Label_ID;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ListButton;
        private System.Windows.Forms.GroupBox FilterGroupBox;
        private System.Windows.Forms.Label IDFilterLabel;
        private System.Windows.Forms.TextBox NameFilterTextBox;
        private System.Windows.Forms.Label NameFilterLabel;
        private System.Windows.Forms.TextBox IDFilterTextBox;
        private System.Windows.Forms.ListBox DataListBox;
    }
}