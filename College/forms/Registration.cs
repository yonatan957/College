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
    internal partial class Registration : Form
    {
        public CoursRepository CoursRepository { get; set; }
        public StudentRepository StudentRepository { get; set; }
        public NavigationService _navigationService { get; set; }


        public Registration(CoursRepository coursRepository, StudentRepository studentRepository, NavigationService navigationService)
        {
            InitializeComponent();
            CoursRepository = coursRepository;
            StudentRepository = studentRepository;
            _navigationService = navigationService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Corsenum = textBox_num.Text;
            if (string.IsNullOrEmpty(Corsenum))
            { return; }
            if (!CoursRepository.IfCurseExist(Corsenum))
            {
                MessageBox.Show("invalid curse id!");
                return;
            }
            string sid = _navigationService.data["ID"].ToString();
            if (StudentRepository.allredySignChecked(Corsenum, sid))
            {
                MessageBox.Show("you allready have this curse");
                return;
            }
            CoursRepository.addtocorse(sid, Corsenum);
            MessageBox.Show("add curse succsessfuly");
            textBox_num.Clear();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (!_navigationService._isNavigate)
            {
                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _navigationService.ShowForm("HomePage");
        }
    }
}
