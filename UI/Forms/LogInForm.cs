using NotShoshanisProject.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotShoshanisProject.UI.Forms;


namespace NotShoshanisProject.Forms
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            CityArrToForm();
            CapsLockCheck();
            Form_Client_InputLanguageChanged(null, null);
            ClientToForm(null);
        }

        private void CapsLockCheck()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
                MessageBox.Show("You have CapsLock on.");
        }

        private void Form_Client_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            if (InputLanguage.CurrentInputLanguage.Culture.Name.ToLower() != "en-us")
                MessageBox.Show("Your language is not English.");
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (sender as TextBox);
            if (textBox.Text.Length < 2)
                textBox.BackColor = Color.Red;
            else
                textBox.BackColor = Color.White;

        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsEngLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.KeyChar = char.MinValue;
        }

        private bool IsEngLetter(char C)
        {
            return (C >= 'a' && C <= 'z') || (C >= 'A' && C <= 'Z');
        }

        private void EmailTextBox_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '@')
                e.KeyChar = char.MinValue;
        }

        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.KeyChar = char.MinValue;
            }
        }

        private bool CheckForm()
        {
            bool flag = true;

            if (firstNameTextBox.Text.Length < 2)
            {
                flag = false;
                firstNameTextBox.BackColor = Color.Red;
            }
            else
                firstNameTextBox.BackColor = Color.White;

            if (lastNameTextBox.Text.Length < 2)
            {
                flag = false;
                lastNameTextBox.BackColor = Color.Red;
            }
            else
                lastNameTextBox.BackColor = Color.White;

            if (emailTextBox.Text.Length < 2 || emailComboBox.SelectedItem == null)
            {
                flag = false;
                emailComboBox.BackColor = Color.Red;
                emailTextBox.BackColor = Color.Red;

            }
            else
            {
                emailComboBox.BackColor = Color.White;
                emailTextBox.BackColor = Color.White;
            }

            if (phoneTextBox.Text.Length != 7 || phoneComboBox.SelectedItem == null)
            {
                flag = false;
                phoneComboBox.BackColor = Color.Red;
                phoneTextBox.BackColor = Color.Red;
            }
            else
            {
                phoneComboBox.BackColor = Color.White;
                phoneTextBox.BackColor = Color.White;
            }

            if (classComboBox.SelectedItem == null)
            {
                classComboBox.BackColor = Color.Red;

            }
            else
                classComboBox.BackColor = Color.White;

            if ((int)cityComboBox.SelectedValue > -1)
                cityComboBox.ForeColor = Color.Red;
            else
                cityComboBox.BackColor = Color.White;

            return flag;
        }
        private Client FormToClient()
        {
            Client client = new Client
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Grade = classComboBox.SelectedItem.ToString(),
                Phone = int.Parse(phoneComboBox.SelectedItem.ToString() + phoneTextBox.Text),
                ID = int.Parse(label_ID.Text),
                Email = emailTextBox.Text + emailComboBox.SelectedItem.ToString(),
                Birth = dateTimePicker1.Value,
                City = cityComboBox.SelectedItem as City
        };

            return client;
               
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!CheckForm() || dateTimePicker1.Checked && dateTimePicker1.Value >= DateTime.Today)
            {
                MessageBox.Show("Fill all the mandatory fields!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                Client client = FormToClient();

                if (client.ID == 0)
                {
                    if (client.Insert())
                        MessageBox.Show("Form filled successfully", "Yay!", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Error adding", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                
                else
                {
                    if (client.Update())
                        MessageBox.Show("Updated successfully", "Yay!", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Error updating", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                ClientArrToForm();
            }
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void ClientArrToForm()
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            DataListBox.DataSource = clientArr;
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            listButton.Visible = false;
            ClientArrToForm();
            DataListBox.Visible = true;
            FilterGroupBox.Visible = true;
        }

        private void ClientToForm(Client client)
        {
            if (client != null)
            {
                //ממירה את המידע בטנ"מ לקוח לטופס
                string phonestart = "0" + client.Phone.ToString().Substring(0, 2);
                string phoneend = client.Phone.ToString().Substring(2);
                string emailend = client.Email.Substring(client.Email.IndexOf("@"));
                string emailstart = client.Email.Substring(0, (client.Email.Length - emailend.Length));
                label_ID.Text = client.ID.ToString();
                firstNameTextBox.Text = client.FirstName;
                lastNameTextBox.Text = client.LastName;
                classComboBox.SelectedItem = client.Grade;
                phoneComboBox.SelectedItem = phonestart;
                phoneTextBox.Text = phoneend;
                emailComboBox.SelectedItem = emailend;
                emailTextBox.Text = emailstart;
                dateTimePicker1.Value = client.Birth;
                cityComboBox.SelectedValue = client.City.ID;
            }

            else
            {
                label_ID.Text = "0";
                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                classComboBox.SelectedItem = null;
                phoneComboBox.SelectedItem = null;
                phoneTextBox.Text = "";
                emailComboBox.SelectedItem = null;
                emailTextBox.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                cityComboBox.SelectedItem = null;
            }

        }
        private void listBox_Client_DoubleClick(object sender, EventArgs e)
        {
            ClientToForm(DataListBox.SelectedItem as Client);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClientToForm(null);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Client client = FormToClient();
            if (client.ID == 0)
                MessageBox.Show("You need to choose a client");
            else
            {

                //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    if (client.Delete())
                    {
                        MessageBox.Show("Client deleted successfully!", "Yay!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Error deleting", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    ClientToForm(null);
                    ClientArrToForm();
                }
            }
        }

        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (IDFilterTextBox.Text != "")
                id = int.Parse(IDFilterTextBox.Text);

            //מייצרים אוסף של כלל הלקוחות

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            string phonenumber;
            if (PhoneFilterTextBox.Text != "")
            {
                if (PhoneFilterTextBox.Text[0] == '0')
                    phonenumber = PhoneFilterTextBox.Text.Substring(1);
                else
                    phonenumber = PhoneFilterTextBox.Text;
            }
            else
                phonenumber = PhoneFilterTextBox.Text;
            
            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            clientArr = clientArr.Filter(id, LastNameFilterTextBox.Text,
            phonenumber);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            DataListBox.DataSource = clientArr;
        }

        public void CityArrToForm(City curCity = null)
        {

            //ממירה את הטנ"מ אוסף ישובים לטופס

            CityArr cityArr = new CityArr();

            //הוספת ישוב ברירת מחדל - בחר ישוב
            //יצירת מופע חדש של ישוב עם מזהה מינוס 1 ושם מתאים

            City cityDefault = new City();
            cityDefault.ID = -1;
            cityDefault.Name = "Select city";

            //הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            cityArr.Add(cityDefault); 
            cityArr.Fill();

            cityComboBox.DataSource = cityArr;
            cityComboBox.ValueMember = "Id";
            cityComboBox.DisplayMember = "Name";
            if (curCity != null)
                cityComboBox.SelectedValue = curCity.ID;
        }

        private void AddCityButton_Click(object sender, EventArgs e)
        {
            Form_City form_City = new Form_City(cityComboBox.SelectedItem as City);
            form_City.ShowDialog();
            CityArrToForm(form_City.SelectedCity);
        }
    }
}
