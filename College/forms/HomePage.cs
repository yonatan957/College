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
    internal partial class HomePage : Form
    {
        public CoursRepository CoursRepository { get; set; }
        public StudentRepository StudentRepository { get; set; }
        public NavigationService _navigationService { get; set; }

        public HomePage(CoursRepository coursRepository, StudentRepository studentRepository, NavigationService navigationService)
        {
            InitializeComponent();
            CoursRepository = coursRepository;
            StudentRepository = studentRepository;
            _navigationService = navigationService;
        }

        private void button_curse_Click(object sender, EventArgs e)
        {
            _navigationService.ShowForm("Registration");
        }

        private void button_data_Click(object sender, EventArgs e)
        {
            _navigationService.ShowForm("MyData");
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
