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

namespace NotShoshanisProject.UI.Forms
{
    public partial class Form_City : Form
    {
        public City SelectedCity { get => DataListBox.SelectedItem as City; }
        public Form_City(City city = null)
        {
            InitializeComponent();

            //אם נשלח ישוב שאינו ישוב אמיתי )נדבר על זה בהמשך( - לאפס אותו

            if (city != null && city.ID <= 0)
                city = null;

            //טעינת אוסף הישובים לרשימה בטופס

            CityArrToForm(city);
            CityToForm(city);
            CapsLockCheck();
            Form_Client_InputLanguageChanged(null, null);
        }

        private void Form_City_Load(object sender, EventArgs e)
        {

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

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsEngLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.KeyChar = char.MinValue;
        }

        private bool IsEngLetter(char C)
        {
            return (C >= 'a' && C <= 'z') || (C >= 'A' && C <= 'Z');
        }

        private bool CheckForm()
        {
            bool flag = true;

            if (NameTextBox.Text.Length < 2)
            {
                flag = false;
                NameFilterTextBox.BackColor = Color.Red;
            }
            else
                NameTextBox.BackColor = Color.White;

            return flag;
        }

        private City FormToCity()
        {
            City city = new City
            {
                Name = NameTextBox.Text,
                ID = int.Parse(Label_ID.Text)
            };

            return city;

        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("Fill all the mandatory fields!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                City city = FormToCity();

                if (city.ID == 0)
                {
                    //בדיקה האם היישוב קיים כבר

                    CityArr oldCityArr = new CityArr();
                    oldCityArr.Fill();
                    if (!oldCityArr.IsContains(city.Name))
                    {
                        if (city.Insert())
                        {
                            MessageBox.Show("Form filled successfully", "Yay!", MessageBoxButtons.OK);

                            //עדכון תיבת הרשימה
                            CityArr cityArr = new CityArr();
                            cityArr.Fill();
                            city = cityArr.GetCityWithMaxId();
                            CityArrToForm();
                        }
                        else
                            MessageBox.Show("Error adding", "Error", MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    else
                        MessageBox.Show("This city already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); ;
                }

                else
                {
                    if (city.Update())
                        MessageBox.Show("Updated successfully", "Yay!", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Error updating", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                CityArrToForm(city);
            }
        }

        private void CityArrToForm(City curCity = null)
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            CityArr cityArr = new CityArr();
            cityArr.Fill();
            DataListBox.DataSource = cityArr;
            DataListBox.ValueMember = "Id";
            DataListBox.DisplayMember = "Name";

            //אם נשלח לפעולה ישוב ,הצבתו בתיבת הבחירה של ישובים בטופס

            if (curCity != null)
                DataListBox.SelectedValue = curCity.ID;
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            ListButton.Visible = false;
            CityArrToForm();
            DataListBox.Visible = true;
            FilterGroupBox.Visible = true;
        }

        private void CityToForm(City city)
        {
            if (city != null)
            {
                //ממירה את המידע בטנ"מ לקוח 
                Label_ID.Text = city.ID.ToString();
                NameTextBox.Text = city.Name;
            }

            else
            {
                Label_ID.Text = "0";
                NameTextBox.Text = "";
            }

        }
        private void listBox_Client_DoubleClick(object sender, EventArgs e)
        {
            CityToForm(DataListBox.SelectedItem as City);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CityToForm(null);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            City city = FormToCity();
            if (city.ID == 0)
                MessageBox.Show("You need to choose a city");
            else
            {

                //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    //לפני המחיקה - בדיקה שהישוב לא בשימוש בישויות אחרות
                    //בדיקה עבור לקוחות

                    ClientArr clientArr = new ClientArr();
                    clientArr.Fill();
                    if (clientArr.DoesExist(city))
                        MessageBox.Show("You can’t delete a city that is related to a client");
                    else
                     if (city.Delete())
                    {
                        MessageBox.Show("Client deleted successfully!", "Yay!", MessageBoxButtons.OK);
                        CityToForm(null);
                        CityArrToForm();
                    }
                     else
                         MessageBox.Show("Error deleting", "Error", MessageBoxButtons.OK,
                         MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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

            CityArr cityArr = new CityArr();
            cityArr.Fill();
            

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            cityArr = cityArr.Filter(id, NameFilterTextBox.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            DataListBox.DataSource = cityArr;
        }

        
    }
}
