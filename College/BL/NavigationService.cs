using College.DAL.Repositries;
using College.forms;
using ShabatGuest.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabatGuest.BL
{
    
    internal class NavigationService
    {   
        
        public CoursRepository CoursRepository { get; set; }
        public StudentRepository StudentRepository { get; set; }
        public bool _isNavigate { get; set; }
        public DBconnections _dbconnections { get; init; }
        public string _name { get; set; }
        public string _password { get; set; }
        public DataRow data { get; set; }
        public NavigationService(DBconnections dBconnections, StudentRepository studentRepository, CoursRepository coursRepository)
        {
            _dbconnections = dBconnections;
            _isNavigate = false;
            StudentRepository = studentRepository;
            CoursRepository = coursRepository;
        }
        private void CloseAllForms()
        {
            _isNavigate = true;
            List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());
            foreach (Form item in openForms)
            {
                item.Close();
            }
            _isNavigate = false;
        }
        public void ShowForm(string formName, string name = "e")
        {
            CloseAllForms();
            Form form = formName switch
            {
                "Registration" => new Registration(CoursRepository, StudentRepository, this),
                "MyData" => new MyData(CoursRepository, StudentRepository, this),
                "HomePage" => new HomePage(CoursRepository, StudentRepository, this),
                "LogIn" => new LogIn(this, CoursRepository, StudentRepository ),
                "NewStudentForm" => new NewStudentForm(CoursRepository, StudentRepository, this),
                _ => throw new ArgumentException("invalid form name.", nameof(formName)),
            };
            form.Show();
        }
    }
}
