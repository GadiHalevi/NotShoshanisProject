using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace NotShoshanisProject.DAL
{
    class Client_Dal
    {
        public static bool Insert(string firstName, string lastName, int phone, string email , string grade, DateTime birth, int city )
        {
            string str = "INSERT INTO Table_Client"
            + "("
            + "[FirstName],[LastName],[Email],[Grade],[Phone],[DoB],[City]"
            + ")"
            + " VALUES "
            + "("
            + $"'{firstName}','{lastName}','{email}','{grade}',{phone},'{birth}', {city}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Client"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_Client", "[FirstName],[LastName],[Email],[Grade],[Phone],[DoB]");
            //בהמשך יהיו כאן הוראות נוספות הקשורות לקשרי גומלין...
            DataRelation dataRelation = null;
            City_Dal.FillDataSet(dataSet);
            dataRelation = new DataRelation(

            //שם קשר הגומלין

            "ClientCity"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_City"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_Client"].Columns["City"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);
        }

        public static bool Update(int id, string firstName, string lastName, int phone, string email, string grade, DateTime birth, int city)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Client SET"
            + $" [FirstName] = '{firstName}'"
            + $",[LastName] = '{lastName}'"
            + $",[Phone] = {phone}"
            + $",[Email] = '{email}'"
            + $",[Grade] = '{grade}'"
            + $",[DoB] = '{birth}'"
            + $",[City] = {city}"
            + $" WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = $"DELETE FROM Table_Client WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }


    }
}
