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
    internal class StudentRepository
    {

        private readonly DBconnections DBconnections;

        public StudentRepository(DBconnections dBconnections)
        {
            DBconnections = dBconnections;
        }

        public int Finddebt(string Name, string password)
        {
            string query = @"select SUM(c.price)
                            from Students s 
                            join Registrations r on r.StudentID = s.ID 
                            join Course c on c.ID = r.CourseID
                            where s.Studentname = @Name and s.Password = @password";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Name", Name),
                new SqlParameter("@password", password)
            };
            string query2 = @"select SUM(p.amount)
                            from Students s 
                            join Payments p on p.ID = s.ID
                            where s.Studentname = @Name and s.Password = @password";
            SqlParameter[] sqlParameters2 =
            {
                new SqlParameter("@Name", Name),
                new SqlParameter("@password", password)
            };
            object ressult = DBconnections.ExecuteScalar(query, sqlParameters);
            object ressult_allready_paid = DBconnections.ExecuteScalar(query2, sqlParameters2);
            int debt;
            int paid;
            bool isNumeric = int.TryParse($"{ressult}", out debt);
            if (!isNumeric)
            {
                debt = 0;
            }
            bool isNumeric2 = int.TryParse($"{ressult_allready_paid}", out paid);
            if (!isNumeric2)
            {
                paid = 0;
            }
            return debt - paid;
        }
        public bool allredySignChecked(string CID, string SID)
        {
            string query = "select * from Registrations r where r.CourseID = @CID and r.StudentID = @SID";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@CID", CID),
                new SqlParameter("@SID", SID)
            };
            DataTable ressult = DBconnections.ExecuteQuery(query, sqlParameters);
            if (ressult.Rows.Count <= 0)
            {
                return false;
            }
            return true;
        }

            public DataRow FindByName_andPassword(string Name, string password)
        {
            string query = "select * from Students s where s.Studentname = @Name and s.Password = @password";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Name", Name),
                new SqlParameter("@password", password)
            };
            DataTable ressult = DBconnections.ExecuteQuery(query, sqlParameters);
            if (ressult.Rows.Count <= 0)
            {
                throw new Exception("didn't Exist");
            }
            return ressult.Rows[0];
        }

        public bool insert(string studentname, string password, string city, string Street, string HousNum, string PhoneNum)
        {
            string query = "insert into Students(Studentname, Password, city, Street, HousNum, PhoneNum) values(@Studentname,@Password,@city, @Street, @HousNum,@PhoneNum)";
            SqlParameter[] sqlParameters = { new SqlParameter("@Studentname", studentname),
                                            new SqlParameter("@Password", password),
                                            new SqlParameter("@city", city),
                                            new SqlParameter("@Street", Street),
                                            new SqlParameter("@HousNum", HousNum),
                                            new SqlParameter("@PhoneNum", PhoneNum),}; ;
            int rowsAffected = DBconnections.ExecuteNoneQuery(query, sqlParameters);
            return rowsAffected > 0;
        }        

        public DataTable FindStudentData(string Name, string password)
        {
            string query = @"select * 
                            from Students s                             
                            where s.Studentname = @Name and s.Password = @password";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Name", Name),
                new SqlParameter("@password", password)
            };
            DataTable ressult = DBconnections.ExecuteQuery(query, sqlParameters);
            if (ressult.Rows.Count <= 0)
            {
                MessageBox.Show("invalid Name");
            }
            return ressult;
        }
        public DataTable FindStudentPayments(string Name, string password)
        {
            string query = @"select p.amount, p.ID
                            from Students s
                            join Payments p on p.StudentID = s.ID
                            where s.Studentname = @Name and s.Password = @password";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Name", Name),
                new SqlParameter("@password", password)
            };
            DataTable ressult = DBconnections.ExecuteQuery(query, sqlParameters);
            return ressult;
        }
    }
}
