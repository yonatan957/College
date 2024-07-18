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
    internal partial class NewStudentForm : Form
    {
        public CoursRepository CoursRepository { get; set; }
        public StudentRepository StudentRepository { get; set; }
        public NavigationService _navigationService { get; set; }

        public NewStudentForm(CoursRepository coursRepository, StudentRepository studentRepository, NavigationService navigationService)
        {
            InitializeComponent();
            CoursRepository = coursRepository;
            StudentRepository = studentRepository;
            _navigationService = navigationService;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string password = textBox_password.Text;
            string city = textBox_city.Text;
            string street = textBox_street.Text;
            string HoseNum = textBox_Hnum.Text;
            string phone = textBox_phonNum.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(HoseNum) || string.IsNullOrEmpty(street))
            {
                MessageBox.Show("one or more is empty");
                return;
            }
            bool result = StudentRepository.insert(name, password, city, street, HoseNum, phone);
            if (!result)
            {
                MessageBox.Show("you allready exist");
            }
            DataRow data = StudentRepository.FindByName_andPassword(name, password);
            _navigationService.data = data;
            _navigationService._name = name;
            _navigationService._password = password;
            _navigationService.ShowForm("HomePage");
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
