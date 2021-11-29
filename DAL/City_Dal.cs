using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace NotShoshanisProject.DAL
{
    class City_Dal
    {
        public static bool Insert(string name)
        {
            string str = "INSERT INTO Table_City"
            + "("
            + "[Name]"
            + ")"
            + " VALUES "
            + "("
            + $"'{name}'"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_City"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלה הנוכחית - בתנאי שהטבלה לא נמצאת כבר באוסף
            {
                Dal.FillDataSet(dataSet, "Table_City", "[Name]");
            }
            //בהמשך יהיו כאן הוראות נוספות הקשורות לקשרי גומלין...

        }

        public static bool Update(int id, string name)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_City SET"
            + $" [Name] = '{name}'"
            + $" WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = $"DELETE FROM Table_City WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }


    }
}
