using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;


class Dal
{
    public static bool ExecuteSql(string sql)
    {
        //מקשר
        SqlConnection connection = new SqlConnection
        {
            //הצבת מחרוזת הקישור במקשר - שימוש בפעולת עזר למציאת מחרוזת זאת
            ConnectionString = GetConnectionString()
        };


        //ההוראה
        SqlCommand command = new SqlCommand
        {
            Connection = connection,
            CommandText = sql
        };

        //בגלל שיש גישה לקבצים חיצוניים וכן בגלל פתיחת קשר לקובץ חיצוני - "עוטפים" במנגנון טיפול בשגיאות"
        try
        {
            //פתיחת הקשר
            connection.Open();

            //הפעלת הפקודה
            command.ExecuteNonQuery();

            //סגירת הקשר
            connection.Close();

            return true;
        }
        catch (Exception e)
        {
            //משמש רק לצרכי בקרה במקרה של תקלה - חשוב להשאיר כאן נקודת עצירה
            e.ToString();
        }

        return false;
    }

    public static void FillDataSet(DataSet dataSet, string tableName, string orderBy = "")
    {
        //מקשר

        //using System.Data.SqlClient;

        SqlConnection connection = new SqlConnection
        {
            //הצבת מחרוזת הקישור במקשר
            ConnectionString = GetConnectionString()
        };

        //מבצע פעולה
        SqlCommand command = new SqlCommand
        {
            Connection = connection
        };
        if (orderBy != "")
            command.CommandText = "SELECT * FROM " + tableName + " ORDER BY " + orderBy;
        else
            command.CommandText = "SELECT * FROM " + tableName;

        //מתאם
        SqlDataAdapter adapter = new SqlDataAdapter
        {
            SelectCommand = command
        };
        adapter.Fill(dataSet, tableName);
    }

    private static string GetConnectionString()
    {
        //בניית מחרוזת הקישור
        SqlConnectionStringBuilder cString = new SqlConnectionStringBuilder
        {
            DataSource = @"(localdb)\.",
            AttachDBFilename = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\DB_NotShoshanisProject.mdf"
        };


        return cString.ToString();
    }
}