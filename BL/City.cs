using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotShoshanisProject.DAL;
using System.Data;

namespace NotShoshanisProject.BL
{
    public class City
    {
        private string m_Name;
        private int m_ID;

        public string Name { get => m_Name; set => m_Name = value; }
        public int ID { get => m_ID; set => m_ID = value; }

        public City() { }
        public bool Insert()
        {
            return City_Dal.Insert(m_Name);
        }

        public City(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            m_ID = (int)dataRow["Id"];
            m_Name = dataRow["Name"].ToString();
            
        }

        public bool Delete()
        {
            return City_Dal.Delete(m_ID);
        }

        public bool Update()
        {
            return City_Dal.Update(m_ID, m_Name);
        }
        public override string ToString()
        { return $"{m_Name}"; }
    }
}
