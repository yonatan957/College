using ShabatGuest.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace College.DAL.Repositries
{
    internal class CoursRepository
    {
        private readonly DBconnections DBconnections;

        public CoursRepository(DBconnections dBconnections)
        {
            DBconnections = dBconnections;
        }

        public DataTable FindAll()
        {
            string query = "select * from Course order by Categories.ID";
            DataTable ressult = DBconnections.ExecuteQuery(query, null);
            if (ressult.Rows.Count == 0)
            {
                MessageBox.Show("FindAll Get Empty DataTable");
            }
            return ressult;
        }
        public bool IfCurseExist(string CourseID)
        {
            string query = "select * from Course c where c.ID = @CID ";
            SqlParameter[] sqlParameters = { new SqlParameter("@CID", CourseID) };
            DataTable ressult = DBconnections.ExecuteQuery(query, sqlParameters);
            if (ressult.Rows.Count <= 0)
            {
                return false;
            }
            return true;
        }

        public DataTable FindByCursesStudentName_andPassword(string Name, string password)
        {
            string query = @"select c.Coursename, c.price 
                            from Students s 
                            join Registrations r on r.StudentID = s.ID 
                            join Course c on c.ID = r.CourseID
                            where s.Studentname = @Name and s.Password = @password";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Name", Name),
                new SqlParameter("@password", password)
            };
            DataTable ressult = DBconnections.ExecuteQuery(query, sqlParameters);
            return ressult;
        }
        public bool addtocorse(string sid, string cid)
        {
            string query = "insert into Registrations(StudentID, CourseID) values (@sid, @cid)";
            SqlParameter[] sqlParameters =
{
                new SqlParameter("@sid", sid),
                new SqlParameter("@cid", cid)
            };
            int rowsAffected = DBconnections.ExecuteNoneQuery(query, sqlParameters);
            return rowsAffected > 0;
        }
    }
}
