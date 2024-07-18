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
    internal partial class MyData : Form
    {
        public CoursRepository CoursRepository { get; set; }
        public StudentRepository StudentRepository { get; set; }
        public NavigationService _navigationService { get; set; }


        public MyData(CoursRepository coursRepository, StudentRepository studentRepository, NavigationService navigationService)
        {
            InitializeComponent();
            CoursRepository = coursRepository;
            StudentRepository = studentRepository;
            _navigationService = navigationService;
            Show_details();
        }

        public void Show_details()
        {
            dataGridView_data.DataSource = StudentRepository.FindStudentData(_navigationService._name, _navigationService._password);
            dataGridView_curse.DataSource = CoursRepository.FindByCursesStudentName_andPassword(_navigationService._name, _navigationService._password);
            dataGridView_payment.DataSource = StudentRepository.FindStudentPayments(_navigationService._name, _navigationService._password);
            string name = _navigationService._name;
            string password =  _navigationService._password;
            label3.Text = $"you own :{StudentRepository.Finddebt(name, password)} ils";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
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
