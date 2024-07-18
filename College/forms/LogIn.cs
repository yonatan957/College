using College.DAL.Repositries;
using ShabatGuest.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College.forms
{
    internal partial class LogIn : Form
    {
        public CoursRepository CoursRepository { get; set; }
        public StudentRepository StudentRepository { get; set; }
        public NavigationService _navigationService { get; set; }
        public LogIn(NavigationService navigationService, CoursRepository coursRepository, StudentRepository studentRepository)
        {
            InitializeComponent();
            _navigationService = navigationService;
            CoursRepository = coursRepository;
            StudentRepository = studentRepository;
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            _navigationService.ShowForm("NewStudentForm");
        }

        private void button_log_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string password = textBox_password.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password)) {
                MessageBox.Show("empty rows!!!");
                return;
            }
            try
            {
                DataRow data = StudentRepository.FindByName_andPassword(name, password);
                _navigationService.data = data;
                _navigationService._name = name;
                _navigationService._password = password;
                _navigationService.ShowForm("HomePage");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (!_navigationService._isNavigate)
            {
                Application.Exit();
            }
        }
    }
}
