using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotShoshanisProject.DAL;
using System.Data;

namespace NotShoshanisProject.BL
{
   public class Client
    {
        private string m_FirstName , m_LastName , m_Email , m_Grade;
        private int m_Phone, m_ID;
        private DateTime m_Birth;
        private City m_City;
       

        public int ID { get => m_ID; set => m_ID = value; }
        public string FirstName { get => m_FirstName; set => m_FirstName = value; }
        public string LastName { get => m_LastName; set => m_LastName = value; }
        public string Email { get => m_Email; set => m_Email = value; }
        public string Grade { get => m_Grade; set => m_Grade = value; }
        public int Phone { get => m_Phone; set => m_Phone = value; }
        public DateTime Birth { get => m_Birth; set => m_Birth = value; }
        public City City { get => m_City; set => m_City = value; }
        public Client() { }
        public bool Insert()
        {
            return Client_Dal.Insert(m_FirstName, m_LastName, m_Phone,
            m_Email, m_Grade, m_Birth, m_City.ID);
        }

        public Client(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            m_ID = (int)dataRow["ID"];
            m_FirstName = dataRow["FirstName"].ToString();
            m_LastName = dataRow["LastName"].ToString();
            m_Email = dataRow["Email"].ToString();
            m_Grade = dataRow["Grade"].ToString();
            m_Phone = (int)dataRow["Phone"];
            m_Birth = (DateTime)dataRow["DoB"];
            m_City = new City(dataRow.GetParentRow("ClientCity"));
        }

        public bool Delete()
        {
            return Client_Dal.Delete(m_ID);
        }

        public bool Update()
        {
            return Client_Dal.Update(m_ID, m_FirstName, m_LastName, m_Phone, m_Email, m_Grade, m_Birth, m_City.ID);
        }
        public override string ToString()
        { return $"{m_LastName} {m_FirstName}"; }
    }
}
